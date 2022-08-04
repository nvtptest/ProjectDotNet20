using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace ProjectDotNet20
{
    internal class Utilities
    {
        public static void webRequest2(string pzUrl, string pzBody, string pzAuthorization, string pzHeaders,
         string pzContentType, string pzMethod, bool zgetByte, out string pzResponse)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(
                delegate
                {
                    return true;
                });

                ServicePointManager.SecurityProtocol = (SecurityProtocolType)(0xc0 | 0x300 | 0xc00);
            }
            catch { }

            pzResponse = string.Empty;

            HttpWebResponse _rp = null;
            WebRequest _rq = null;

            try
            {
                //ServicePointManager.SecurityProtocol = (SecurityProtocolType)(0xc0 | 0x300 | 0xc00);    // framework 4.0 only
                ///*SecurityProtocolType.Tls |
                //SecurityProtocolType.Tls12 |
                //SecurityProtocolType.Tls11; */

                //ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072 | (SecurityProtocolType)768 | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;

                _rq = WebRequest.Create(pzUrl);
                _rq.Method = pzMethod;
                _rq.Timeout = 300000;

                if (!string.IsNullOrEmpty(pzContentType))
                    _rq.ContentType = pzContentType;

                if (!string.IsNullOrEmpty(pzAuthorization))
                    _rq.Headers.Add(pzAuthorization);

                if (!string.IsNullOrEmpty(pzHeaders))
                {
                    var _doc = new XmlDocument();
                    _doc.LoadXml(pzHeaders);

                    var _headerNodes = _doc.DocumentElement.GetElementsByTagName("Header");
                    foreach (XmlNode _headerNode in _headerNodes)
                    {
                        var _nodeKey = _headerNode.SelectNodes("Key");
                        var _nodeValue = _headerNode.SelectNodes("Value");

                        if (_nodeKey == null || string.IsNullOrEmpty(_nodeKey[0].InnerText) ||
                            _nodeValue == null || string.IsNullOrEmpty(_nodeValue[0].InnerText)) continue;

                        _rq.Headers.Add(string.Format("{0}:{1}",
                            _nodeKey[0].InnerText, _nodeValue[0].InnerText));
                    }
                }

                if (!string.IsNullOrEmpty(pzBody))
                {
                    var _buffer = Encoding.UTF8.GetBytes(pzBody);
                    _rq.ContentLength = _buffer.Length;

                    using (var rs = _rq.GetRequestStream())
                    {
                        rs.Write(_buffer, 0, _buffer.Length);
                        rs.Close();
                    }
                }
                else
                    _rq.ContentLength = 0;

                _rp = (HttpWebResponse)_rq.GetResponse();
                using (var _rs = _rp.GetResponseStream())
                {
                    if (!zgetByte)
                    {
                        using (var _sr = new StreamReader(_rs))
                        {
                            pzResponse = _sr.ReadToEnd();
                        }
                    }
                    else
                    {
                        using (BinaryReader br = new BinaryReader(_rp.GetResponseStream()))
                        {
                            var _t = br.ReadBytes(2000000);
                            //pzResponse = br.ReadBytes(2000000);
                            pzResponse = Convert.ToBase64String(_t, 0, _t.Length);
                        }
                    }
                }

            }
            catch (Exception _ex)
            {
                var _we = _ex as WebException;
                if (_we != null)
                {
                    _rp = (HttpWebResponse)_we.Response;
                    if (_rp != null)
                    {
                        using (var _rs = _rp.GetResponseStream())
                        using (var _sr = new StreamReader(_rs))
                        {
                            var _zExMsg = _sr.ReadToEnd();
                            if (!string.IsNullOrEmpty(_zExMsg))
                            {
                                pzResponse = string.Format("ERR_WEBSERVICE:{0}", _zExMsg);

                                return;
                            }
                        }
                    }
                }

                pzResponse = string.Format("ERR_WEBSERVICE:{0}", _ex.Message);
            }
            finally
            {
                if (_rp != null)
                {
                    _rp.Close();
                    // _rp.Dispose();
                    _rp = null;
                }

                if (_rq != null) _rq = null;
            }
        }

        internal static X509Certificate2 getCertificateBySerial(string pzSerial)
        {
            var _x509Store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            _x509Store.Open(OpenFlags.ReadOnly);

            var _enumerator = _x509Store.Certificates.GetEnumerator();
            while (_enumerator.MoveNext())
            {
                var _current = _enumerator.Current;
                if (_current.GetSerialNumberString().ToUpper().CompareTo(pzSerial.ToUpper().Trim()) == 0)
                {
                    try
                    {
                        if (!_current.HasPrivateKey)
                            throw new Exception("Không lấy được private key, chọn chứng thư khác!");
                    }
                    catch
                    {
                        throw new Exception("Không lấy được private key, chọn chứng thư khác!");
                    }

                    return _current;
                }
            }

            return null;
        }

        internal static string getBase64CertBySerial (string pzSerialCert)
        {
            X509Certificate2 _certificateBySerial = getCertificateBySerial(pzSerialCert);
            byte[] _rawData = _certificateBySerial.RawData;
            var _zCertString = Convert.ToBase64String(_rawData);
            return _zCertString;
        }

        public static string signHashCert(string pzHashValue, string pzSerial)
        {
            var _zResult = string.Empty;
            try
            {
                RSACryptoServiceProvider _rSACryptoServiceProvider = null;

                var _x509Store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                _x509Store.Open(OpenFlags.ReadOnly);

                var _enumerator = _x509Store.Certificates.GetEnumerator();
                while (_enumerator.MoveNext())
                {
                    var _current = _enumerator.Current;
                    if (_current.GetSerialNumberString().ToUpper() == pzSerial.ToUpper())
                    {
                        _rSACryptoServiceProvider = (RSACryptoServiceProvider)_current.PrivateKey;
                        if (_rSACryptoServiceProvider == null)
                            return "ERR:-2";

                        break;
                    }
                }

                var _zText = Convert.ToBase64String(_rSACryptoServiceProvider.SignHash(Convert.FromBase64String(pzHashValue), CryptoConfig.MapNameToOID("SHA1")));

                _x509Store.Close();

                _zResult = _zText;
            }
            catch (Exception _ex)
            {
                //if (_ex.Message.Contains("cancelled by the user"))
                //    _zResult = "ERR:-1";
                //else
                //    _zResult = "ERR:-3 " + _ex;
                throw _ex;
            }

            return _zResult;
        }
    }
}

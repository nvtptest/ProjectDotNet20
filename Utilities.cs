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

                string boundary = "----------------------------" + DateTime.Now.Ticks.ToString("x");

                if (!string.IsNullOrEmpty(pzContentType))
                {
                    if(pzContentType.Contains("multipart/form-data"))
                    {
                        _rq.ContentType = "multipart/form-data; boundary=" + boundary;
                    }
                    else
                    {
                        _rq.ContentType = pzContentType;
                    }
                }

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
                    if (pzContentType.Contains("multipart/form-data"))
                    {
                        byte[] boundarybytes = Encoding.UTF8.GetBytes("--" + boundary + "\r\n");
                        /// the last boundary.
                        byte[] trailer = Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n");
                        /// the form data, properly formatted
                        string formdataTemplate = " ; name=\"{0}\"\r\n\r\n{1}";
                        /// Added to track if we need a CRLF or not.
                        bool bNeedsCRLF = false;

                        Dictionary<string, object> postParameters = new Dictionary<string, object>();
                        //pzBody truyền vào dạng: key1=value1&key2=value2
                        foreach (string _data in pzBody.Split('&'))
                        {
                            string _key = _data.Split('=')[0];
                            string _value = _data.Split('=')[1];

                            postParameters.Add(_key, _value);
                        }

                        byte[] formData = GetMultipartFormData(postParameters, boundary);
                        string z123result = System.Text.Encoding.UTF8.GetString(formData);


                        _rq.ContentLength = formData.Length;

                        using (var rs = _rq.GetRequestStream())
                        {
                            rs.Write(formData, 0, formData.Length);
                            rs.Close();
                        }
                    }
                    else
                    {
                        var _buffer = Encoding.UTF8.GetBytes(pzBody);
                        _rq.ContentLength = _buffer.Length;

                        using (var rs = _rq.GetRequestStream())
                        {
                            rs.Write(_buffer, 0, _buffer.Length);
                            rs.Close();
                        }
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

        public static byte[] GetMultipartFormData(Dictionary<string, object> postParameters, string boundary)
        {
            Stream formDataStream = new System.IO.MemoryStream();
            bool needsCLRF = false;

            foreach (var param in postParameters)
            {
                // Thanks to feedback from commenters, add a CRLF to allow multiple parameters to be added.
                // Skip it on the first parameter, add it to subsequent parameters.
                if (needsCLRF)
                    formDataStream.Write(Encoding.UTF8.GetBytes("\r\n"), 0, Encoding.UTF8.GetByteCount("\r\n"));

                needsCLRF = true;

                //if (param.Value is FileParameter)
                //{
                //    FileParameter fileToUpload = (FileParameter)param.Value;

                //    // Add just the first part of this param, since we will write the file data directly to the Stream
                //    string header = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{2}\"\r\nContent-Type: {3}\r\n\r\n",
                //        boundary,
                //        param.Key,
                //        fileToUpload.FileName ?? param.Key,
                //        fileToUpload.ContentType ?? "application/octet-stream");

                //    formDataStream.Write(encoding.GetBytes(header), , encoding.GetByteCount(header));

                //    // Write the file data directly to the Stream, rather than serializing it to a string.
                //    formDataStream.Write(fileToUpload.File, , fileToUpload.File.Length);
                //}
                //else
                {
                    string postData = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}",
                    boundary,
                    param.Key,
                    param.Value);
                    formDataStream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetByteCount(postData));
                }
            }

            // Add the end of the request.  Start with a newline
            string footer = "\r\n--" + boundary + "--\r\n";
            formDataStream.Write(Encoding.UTF8.GetBytes(footer), 0, Encoding.UTF8.GetByteCount(footer));

            // Dump the Stream into a byte[]
            formDataStream.Position = 0;
            byte[] formData = new byte[formDataStream.Length];
            formDataStream.Read(formData, 0, formData.Length);
            formDataStream.Close();

            return formData;
        }


        public static string signHashString(string pzStringValue, string pzSerial, string cryptType)
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

                byte[] rgbHash = Encoding.ASCII.GetBytes(pzStringValue);


                var _zText = Convert.ToBase64String(_rSACryptoServiceProvider.SignData(rgbHash, CryptoConfig.CreateFromName(cryptType)));

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

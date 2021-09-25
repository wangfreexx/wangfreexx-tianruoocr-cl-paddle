using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;

// ReSharper disable StringLiteralTypo

namespace TrOCR.Helper
{
    public static class CommonHelper
    {
        private static readonly HttpHelper DefaultHttpHelper = new HttpHelper();  

        public static void ShowHelpMsg(string msg)
        {
            var fmFlags = new FmFlags();
            fmFlags.Show();
            fmFlags.DrawStr(msg);
        }

        public static void AddLog(string str)
        {
            str = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + str + "\r\n";
            var path = Path.Combine(Environment.CurrentDirectory, "Log");
            if (Directory.Exists(path))
            {
                try
                {
                    File.AppendAllText(Path.Combine(path, DateTime.Now.ToString("yyyy_MM_dd") + ".log"), str, Encoding.Default);
                }
                catch (Exception)
                {
                    //文件被占用
                }
            }
            else
            {
                Directory.CreateDirectory(path);
                var fs = File.Create(Path.Combine(path, DateTime.Now.ToString("yyyy_MM_dd") + ".log"));
                fs.Write(Encoding.Default.GetBytes(str), 0, Encoding.Default.GetBytes(str).Length);
                fs.Close();
            }
        }

        public static string GetHtmlContent(string url, int userAgent = 0, Dictionary<string, string> headers = null)
        {
            try
            {
                var httpItem = new HttpItem
                {
                    Url = url,
                    Timeout = 15000
                };
                SetUserAgent(httpItem, userAgent, headers);
                return DefaultHttpHelper.GetHtml(httpItem).Html;
            }
            catch (Exception ex)
            {
                AddLog(ex.ToString());
                return null;
            }
        }

        public static string PostData(string url, string data, int contentType = 0, int userAgent = 0, Dictionary<string, string> headers = null)
        {
            try
            {
                var httpItem = new HttpItem
                {
                    Url = url,
                    Timeout = 15000,
                    Method = "POST",
                    PostDataType = PostDataType.String,
                    PostData = data
                };
                SetContentType(httpItem, contentType);
                SetUserAgent(httpItem, userAgent, headers);
                return DefaultHttpHelper.GetHtml(httpItem).Html;
            }
            catch (Exception ex)
            {
                AddLog(ex.ToString());
                return null;
            }
        }

        public static string PostStrData(string url, string data, string cookie = "", string referer = "")
        {
            try
            {
                var httpItem = new HttpItem
                {
                    Url = url,
                    Timeout = 15000,
                    Method = "POST",
                    PostDataType = PostDataType.String,
                    PostData = data
                };
                SetContentType(httpItem, 0);
                if (!string.IsNullOrEmpty(referer))
                {
                    httpItem.Referer = referer;
                }
                httpItem.Cookie = cookie;
                return DefaultHttpHelper.GetHtml(httpItem).Html;
            }
            catch (Exception ex)
            {
                AddLog(ex.ToString());
                return null;
            }
        }

        private static void SetContentType(HttpItem httpItem, int contentType)
        {
            switch (contentType)
            {
                case 0:
                    httpItem.ContentType = "application/x-www-form-urlencoded;charset=utf-8 ";
                    break;
                case 1:
                    httpItem.ContentType = "application/json;charset=utf-8";
                    break;
                case 2:
                    httpItem.ContentType = "application/xml";
                    break;
                case 3:
                    httpItem.ContentType = "multipart/form-data";
                    break;
                case 4:
                    httpItem.ContentType = "text/html";
                    break;
                default:
                    httpItem.ContentType = "text/plain";
                    break;
            }
        }

        private static void SetUserAgent(HttpItem httpItem, int ua, Dictionary<string, string> headers)
        {
            switch (ua)
            {
                case 1:
                    httpItem.UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 9_3_2 like Mac OS X) AppleWebKit/601.1.46 (KHTML, like Gecko) Mobile/13F69 MicroMessenger/6.3.16 NetType/WIFI Language/zh_CN";
                    break;
                case 2:
                    httpItem.UserAgent = "Mozilla/5.0 (Linux; U; Android 2.2; en-gb; GT-P1000 Build/FROYO) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1";
                    break;
                case 3:
                    httpItem.UserAgent = "Mozilla/5.0 (Windows Phone 10.0; Android 4.2.1; NOKIA; Lumia 930) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2486.0 Mobile Safari/537.36 Edge/13.10586";
                    break;
                case 4:
                    httpItem.UserAgent = "NativeHost";
                    break;
                case 5:
                    httpItem.UserAgent = "Dalvik/1.6.0 (Linux; U; Android 4.4.2; NoxW Build/KOT49H) ITV_5.7.1.46583";
                    break;
                case 6:
                    httpItem.UserAgent = "qqlive";
                    break;
                case 7:
                    httpItem.UserAgent = "Dalvik/1.6.0 (Linux; U; Android 4.2.2; 6S Build/JDQ39E)";
                    break;
                case 8:
                    httpItem.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) XIAMI-MUSIC/3.0.2 Chrome/51.0.2704.106 Electron/1.2.8 Safari/537.36";
                    break;
                case 9:
                    httpItem.UserAgent = "Dalvik/1.6.0 (Linux; U; Android 4.4.2; MI 6 Build/NMF26X)";
                    break;
                case 10:
                    httpItem.UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 5_0 like Mac OS X) AppleWebKit/534.46 (KHTML, like Gecko) Version/5.1 Mobile/9A334 Safari/7534.48.3";
                    break;
                case 11:
                    httpItem.UserAgent = "Mozilla/5.0 (Linux; Android 4.0.4; Galaxy Nexus Build/IMM76B) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.133 Mobile Safari/535.19";
                    break;
                case 12:
                    httpItem.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows Phone 8.0; Trident/6.0; IEMobile/10.0; ARM; Touch; NOKIA; Lumia 920)";
                    break;
                case 14:
                    httpItem.UserAgent = "Apache-HttpClient/UNAVAILABLE (java 1.4)";
                    break;
                case 15:
                    httpItem.UserAgent = "Mozilla/5.0 (iPad; CPU OS 8_1_3 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) Version/8.0 Mobile/12B466 Safari/600.1.4";
                    break;
                default:
                    httpItem.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36";
                    break;
            }
            if (headers != null)
            {
                foreach (var k in headers)
                {
                    if (k.Key == "Cookie")
                    {
                        httpItem.Cookie = k.Value;
                    }
                    else
                    {
                        httpItem.Header.Add(k.Key, k.Value);
                    }
                }
            }
        }

        public static string PostMultiData(string url, byte[] data, string boundary, string cookie = "", string referer = "")
        {
            try
            {
                var httpItem = new HttpItem
                {
                    Url = url,
                    Timeout = 15000,
                    Method = "POST",
                    PostDataType = PostDataType.Byte,
                    PostDataByte = data,
                    ContentType = "multipart/form-data; boundary=" + boundary
                };
                if (!string.IsNullOrEmpty(referer))
                {
                    httpItem.Referer = referer;
                }
                httpItem.Cookie = cookie;
                return DefaultHttpHelper.GetHtml(httpItem).Html;
            }
            catch (Exception ex)
            {
                AddLog(ex.ToString());
                return null;
            }
        }

        public static string Md5(string input)
        {
            using (var md5 = MD5.Create())
            {
                var str = Encoding.UTF8.GetBytes(input);
                var output = md5.ComputeHash(str);
                return BitConverter.ToString(output).Replace("-", "").ToLower();
            }
        }

        public static string Md5(byte[] input)
        {
            using (var md5 = MD5.Create())
            {
                var output = md5.ComputeHash(input);
                return BitConverter.ToString(output).Replace("-", "").ToLower();
            }
        }

        public static string Sha1(string str)
        {
            using (var sha1 = SHA1.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(str);
                var output = sha1.ComputeHash(bytes);
                return BitConverter.ToString(output).Replace("-", "").ToLower();
            }
        }
        public static long GetTimeSpan(bool isMills = false)
        {
            var startTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64((DateTime.UtcNow.Ticks - startTime.Ticks) / (isMills ? 10000 : 10000000));
        }

        public static DateTime UnixTimestampToDateTime(long timestamp)
        {
            var start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return start.AddSeconds(timestamp);
        }

        public static string UnicodeToString(string input)
        {
            var matches = Regex.Matches(input, @"\\u([0-9a-f]{4})");
            foreach (Match match in matches)
            {
                var str = (char)int.Parse(match.Groups[1].Value, NumberStyles.HexNumber);
                input = input.Replace(match.Value, str.ToString());
            }
            return input;
        }

        public static string DecodeBase64(Encoding encode, string result)
        {
            return encode.GetString(Convert.FromBase64String(result));
        }

        public static string EncodeBase64(Encoding encode, string source)
        {
            return Convert.ToBase64String(encode.GetBytes(source));
        }

        public static string HtmlDecode(this string html)
        {
            return WebUtility.HtmlDecode(html);
        }

        public static bool CompareStr(string s1, string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            s1 = Regex.Replace(s1, "\\W+", "");
            s2 = Regex.Replace(s2, "\\W+", "");
            return s1 == s2;
        }

        [DllImport("user32.dll")]
        public static extern bool SetProcessDPIAware();

        public static float GetDpiFactor()
        {
            float result;
            try
            {
                const string name = "AppliedDPI";
                var registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop\\WindowMetrics", true);
                if (registryKey != null)
                {
                    var value = registryKey.GetValue(name).ToString();
                    registryKey.Close();
                    result = Convert.ToSingle(value) / 96f;
                }
                else
                {
                    result = 1f;
                }
            }
            catch
            {
                result = 1f;
            }
            return result;
        }

        public static string EnPunctuation2Ch(string text)
        {
            var array = text.ToCharArray();
            for (var i = 0; i < array.Length; i++)
            {
                var num = ":;,?!()".IndexOf(array[i]);
                if (num != -1)
                {
                    array[i] = "：；，？！（）"[num];
                }
            }
            return new string(array);
        }

        public static string LangDetect(string text)
        {
            var mt = Regex.Match(text, "[.。，,！!?？]");
            if (mt.Success)
            {
                text = text.Substring(0, mt.Index);
            }
            var url = "https://fanyi.baidu.com/langdetect?query=" + text;
            var html = GetHtmlContent(url);
            if (string.IsNullOrEmpty(html))
            {
                return "zh";
            }
            return JObject.Parse(html)["lan"].Value<string>();
        }

        public static string GetResponseHtml(HttpWebRequest httpWebRequest)
        {
            var responseStream = ((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream();
            if (responseStream != null)
            {
                var value = new StreamReader(responseStream, Encoding.GetEncoding("utf-8")).ReadToEnd();
                responseStream.Close();
                return value;
            }
            return "";
        }
    }
}
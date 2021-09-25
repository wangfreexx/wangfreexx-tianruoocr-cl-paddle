using System.Web;

namespace TrOCR.Helper
{
    public class TranslateHelper
    {
        public static string BdTrans(string text, string from, string to)
        {
            var t = CommonHelper.GetTimeSpan(true);
            var query = HttpUtility.UrlEncode(text)?.Replace("+", "%20");
            var url = "https://fanyi-app.baidu.com/transapp/agent.php";
            var sign = GetBdSign(text, t, from, to, "v2trans", "", "");
            var data =
                $"query={query}&timestamp={t}&from={from}&imei=865166029384834&req=v2trans&version=9999&to={to}&trans_mode=3&product=transapp&sign={sign}";
            return CommonHelper.PostData(url, data);
        }

        private static string GetBdSign(string query, long t, string from, string to, string req, string text, string image)
        {
            return CommonHelper.Md5(
                $"query{query}imei865166029384834version9999timestamp{t}from{from}to{to}req{req}text{text}image{image}e324arrq");
        }

        public static string BdTts(string text, string lang, int speed)
        {
            var t = CommonHelper.GetTimeSpan(true);
            var query = HttpUtility.UrlEncode(text);
            var url =
                $"https://fanyi-app.baidu.com/transapp/agent.php?text={query}&os_lang=zh&imei=865166029384834&syslan=zh&type=trans_{lang}&version=9999&timestamp={t}&product=transapp&plat=android&netterm=WIFI&spd={speed}&req=tts&channel=bdguanwang&sign=";
            var sign = GetBdSign("", t, "", "", "tts", text, "");
            return url + sign;
        }
    }
}
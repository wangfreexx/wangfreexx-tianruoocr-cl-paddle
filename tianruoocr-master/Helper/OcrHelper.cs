using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Web;

namespace TrOCR.Helper
{
    public class OcrHelper
    {
        public static string TxOcr(Image img)
        {
            const string url = "https://ai.qq.com/cgi-bin/appdemo_generalocr";
            return TxComm(img, url);
        }

        public static string TxComm(Image img, string url)
        {
            const string boundary = "------WebKitFormBoundaryRDEqU0w702X9cWPJ";
            const string refer = "http://ai.qq.com/product/ocr.shtml";
            var header = boundary + "\r\nContent-Disposition: form-data; name=\"image_file\"; filename=\"pic.jpg\"\r\nContent-Type: image/jpeg\r\n\r\n";
            const string footer = "\r\n" + boundary + "--\r\n";
            var data = FmMain.MergeByte(Encoding.ASCII.GetBytes(header), ImgToBytes(img), Encoding.ASCII.GetBytes(footer));
            return CommonHelper.PostMultiData(url, data, boundary.Substring(2), "", refer);
        }

        public static string SgOcr(Image img)
        {
            const string boundary = "------WebKitFormBoundary8orYTmcj8BHvQpVU";
            const string url = "http://ocr.shouji.sogou.com/v2/ocr/json";
            var header = boundary + "\r\nContent-Disposition: form-data; name=\"pic\"; filename=\"pic.jpg\"\r\nContent-Type: image/jpeg\r\n\r\n";
            const string footer = "\r\n" + boundary + "--\r\n";
            var data = FmMain.MergeByte(Encoding.ASCII.GetBytes(header), ImgToBytes(img), Encoding.ASCII.GetBytes(footer));
            return CommonHelper.PostMultiData(url, data, boundary.Substring(2));
        }

        public static string SgBasicOpenOcr(Image image)
        {
            var url = "https://deepi.sogou.com/api/sogouService";
            var referer = "https://deepi.sogou.com/?from=picsearch&tdsourcetag=s_pctim_aiomsg";
            var imageData = Convert.ToBase64String(ImgToBytes(image));
            var t = CommonHelper.GetTimeSpan(true);
            var sign = CommonHelper.Md5($"sogou_ocr_just_for_deepibasicOpenOcr{t}{imageData.Substring(0, Math.Min(1024, imageData.Length))}7f42cedccd1b3917c87aeb59e08b40ad");
            var data =
                $"image={HttpUtility.UrlEncode(imageData)}&lang=zh-Chs&pid=sogou_ocr_just_for_deepi&salt={t}&service=basicOpenOcr&sign={sign}";
            return CommonHelper.PostStrData(url, data, "", referer);
        }

        public static byte[] ImgToBytes(Image img)
        {
            byte[] result;
            try
            {
                var memoryStream = new MemoryStream();
                img.Save(memoryStream, ImageFormat.Jpeg);
                var array = new byte[memoryStream.Length];
                memoryStream.Position = 0L;
                memoryStream.Read(array, 0, (int)memoryStream.Length);
                memoryStream.Close();
                result = array;
            }
            catch
            {
                result = null;
            }
            return result;
        }
    }
}
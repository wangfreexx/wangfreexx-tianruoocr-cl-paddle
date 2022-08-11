using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using IniParser;
using IniParser.Model;
namespace TrOCR.Helper
{

    public static class IniHelper
    {

        public static string GetValue(string sectionName, string key)
        {
            var text = AppDomain.CurrentDomain.BaseDirectory + "Data\\config.ini";
            var flag = !File.Exists(text);
            if (flag)
            {
                using (File.Create(text))
                {
                }
            }
            var array = new byte[2048];
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(text, Encoding.UTF8);
            //var privateProfileString = GetPrivateProfileString(sectionName, key, "发生错误", array, 999, text);
            //return Encoding.Default.GetString(array, 0, privateProfileString);
            try
            {
                string useFullScreenStr = data[sectionName][key];
                if (useFullScreenStr != null)
                {
                    return useFullScreenStr;
                }
                else
                {
                    return "发生错误";
                }

            }
            catch (Exception)
            {
                return "发生错误";
                throw;
            }

        }

        public static bool SetValue(string sectionName, string key, string value)
        {
            var text = AppDomain.CurrentDomain.BaseDirectory + "Data\\config.ini";
            var flag = !File.Exists(text);
            if (flag)
            {
                using (File.Create(text))
                {
                }
            }
            bool result = true;
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(text, Encoding.UTF8);
            try
            {
                data[sectionName][key] = value;
                parser.WriteFile(text, data, Encoding.UTF8);

            }
            catch (Exception ex)
            {

                result = false;
                throw ex;
            }
            return result;
        }


    }
}

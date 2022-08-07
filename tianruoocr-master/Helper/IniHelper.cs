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

		[DllImport("kernel32")]
		public static extern int GetPrivateProfileString(string sectionName, string key, string defaultValue, byte[] returnBuffer, int size, string filePath);

		[DllImport("kernel32")]
		public static extern long WritePrivateProfileString(string sectionName, string key, string value, string filePath);

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
			IniData data = parser.ReadFile(text,Encoding.Unicode);
            //var privateProfileString = GetPrivateProfileString(sectionName, key, "发生错误", array, 999, text);
            //return Encoding.Default.GetString(array, 0, privateProfileString);
            try
            {
				string useFullScreenStr = data[sectionName][key];
				if(useFullScreenStr != null)
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
			var flag2 = flag;
			var flag3 = flag2;
			var flag4 = flag3;
			var flag5 = flag4;
			var flag6 = flag5;
			if (flag6)
			{
				using (File.Create(text))
				{
				}
			}
			bool result=true;
			var parser = new FileIniDataParser();
			IniData data = parser.ReadFile(text, Encoding.Unicode);
			try
			{
				data[sectionName][key] =value;
				parser.WriteFile(text, data, Encoding.Unicode);
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

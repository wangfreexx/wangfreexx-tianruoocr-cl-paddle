using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

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
			var array = new byte[2048];
			var privateProfileString = GetPrivateProfileString(sectionName, key, "发生错误", array, 999, text);
			return Encoding.Default.GetString(array, 0, privateProfileString);
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
			bool result;
			try
			{
				result = ((int)WritePrivateProfileString(sectionName, key, value, text) > 0);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		public static bool RemoveSection(string sectionName, string filePath)
		{
			bool result;
			try
			{
				result = ((int)WritePrivateProfileString(sectionName, null, "", filePath) > 0);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		public static bool RemoveKey(string sectionName, string key, string filePath)
		{
			bool result;
			try
			{
				result = ((int)WritePrivateProfileString(sectionName, key, null, filePath) > 0);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}
	}
}

using System;
using System.IO;
using System.Collections.Specialized;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Text;
using IniParser;
using IniParser.Model;
using System.Windows.Forms;
using System.Xml;

namespace TrOCR.Helper
{

    public static class IniHelper
    {

        public static string GetValue(string sectionName, string key)
        {
            //var text = AppDomain.CurrentDomain.BaseDirectory + "Data\\config.ini";
            //var flag = !File.Exists(text);
            //if (flag)
            //{
            //    using (File.Create(text))
            //    {
            //    }
            //}
            ////var array = new byte[2048];
            //var parser = new FileIniDataParser();
            //IniData data = parser.ReadFile(text, Encoding.Unicode);
            ////var privateProfileString = GetPrivateProfileString(sectionName, key, "发生错误", array, 999, text);
            ////return Encoding.Default.GetString(array, 0, privateProfileString);
            //try
            //{
            //    string useFullScreenStr = data[sectionName][key];
            //    if (useFullScreenStr != null)
            //    {
            //        return useFullScreenStr;
            //    }
            //    else
            //    {
            //        return "发生错误";
            //    }

            //}
            //catch (Exception)
            //{
            //    return "发生错误";
            //    throw;
            //}
            //string file = AppDomain.CurrentDomain.BaseDirectory + "\\天若OCR文字识别.exe.Config";
            //if (!File.Exists(file))
            //{
            //    CreatConfig();
            //}
            //NameValueCollection sec = null;
            //try
            //{
            //    sec = (NameValueCollection)ConfigurationManager.GetSection(sectionName);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("配置文件出现问题，请删除app.config重启，程序即将自动退出1");
            //    throw;
            //}

            //if (sec == null)
            //{
            //    MessageBox.Show("配置文件出现问题，请删除app.config重启，程序即将自动退出2");
            //    System.Environment.Exit(0);
            //    return "发生错误";
            //}
            //else
            //{
            //    string value = sec[key];
            //    if (value == null)
            //    {
            //        return "发生错误";
            //    }
            //    else
            //    {
            //        return value;
            //    }
            //}
            string file = AppDomain.CurrentDomain.BaseDirectory + "Data\\my.Config";
            if (!File.Exists(file))
            {
                CreatConfig();
            }
            XmlDocument xDoc = new XmlDocument();

            //获取可执行文件的路径和名称

            xDoc.Load(file);

            XmlNode xNode;

            XmlElement xElem1;

            string str = "//" + sectionName;

            xNode = xDoc.SelectSingleNode(str);
            if (xNode == null)
            {
                MessageBox.Show("配置文件出现问题，请删除app.config重启，程序即将自动退出2");
                System.Environment.Exit(0);
                return "发生错误";
            }
            xElem1 = (XmlElement)xNode.SelectSingleNode(str + "//add[@key='" + key + "']");
            if (xElem1 == null)
            {
                return "发生错误";
            }
            else
            {
                var value1 = xElem1.GetAttribute("value");
                if (value1 == null || value1 == "")
                {
                    return "发生错误";
                }
                else
                {
                    return value1;
                }

            }

        }

        public static bool SetValue(string sectionName, string key, string value)
        {
            //    var text = AppDomain.CurrentDomain.BaseDirectory + "Data\\config.ini";
            //    var flag = !File.Exists(text);
            //    if (flag)
            //    {
            //        using (File.Create(text))
            //        {
            //        }
            //    }
            //    bool result = true;
            //    var parser = new FileIniDataParser();
            //    IniData data = parser.ReadFile(text, Encoding.Unicode);
            //    try
            //    {
            //        data[sectionName][key] = value;
            //        parser.WriteFile(text, data, Encoding.Unicode);

            //    }
            //    catch (Exception ex)
            //    {

            //        result = false;
            //        throw ex;
            //    }
            //    return result;
            //}
            string file = AppDomain.CurrentDomain.BaseDirectory + "Data\\my.Config";
            if (!File.Exists(file))
            {
                CreatConfig();
            }
            XmlDocument xDoc = new XmlDocument();

            //获取可执行文件的路径和名称

            xDoc.Load(file);
            XmlNode xNode;

            XmlElement xElem1;

            XmlElement xElem2;
            string str = "//" + sectionName;

            xNode = xDoc.SelectSingleNode(str);

            xElem1 = (XmlElement)xNode.SelectSingleNode(str + "//add[@key='" + key + "']");

            if (xElem1 != null) xElem1.SetAttribute("value", value);

            else

            {

                xElem2 = xDoc.CreateElement("add");

                xElem2.SetAttribute("key", key);

                xElem2.SetAttribute("value", value);

                xNode.AppendChild(xElem2);

            }

            xDoc.Save(file);
            return true;

        }

        public static void CreatConfig()
        {

            string file = AppDomain.CurrentDomain.BaseDirectory + "Data\\my.Config";
            if (File.Exists(file))
            {
                return;
            }
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            // <root>
            XmlElement root = doc.CreateElement("configuration");
            doc.AppendChild(root);

            /*            XmlElement congfig = doc.CreateElement("configSections");
                        root.AppendChild(congfig);
                        XmlElement x = doc.CreateElement("section");

                        x.SetAttribute("name", "配置");
                        x.SetAttribute("type", "System.Configuration.NameValueSectionHandler");
                        congfig.AppendChild(x);

                        x = doc.CreateElement("section");

                        x.SetAttribute("name", "快捷键");
                        x.SetAttribute("type", "System.Configuration.NameValueSectionHandler");congfig.AppendChild(x);

                        x = doc.CreateElement("section");

                        x.SetAttribute("name", "密钥_百度");
                        x.SetAttribute("type", "System.Configuration.NameValueSectionHandler");congfig.AppendChild(x);

                        x = doc.CreateElement("section");
                        x.SetAttribute("name", "代理");
                        x.SetAttribute("type", "System.Configuration.NameValueSectionHandler");congfig.AppendChild(x);
                        x = doc.CreateElement("section");

                        x.SetAttribute("name", "更新");
                        x.SetAttribute("type", "System.Configuration.NameValueSectionHandler");congfig.AppendChild(x);
                        x = doc.CreateElement("section");

                        x.SetAttribute("name", "截图音效");
                        x.SetAttribute("type", "System.Configuration.NameValueSectionHandler");congfig.AppendChild(x);
                        x = doc.CreateElement("section");
                        x.SetAttribute("name", "工具栏");
                        x.SetAttribute("type", "System.Configuration.NameValueSectionHandler");congfig.AppendChild(x);
                        x = doc.CreateElement("section");

                        x.SetAttribute("name", "取色器");
                        x.SetAttribute("type", "System.Configuration.NameValueSectionHandler");congfig.AppendChild(x);
                        x = doc.CreateElement("section");

                        x.SetAttribute("name", "OCR");
                        x.SetAttribute("type", "System.Configuration.NameValueSectionHandler");congfig.AppendChild(x);

                              x = doc.CreateElement("section");      
                        x.SetAttribute("name", "paddle模型");
                        x.SetAttribute("type", "System.Configuration.NameValueSectionHandler");congfig.AppendChild(x);
                        x = doc.CreateElement("section");
                        x.SetAttribute("name", "翻译API_百度");
                        x.SetAttribute("type", "System.Configuration.NameValueSectionHandler");congfig.AppendChild(x);
                        x = doc.CreateElement("section");

                        x.SetAttribute("name", "特殊");
                        x.SetAttribute("type", "System.Configuration.NameValueSectionHandler");congfig.AppendChild(x);
                        x = doc.CreateElement("section");
                        x.SetAttribute("name", "OCR2");
                        x.SetAttribute("type", "System.Configuration.NameValueSectionHandler");congfig.AppendChild(x);

                        XmlElement startup = doc.CreateElement("startup");
                        root.AppendChild(startup);
                        XmlElement supportedRuntime = doc.CreateElement("supportedRuntime");

                        supportedRuntime.SetAttribute("version", "v4.0");
                        supportedRuntime.SetAttribute("sku", ".NETFramework,Version=v4.7.2");startup.AppendChild(supportedRuntime);*/

            XmlElement 配置 = doc.CreateElement("配置");
            root.AppendChild(配置);
            XmlElement b = doc.CreateElement("add");

            b.SetAttribute("key", "测试");
            b.SetAttribute("value", "0"); 配置.AppendChild(b);

            XmlElement 快捷键 = doc.CreateElement("快捷键");
            root.AppendChild(快捷键);
            b = doc.CreateElement("add");

            b.SetAttribute("key", "测试");
            b.SetAttribute("value", "0"); 快捷键.AppendChild(b);

            XmlElement 工具栏 = doc.CreateElement("工具栏");
            root.AppendChild(工具栏);
            b = doc.CreateElement("add");

            b.SetAttribute("key", "测试");
            b.SetAttribute("value", "0"); 工具栏.AppendChild(b);

            XmlElement 密钥_百度 = doc.CreateElement("密钥_百度");
            root.AppendChild(密钥_百度);
            b = doc.CreateElement("add");

            b.SetAttribute("key", "测试");
            b.SetAttribute("value", "0"); 密钥_百度.AppendChild(b);

            XmlElement 代理 = doc.CreateElement("代理");
            root.AppendChild(代理);
            b = doc.CreateElement("add");

            b.SetAttribute("key", "测试");
            b.SetAttribute("value", "0");
            代理.AppendChild(b);
            XmlElement 更新 = doc.CreateElement("更新");
            root.AppendChild(更新);
            b = doc.CreateElement("add");

            b.SetAttribute("key", "测试");
            b.SetAttribute("value", "0"); 更新.AppendChild(b);
            XmlElement 截图音效 = doc.CreateElement("截图音效");
            root.AppendChild(截图音效);
            b = doc.CreateElement("add");

            b.SetAttribute("key", "测试");
            b.SetAttribute("value", "0"); 截图音效.AppendChild(b);
            XmlElement 取色器 = doc.CreateElement("取色器");
            root.AppendChild(取色器);
            b = doc.CreateElement("add");

            b.SetAttribute("key", "测试");
            b.SetAttribute("value", "0"); 取色器.AppendChild(b);
            XmlElement OCR = doc.CreateElement("OCR");
            root.AppendChild(OCR);
            b = doc.CreateElement("add");

            b.SetAttribute("key", "测试");
            b.SetAttribute("value", "0"); OCR.AppendChild(b);
            XmlElement OCR2 = doc.CreateElement("OCR2");
            root.AppendChild(OCR2);
            b = doc.CreateElement("add");
            b.SetAttribute("key", "测试");
            b.SetAttribute("value", "0"); OCR2.AppendChild(b);
            XmlElement paddle模型 = doc.CreateElement("paddle模型");
            root.AppendChild(paddle模型);
            b = doc.CreateElement("add");

            b.SetAttribute("key", "测试");
            b.SetAttribute("value", "0"); paddle模型.AppendChild(b);

            XmlElement 翻译API_百度 = doc.CreateElement("翻译API_百度");
            root.AppendChild(翻译API_百度);
            b = doc.CreateElement("add");
            b.SetAttribute("key", "测试");
            b.SetAttribute("value", "0");
            翻译API_百度.AppendChild(b);

            XmlElement 特殊 = doc.CreateElement("特殊");
            root.AppendChild(特殊);
            b = doc.CreateElement("add");

            b.SetAttribute("key", "测试");
            b.SetAttribute("value", "0"); 特殊.AppendChild(b);



            doc.Save(file);
        }

    }
}

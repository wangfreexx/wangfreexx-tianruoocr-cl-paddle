using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using TrOCR.Properties;

namespace TrOCR.Helper
{
    public class HanToPinyin
    {
        private static readonly Dictionary<string, string> WordsDictionary;
        static HanToPinyin()
        {
            var text = Resources.pinyin;
            WordsDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(text);
        }

        public static string GetFirstLetter(string input)
        {
            input = input.Split(new[] { ':', '-' }, StringSplitOptions.RemoveEmptyEntries)[0];
            input = Regex.Replace(input, @"[^\u4e00-\u9fa5]", "");
            var strArr = GetFullPinyin(input).Split(new[] {'\t', ' '}, StringSplitOptions.RemoveEmptyEntries);
            return strArr.Aggregate("", (current, s) => current + s[0]).ToUpper();
        }

        public static string GetFullPinyin(string input)
        {
            var result = "";
            var index = 0;
            while (index < input.Length)
            {
                var strLength = 1;
                while (true)
                {
                    var str = input.Substring(index, strLength);
                    if (WordsDictionary.ContainsKey(str))
                    {
                        if (index + strLength >= input.Length)
                        {
                            result += WordsDictionary[str];
                            index += strLength;
                            break;
                        }
                        strLength++;
                    }
                    else
                    {
                        str = input.Substring(index, strLength - 1);
                        result += WordsDictionary[str];
                        index += (strLength - 1);
                        break;
                    }
                }
            }
            return result;
        }
    }
}
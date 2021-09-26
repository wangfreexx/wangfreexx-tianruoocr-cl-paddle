using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace GoogleTranslateApi
{
    /// <summary>
    /// The Google translator api wrapper
    /// </summary>
    public class GoogleTranslator
    {
        private const string Url = "https://translate.googleapis.com/translate_a/single?client=gtx&sl=";
        private string Request { get; set; } = String.Empty;

        /// <summary>
        /// JSON Array parser
        /// </summary>
        private struct Block
        {
            public object[] Data { get; }
            public int Elements { get => Data.Length; }
            public int Blocks
            {
                get
                {
                    int c = 0;
                    foreach (object _data in Data)
                        if (_data is Block)
                            c++;
                    return c;
                }
            }
            public Block this[int x]
            {
                get
                {
                    if (x > Blocks - 1)
                        throw new IndexOutOfRangeException("Index out of range");
                    List<Block> _blocks = new List<Block>();
                    foreach(object _data in Data)
                    {
                        if (_data is Block)
                        {
                            //Block block = _data as Block? ?? throw new Exception("Cannot Parse the block at the given index");
                            _blocks.Add((Block)_data);
                        }
                    }
                    return _blocks[x];
                }
            }

            /// <summary>
            /// Creates a Block class 
            /// </summary>
            /// <param name="data">The data string to be parsed</param>
            /// <exception cref="ArgumentException"></exception>
            public Block(string data)
            {
                if (!IsValidData(data))
                    throw new ArgumentException("Invalid data string", "data");
                List<object> ldata = new List<object>() { null };   
                Queue<char> vs = new Queue<char>(data.ToCharArray());

                while (vs.Count > 0)
                {
                    char @char = vs.Dequeue();
                    switch (@char)
                    {
                        case '[':
                            string nblock = new string(vs.ToArray());
                            int end = 0;
                            /* FIXED - find the correct end*/
                            for (int n = 1; n != 0; end++)
                            {
                                if (nblock[end] == '[')
                                    n++;
                                else if (nblock[end] == ']')
                                    n--;
                            }
                            vs = new Queue<char>(nblock.Substring(end));
                            ldata[ldata.Count - 1] = new Block(nblock.Substring(0, end - 1));
                            break;
                        case ',':
                            ldata.Add(null);
                            continue;
                        case '"':
                            do
                            {
                                @char = vs.Peek();
                                switch(@char)
                                {
                                    case '"':
                                        continue;
                                    case '\\':
                                        vs.Dequeue();
                                        goto default;
                                    default:
                                        @char = vs.Dequeue();
                                        break;
                                }
                                ldata[ldata.Count - 1] = String.Concat(ldata[ldata.Count - 1], @char);
                            }
                            while (vs.Peek() != '"');
                            vs.Dequeue();
                            break;
                        default:
                            ldata[ldata.Count - 1] = String.Concat(ldata[ldata.Count - 1], @char);
                            break;
                    }

                }
                Data = ldata.ToArray();
            }
         
            private static bool IsValidData(string data)
            {
                if ((data.Count(c => c == '[') + data.Count(c => c == ']')) % 2 != 0)
                    return false;
                if (data.Count(c => c == '"') % 2 != 0)
                    return false;
                return true;
            }
        }

        /// <summary>
        /// Creates a instance of the GoogleTranslatorApi
        /// </summary>
        /// <param name="source">The source language</param>
        /// <param name="target">The target language</param>
        public GoogleTranslator(Language source, Language target)
        {
            //if (target.Value == Language.Auto.Value)
            //    throw new Exception("The target language can't be Language.Auto");
            this.Request = Url + $"{source.Value}&tl={target.Value}&dt=t&q=";
        }

        private string Download(string text)
        {
            WebClient web = new WebClient
            {
                Encoding = Encoding.UTF8
            };
            //web.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0");
            //web.Headers.Add(HttpRequestHeader.AcceptCharset, "UTF-8");
            Uri uri = new Uri(this.Request + Uri.EscapeUriString(text));
            return web.DownloadString(uri);
        }

        private async Task<string> DownloadAsync(string text)
        {
            WebClient web = new WebClient
            {
                Encoding = Encoding.UTF8
            };
            Uri uri = new Uri(this.Request + Uri.EscapeDataString(text));
            return await web.DownloadStringTaskAsync(uri);
        }

        /// <summary>
        /// Returns the translated text
        /// </summary>
        /// <param name="text">The text to be translated</param>
        /// <returns>A string that contains the translated text</returns>
        public string Text(string text)
        {
            string Dest = string.Empty;
            /* FIXED - Remove '\n' (Line feed/new line char) */
            text = (Download(text)).Replace("\n", "");
            /* FIXED - Gets the multiples blocks that can be received */
            Block Datablock = new Block(text);
            for(int n = 0; n < Datablock[0][0].Blocks; n++)
            {
                Block splitData = Datablock[0][0][n];
                Dest = String.Concat(Dest, splitData.Data[0]);
            }
            return Dest;
        }

        /// <summary>
        /// Returns the translated text not blocking the current thead
        /// </summary>
        /// <param name="source">The text to be translated</param>
        /// <returns>A string that contains the translated text</returns>
        public async Task<string> GetTextAsync(string source)
        {
            string result = string.Empty;
            source = (await DownloadAsync(source)).Replace("\n", "");

            var dataBlock = new Block(source);
            for (int n = 0; n < dataBlock.Blocks; n++)
            {
                Block splitData = dataBlock[0][0][n];
                result = string.Concat(result, splitData.Data[0]);
            }
            return result;
        }
    }
}

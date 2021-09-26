using System;
using System.Linq;
using System.Reflection;

namespace GoogleTranslateApi
{
    public class Language
    {
        public string Value { get; set; }

        /// <summary>
        /// Parse 
        /// </summary>
        /// <param name="Lang"></param>
        /// <returns></returns>
        public static Language Parse(string Lang)
        {
            var langs = typeof(Language).GetProperties(BindingFlags.Static | BindingFlags.Public);
            var lang = langs.Single((i) =>
                string.Equals(i.Name, Lang, StringComparison.OrdinalIgnoreCase) ||
                string.Equals((i.GetValue(i, null) as Language).Value ?? string.Empty, Lang, StringComparison.OrdinalIgnoreCase)
            ) ?? throw new ArgumentException("Invalid lang id: " + Lang, nameof(Lang));
            return lang.GetValue(lang) as Language;
        }

        public string GetLanguageFullName()
        {
            var langs = typeof(Language).GetProperties(BindingFlags.Static | BindingFlags.Public);
            var lang = langs.Single((i) =>
                string.Equals((i.GetValue(i, null) as Language).Value ?? string.Empty, this.Value, StringComparison.Ordinal)
            );
            return lang?.Name ?? String.Empty;
        }

        private Language(string x) => Value = x;
        public static Language Portuguese { get { return new Language("pt"); } }
        public static Language English { get { return new Language("en"); } }
        public static Language Spanish { get { return new Language("es"); } }
        public static Language Russian { get { return new Language("ru"); } }
        public static Language French { get { return new Language("fr"); } }
        public static Language German { get { return new Language("de"); } }
        public static Language Swedish { get { return new Language("sv"); } }
        public static Language Italian { get { return new Language("it"); } }
        public static Language Japanese { get { return new Language("ja"); } }
        public static Language Chinese { get { return new Language("zh"); } }
        //public static Language Auto { get { return new Language("auto"); } }
    }
}

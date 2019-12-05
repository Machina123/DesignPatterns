using System.Text.RegularExpressions;

namespace Builder
{
    public class TagCapitalizeConverter : Converter
    {
        public char ConvertCharacter(char c)
        {
            return c;
        }

        public string ConvertTag(string t)
        {
            string tagContent = Regex.Replace(t, @"<(\w)>(.+?)<\/\1>", "$2");
            string tagName = Regex.Replace(t, @"<(\w)>(.+?)<\/\1>", "$1");
            return $"<{tagName}>{tagContent.ToUpper()}</{tagName}>";
        }
    }
}
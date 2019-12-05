using System.Text.RegularExpressions;

namespace Builder
{
    public class TagToUppercaseConverter : Converter
    {
        public char ConvertCharacter(char c)
        {
            return c;
        }

        public string ConvertTag(string t)
        {
            return Regex.Replace(t, @"<(\w)>(.+?)<\/\1>", @"$2").ToUpper();
        }
    }
}
using System.Text;
using System.Text.RegularExpressions;

namespace Builder
{
    public class HtmlReader
    {
        private Converter _converter;
        private string _input;

        public HtmlReader(string input)
        {
            _input = input;
        }

        public void SetConverter(Converter converter)
        {
            _converter = converter;
        }

        public string GetConvertedString()
        {
            StringBuilder result = new StringBuilder();
            int pos = 0;
            while (pos < _input.Length)
            {
                string token = _input[pos].ToString();
                if (token != "<")
                {
                    result.Append(_converter.ConvertCharacter(token[0]));
                    pos++;
                }
                else
                {
                    string tag = Regex.Match(_input.Substring(pos), @"<(\w)>(.+?)<\/\1>").Value;
                    result.Append(_converter.ConvertTag(tag));
                    pos += tag.Length;
                }
            }
            return result.ToString();
        }
    }
}
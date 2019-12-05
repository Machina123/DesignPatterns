using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = @"A<b>l</b>a ma <i>k</i>o<u>t</u>a";
            HtmlReader reader = new HtmlReader(test);
            
            Console.WriteLine($"Tekst wejściowy: {test}");
            
            reader.SetConverter(Config.GetConverter(Converters.HTML_TO_TEXT));
            Console.WriteLine($"HTML -> tekst ASCII: {reader.GetConvertedString()}");
            
            reader.SetConverter(Config.GetConverter(Converters.TAG_TO_UPPERCASE_TEXT));
            Console.WriteLine($"HTML -> tekst ASCII (zawartość tagów wielkimi literami): {reader.GetConvertedString()}");
            
            reader.SetConverter(Config.GetConverter(Converters.CAPITALIZE_TAG_CONTENT));
            Console.WriteLine($"HTML -> HTML (zawartość tagów wielkimi literami): {reader.GetConvertedString()}");
            
            reader.SetConverter(Config.GetConverter(Converters.TAG_FORMAT_CHANGE));
            Console.WriteLine($"HTML -> inny format tagów: {reader.GetConvertedString()}");
        }
    }
}
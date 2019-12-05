namespace Builder
{
    public class Config
    {
        public static Converter GetConverter(Converters c)
        {
            switch (c)
            {
                case Converters.HTML_TO_TEXT:
                    return new HtmlToTextConverter();
                case Converters.TAG_TO_UPPERCASE_TEXT:
                    return new TagToUppercaseConverter();
                case Converters.CAPITALIZE_TAG_CONTENT:
                    return new TagCapitalizeConverter();
                case Converters.TAG_FORMAT_CHANGE:
                    return new TagFormatConverter();
            }

            return null;
        }
    }
}
namespace Prettify
{
    public static class StringExtentions
    {
        public static string Dashify(this string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            return input.Replace(" ", "-");
        }
    }
}

namespace Task2
{
    using System.Text;

    public static class StringExtensions
    {
        public static string SplitByUpperLetter(this string sequence)
        {
            int probableStringMargin = 10;
            int probableStringSize = sequence.Length + probableStringMargin;
            var builder = new StringBuilder(probableStringSize);
            char singleWhitespace = ' ';

            foreach (char letter in sequence)
            {
                if (char.IsUpper(letter))
                {
                    builder.Append(singleWhitespace);
                }

                builder.Append(letter);
            }

            return builder.ToString().Trim();
        }
    }
}

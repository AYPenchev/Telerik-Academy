namespace Task1
{
    public class TestBoolStringifier
    {
        private const int MAX_COUNT = 6;

        public static void Main()
        {
            BoolStringifier boolToString = new BoolStringifier();
            boolToString.GetBoolAsString(true);
        }
    }
}

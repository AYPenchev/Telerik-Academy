namespace Task1
{
    using System;

    public class BoolStringifier
    {
        public void GetBoolAsString(bool boolToBeStringify)
        {
            string stringifiedBool = boolToBeStringify.ToString();
            Console.WriteLine(stringifiedBool);
        }
    }
}

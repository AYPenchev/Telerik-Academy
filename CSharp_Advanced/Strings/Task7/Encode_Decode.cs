namespace Task7
{
    using System;
    using System.Text;

    class EncodeDecode
    {
        public static string EncodeString(string cryptKey, string stringToBeEncoded)
        {
            StringBuilder cipher = new StringBuilder();
            for (int i = 0; i < stringToBeEncoded.Length; i++)
            {
                cipher.Append((char)(stringToBeEncoded[i] ^ cryptKey[i % cryptKey.Length]));
            }
            return cipher.ToString();
        }

        public static string DecodeString(string cryptKey, string stringToBeDecoded)
        {
            return EncodeString(cryptKey, stringToBeDecoded);
        }

        static void Main()
        {
            string cryptKey = "A@1$#f";

            string stringToBeEncoded = Console.ReadLine();
            string encodedString = EncodeString(cryptKey, stringToBeEncoded);
            Console.WriteLine(encodedString);

            string decodedString = DecodeString(cryptKey, encodedString);
            Console.WriteLine(decodedString);

        }
    }
}

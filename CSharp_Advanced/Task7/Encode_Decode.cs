namespace Task7
{
    using System;

    class EncodeDecode
    {
        public static string EncodeString(string cryptKey, string stringToBeEncoded)
        {
            string encodedString = string.Empty;
            for (int i = 0, j = 0; i < stringToBeEncoded.Length; i++, j++)
            {
                if (cryptKey.Length - 1 == j)
                {
                    j = 0;
                }

                encodedString += stringToBeEncoded[i] ^ cryptKey[j];
            }
            return encodedString;
        }

        public static string DecodeString(string cryptKey, string stringToBeDecoded)
        {
            string decodedString = string.Empty;
            for (int i = 0, j = 0; i < stringToBeDecoded.Length; i++, j++)
            {
                if (cryptKey.Length - 1 == j)
                {
                    j = 0;
                }

                decodedString += stringToBeDecoded[i] ^ cryptKey[j];
            }
            
            for (int i = 0, j = 0; i < stringToBeDecoded.Length; i++, j++)
            {
                if (cryptKey.Length - 1 == j)
                {
                    j = 0;
                }

                decodedString += stringToBeDecoded[i] ^ cryptKey[j];
            }
            return decodedString;
        }

        static void Main()
        {
            string cryptKey = "A@1$#f";

            string stringToBeEncoded = Console.ReadLine();
            string encodedString = EncodeString(cryptKey, stringToBeEncoded);
            Console.WriteLine(encodedString);
            //string
        }
    }
}

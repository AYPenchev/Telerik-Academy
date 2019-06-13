using System.Runtime.InteropServices;
using System.Text;
using Microsoft.SqlServer.Server;

namespace Task1
{
    using System;

    public class TestStringExtensions
    {
        public static void Main()
        {
            string hashValue = StringExtensions.ToMd5Hash("hash this");
            Console.WriteLine(hashValue);

            bool isTrueValue = StringExtensions.ToBoolean("yes");
            Console.WriteLine(isTrueValue);

            short shortValue = StringExtensions.ToShort("20000");
            Console.WriteLine(shortValue);

            int integerValue = StringExtensions.ToInteger("4");
            Console.WriteLine(integerValue);

            long longValue = StringExtensions.ToLong("4000000000000000000");
            Console.WriteLine(longValue);

            DateTime dateValue = StringExtensions.ToDateTime("12.05.2019");
            Console.WriteLine(dateValue);

            string firstCapitalLetter = StringExtensions.CapitalizeFirstLetter("hey");
            Console.WriteLine(firstCapitalLetter);

            string getStringBetween = StringExtensions.GetStringBetween("kostavabe", "be", "ko");
            Console.WriteLine(getStringBetween);

            string cyrillicLettersToLatinLetterRepresentation = StringExtensions.ConvertCyrillicToLatinLetters("как е?");
            Console.WriteLine(cyrillicLettersToLatinLetterRepresentation);

            Console.OutputEncoding = Encoding.UTF8;
            string latinLettersToCyrillicLetterRepresentation = StringExtensions.ConvertLatinToCyrillicKeyboard("masa");
            Console.WriteLine(latinLettersToCyrillicLetterRepresentation);

            string validUserName = StringExtensions.ToValidUsername("^[_].ас/ \\д_9SСs");
            Console.WriteLine(validUserName);

            string validLatinUserName = StringExtensions.ToValidLatinFileName("^[_].ас/ \\д_9S Сs");
            Console.WriteLine(validLatinUserName);

            string firstCharacters = StringExtensions.GetFirstCharacters("hey", 4);
            Console.WriteLine(firstCharacters);

            string fileName = StringExtensions.GetFileExtension("File.exe.lev");
            Console.WriteLine(fileName);

            string contentFromExtension = StringExtensions.ToContentType("jpg3");
            Console.WriteLine(contentFromExtension);

            byte[] stringBytes = StringExtensions.ToByteArray("aA1234");
            foreach (byte currentByte in stringBytes)
            {
                Console.WriteLine(currentByte);
            }
        }
    }
}

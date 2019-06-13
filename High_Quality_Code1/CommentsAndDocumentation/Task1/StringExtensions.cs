namespace Task1
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    public static class StringExtensions
    {
        /// <summary>
        /// The MD5 message-digest algorithm is a widely used hash function producing a 128-bit hash value. 
        /// </summary>
        /// <param name="input">Convert this parameter to MD5.</param>
        /// <returns>128-bit hash value.</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            var builder = new StringBuilder();

            // Format hashed data each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            return builder.ToString();
        }
 
        /// <summary>
        /// This function checks whether the input string is contained in array of values which represent true value.
        /// </summary>
        /// <param name="input">This parameter is compared with each value of the array in the function.</param>
        /// <returns>return True if the string input parameter is contained in the array and
        /// False if it is not contained.</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// This function tries to parse a value given as string to type short.
        /// </summary>
        /// <param name="input">String value to be TryParsed.</param>
        /// <returns>If succeed returns the value and if it can't be parsed returns 0.</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// This function tries to parse a value given as string to type int.
        /// </summary>
        /// <param name="input">String value to be TryParsed.</param>
        /// <returns>If succeed returns the value and if it can't be parsed returns 0.</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// This function tries to parse a value given as string to type long.
        /// </summary>
        /// <param name="input">String value to be TryParsed.</param>
        /// <returns>If succeed returns the value and if it can't be parsed returns 0.</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// This function tries to parse a value given as string to type DateTime.
        /// </summary>
        /// <param name="input">String value to be TryParsed.</param>
        /// <returns>If succeed returns the date and time in the format: mm/dd/yyyy hh:mm:ss
        /// If it can't be parsed returns the default value of DateTime.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <returns>If correct string is entered this function returns the same string with first letter capitalized
        /// And if the string entered is null or empty it returns null or empty.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + 
                                                                 input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Returns the string between two other string entered by the user.
        /// </summary>
        /// <param name="input">String value that we would work with.</param>
        /// <param name="startFrom">This parameter gives us the position from which we should start looking for
        /// "startString" and "endString".</param>
        /// <returns>this function returns empty string when either of "startString" or "endString" parameters
        /// are missing or if they are given in the incorrect order.
        /// In the other case it returns the string between the two given parameters.</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// This function replaces every Cyrillic letter if there is any with its Latin representation.
        /// </summary>
        /// <param name="input">Cyrillic text</param>
        /// <returns>It returns the Latin representation of the text</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// This function replaces every Latin letter if there is any with its Cyrillic representation.
        /// In order to use this function you may need to set your encoding to UTF8.
        /// </summary>
        /// <param name="input">Latin text</param>
        /// <returns>It returns the Cyrillic representation of the text</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// This function converts all Cyrillic letters to Latin and
        /// then through regex it filters the input username to make it correct. Empty spaces are ignored.
        /// </summary>
        /// <param name="input">Username</param>
        /// <returns>Returns the corrected username.</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// This function converts all Cyrillic letters to Latin and
        /// then through regex it filters the input file name to make it correct. Empty spaces are replaced with "-".
        /// </summary>
        /// <param name="input">File name</param>
        /// <returns>Returns the corrected file name.</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// This function extract first characters from input string.
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="charsCount">Number of characters to extract.</param>
        /// <returns>Returns extracted characters as string</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            /*Using Math.Min static method we make sure that if we enter bigger charCount than the input length,
            there would be no exceptions.*/ 
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// This function extract the file extension if the file name is entered correctly.
        /// If the name is not correct, it return empty string.
        /// </summary>
        /// <param name="fileName">Enter full file name (with extension)!</param>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <returns>Returns content of the file correspondingly to the extension given as parameter.
        /// If incorrect extension is entered it returns extension of binary file.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            //This is default file extension (binary file).
            return "application/octet-stream";
        }

        /// <see>The length of the byte array is multiplied with sizeof(char) which I think is not needed!</see>
        /// <returns>Returns the ascii codes of each character separated by lines with zeros.</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}

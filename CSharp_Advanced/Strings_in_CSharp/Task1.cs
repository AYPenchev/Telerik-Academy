namespace Strings_in_CSharp
{
    using System;

    /// <summary>
    /// string in C# is immutable reference type
    /// 
    /// Important functions:
    /// Contains() -  The C# Contains method checks whether specified character or string is exists or not in the string value.
    /// ToLower() -	  Converts String into lower case based on rules of the current culture.
    /// ToUpper() -	  Converts String into Upper case based on rules of the current culture.
    /// Replace() -	  This method replaces the character.
    /// Split() -     This method splits the string based on specified value.
    /// Substring() - This method returns substring.
    /// 
    /// Important properties:
    /// Length -      It is a string property that returns length of string.
    /// </summary>
    class Task1
    {
        static void Main()
        {
            string stringCSharp = "CSharp string!";
            string copyStringCSharp = stringCSharp;
            bool isRefType = ReferenceEquals(stringCSharp, copyStringCSharp);
            Console.WriteLine(isRefType);

            Console.WriteLine(stringCSharp.Contains("CS"));
            Console.WriteLine(stringCSharp.ToLower());
            Console.WriteLine(stringCSharp.ToUpper());
            Console.WriteLine(stringCSharp.Replace('p', 'k'));
            string[] splitSting = stringCSharp.Split(' ');
            Console.WriteLine(stringCSharp.Substring(0,6));

            Console.WriteLine(stringCSharp.Length);
        }
    }
}

namespace Task4
{
    using System;
    using System.Net;

    class InvalidAnswerException : Exception
    {
        public InvalidAnswerException()
        {

        }

        public InvalidAnswerException(string answer)
            : base(string.Format("Invalid answer: {0}", answer))
        {

        }
    }

    class DownloadFile
    {
        private static void ValidateAnswer(string answer)
        {
            if (answer.ToLower() != "y")
            {
                throw new InvalidAnswerException(answer);
            }

        }
        static void Main()
        {
            Console.WriteLine("Do You allow access of the program to download a picture from the web?\n");

            Console.Write("Enter your choice ([Y] / [N]): ");
            string userChoice = Console.ReadLine();

            try
            {
                if (userChoice.ToLower() == "n")
                {
                    return;
                }
                ValidateAnswer(userChoice);
            }
            catch (InvalidAnswerException exception)
            {
                Console.Error.WriteLine(exception.Message);
                return;
            }

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    Console.WriteLine("\nStart downloading...");
                    webClient.DownloadFile("https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwi935Ot1I_iAhUC3qQKHWhcDeYQjRx6BAgBEAU&url=https%3A%2F%2Fwww.google.com%2Fearth%2F&psig=AOvVaw2DGjLADFBsA4YONefH9ghg&ust=1557532901667696", "../../Google.png");
                    Console.WriteLine("\n-> Download successfully!");
                }
                catch (ArgumentException)
                {
                    Console.Error.WriteLine("\n-> Error: You have entered an empty URL!");
                }
                catch (WebException)
                {
                    Console.Error.WriteLine("\n-> Error: You have entered an invalid URL!");
                }
                catch (NotSupportedException)
                {
                    Console.Error.WriteLine("\n-> Error: This method does not support simultaneous downloads!");
                }
                finally
                {
                    Console.WriteLine("\nGoodbye!\n");
                }
            }
        }
    }
}

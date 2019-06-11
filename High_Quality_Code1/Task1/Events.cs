namespace Task1
{
    using System;
  
    public class Program
    {
        public static EventHolder Events { get; set; } = new EventHolder();

        static void Main()
        {
            while (ExecuteNextCommand() == true)
            {
                Console.WriteLine(Messages.Output);
            }
        }

        private static bool ExecuteNextCommand()
        {
            //string testAdd = "AddEvent 02/16/2008 12:15:12 |Beach party|Plodiv";
            //string testDelete = "DeleteEvent House party";
            //string testList = "ListEvents 02/16/2008 12:15:12 |2";
            //string testExit = "Exit";

            string command = Console.ReadLine();

            switch (command[0])
            {
                case 'A':
                    AddEvent(command);
                    return true;

                case 'D':
                    DeleteEvents(command);
                    return true;

                case 'L':
                    ListEvents(command);
                    return true;

                case 'E':
                    return false;

                default:
                    return false;
            }
        }

        private static void ListEvents(string command)
        {
            DateTime date = GetDate(command, "ListEvents");

            int pipeIndex = command.IndexOf('|');
            string countString = command.Substring(pipeIndex + 1);
            int count = int.Parse(countString);

            Events.ListEvents(date, count);
        }

        private static void DeleteEvents(string command)
        {
            string title = command.Substring("DeleteEvents".Length);
            Events.DeleteEvents(title);
        }

        private static void AddEvent(string command)
        {
            GetParameters(command, "AddEvent");
        }
        private static void GetParameters(string commandForExecution, string commandType)
        {
            DateTime dateAndTime = GetDate(commandForExecution, commandType);
            string eventTitle;
            string eventLocation;

            int firstPipeIndex = commandForExecution.IndexOf('|');
            int lastPipeIndex = commandForExecution.LastIndexOf('|');

            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
                eventLocation = "";
            }
            else
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }

            Events.AddEvent(dateAndTime, eventTitle, eventLocation);
        }

        private static DateTime GetDate(string command, string commandType)
        {
            int dateLenght = 19;
            return DateTime.Parse(command.Substring(commandType.Length + 1, dateLenght));
        }
    }
}

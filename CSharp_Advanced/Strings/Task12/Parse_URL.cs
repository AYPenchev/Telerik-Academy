namespace Task12
{
    using System;

    class ParseURL
    {
        static void Main()
        {
            string inputURL = Console.ReadLine();

            string protocol = inputURL.Remove(inputURL.IndexOf("://"));
            Console.WriteLine("[protocol] = " + protocol);

            string server = inputURL.Remove(0, inputURL.IndexOf("://") + 3);
            server = server.Remove(server.IndexOf("/"));
            Console.WriteLine("[server] = " + server);

            string resource = inputURL.Remove(0, inputURL.IndexOf("://") + 3);
            resource = resource.Remove(0, resource.IndexOf("/"));
            Console.WriteLine("[resource] = " + resource);
        }
    }
}

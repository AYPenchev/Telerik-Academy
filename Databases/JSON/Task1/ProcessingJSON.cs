namespace Task1
{
    using System.Net;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Xml.Linq;
    using Model;
    using Newtonsoft.Json;

    public class ProcessingJSON
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            string urlToRss = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            var client = new WebClient { Encoding = Encoding.UTF8 };
            string xml = client.DownloadString(urlToRss);

            var youtubeAsXml = XDocument.Parse(xml);
            
            var youtubeAsJsonFilePath = "../../ youtube.json";
            SaveToFile(youtubeAsJsonFilePath, youtubeAsXml);
            var youtubeAsJson = LoadFromFile(youtubeAsJsonFilePath);

            var titles = GetVideoTitles(youtubeAsJson);
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }

            var poco = ConvertJsonToPoco(youtubeAsJson);
            foreach (var element in poco)
            {
                Console.WriteLine(element);   
            }

            var htmlGenerator = new HTMLGenerator();
            htmlGenerator.CreateHtmlPage("../../rss.html", poco, titles);
        }

        private static Document LoadFromFile(string youtubeAsJsonFilePath)
        {
            var json = File.ReadAllText(youtubeAsJsonFilePath);
            var document = JsonConvert.DeserializeObject<Document>(json);
            return document;
        }

        private static void SaveToFile(string youtubeAsJsonFilePath, XDocument youtubeAsXml)
        {
            var youtubeAsJson = JsonConvert.SerializeXNode(youtubeAsXml, Formatting.Indented);
            File.WriteAllText(youtubeAsJsonFilePath, youtubeAsJson);
        }

        private static IList<string> ConvertJsonToPoco(Document json)
        {
            IList<string> videoUrls = new List<string>();
            json.Feed.Entries.ForEach(entry => videoUrls.Add(entry.UrlToVideo.Href));

            return videoUrls;
        }

        private static IList<string> GetVideoTitles(Document json)
        {
            IList<string> videoTitles = new List<string>()
            {
                json.Feed.Title
            };

            json.Feed.Entries.ForEach(entry => videoTitles.Add(entry.Title));

            return videoTitles;
        }
    }
}

using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task1.Model
{
    using System;

    public class HTMLGenerator
    {
        private const string styleFormat = @"<li><a href=""{0}""> {1} </a></li>";

        public void CreateHtmlPage(string path, IList<string> videoUrls, IList<string> titles)
        {
            var html = this.GenerateHtml(videoUrls, titles);
            this.CreateFile(path, html);
        }

        private string GenerateHtml(IList<string> videoUrls, IList<string> titles)
        {
            var html = new StringBuilder();
            html.AppendLine("<ul>");

            // titles start at index one because in the json file there one more title
            for(int i = 0, j = 1; i < videoUrls.Count || j < titles.Count ; i++, j++)
            {
                html.AppendFormat(styleFormat, videoUrls[i], titles[j]);
            }

            html.AppendLine("<ul>");
            return html.ToString();
        }

        private void CreateFile(string path, string html)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    streamWriter.WriteLine(html);
                }
            }
        }
    }
}

namespace Task1.Model
{
    using Newtonsoft.Json;

    public class Entry : IEntry
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public Link UrlToVideo { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        public override string ToString()
        {
            return $"Item Title: {this.Title}";
        }
    }
}

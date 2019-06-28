namespace Task1.Model
{
    using System.Collections.Generic;
    using Newtonsoft.Json;


    public class Feed
    {
        [JsonProperty("entry")]
        public List<Entry> Entries { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}

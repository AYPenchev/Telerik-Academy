namespace Task1.Model
{
    using Newtonsoft.Json;
    
    public class Document
    {
        [JsonProperty("feed")]
        public Feed Feed { get; set; }
    }

}

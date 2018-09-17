using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestSkill.Core.API.Models
{
    public class Movie : BaseEntity
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("cover_url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}

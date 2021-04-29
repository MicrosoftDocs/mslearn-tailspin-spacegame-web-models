using Newtonsoft.Json;

namespace TailSpin.SpaceGame.Web.Models
{
    /// <summary>
    /// Base class for data models.
    /// </summary>
    public abstract class FakeViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        // Name
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        // Age
        [JsonProperty(PropertyName = "age")]
        public int Age { get; set; }
    }
}
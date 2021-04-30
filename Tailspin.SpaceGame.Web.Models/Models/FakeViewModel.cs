using Newtonsoft.Json;

namespace TailSpin.SpaceGame.Web.Models
{
    /// <summary>
    /// Base class for data models.
    /// </summary>
    public abstract class FakeViewModel
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        /// <summary>
        /// Age
        /// </summary>
        [JsonProperty(PropertyName = "age")]
        public int Age { get; set; }
    }
}
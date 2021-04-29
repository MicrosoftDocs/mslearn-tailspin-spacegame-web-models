using Newtonsoft.Json;

namespace TailSpin.SpaceGame.Web.Models
{
    /// <summary>
    /// Base class for data models.
    /// </summary>
    public abstract class FakeViewModel
    {
        // The value that uniquely identifies this object.
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
}
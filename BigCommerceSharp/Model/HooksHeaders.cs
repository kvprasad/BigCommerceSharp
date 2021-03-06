using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// You can pass in any number of custom headers to validate webhooks being returned.
  /// </summary>
  [DataContract]
  public class HooksHeaders {
    /// <summary>
    /// Gets or Sets Custom
    /// </summary>
    [DataMember(Name="custom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom")]
    public string Custom { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HooksHeaders {\n");
      sb.Append("  Custom: ").Append(Custom).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}

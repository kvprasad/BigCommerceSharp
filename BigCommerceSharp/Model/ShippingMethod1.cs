using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ShippingMethod1 {
    /// <summary>
    /// Shipping-method ID. READ-ONLY
    /// </summary>
    /// <value>Shipping-method ID. READ-ONLY</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Display name for shipping method.
    /// </summary>
    /// <value>Display name for shipping method.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Depends on the shipping-method type. See the [supported settings object](#supported-settings).
    /// </summary>
    /// <value>Depends on the shipping-method type. See the [supported settings object](#supported-settings).</value>
    [DataMember(Name="settings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "settings")]
    public Object Settings { get; set; }

    /// <summary>
    /// Whether or not this shipping-zone method is enabled.
    /// </summary>
    /// <value>Whether or not this shipping-zone method is enabled.</value>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// `fixed_surcharge`: flat-rate handling fee applied to shipping cost.  `percentage_surcharge`: percentage handling fee applied to shipping cost
    /// </summary>
    /// <value>`fixed_surcharge`: flat-rate handling fee applied to shipping cost.  `percentage_surcharge`: percentage handling fee applied to shipping cost</value>
    [DataMember(Name="handling_fees", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "handling_fees")]
    public Object HandlingFees { get; set; }

    /// <summary>
    /// Whether or not this shipping zone is the fallback if all others are not valid for the order.
    /// </summary>
    /// <value>Whether or not this shipping zone is the fallback if all others are not valid for the order.</value>
    [DataMember(Name="is_fallback", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_fallback")]
    public bool? IsFallback { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShippingMethod1 {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Settings: ").Append(Settings).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  HandlingFees: ").Append(HandlingFees).Append("\n");
      sb.Append("  IsFallback: ").Append(IsFallback).Append("\n");
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

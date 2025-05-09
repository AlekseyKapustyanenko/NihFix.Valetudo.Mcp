// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Config.Interfaces.Mqtt
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class MqttGetResponse_interfaces : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The homeassistant property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Config.Interfaces.Mqtt.MqttGetResponse_interfaces_homeassistant? Homeassistant { get; set; }
#nullable restore
#else
        public global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Config.Interfaces.Mqtt.MqttGetResponse_interfaces_homeassistant Homeassistant { get; set; }
#endif
        /// <summary>The homie property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Config.Interfaces.Mqtt.MqttGetResponse_interfaces_homie? Homie { get; set; }
#nullable restore
#else
        public global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Config.Interfaces.Mqtt.MqttGetResponse_interfaces_homie Homie { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Config.Interfaces.Mqtt.MqttGetResponse_interfaces"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Config.Interfaces.Mqtt.MqttGetResponse_interfaces CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Config.Interfaces.Mqtt.MqttGetResponse_interfaces();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "homeassistant", n => { Homeassistant = n.GetObjectValue<global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Config.Interfaces.Mqtt.MqttGetResponse_interfaces_homeassistant>(global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Config.Interfaces.Mqtt.MqttGetResponse_interfaces_homeassistant.CreateFromDiscriminatorValue); } },
                { "homie", n => { Homie = n.GetObjectValue<global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Config.Interfaces.Mqtt.MqttGetResponse_interfaces_homie>(global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Config.Interfaces.Mqtt.MqttGetResponse_interfaces_homie.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Config.Interfaces.Mqtt.MqttGetResponse_interfaces_homeassistant>("homeassistant", Homeassistant);
            writer.WriteObjectValue<global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.Config.Interfaces.Mqtt.MqttGetResponse_interfaces_homie>("homie", Homie);
        }
    }
}
#pragma warning restore CS0618

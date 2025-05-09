// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ActionNamespace
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ActionPutRequestBody : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The action property</summary>
        public global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ActionNamespace.ActionPutRequestBody_action? Action { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ActionNamespace.ActionPutRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ActionNamespace.ActionPutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ActionNamespace.ActionPutRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action", n => { Action = n.GetEnumValue<global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ActionNamespace.ActionPutRequestBody_action>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::NihFix.Valetudo.HttpClient.Api.V2.Valetudo.ActionNamespace.ActionPutRequestBody_action>("action", Action);
        }
    }
}
#pragma warning restore CS0618

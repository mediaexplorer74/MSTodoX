// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type HybridAgentUpdaterConfiguration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class HybridAgentUpdaterConfiguration
    {

        /// <summary>
        /// Gets or sets deferUpdateDateTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deferUpdateDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? DeferUpdateDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets updateWindow.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updateWindow", Required = Newtonsoft.Json.Required.Default)]
        public UpdateWindow UpdateWindow { get; set; }
    
        /// <summary>
        /// Gets or sets allowUpdateConfigurationOverride.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowUpdateConfigurationOverride", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowUpdateConfigurationOverride { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}

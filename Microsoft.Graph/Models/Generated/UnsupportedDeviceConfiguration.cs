// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Unsupported Device Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UnsupportedDeviceConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets original entity type name.
        /// The type of entity that would be returned otherwise.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "originalEntityTypeName", Required = Newtonsoft.Json.Required.Default)]
        public string OriginalEntityTypeName { get; set; }
    
        /// <summary>
        /// Gets or sets details.
        /// Details describing why the entity is unsupported. This collection can contain a maximum of 1000 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "details", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<UnsupportedDeviceConfigurationDetail> Details { get; set; }
    
    }
}


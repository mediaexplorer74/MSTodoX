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
    /// The type Shared Insight.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SharedInsight : Entity
    {
    
        /// <summary>
        /// Gets or sets last shared.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastShared", Required = Newtonsoft.Json.Required.Default)]
        public SharingDetail LastShared { get; set; }
    
        /// <summary>
        /// Gets or sets sharing history.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharingHistory", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<SharingDetail> SharingHistory { get; set; }
    
        /// <summary>
        /// Gets or sets resource visualization.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceVisualization", Required = Newtonsoft.Json.Required.Default)]
        public ResourceVisualization ResourceVisualization { get; set; }
    
        /// <summary>
        /// Gets or sets resource reference.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceReference", Required = Newtonsoft.Json.Required.Default)]
        public ResourceReference ResourceReference { get; set; }
    
        /// <summary>
        /// Gets or sets last shared method.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastSharedMethod", Required = Newtonsoft.Json.Required.Default)]
        public Entity LastSharedMethod { get; set; }
    
        /// <summary>
        /// Gets or sets resource.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resource", Required = Newtonsoft.Json.Required.Default)]
        public Entity Resource { get; set; }
    
    }
}


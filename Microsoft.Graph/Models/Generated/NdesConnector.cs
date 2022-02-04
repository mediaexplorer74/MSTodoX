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
    /// The type Ndes Connector.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class NdesConnector : Entity
    {
    
        /// <summary>
        /// Gets or sets last connection date time.
        /// Last connection time for the Ndes Connector
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastConnectionDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastConnectionDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// Ndes Connector Status
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public NdesConnectorState? State { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The friendly name of the Ndes Connector.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
    }
}

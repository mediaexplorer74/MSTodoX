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
    /// The type Mobile App Relationship.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MobileAppRelationship : Entity
    {
    
		///<summary>
		/// The internal MobileAppRelationship constructor
		///</summary>
        protected internal MobileAppRelationship()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets target id.
        /// The target child mobile app's app id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetId", Required = Newtonsoft.Json.Required.Default)]
        public string TargetId { get; set; }
    
        /// <summary>
        /// Gets or sets target display name.
        /// The target child mobile app's display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string TargetDisplayName { get; set; }
    
    }
}


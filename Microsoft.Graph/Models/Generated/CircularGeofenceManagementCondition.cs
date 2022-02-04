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
    /// The type Circular Geofence Management Condition.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class CircularGeofenceManagementCondition : LocationManagementCondition
    {
    
        /// <summary>
        /// Gets or sets latitude.
        /// Latitude in degrees, between -90 and +90 inclusive.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "latitude", Required = Newtonsoft.Json.Required.Default)]
        public double? Latitude { get; set; }
    
        /// <summary>
        /// Gets or sets longitude.
        /// Longitude in degrees, between -180 and +180 inclusive.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "longitude", Required = Newtonsoft.Json.Required.Default)]
        public double? Longitude { get; set; }
    
        /// <summary>
        /// Gets or sets radius in meters.
        /// Radius in meters.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "radiusInMeters", Required = Newtonsoft.Json.Required.Default)]
        public Single? RadiusInMeters { get; set; }
    
    }
}

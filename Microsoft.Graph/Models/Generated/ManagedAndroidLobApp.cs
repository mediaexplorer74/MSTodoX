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
    /// The type Managed Android Lob App.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ManagedAndroidLobApp : ManagedMobileLobApp
    {
    
        /// <summary>
        /// Gets or sets package id.
        /// The package identifier.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "packageId", Required = Newtonsoft.Json.Required.Default)]
        public string PackageId { get; set; }
    
        /// <summary>
        /// Gets or sets identity name.
        /// The Identity Name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityName", Required = Newtonsoft.Json.Required.Default)]
        public string IdentityName { get; set; }
    
        /// <summary>
        /// Gets or sets minimum supported operating system.
        /// The value for the minimum applicable operating system.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumSupportedOperatingSystem", Required = Newtonsoft.Json.Required.Default)]
        public AndroidMinimumOperatingSystem MinimumSupportedOperatingSystem { get; set; }
    
        /// <summary>
        /// Gets or sets version name.
        /// The version name of managed Android Line of Business (LoB) app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "versionName", Required = Newtonsoft.Json.Required.Default)]
        public string VersionName { get; set; }
    
        /// <summary>
        /// Gets or sets version code.
        /// The version code of managed Android Line of Business (LoB) app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "versionCode", Required = Newtonsoft.Json.Required.Default)]
        public string VersionCode { get; set; }
    
        /// <summary>
        /// Gets or sets identity version.
        /// The identity version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityVersion", Required = Newtonsoft.Json.Required.Default)]
        public string IdentityVersion { get; set; }
    
    }
}


// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type IosVppAppRevokeUserLicenseRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosVppAppRevokeUserLicenseRequestBody
    {
    
        /// <summary>
        /// Gets or sets UserId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets NotifyManagedDevices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notifyManagedDevices", Required = Newtonsoft.Json.Required.Default)]
        public bool NotifyManagedDevices { get; set; }
    
    }
}

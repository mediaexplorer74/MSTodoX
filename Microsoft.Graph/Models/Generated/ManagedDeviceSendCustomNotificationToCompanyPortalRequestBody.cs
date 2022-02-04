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
    /// The type ManagedDeviceSendCustomNotificationToCompanyPortalRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ManagedDeviceSendCustomNotificationToCompanyPortalRequestBody
    {
    
        /// <summary>
        /// Gets or sets NotificationTitle.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notificationTitle", Required = Newtonsoft.Json.Required.Default)]
        public string NotificationTitle { get; set; }
    
        /// <summary>
        /// Gets or sets NotificationBody.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notificationBody", Required = Newtonsoft.Json.Required.Default)]
        public string NotificationBody { get; set; }
    
    }
}

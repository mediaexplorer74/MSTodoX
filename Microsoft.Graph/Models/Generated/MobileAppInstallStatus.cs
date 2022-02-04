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
    /// The type Mobile App Install Status.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MobileAppInstallStatus : Entity
    {
    
        /// <summary>
        /// Gets or sets device name.
        /// Device name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceName", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets device id.
        /// Device ID
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceId", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets last sync date time.
        /// Last sync date time
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastSyncDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets mobile app install status value.
        /// The install state of the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobileAppInstallStatusValue", Required = Newtonsoft.Json.Required.Default)]
        public ResultantAppState? MobileAppInstallStatusValue { get; set; }
    
        /// <summary>
        /// Gets or sets install state.
        /// The install state of the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installState", Required = Newtonsoft.Json.Required.Default)]
        public ResultantAppState? InstallState { get; set; }
    
        /// <summary>
        /// Gets or sets install state detail.
        /// The install state detail of the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installStateDetail", Required = Newtonsoft.Json.Required.Default)]
        public ResultantAppStateDetail? InstallStateDetail { get; set; }
    
        /// <summary>
        /// Gets or sets error code.
        /// The error code for install or uninstall failures.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorCode", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ErrorCode { get; set; }
    
        /// <summary>
        /// Gets or sets os version.
        /// OS Version
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets os description.
        /// OS Description
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osDescription", Required = Newtonsoft.Json.Required.Default)]
        public string OsDescription { get; set; }
    
        /// <summary>
        /// Gets or sets user name.
        /// Device User Name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userName", Required = Newtonsoft.Json.Required.Default)]
        public string UserName { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// User Principal Name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets display version.
        /// Human readable version of the application
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayVersion", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayVersion { get; set; }
    
        /// <summary>
        /// Gets or sets app.
        /// The navigation link to the mobile app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "app", Required = Newtonsoft.Json.Required.Default)]
        public MobileApp App { get; set; }
    
    }
}

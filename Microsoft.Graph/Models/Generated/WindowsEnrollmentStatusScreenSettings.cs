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
    /// The type WindowsEnrollmentStatusScreenSettings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class WindowsEnrollmentStatusScreenSettings
    {

        /// <summary>
        /// Gets or sets hideInstallationProgress.
        /// Show or hide installation progress to user
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hideInstallationProgress", Required = Newtonsoft.Json.Required.Default)]
        public bool? HideInstallationProgress { get; set; }
    
        /// <summary>
        /// Gets or sets allowDeviceUseBeforeProfileAndAppInstallComplete.
        /// Allow or block user to use device before profile and app installation complete
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowDeviceUseBeforeProfileAndAppInstallComplete", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowDeviceUseBeforeProfileAndAppInstallComplete { get; set; }
    
        /// <summary>
        /// Gets or sets blockDeviceSetupRetryByUser.
        /// Allow the user to retry the setup on installation failure
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "blockDeviceSetupRetryByUser", Required = Newtonsoft.Json.Required.Default)]
        public bool? BlockDeviceSetupRetryByUser { get; set; }
    
        /// <summary>
        /// Gets or sets allowLogCollectionOnInstallFailure.
        /// Allow or block log collection on installation failure
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowLogCollectionOnInstallFailure", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowLogCollectionOnInstallFailure { get; set; }
    
        /// <summary>
        /// Gets or sets customErrorMessage.
        /// Set custom error message to show upon installation failure
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customErrorMessage", Required = Newtonsoft.Json.Required.Default)]
        public string CustomErrorMessage { get; set; }
    
        /// <summary>
        /// Gets or sets installProgressTimeoutInMinutes.
        /// Set installation progress timeout in minutes
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installProgressTimeoutInMinutes", Required = Newtonsoft.Json.Required.Default)]
        public Int32? InstallProgressTimeoutInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets allowDeviceUseOnInstallFailure.
        /// Allow the user to continue using the device on installation failure
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowDeviceUseOnInstallFailure", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowDeviceUseOnInstallFailure { get; set; }
    
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
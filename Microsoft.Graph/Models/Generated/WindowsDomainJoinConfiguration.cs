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
    /// The type Windows Domain Join Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsDomainJoinConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets computer name static prefix.
        /// Fixed prefix to be used for computer name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "computerNameStaticPrefix", Required = Newtonsoft.Json.Required.Default)]
        public string ComputerNameStaticPrefix { get; set; }
    
        /// <summary>
        /// Gets or sets computer name suffix random char count.
        /// Dynamically generated characters used as suffix for computer name. Valid values 3 to 14
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "computerNameSuffixRandomCharCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ComputerNameSuffixRandomCharCount { get; set; }
    
        /// <summary>
        /// Gets or sets active directory domain name.
        /// Active Directory domain name to join.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activeDirectoryDomainName", Required = Newtonsoft.Json.Required.Default)]
        public string ActiveDirectoryDomainName { get; set; }
    
        /// <summary>
        /// Gets or sets organizational unit.
        /// Organizational unit (OU) where the computer account will be created. If this parameter is NULL, the well known computer object container will be used as published in the domain.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizationalUnit", Required = Newtonsoft.Json.Required.Default)]
        public string OrganizationalUnit { get; set; }
    
        /// <summary>
        /// Gets or sets network access configurations.
        /// Reference to device configurations required for network connectivity
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkAccessConfigurations", Required = Newtonsoft.Json.Required.Default)]
        public IWindowsDomainJoinConfigurationNetworkAccessConfigurationsCollectionWithReferencesPage NetworkAccessConfigurations { get; set; }
    
    }
}


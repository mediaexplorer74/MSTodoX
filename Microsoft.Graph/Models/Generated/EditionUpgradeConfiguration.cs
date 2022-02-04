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
    /// The type Edition Upgrade Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EditionUpgradeConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets license type.
        /// Edition Upgrade License Type. Possible values are: productKey, licenseFile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "licenseType", Required = Newtonsoft.Json.Required.Default)]
        public EditionUpgradeLicenseType? LicenseType { get; set; }
    
        /// <summary>
        /// Gets or sets target edition.
        /// Edition Upgrade Target Edition. Possible values are: windows10Enterprise, windows10EnterpriseN, windows10Education, windows10EducationN, windows10MobileEnterprise, windows10HolographicEnterprise, windows10Professional, windows10ProfessionalN, windows10ProfessionalEducation, windows10ProfessionalEducationN, windows10ProfessionalWorkstation, windows10ProfessionalWorkstationN.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetEdition", Required = Newtonsoft.Json.Required.Default)]
        public Windows10EditionType? TargetEdition { get; set; }
    
        /// <summary>
        /// Gets or sets license.
        /// Edition Upgrade License File Content.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "license", Required = Newtonsoft.Json.Required.Default)]
        public string License { get; set; }
    
        /// <summary>
        /// Gets or sets product key.
        /// Edition Upgrade Product Key.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "productKey", Required = Newtonsoft.Json.Required.Default)]
        public string ProductKey { get; set; }
    
        /// <summary>
        /// Gets or sets windows smode.
        /// S mode configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsSMode", Required = Newtonsoft.Json.Required.Default)]
        public WindowsSModeConfiguration? WindowsSMode { get; set; }
    
    }
}


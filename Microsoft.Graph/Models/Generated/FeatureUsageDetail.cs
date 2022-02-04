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
    /// The type FeatureUsageDetail.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class FeatureUsageDetail
    {

        /// <summary>
        /// Gets or sets featureName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "featureName", Required = Newtonsoft.Json.Required.Default)]
        public string FeatureName { get; set; }
    
        /// <summary>
        /// Gets or sets licenseRequired.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "licenseRequired", Required = Newtonsoft.Json.Required.Default)]
        public AzureADLicenseType? LicenseRequired { get; set; }
    
        /// <summary>
        /// Gets or sets licenseAssigned.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "licenseAssigned", Required = Newtonsoft.Json.Required.Default)]
        public AzureADLicenseType? LicenseAssigned { get; set; }
    
        /// <summary>
        /// Gets or sets lastUsedDateTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastUsedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastUsedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets lastConfiguredDateTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastConfiguredDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastConfiguredDateTime { get; set; }
    
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

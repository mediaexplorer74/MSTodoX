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
    /// The type WebApplication.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class WebApplication
    {

        /// <summary>
        /// Gets or sets homePageUrl.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "homePageUrl", Required = Newtonsoft.Json.Required.Default)]
        public string HomePageUrl { get; set; }
    
        /// <summary>
        /// Gets or sets redirectUris.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "redirectUris", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RedirectUris { get; set; }
    
        /// <summary>
        /// Gets or sets oauth2AllowImplicitFlow.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "oauth2AllowImplicitFlow", Required = Newtonsoft.Json.Required.Default)]
        public bool? Oauth2AllowImplicitFlow { get; set; }
    
        /// <summary>
        /// Gets or sets logoutUrl.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "logoutUrl", Required = Newtonsoft.Json.Required.Default)]
        public string LogoutUrl { get; set; }
    
        /// <summary>
        /// Gets or sets implicitGrantSettings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "implicitGrantSettings", Required = Newtonsoft.Json.Required.Default)]
        public ImplicitGrantSettings ImplicitGrantSettings { get; set; }
    
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

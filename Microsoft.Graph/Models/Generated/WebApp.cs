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
    /// The type Web App.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WebApp : MobileApp
    {
    
        /// <summary>
        /// Gets or sets app url.
        /// The web app URL.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appUrl", Required = Newtonsoft.Json.Required.Default)]
        public string AppUrl { get; set; }
    
        /// <summary>
        /// Gets or sets use managed browser.
        /// Whether or not to use managed browser. This property is only applicable for Android and IOS.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "useManagedBrowser", Required = Newtonsoft.Json.Required.Default)]
        public bool? UseManagedBrowser { get; set; }
    
    }
}


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
    /// The type WorkbookFunctionsDollarFrRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsDollarFrRequestBody
    {
    
        /// <summary>
        /// Gets or sets DecimalDollar.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "decimalDollar", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken DecimalDollar { get; set; }
    
        /// <summary>
        /// Gets or sets Fraction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fraction", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Fraction { get; set; }
    
    }
}

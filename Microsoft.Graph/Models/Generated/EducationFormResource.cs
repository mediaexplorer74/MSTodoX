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
    /// The type EducationFormResource.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EducationFormResource : EducationResource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EducationFormResource"/> class.
        /// </summary>
        public EducationFormResource()
        {
            this.ODataType = "microsoft.graph.educationFormResource";
        }

        /// <summary>
        /// Gets or sets originalFormId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "originalFormId", Required = Newtonsoft.Json.Required.Default)]
        public string OriginalFormId { get; set; }
    
        /// <summary>
        /// Gets or sets formId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "formId", Required = Newtonsoft.Json.Required.Default)]
        public string FormId { get; set; }
    
        /// <summary>
        /// Gets or sets isGroupForm.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isGroupForm", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsGroupForm { get; set; }
    
        /// <summary>
        /// Gets or sets viewUrl.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "viewUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ViewUrl { get; set; }
    
        /// <summary>
        /// Gets or sets editUrl.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "editUrl", Required = Newtonsoft.Json.Required.Default)]
        public string EditUrl { get; set; }
    
    }
}

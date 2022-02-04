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
    /// The type Workbook Chart Gridlines.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookChartGridlines : Entity
    {
    
        /// <summary>
        /// Gets or sets visible.
        /// Boolean value representing if the axis gridlines are visible or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "visible", Required = Newtonsoft.Json.Required.Default)]
        public bool? Visible { get; set; }
    
        /// <summary>
        /// Gets or sets format.
        /// Represents the formatting of chart gridlines. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "format", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookChartGridlinesFormat Format { get; set; }
    
    }
}


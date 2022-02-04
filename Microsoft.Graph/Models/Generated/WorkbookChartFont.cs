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
    /// The type Workbook Chart Font.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookChartFont : Entity
    {
    
        /// <summary>
        /// Gets or sets bold.
        /// Represents the bold status of font.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bold", Required = Newtonsoft.Json.Required.Default)]
        public bool? Bold { get; set; }
    
        /// <summary>
        /// Gets or sets color.
        /// HTML color code representation of the text color. E.g. #FF0000 represents Red.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "color", Required = Newtonsoft.Json.Required.Default)]
        public string Color { get; set; }
    
        /// <summary>
        /// Gets or sets italic.
        /// Represents the italic status of the font.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "italic", Required = Newtonsoft.Json.Required.Default)]
        public bool? Italic { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// Font name (e.g. 'Calibri')
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets size.
        /// Size of the font (e.g. 11)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "size", Required = Newtonsoft.Json.Required.Default)]
        public double? Size { get; set; }
    
        /// <summary>
        /// Gets or sets underline.
        /// Type of underline applied to the font. The possible values are: None, Single.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "underline", Required = Newtonsoft.Json.Required.Default)]
        public string Underline { get; set; }
    
    }
}


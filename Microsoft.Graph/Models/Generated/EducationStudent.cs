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
    /// The type EducationStudent.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class EducationStudent
    {

        /// <summary>
        /// Gets or sets graduationYear.
        /// Year the student is graduating from the school.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "graduationYear", Required = Newtonsoft.Json.Required.Default)]
        public string GraduationYear { get; set; }
    
        /// <summary>
        /// Gets or sets grade.
        /// Current grade level of the student.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "grade", Required = Newtonsoft.Json.Required.Default)]
        public string Grade { get; set; }
    
        /// <summary>
        /// Gets or sets birthDate.
        /// Birth date of the student.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "birthDate", Required = Newtonsoft.Json.Required.Default)]
        public Date BirthDate { get; set; }
    
        /// <summary>
        /// Gets or sets gender.
        /// The possible values are: female, male, other, unknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gender", Required = Newtonsoft.Json.Required.Default)]
        public EducationGender? Gender { get; set; }
    
        /// <summary>
        /// Gets or sets studentNumber.
        /// Student Number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "studentNumber", Required = Newtonsoft.Json.Required.Default)]
        public string StudentNumber { get; set; }
    
        /// <summary>
        /// Gets or sets externalId.
        /// ID of the student in the source system.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "externalId", Required = Newtonsoft.Json.Required.Default)]
        public string ExternalId { get; set; }
    
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

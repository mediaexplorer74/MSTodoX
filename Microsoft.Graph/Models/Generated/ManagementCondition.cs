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
    /// The type Management Condition.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ManagementCondition : Entity
    {
    
		///<summary>
		/// The internal ManagementCondition constructor
		///</summary>
        protected internal ManagementCondition()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets unique name.
        /// Unique name for the management condition. Used in management condition expressions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "uniqueName", Required = Newtonsoft.Json.Required.Default)]
        public string UniqueName { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The admin defined name of the management condition.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The admin defined description of the management condition.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The time the management condition was created. Generated service side.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets modified date time.
        /// The time the management condition was last modified. Updated service side.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "modifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets e tag.
        /// ETag of the management condition. Updated service side.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "eTag", Required = Newtonsoft.Json.Required.Default)]
        public string ETag { get; set; }
    
        /// <summary>
        /// Gets or sets applicable platforms.
        /// The applicable platforms for this management condition.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicablePlatforms", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DevicePlatformType> ApplicablePlatforms { get; set; }
    
        /// <summary>
        /// Gets or sets management condition statements.
        /// The management condition statements associated to the management condition.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managementConditionStatements", Required = Newtonsoft.Json.Required.Default)]
        public IManagementConditionManagementConditionStatementsCollectionWithReferencesPage ManagementConditionStatements { get; set; }
    
    }
}


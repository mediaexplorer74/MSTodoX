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
    /// The type List.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class List : BaseItem
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// The displayable title of the list.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets list.
        /// Provides additional details about the list.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "list", Required = Newtonsoft.Json.Required.Default)]
        public ListInfo ListInfo { get; set; }
    
        /// <summary>
        /// Gets or sets sharepoint ids.
        /// Returns identifiers useful for SharePoint REST compatibility. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharepointIds", Required = Newtonsoft.Json.Required.Default)]
        public SharepointIds SharepointIds { get; set; }
    
        /// <summary>
        /// Gets or sets system.
        /// If present, indicates that this is a system-managed list. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "system", Required = Newtonsoft.Json.Required.Default)]
        public SystemFacet System { get; set; }
    
        /// <summary>
        /// Gets or sets activities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activities", Required = Newtonsoft.Json.Required.Default)]
        public IListActivitiesCollectionPage Activities { get; set; }
    
        /// <summary>
        /// Gets or sets columns.
        /// The collection of field definitions for this list.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "columns", Required = Newtonsoft.Json.Required.Default)]
        public IListColumnsCollectionPage Columns { get; set; }
    
        /// <summary>
        /// Gets or sets content types.
        /// The collection of content types present in this list.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentTypes", Required = Newtonsoft.Json.Required.Default)]
        public IListContentTypesCollectionPage ContentTypes { get; set; }
    
        /// <summary>
        /// Gets or sets drive.
        /// Only present on document libraries. Allows access to the list as a [drive][] resource with [driveItems][driveItem].
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "drive", Required = Newtonsoft.Json.Required.Default)]
        public Drive Drive { get; set; }
    
        /// <summary>
        /// Gets or sets items.
        /// All items contained in the list.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "items", Required = Newtonsoft.Json.Required.Default)]
        public IListItemsCollectionPage Items { get; set; }
    
        /// <summary>
        /// Gets or sets subscriptions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscriptions", Required = Newtonsoft.Json.Required.Default)]
        public IListSubscriptionsCollectionPage Subscriptions { get; set; }
    
    }
}


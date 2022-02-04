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
    /// The type Device Compliance Action Item.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceComplianceActionItem : Entity
    {
    
        /// <summary>
        /// Gets or sets grace period hours.
        /// Number of hours to wait till the action will be enforced. Valid values 0 to 8760
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gracePeriodHours", Required = Newtonsoft.Json.Required.Default)]
        public Int32? GracePeriodHours { get; set; }
    
        /// <summary>
        /// Gets or sets action type.
        /// What action to take. Possible values are: noAction, notification, block, retire, wipe, removeResourceAccessProfiles, pushNotification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actionType", Required = Newtonsoft.Json.Required.Default)]
        public DeviceComplianceActionType? ActionType { get; set; }
    
        /// <summary>
        /// Gets or sets notification template id.
        /// What notification Message template to use
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notificationTemplateId", Required = Newtonsoft.Json.Required.Default)]
        public string NotificationTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets notification message cclist.
        /// A list of group IDs to speicify who to CC this notification message to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notificationMessageCCList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> NotificationMessageCCList { get; set; }
    
    }
}


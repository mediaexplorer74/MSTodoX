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
    /// The type Call.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Call : Entity
    {
    
        /// <summary>
        /// Gets or sets state.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public CallState? State { get; set; }
    
        /// <summary>
        /// Gets or sets media state.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mediaState", Required = Newtonsoft.Json.Required.Default)]
        public CallMediaState MediaState { get; set; }
    
        /// <summary>
        /// Gets or sets result info.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resultInfo", Required = Newtonsoft.Json.Required.Default)]
        public ResultInfo ResultInfo { get; set; }
    
        /// <summary>
        /// Gets or sets termination reason.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "terminationReason", Required = Newtonsoft.Json.Required.Default)]
        public string TerminationReason { get; set; }
    
        /// <summary>
        /// Gets or sets direction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "direction", Required = Newtonsoft.Json.Required.Default)]
        public CallDirection? Direction { get; set; }
    
        /// <summary>
        /// Gets or sets ringing timeout in seconds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ringingTimeoutInSeconds", Required = Newtonsoft.Json.Required.Default)]
        public Int32? RingingTimeoutInSeconds { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subject", Required = Newtonsoft.Json.Required.Default)]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets callback uri.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "callbackUri", Required = Newtonsoft.Json.Required.Default)]
        public string CallbackUri { get; set; }
    
        /// <summary>
        /// Gets or sets call routes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "callRoutes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<CallRoute> CallRoutes { get; set; }
    
        /// <summary>
        /// Gets or sets source.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "source", Required = Newtonsoft.Json.Required.Default)]
        public ParticipantInfo Source { get; set; }
    
        /// <summary>
        /// Gets or sets targets.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targets", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ParticipantInfo> Targets { get; set; }
    
        /// <summary>
        /// Gets or sets answered by.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "answeredBy", Required = Newtonsoft.Json.Required.Default)]
        public ParticipantInfo AnsweredBy { get; set; }
    
        /// <summary>
        /// Gets or sets requested modalities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requestedModalities", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Modality> RequestedModalities { get; set; }
    
        /// <summary>
        /// Gets or sets active modalities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activeModalities", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Modality> ActiveModalities { get; set; }
    
        /// <summary>
        /// Gets or sets media config.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mediaConfig", Required = Newtonsoft.Json.Required.Default)]
        public MediaConfig MediaConfig { get; set; }
    
        /// <summary>
        /// Gets or sets chat info.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "chatInfo", Required = Newtonsoft.Json.Required.Default)]
        public ChatInfo ChatInfo { get; set; }
    
        /// <summary>
        /// Gets or sets meeting info.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "meetingInfo", Required = Newtonsoft.Json.Required.Default)]
        public MeetingInfo MeetingInfo { get; set; }
    
        /// <summary>
        /// Gets or sets meeting capability.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "meetingCapability", Required = Newtonsoft.Json.Required.Default)]
        public MeetingCapability MeetingCapability { get; set; }
    
        /// <summary>
        /// Gets or sets routing policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "routingPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<RoutingPolicy> RoutingPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets tenant id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tenantId", Required = Newtonsoft.Json.Required.Default)]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets my participant id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "myParticipantId", Required = Newtonsoft.Json.Required.Default)]
        public string MyParticipantId { get; set; }
    
        /// <summary>
        /// Gets or sets tone info.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "toneInfo", Required = Newtonsoft.Json.Required.Default)]
        public ToneInfo ToneInfo { get; set; }
    
        /// <summary>
        /// Gets or sets participants.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "participants", Required = Newtonsoft.Json.Required.Default)]
        public ICallParticipantsCollectionPage Participants { get; set; }
    
        /// <summary>
        /// Gets or sets audio routing groups.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "audioRoutingGroups", Required = Newtonsoft.Json.Required.Default)]
        public ICallAudioRoutingGroupsCollectionPage AudioRoutingGroups { get; set; }
    
        /// <summary>
        /// Gets or sets operations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operations", Required = Newtonsoft.Json.Required.Default)]
        public ICallOperationsCollectionPage Operations { get; set; }
    
    }
}


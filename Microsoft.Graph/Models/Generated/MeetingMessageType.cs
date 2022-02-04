// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum MeetingMessageType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum MeetingMessageType
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Meeting Request
        /// </summary>
        MeetingRequest = 1,
	
        /// <summary>
        /// Meeting Cancelled
        /// </summary>
        MeetingCancelled = 2,
	
        /// <summary>
        /// Meeting Accepted
        /// </summary>
        MeetingAccepted = 3,
	
        /// <summary>
        /// Meeting Tentatively Accepted
        /// </summary>
        MeetingTentativelyAccepted = 4,
	
        /// <summary>
        /// Meeting Declined
        /// </summary>
        MeetingDeclined = 5,
	
    }
}

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
    /// The type Apple Push Notification Certificate.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ApplePushNotificationCertificate : Entity
    {
    
        /// <summary>
        /// Gets or sets apple identifier.
        /// Apple Id of the account used to create the MDM push certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appleIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string AppleIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets topic identifier.
        /// Topic Id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "topicIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string TopicIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Last modified date and time for Apple push notification certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// The expiration date and time for Apple push notification certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets certificate upload status.
        /// The certificate upload status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateUploadStatus", Required = Newtonsoft.Json.Required.Default)]
        public string CertificateUploadStatus { get; set; }
    
        /// <summary>
        /// Gets or sets certificate upload failure reason.
        /// The reason the certificate upload failed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateUploadFailureReason", Required = Newtonsoft.Json.Required.Default)]
        public string CertificateUploadFailureReason { get; set; }
    
        /// <summary>
        /// Gets or sets certificate.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificate", Required = Newtonsoft.Json.Required.Default)]
        public string Certificate { get; set; }
    
    }
}


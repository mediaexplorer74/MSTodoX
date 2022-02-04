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
    /// The type Windows Identity Protection Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsIdentityProtectionConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets use security key for signin.
        /// Boolean value used to enable the Windows Hello security key as a logon credential.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "useSecurityKeyForSignin", Required = Newtonsoft.Json.Required.Default)]
        public bool? UseSecurityKeyForSignin { get; set; }
    
        /// <summary>
        /// Gets or sets enhanced anti spoofing for facial features enabled.
        /// Boolean value used to enable enhanced anti-spoofing for facial feature recognition on Windows Hello face authentication.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enhancedAntiSpoofingForFacialFeaturesEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnhancedAntiSpoofingForFacialFeaturesEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets pin minimum length.
        /// Integer value that sets the minimum number of characters required for the Windows Hello for Business PIN. Valid values are 4 to 127 inclusive and less than or equal to the value set for the maximum PIN. Valid values 4 to 127
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PinMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets pin maximum length.
        /// Integer value that sets the maximum number of characters allowed for the work PIN. Valid values are 4 to 127 inclusive and greater than or equal to the value set for the minimum PIN. Valid values 4 to 127
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinMaximumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PinMaximumLength { get; set; }
    
        /// <summary>
        /// Gets or sets pin uppercase characters usage.
        /// This value configures the use of uppercase characters in the Windows Hello for Business PIN.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinUppercaseCharactersUsage", Required = Newtonsoft.Json.Required.Default)]
        public ConfigurationUsage? PinUppercaseCharactersUsage { get; set; }
    
        /// <summary>
        /// Gets or sets pin lowercase characters usage.
        /// This value configures the use of lowercase characters in the Windows Hello for Business PIN.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinLowercaseCharactersUsage", Required = Newtonsoft.Json.Required.Default)]
        public ConfigurationUsage? PinLowercaseCharactersUsage { get; set; }
    
        /// <summary>
        /// Gets or sets pin special characters usage.
        /// Controls the ability to use special characters in the Windows Hello for Business PIN.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinSpecialCharactersUsage", Required = Newtonsoft.Json.Required.Default)]
        public ConfigurationUsage? PinSpecialCharactersUsage { get; set; }
    
        /// <summary>
        /// Gets or sets pin expiration in days.
        /// Integer value specifies the period (in days) that a PIN can be used before the system requires the user to change it. Valid values are 0 to 730 inclusive. Valid values 0 to 730
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinExpirationInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PinExpirationInDays { get; set; }
    
        /// <summary>
        /// Gets or sets pin previous block count.
        /// Controls the ability to prevent users from using past PINs. This must be set between 0 and 50, inclusive, and the current PIN of the user is included in that count. If set to 0, previous PINs are not stored. PIN history is not preserved through a PIN reset. Valid values 0 to 50
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinPreviousBlockCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PinPreviousBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets pin recovery enabled.
        /// Boolean value that enables a user to change their PIN by using the Windows Hello for Business PIN recovery service.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinRecoveryEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? PinRecoveryEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets security device required.
        /// Controls whether to require a Trusted Platform Module (TPM) for provisioning Windows Hello for Business. A TPM provides an additional security benefit in that data stored on it cannot be used on other devices. If set to False, all devices can provision Windows Hello for Business even if there is not a usable TPM.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityDeviceRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityDeviceRequired { get; set; }
    
        /// <summary>
        /// Gets or sets unlock with biometrics enabled.
        /// Controls the use of biometric gestures, such as face and fingerprint, as an alternative to the Windows Hello for Business PIN.  If set to False, biometric gestures are not allowed. Users must still configure a PIN as a backup in case of failures.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unlockWithBiometricsEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? UnlockWithBiometricsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets use certificates for on premises auth enabled.
        /// Boolean value that enables Windows Hello for Business to use certificates to authenticate on-premise resources.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "useCertificatesForOnPremisesAuthEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? UseCertificatesForOnPremisesAuthEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets windows hello for business blocked.
        /// Boolean value that blocks Windows Hello for Business as a method for signing into Windows.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsHelloForBusinessBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? WindowsHelloForBusinessBlocked { get; set; }
    
    }
}


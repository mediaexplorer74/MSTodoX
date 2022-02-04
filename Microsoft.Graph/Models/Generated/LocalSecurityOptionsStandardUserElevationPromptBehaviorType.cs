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
    /// The enum LocalSecurityOptionsStandardUserElevationPromptBehaviorType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum LocalSecurityOptionsStandardUserElevationPromptBehaviorType
    {
    
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// Automatically Deny Elevation Requests
        /// </summary>
        AutomaticallyDenyElevationRequests = 1,
	
        /// <summary>
        /// Prompt For Credentials On The Secure Desktop
        /// </summary>
        PromptForCredentialsOnTheSecureDesktop = 2,
	
        /// <summary>
        /// Prompt For Credentials
        /// </summary>
        PromptForCredentials = 3,
	
    }
}

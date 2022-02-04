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
    /// The enum MobileAppIntent.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum MobileAppIntent
    {
    
        /// <summary>
        /// Available
        /// </summary>
        Available = 0,
	
        /// <summary>
        /// Not Available
        /// </summary>
        NotAvailable = 1,
	
        /// <summary>
        /// Required Install
        /// </summary>
        RequiredInstall = 2,
	
        /// <summary>
        /// Required Uninstall
        /// </summary>
        RequiredUninstall = 3,
	
        /// <summary>
        /// Required And Available Install
        /// </summary>
        RequiredAndAvailableInstall = 4,
	
        /// <summary>
        /// Available Install Without Enrollment
        /// </summary>
        AvailableInstallWithoutEnrollment = 5,
	
        /// <summary>
        /// Exclude
        /// </summary>
        Exclude = 6,
	
    }
}

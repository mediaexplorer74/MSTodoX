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
    /// The enum DomainNameSource.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DomainNameSource
    {
    
        /// <summary>
        /// Full Domain Name
        /// </summary>
        FullDomainName = 0,
	
        /// <summary>
        /// Net Bios Domain Name
        /// </summary>
        NetBiosDomainName = 1,
	
    }
}

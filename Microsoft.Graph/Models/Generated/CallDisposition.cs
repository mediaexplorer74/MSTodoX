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
    /// The enum CallDisposition.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum CallDisposition
    {
    
        /// <summary>
        /// Default
        /// </summary>
        Default = 0,
	
        /// <summary>
        /// Simultaneous Ring
        /// </summary>
        SimultaneousRing = 1,
	
        /// <summary>
        /// Forward
        /// </summary>
        Forward = 2,
	
    }
}

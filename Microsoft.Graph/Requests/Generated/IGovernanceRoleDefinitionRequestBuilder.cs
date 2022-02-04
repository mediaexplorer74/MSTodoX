// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IGovernanceRoleDefinitionRequestBuilder.
    /// </summary>
    public partial interface IGovernanceRoleDefinitionRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IGovernanceRoleDefinitionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IGovernanceRoleDefinitionRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Resource.
        /// </summary>
        /// <returns>The <see cref="IGovernanceResourceRequestBuilder"/>.</returns>
        IGovernanceResourceRequestBuilder Resource { get; }

        /// <summary>
        /// Gets the request builder for RoleSetting.
        /// </summary>
        /// <returns>The <see cref="IGovernanceRoleSettingRequestBuilder"/>.</returns>
        IGovernanceRoleSettingRequestBuilder RoleSetting { get; }
    
    }
}

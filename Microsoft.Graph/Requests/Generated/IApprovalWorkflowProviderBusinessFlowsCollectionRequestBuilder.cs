// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IApprovalWorkflowProviderBusinessFlowsCollectionRequestBuilder.
    /// </summary>
    public partial interface IApprovalWorkflowProviderBusinessFlowsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IApprovalWorkflowProviderBusinessFlowsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IApprovalWorkflowProviderBusinessFlowsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IBusinessFlowRequestBuilder"/> for the specified BusinessFlow.
        /// </summary>
        /// <param name="id">The ID for the BusinessFlow.</param>
        /// <returns>The <see cref="IBusinessFlowRequestBuilder"/>.</returns>
        IBusinessFlowRequestBuilder this[string id] { get; }

        
    }
}

// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ApprovalWorkflowProviderRequestsAwaitingMyDecisionCollectionRequestBuilder.
    /// </summary>
    public partial class ApprovalWorkflowProviderRequestsAwaitingMyDecisionCollectionRequestBuilder : BaseRequestBuilder, IApprovalWorkflowProviderRequestsAwaitingMyDecisionCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ApprovalWorkflowProviderRequestsAwaitingMyDecisionCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ApprovalWorkflowProviderRequestsAwaitingMyDecisionCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IApprovalWorkflowProviderRequestsAwaitingMyDecisionCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IApprovalWorkflowProviderRequestsAwaitingMyDecisionCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ApprovalWorkflowProviderRequestsAwaitingMyDecisionCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IRequestRequestBuilder"/> for the specified ApprovalWorkflowProviderRequest.
        /// </summary>
        /// <param name="id">The ID for the ApprovalWorkflowProviderRequest.</param>
        /// <returns>The <see cref="IRequestRequestBuilder"/>.</returns>
        public IRequestRequestBuilder this[string id]
        {
            get
            {
                return new RequestRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}

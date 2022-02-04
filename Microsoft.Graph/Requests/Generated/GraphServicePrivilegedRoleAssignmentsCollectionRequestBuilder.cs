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
    /// The type GraphServicePrivilegedRoleAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServicePrivilegedRoleAssignmentsCollectionRequestBuilder : BaseRequestBuilder, IGraphServicePrivilegedRoleAssignmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServicePrivilegedRoleAssignmentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServicePrivilegedRoleAssignmentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServicePrivilegedRoleAssignmentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServicePrivilegedRoleAssignmentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServicePrivilegedRoleAssignmentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IPrivilegedRoleAssignmentRequestBuilder"/> for the specified GraphServicePrivilegedRoleAssignment.
        /// </summary>
        /// <param name="id">The ID for the GraphServicePrivilegedRoleAssignment.</param>
        /// <returns>The <see cref="IPrivilegedRoleAssignmentRequestBuilder"/>.</returns>
        public IPrivilegedRoleAssignmentRequestBuilder this[string id]
        {
            get
            {
                return new PrivilegedRoleAssignmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for PrivilegedRoleAssignmentMy.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedRoleAssignmentMyRequestBuilder"/>.</returns>
        public IPrivilegedRoleAssignmentMyRequestBuilder My()
        {
            return new PrivilegedRoleAssignmentMyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.my"),
                this.Client);
        }
    }
}

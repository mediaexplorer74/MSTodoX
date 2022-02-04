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
    /// The type PlannerUserRecentPlansCollectionRequestBuilder.
    /// </summary>
    public partial class PlannerUserRecentPlansCollectionRequestBuilder : BaseRequestBuilder, IPlannerUserRecentPlansCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new PlannerUserRecentPlansCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PlannerUserRecentPlansCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPlannerUserRecentPlansCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPlannerUserRecentPlansCollectionRequest Request(IEnumerable<Option> options)
        {
            return new PlannerUserRecentPlansCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IPlannerPlanRequestBuilder"/> for the specified PlannerUserPlannerPlan.
        /// </summary>
        /// <param name="id">The ID for the PlannerUserPlannerPlan.</param>
        /// <returns>The <see cref="IPlannerPlanRequestBuilder"/>.</returns>
        public IPlannerPlanRequestBuilder this[string id]
        {
            get
            {
                return new PlannerPlanRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}

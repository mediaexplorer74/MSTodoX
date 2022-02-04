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
    /// The type SecurityBaselineTemplateCategoryDeviceStateSummariesCollectionRequestBuilder.
    /// </summary>
    public partial class SecurityBaselineTemplateCategoryDeviceStateSummariesCollectionRequestBuilder : BaseRequestBuilder, ISecurityBaselineTemplateCategoryDeviceStateSummariesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new SecurityBaselineTemplateCategoryDeviceStateSummariesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SecurityBaselineTemplateCategoryDeviceStateSummariesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ISecurityBaselineTemplateCategoryDeviceStateSummariesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ISecurityBaselineTemplateCategoryDeviceStateSummariesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new SecurityBaselineTemplateCategoryDeviceStateSummariesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISecurityBaselineCategoryStateSummaryRequestBuilder"/> for the specified SecurityBaselineTemplateSecurityBaselineCategoryStateSummary.
        /// </summary>
        /// <param name="id">The ID for the SecurityBaselineTemplateSecurityBaselineCategoryStateSummary.</param>
        /// <returns>The <see cref="ISecurityBaselineCategoryStateSummaryRequestBuilder"/>.</returns>
        public ISecurityBaselineCategoryStateSummaryRequestBuilder this[string id]
        {
            get
            {
                return new SecurityBaselineCategoryStateSummaryRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}

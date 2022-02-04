// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type OutlookTaskRequestBuilder.
    /// </summary>
    public partial class OutlookTaskRequestBuilder : OutlookItemRequestBuilder, IOutlookTaskRequestBuilder
    {

        /// <summary>
        /// Constructs a new OutlookTaskRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OutlookTaskRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IOutlookTaskRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IOutlookTaskRequest Request(IEnumerable<Option> options)
        {
            return new OutlookTaskRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for SingleValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IOutlookTaskSingleValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        public IOutlookTaskSingleValueExtendedPropertiesCollectionRequestBuilder SingleValueExtendedProperties
        {
            get
            {
                return new OutlookTaskSingleValueExtendedPropertiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("singleValueExtendedProperties"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MultiValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IOutlookTaskMultiValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        public IOutlookTaskMultiValueExtendedPropertiesCollectionRequestBuilder MultiValueExtendedProperties
        {
            get
            {
                return new OutlookTaskMultiValueExtendedPropertiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("multiValueExtendedProperties"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Attachments.
        /// </summary>
        /// <returns>The <see cref="IOutlookTaskAttachmentsCollectionRequestBuilder"/>.</returns>
        public IOutlookTaskAttachmentsCollectionRequestBuilder Attachments
        {
            get
            {
                return new OutlookTaskAttachmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("attachments"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for OutlookTaskComplete.
        /// </summary>
        /// <returns>The <see cref="IOutlookTaskCompleteRequestBuilder"/>.</returns>
        public IOutlookTaskCompleteRequestBuilder Complete()
        {
            return new OutlookTaskCompleteRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.complete"),
                this.Client);
        }
    
    }
}

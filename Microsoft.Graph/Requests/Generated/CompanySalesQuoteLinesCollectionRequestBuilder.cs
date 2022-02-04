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
    /// The type CompanySalesQuoteLinesCollectionRequestBuilder.
    /// </summary>
    public partial class CompanySalesQuoteLinesCollectionRequestBuilder : BaseRequestBuilder, ICompanySalesQuoteLinesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CompanySalesQuoteLinesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CompanySalesQuoteLinesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICompanySalesQuoteLinesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICompanySalesQuoteLinesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new CompanySalesQuoteLinesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISalesQuoteLineRequestBuilder"/> for the specified CompanySalesQuoteLine.
        /// </summary>
        /// <param name="id">The ID for the CompanySalesQuoteLine.</param>
        /// <returns>The <see cref="ISalesQuoteLineRequestBuilder"/>.</returns>
        public ISalesQuoteLineRequestBuilder this[string id]
        {
            get
            {
                return new SalesQuoteLineRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}

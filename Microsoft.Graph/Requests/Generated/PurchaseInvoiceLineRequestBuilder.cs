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
    /// The type PurchaseInvoiceLineRequestBuilder.
    /// </summary>
    public partial class PurchaseInvoiceLineRequestBuilder : EntityRequestBuilder, IPurchaseInvoiceLineRequestBuilder
    {

        /// <summary>
        /// Constructs a new PurchaseInvoiceLineRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PurchaseInvoiceLineRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IPurchaseInvoiceLineRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IPurchaseInvoiceLineRequest Request(IEnumerable<Option> options)
        {
            return new PurchaseInvoiceLineRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Item.
        /// </summary>
        /// <returns>The <see cref="IItemRequestBuilder"/>.</returns>
        public IItemRequestBuilder Item
        {
            get
            {
                return new ItemRequestBuilder(this.AppendSegmentToRequestUrl("item"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Account.
        /// </summary>
        /// <returns>The <see cref="IAccountRequestBuilder"/>.</returns>
        public IAccountRequestBuilder Account
        {
            get
            {
                return new AccountRequestBuilder(this.AppendSegmentToRequestUrl("account"), this.Client);
            }
        }
    
    }
}

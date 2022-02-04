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
    /// The interface ICompanyCustomerPaymentsCollectionRequestBuilder.
    /// </summary>
    public partial interface ICompanyCustomerPaymentsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        ICompanyCustomerPaymentsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ICompanyCustomerPaymentsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="ICustomerPaymentRequestBuilder"/> for the specified CustomerPayment.
        /// </summary>
        /// <param name="id">The ID for the CustomerPayment.</param>
        /// <returns>The <see cref="ICustomerPaymentRequestBuilder"/>.</returns>
        ICustomerPaymentRequestBuilder this[string id] { get; }

        
    }
}

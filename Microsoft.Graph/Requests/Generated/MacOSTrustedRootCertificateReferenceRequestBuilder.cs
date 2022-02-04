// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type MacOSTrustedRootCertificateReferenceRequestBuilder.
    /// </summary>
    public partial class MacOSTrustedRootCertificateReferenceRequestBuilder : BaseRequestBuilder, IMacOSTrustedRootCertificateReferenceRequestBuilder
    {
        /// <summary>
        /// Constructs a new MacOSTrustedRootCertificateReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public MacOSTrustedRootCertificateReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IMacOSTrustedRootCertificateReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IMacOSTrustedRootCertificateReferenceRequest Request(IEnumerable<Option> options)
        {
            return new MacOSTrustedRootCertificateReferenceRequest(this.RequestUrl, this.Client, options);
        }
    }
}

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
    /// The type OrganizationExtensionsCollectionRequestBuilder.
    /// </summary>
    public partial class OrganizationExtensionsCollectionRequestBuilder : BaseRequestBuilder, IOrganizationExtensionsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new OrganizationExtensionsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OrganizationExtensionsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IOrganizationExtensionsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IOrganizationExtensionsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new OrganizationExtensionsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IExtensionRequestBuilder"/> for the specified OrganizationExtension.
        /// </summary>
        /// <param name="id">The ID for the OrganizationExtension.</param>
        /// <returns>The <see cref="IExtensionRequestBuilder"/>.</returns>
        public IExtensionRequestBuilder this[string id]
        {
            get
            {
                return new ExtensionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}

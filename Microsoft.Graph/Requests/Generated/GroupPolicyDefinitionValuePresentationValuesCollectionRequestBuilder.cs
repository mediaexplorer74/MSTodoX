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
    /// The type GroupPolicyDefinitionValuePresentationValuesCollectionRequestBuilder.
    /// </summary>
    public partial class GroupPolicyDefinitionValuePresentationValuesCollectionRequestBuilder : BaseRequestBuilder, IGroupPolicyDefinitionValuePresentationValuesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GroupPolicyDefinitionValuePresentationValuesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GroupPolicyDefinitionValuePresentationValuesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGroupPolicyDefinitionValuePresentationValuesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGroupPolicyDefinitionValuePresentationValuesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GroupPolicyDefinitionValuePresentationValuesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IGroupPolicyPresentationValueRequestBuilder"/> for the specified GroupPolicyDefinitionValueGroupPolicyPresentationValue.
        /// </summary>
        /// <param name="id">The ID for the GroupPolicyDefinitionValueGroupPolicyPresentationValue.</param>
        /// <returns>The <see cref="IGroupPolicyPresentationValueRequestBuilder"/>.</returns>
        public IGroupPolicyPresentationValueRequestBuilder this[string id]
        {
            get
            {
                return new GroupPolicyPresentationValueRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}

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
    /// The type GraphServiceDirectoriesCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceDirectoriesCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceDirectoriesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceDirectoriesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceDirectoriesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceDirectoriesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceDirectoriesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceDirectoriesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDirectoryDefinitionRequestBuilder"/> for the specified GraphServiceDirectoryDefinition.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceDirectoryDefinition.</param>
        /// <returns>The <see cref="IDirectoryDefinitionRequestBuilder"/>.</returns>
        public IDirectoryDefinitionRequestBuilder this[string id]
        {
            get
            {
                return new DirectoryDefinitionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}

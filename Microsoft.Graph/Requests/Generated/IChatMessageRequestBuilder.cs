// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IChatMessageRequestBuilder.
    /// </summary>
    public partial interface IChatMessageRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IChatMessageRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IChatMessageRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Replies.
        /// </summary>
        /// <returns>The <see cref="IChatMessageRepliesCollectionRequestBuilder"/>.</returns>
        IChatMessageRepliesCollectionRequestBuilder Replies { get; }

        /// <summary>
        /// Gets the request builder for HostedContents.
        /// </summary>
        /// <returns>The <see cref="IChatMessageHostedContentsCollectionRequestBuilder"/>.</returns>
        IChatMessageHostedContentsCollectionRequestBuilder HostedContents { get; }
    
        
    
    }
}

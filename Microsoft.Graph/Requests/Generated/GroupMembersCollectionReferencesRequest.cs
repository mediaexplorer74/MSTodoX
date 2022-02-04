// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type GroupMembersCollectionReferencesRequest.
    /// </summary>
    public partial class GroupMembersCollectionReferencesRequest : BaseRequest, IGroupMembersCollectionReferencesRequest
    {
        /// <summary>
        /// Constructs a new GroupMembersCollectionReferencesRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupMembersCollectionReferencesRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }
        
        /// <summary>
        /// Adds the specified DirectoryObject to the collection via POST.
        /// </summary>
        /// <param name="directoryObject">The DirectoryObject to add.</param>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task AddAsync(DirectoryObject directoryObject)
        {
            return this.AddAsync(directoryObject, CancellationToken.None);
        }

        /// <summary>
        /// Adds the specified DirectoryObject to the collection via POST.
        /// </summary>
        /// <param name="directoryObject">The DirectoryObject to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task AddAsync(DirectoryObject directoryObject, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";

            if (string.IsNullOrEmpty(directoryObject.Id))
            {
                throw new ServiceException(new Error { Code = "invalidRequest", Message = "ID is required to add a reference." });
            }

            var requestBody = new ReferenceRequestBody { ODataId = string.Format("{0}/directoryObjects/{1}", this.Client.BaseUrl, directoryObject.Id) };
            return this.SendAsync(requestBody, cancellationToken);
        }

    }
}

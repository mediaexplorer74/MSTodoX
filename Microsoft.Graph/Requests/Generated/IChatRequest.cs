// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IChatRequest.
    /// </summary>
    public partial interface IChatRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Chat using POST.
        /// </summary>
        /// <param name="chatToCreate">The Chat to create.</param>
        /// <returns>The created Chat.</returns>
        System.Threading.Tasks.Task<Chat> CreateAsync(Chat chatToCreate);        /// <summary>
        /// Creates the specified Chat using POST.
        /// </summary>
        /// <param name="chatToCreate">The Chat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Chat.</returns>
        System.Threading.Tasks.Task<Chat> CreateAsync(Chat chatToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Chat.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Chat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Chat.
        /// </summary>
        /// <returns>The Chat.</returns>
        System.Threading.Tasks.Task<Chat> GetAsync();

        /// <summary>
        /// Gets the specified Chat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Chat.</returns>
        System.Threading.Tasks.Task<Chat> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Chat using PATCH.
        /// </summary>
        /// <param name="chatToUpdate">The Chat to update.</param>
        /// <returns>The updated Chat.</returns>
        System.Threading.Tasks.Task<Chat> UpdateAsync(Chat chatToUpdate);

        /// <summary>
        /// Updates the specified Chat using PATCH.
        /// </summary>
        /// <param name="chatToUpdate">The Chat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Chat.</returns>
        System.Threading.Tasks.Task<Chat> UpdateAsync(Chat chatToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IChatRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IChatRequest Expand(Expression<Func<Chat, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IChatRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IChatRequest Select(Expression<Func<Chat, object>> selectExpression);

    }
}

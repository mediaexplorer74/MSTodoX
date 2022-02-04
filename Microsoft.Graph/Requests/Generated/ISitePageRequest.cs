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
    /// The interface ISitePageRequest.
    /// </summary>
    public partial interface ISitePageRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SitePage using POST.
        /// </summary>
        /// <param name="sitePageToCreate">The SitePage to create.</param>
        /// <returns>The created SitePage.</returns>
        System.Threading.Tasks.Task<SitePage> CreateAsync(SitePage sitePageToCreate);        /// <summary>
        /// Creates the specified SitePage using POST.
        /// </summary>
        /// <param name="sitePageToCreate">The SitePage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SitePage.</returns>
        System.Threading.Tasks.Task<SitePage> CreateAsync(SitePage sitePageToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SitePage.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SitePage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SitePage.
        /// </summary>
        /// <returns>The SitePage.</returns>
        System.Threading.Tasks.Task<SitePage> GetAsync();

        /// <summary>
        /// Gets the specified SitePage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SitePage.</returns>
        System.Threading.Tasks.Task<SitePage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SitePage using PATCH.
        /// </summary>
        /// <param name="sitePageToUpdate">The SitePage to update.</param>
        /// <returns>The updated SitePage.</returns>
        System.Threading.Tasks.Task<SitePage> UpdateAsync(SitePage sitePageToUpdate);

        /// <summary>
        /// Updates the specified SitePage using PATCH.
        /// </summary>
        /// <param name="sitePageToUpdate">The SitePage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SitePage.</returns>
        System.Threading.Tasks.Task<SitePage> UpdateAsync(SitePage sitePageToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISitePageRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISitePageRequest Expand(Expression<Func<SitePage, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISitePageRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISitePageRequest Select(Expression<Func<SitePage, object>> selectExpression);

    }
}

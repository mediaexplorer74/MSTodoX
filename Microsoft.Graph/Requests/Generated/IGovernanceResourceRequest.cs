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
    /// The interface IGovernanceResourceRequest.
    /// </summary>
    public partial interface IGovernanceResourceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified GovernanceResource using POST.
        /// </summary>
        /// <param name="governanceResourceToCreate">The GovernanceResource to create.</param>
        /// <returns>The created GovernanceResource.</returns>
        System.Threading.Tasks.Task<GovernanceResource> CreateAsync(GovernanceResource governanceResourceToCreate);        /// <summary>
        /// Creates the specified GovernanceResource using POST.
        /// </summary>
        /// <param name="governanceResourceToCreate">The GovernanceResource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GovernanceResource.</returns>
        System.Threading.Tasks.Task<GovernanceResource> CreateAsync(GovernanceResource governanceResourceToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified GovernanceResource.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified GovernanceResource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified GovernanceResource.
        /// </summary>
        /// <returns>The GovernanceResource.</returns>
        System.Threading.Tasks.Task<GovernanceResource> GetAsync();

        /// <summary>
        /// Gets the specified GovernanceResource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GovernanceResource.</returns>
        System.Threading.Tasks.Task<GovernanceResource> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified GovernanceResource using PATCH.
        /// </summary>
        /// <param name="governanceResourceToUpdate">The GovernanceResource to update.</param>
        /// <returns>The updated GovernanceResource.</returns>
        System.Threading.Tasks.Task<GovernanceResource> UpdateAsync(GovernanceResource governanceResourceToUpdate);

        /// <summary>
        /// Updates the specified GovernanceResource using PATCH.
        /// </summary>
        /// <param name="governanceResourceToUpdate">The GovernanceResource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GovernanceResource.</returns>
        System.Threading.Tasks.Task<GovernanceResource> UpdateAsync(GovernanceResource governanceResourceToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceResourceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceResourceRequest Expand(Expression<Func<GovernanceResource, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceResourceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceResourceRequest Select(Expression<Func<GovernanceResource, object>> selectExpression);

    }
}

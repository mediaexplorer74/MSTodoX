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
    /// The interface IMobileAppDependencyRequest.
    /// </summary>
    public partial interface IMobileAppDependencyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MobileAppDependency using POST.
        /// </summary>
        /// <param name="mobileAppDependencyToCreate">The MobileAppDependency to create.</param>
        /// <returns>The created MobileAppDependency.</returns>
        System.Threading.Tasks.Task<MobileAppDependency> CreateAsync(MobileAppDependency mobileAppDependencyToCreate);        /// <summary>
        /// Creates the specified MobileAppDependency using POST.
        /// </summary>
        /// <param name="mobileAppDependencyToCreate">The MobileAppDependency to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MobileAppDependency.</returns>
        System.Threading.Tasks.Task<MobileAppDependency> CreateAsync(MobileAppDependency mobileAppDependencyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MobileAppDependency.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MobileAppDependency.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MobileAppDependency.
        /// </summary>
        /// <returns>The MobileAppDependency.</returns>
        System.Threading.Tasks.Task<MobileAppDependency> GetAsync();

        /// <summary>
        /// Gets the specified MobileAppDependency.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MobileAppDependency.</returns>
        System.Threading.Tasks.Task<MobileAppDependency> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MobileAppDependency using PATCH.
        /// </summary>
        /// <param name="mobileAppDependencyToUpdate">The MobileAppDependency to update.</param>
        /// <returns>The updated MobileAppDependency.</returns>
        System.Threading.Tasks.Task<MobileAppDependency> UpdateAsync(MobileAppDependency mobileAppDependencyToUpdate);

        /// <summary>
        /// Updates the specified MobileAppDependency using PATCH.
        /// </summary>
        /// <param name="mobileAppDependencyToUpdate">The MobileAppDependency to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MobileAppDependency.</returns>
        System.Threading.Tasks.Task<MobileAppDependency> UpdateAsync(MobileAppDependency mobileAppDependencyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppDependencyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppDependencyRequest Expand(Expression<Func<MobileAppDependency, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppDependencyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppDependencyRequest Select(Expression<Func<MobileAppDependency, object>> selectExpression);

    }
}

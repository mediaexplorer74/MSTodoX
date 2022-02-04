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
    /// The interface IDetectedAppRequest.
    /// </summary>
    public partial interface IDetectedAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DetectedApp using POST.
        /// </summary>
        /// <param name="detectedAppToCreate">The DetectedApp to create.</param>
        /// <returns>The created DetectedApp.</returns>
        System.Threading.Tasks.Task<DetectedApp> CreateAsync(DetectedApp detectedAppToCreate);        /// <summary>
        /// Creates the specified DetectedApp using POST.
        /// </summary>
        /// <param name="detectedAppToCreate">The DetectedApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DetectedApp.</returns>
        System.Threading.Tasks.Task<DetectedApp> CreateAsync(DetectedApp detectedAppToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DetectedApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DetectedApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DetectedApp.
        /// </summary>
        /// <returns>The DetectedApp.</returns>
        System.Threading.Tasks.Task<DetectedApp> GetAsync();

        /// <summary>
        /// Gets the specified DetectedApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DetectedApp.</returns>
        System.Threading.Tasks.Task<DetectedApp> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DetectedApp using PATCH.
        /// </summary>
        /// <param name="detectedAppToUpdate">The DetectedApp to update.</param>
        /// <returns>The updated DetectedApp.</returns>
        System.Threading.Tasks.Task<DetectedApp> UpdateAsync(DetectedApp detectedAppToUpdate);

        /// <summary>
        /// Updates the specified DetectedApp using PATCH.
        /// </summary>
        /// <param name="detectedAppToUpdate">The DetectedApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DetectedApp.</returns>
        System.Threading.Tasks.Task<DetectedApp> UpdateAsync(DetectedApp detectedAppToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDetectedAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDetectedAppRequest Expand(Expression<Func<DetectedApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDetectedAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDetectedAppRequest Select(Expression<Func<DetectedApp, object>> selectExpression);

    }
}

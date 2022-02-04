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
    /// The interface ISuspiciousIpRiskEventRequest.
    /// </summary>
    public partial interface ISuspiciousIpRiskEventRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SuspiciousIpRiskEvent using POST.
        /// </summary>
        /// <param name="suspiciousIpRiskEventToCreate">The SuspiciousIpRiskEvent to create.</param>
        /// <returns>The created SuspiciousIpRiskEvent.</returns>
        System.Threading.Tasks.Task<SuspiciousIpRiskEvent> CreateAsync(SuspiciousIpRiskEvent suspiciousIpRiskEventToCreate);        /// <summary>
        /// Creates the specified SuspiciousIpRiskEvent using POST.
        /// </summary>
        /// <param name="suspiciousIpRiskEventToCreate">The SuspiciousIpRiskEvent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SuspiciousIpRiskEvent.</returns>
        System.Threading.Tasks.Task<SuspiciousIpRiskEvent> CreateAsync(SuspiciousIpRiskEvent suspiciousIpRiskEventToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SuspiciousIpRiskEvent.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SuspiciousIpRiskEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SuspiciousIpRiskEvent.
        /// </summary>
        /// <returns>The SuspiciousIpRiskEvent.</returns>
        System.Threading.Tasks.Task<SuspiciousIpRiskEvent> GetAsync();

        /// <summary>
        /// Gets the specified SuspiciousIpRiskEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SuspiciousIpRiskEvent.</returns>
        System.Threading.Tasks.Task<SuspiciousIpRiskEvent> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SuspiciousIpRiskEvent using PATCH.
        /// </summary>
        /// <param name="suspiciousIpRiskEventToUpdate">The SuspiciousIpRiskEvent to update.</param>
        /// <returns>The updated SuspiciousIpRiskEvent.</returns>
        System.Threading.Tasks.Task<SuspiciousIpRiskEvent> UpdateAsync(SuspiciousIpRiskEvent suspiciousIpRiskEventToUpdate);

        /// <summary>
        /// Updates the specified SuspiciousIpRiskEvent using PATCH.
        /// </summary>
        /// <param name="suspiciousIpRiskEventToUpdate">The SuspiciousIpRiskEvent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SuspiciousIpRiskEvent.</returns>
        System.Threading.Tasks.Task<SuspiciousIpRiskEvent> UpdateAsync(SuspiciousIpRiskEvent suspiciousIpRiskEventToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISuspiciousIpRiskEventRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISuspiciousIpRiskEventRequest Expand(Expression<Func<SuspiciousIpRiskEvent, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISuspiciousIpRiskEventRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISuspiciousIpRiskEventRequest Select(Expression<Func<SuspiciousIpRiskEvent, object>> selectExpression);

    }
}
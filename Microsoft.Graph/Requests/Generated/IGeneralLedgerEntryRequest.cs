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
    /// The interface IGeneralLedgerEntryRequest.
    /// </summary>
    public partial interface IGeneralLedgerEntryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified GeneralLedgerEntry using POST.
        /// </summary>
        /// <param name="generalLedgerEntryToCreate">The GeneralLedgerEntry to create.</param>
        /// <returns>The created GeneralLedgerEntry.</returns>
        System.Threading.Tasks.Task<GeneralLedgerEntry> CreateAsync(GeneralLedgerEntry generalLedgerEntryToCreate);        /// <summary>
        /// Creates the specified GeneralLedgerEntry using POST.
        /// </summary>
        /// <param name="generalLedgerEntryToCreate">The GeneralLedgerEntry to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GeneralLedgerEntry.</returns>
        System.Threading.Tasks.Task<GeneralLedgerEntry> CreateAsync(GeneralLedgerEntry generalLedgerEntryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified GeneralLedgerEntry.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified GeneralLedgerEntry.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified GeneralLedgerEntry.
        /// </summary>
        /// <returns>The GeneralLedgerEntry.</returns>
        System.Threading.Tasks.Task<GeneralLedgerEntry> GetAsync();

        /// <summary>
        /// Gets the specified GeneralLedgerEntry.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GeneralLedgerEntry.</returns>
        System.Threading.Tasks.Task<GeneralLedgerEntry> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified GeneralLedgerEntry using PATCH.
        /// </summary>
        /// <param name="generalLedgerEntryToUpdate">The GeneralLedgerEntry to update.</param>
        /// <returns>The updated GeneralLedgerEntry.</returns>
        System.Threading.Tasks.Task<GeneralLedgerEntry> UpdateAsync(GeneralLedgerEntry generalLedgerEntryToUpdate);

        /// <summary>
        /// Updates the specified GeneralLedgerEntry using PATCH.
        /// </summary>
        /// <param name="generalLedgerEntryToUpdate">The GeneralLedgerEntry to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GeneralLedgerEntry.</returns>
        System.Threading.Tasks.Task<GeneralLedgerEntry> UpdateAsync(GeneralLedgerEntry generalLedgerEntryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGeneralLedgerEntryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGeneralLedgerEntryRequest Expand(Expression<Func<GeneralLedgerEntry, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGeneralLedgerEntryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGeneralLedgerEntryRequest Select(Expression<Func<GeneralLedgerEntry, object>> selectExpression);

    }
}

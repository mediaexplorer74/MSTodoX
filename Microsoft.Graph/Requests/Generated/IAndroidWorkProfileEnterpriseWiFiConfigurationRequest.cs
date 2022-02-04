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
    /// The interface IAndroidWorkProfileEnterpriseWiFiConfigurationRequest.
    /// </summary>
    public partial interface IAndroidWorkProfileEnterpriseWiFiConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidWorkProfileEnterpriseWiFiConfiguration using POST.
        /// </summary>
        /// <param name="androidWorkProfileEnterpriseWiFiConfigurationToCreate">The AndroidWorkProfileEnterpriseWiFiConfiguration to create.</param>
        /// <returns>The created AndroidWorkProfileEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileEnterpriseWiFiConfiguration> CreateAsync(AndroidWorkProfileEnterpriseWiFiConfiguration androidWorkProfileEnterpriseWiFiConfigurationToCreate);        /// <summary>
        /// Creates the specified AndroidWorkProfileEnterpriseWiFiConfiguration using POST.
        /// </summary>
        /// <param name="androidWorkProfileEnterpriseWiFiConfigurationToCreate">The AndroidWorkProfileEnterpriseWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidWorkProfileEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileEnterpriseWiFiConfiguration> CreateAsync(AndroidWorkProfileEnterpriseWiFiConfiguration androidWorkProfileEnterpriseWiFiConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidWorkProfileEnterpriseWiFiConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AndroidWorkProfileEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidWorkProfileEnterpriseWiFiConfiguration.
        /// </summary>
        /// <returns>The AndroidWorkProfileEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileEnterpriseWiFiConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified AndroidWorkProfileEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidWorkProfileEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileEnterpriseWiFiConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidWorkProfileEnterpriseWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="androidWorkProfileEnterpriseWiFiConfigurationToUpdate">The AndroidWorkProfileEnterpriseWiFiConfiguration to update.</param>
        /// <returns>The updated AndroidWorkProfileEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileEnterpriseWiFiConfiguration> UpdateAsync(AndroidWorkProfileEnterpriseWiFiConfiguration androidWorkProfileEnterpriseWiFiConfigurationToUpdate);

        /// <summary>
        /// Updates the specified AndroidWorkProfileEnterpriseWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="androidWorkProfileEnterpriseWiFiConfigurationToUpdate">The AndroidWorkProfileEnterpriseWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidWorkProfileEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileEnterpriseWiFiConfiguration> UpdateAsync(AndroidWorkProfileEnterpriseWiFiConfiguration androidWorkProfileEnterpriseWiFiConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileEnterpriseWiFiConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileEnterpriseWiFiConfigurationRequest Expand(Expression<Func<AndroidWorkProfileEnterpriseWiFiConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileEnterpriseWiFiConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileEnterpriseWiFiConfigurationRequest Select(Expression<Func<AndroidWorkProfileEnterpriseWiFiConfiguration, object>> selectExpression);

    }
}

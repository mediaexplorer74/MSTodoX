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
    /// The interface IWindowsPhone81ImportedPFXCertificateProfileRequest.
    /// </summary>
    public partial interface IWindowsPhone81ImportedPFXCertificateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsPhone81ImportedPFXCertificateProfile using POST.
        /// </summary>
        /// <param name="windowsPhone81ImportedPFXCertificateProfileToCreate">The WindowsPhone81ImportedPFXCertificateProfile to create.</param>
        /// <returns>The created WindowsPhone81ImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<WindowsPhone81ImportedPFXCertificateProfile> CreateAsync(WindowsPhone81ImportedPFXCertificateProfile windowsPhone81ImportedPFXCertificateProfileToCreate);        /// <summary>
        /// Creates the specified WindowsPhone81ImportedPFXCertificateProfile using POST.
        /// </summary>
        /// <param name="windowsPhone81ImportedPFXCertificateProfileToCreate">The WindowsPhone81ImportedPFXCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsPhone81ImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<WindowsPhone81ImportedPFXCertificateProfile> CreateAsync(WindowsPhone81ImportedPFXCertificateProfile windowsPhone81ImportedPFXCertificateProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsPhone81ImportedPFXCertificateProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsPhone81ImportedPFXCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsPhone81ImportedPFXCertificateProfile.
        /// </summary>
        /// <returns>The WindowsPhone81ImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<WindowsPhone81ImportedPFXCertificateProfile> GetAsync();

        /// <summary>
        /// Gets the specified WindowsPhone81ImportedPFXCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsPhone81ImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<WindowsPhone81ImportedPFXCertificateProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsPhone81ImportedPFXCertificateProfile using PATCH.
        /// </summary>
        /// <param name="windowsPhone81ImportedPFXCertificateProfileToUpdate">The WindowsPhone81ImportedPFXCertificateProfile to update.</param>
        /// <returns>The updated WindowsPhone81ImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<WindowsPhone81ImportedPFXCertificateProfile> UpdateAsync(WindowsPhone81ImportedPFXCertificateProfile windowsPhone81ImportedPFXCertificateProfileToUpdate);

        /// <summary>
        /// Updates the specified WindowsPhone81ImportedPFXCertificateProfile using PATCH.
        /// </summary>
        /// <param name="windowsPhone81ImportedPFXCertificateProfileToUpdate">The WindowsPhone81ImportedPFXCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsPhone81ImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<WindowsPhone81ImportedPFXCertificateProfile> UpdateAsync(WindowsPhone81ImportedPFXCertificateProfile windowsPhone81ImportedPFXCertificateProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81ImportedPFXCertificateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81ImportedPFXCertificateProfileRequest Expand(Expression<Func<WindowsPhone81ImportedPFXCertificateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81ImportedPFXCertificateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81ImportedPFXCertificateProfileRequest Select(Expression<Func<WindowsPhone81ImportedPFXCertificateProfile, object>> selectExpression);

    }
}
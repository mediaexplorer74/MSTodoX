// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IGraphServiceServicePrincipalsCollectionRequestBuilder.
    /// </summary>
    public partial interface IGraphServiceServicePrincipalsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGraphServiceServicePrincipalsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGraphServiceServicePrincipalsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IServicePrincipalRequestBuilder"/> for the specified ServicePrincipal.
        /// </summary>
        /// <param name="id">The ID for the ServicePrincipal.</param>
        /// <returns>The <see cref="IServicePrincipalRequestBuilder"/>.</returns>
        IServicePrincipalRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for ServicePrincipalDelta.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalDeltaRequestBuilder"/>.</returns>
        IServicePrincipalDeltaRequestBuilder Delta();
    }
}

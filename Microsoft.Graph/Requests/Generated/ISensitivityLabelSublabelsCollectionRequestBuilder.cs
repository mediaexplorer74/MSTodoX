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
    /// The interface ISensitivityLabelSublabelsCollectionRequestBuilder.
    /// </summary>
    public partial interface ISensitivityLabelSublabelsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        ISensitivityLabelSublabelsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ISensitivityLabelSublabelsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="ISensitivityLabelRequestBuilder"/> for the specified SensitivityLabel.
        /// </summary>
        /// <param name="id">The ID for the SensitivityLabel.</param>
        /// <returns>The <see cref="ISensitivityLabelRequestBuilder"/>.</returns>
        ISensitivityLabelRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for SensitivityLabelEvaluate.
        /// </summary>
        /// <returns>The <see cref="ISensitivityLabelEvaluateRequestBuilder"/>.</returns>
        ISensitivityLabelEvaluateRequestBuilder Evaluate(
            IEnumerable<DiscoveredSensitiveType> discoveredSensitiveTypes = null);
    }
}

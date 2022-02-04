// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IGroupPolicyDefinitionFileDefinitionsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IGroupPolicyDefinitionFileDefinitionsCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGroupPolicyDefinitionFileDefinitionsCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGroupPolicyDefinitionFileDefinitionsCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IGroupPolicyDefinitionWithReferenceRequestBuilder"/> for the specified GroupPolicyDefinition.
        /// </summary>
        /// <param name="id">The ID for the GroupPolicyDefinition.</param>
        /// <returns>The <see cref="IGroupPolicyDefinitionWithReferenceRequestBuilder"/>.</returns>
        IGroupPolicyDefinitionWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IGroupPolicyDefinitionFileDefinitionsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyDefinitionFileDefinitionsCollectionReferencesRequestBuilder"/>.</returns>
        IGroupPolicyDefinitionFileDefinitionsCollectionReferencesRequestBuilder References { get; }

    }
}

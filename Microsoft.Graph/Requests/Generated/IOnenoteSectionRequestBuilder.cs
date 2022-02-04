// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IOnenoteSectionRequestBuilder.
    /// </summary>
    public partial interface IOnenoteSectionRequestBuilder : IOnenoteEntityHierarchyModelRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IOnenoteSectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IOnenoteSectionRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for ParentNotebook.
        /// </summary>
        /// <returns>The <see cref="INotebookRequestBuilder"/>.</returns>
        INotebookRequestBuilder ParentNotebook { get; }

        /// <summary>
        /// Gets the request builder for ParentSectionGroup.
        /// </summary>
        /// <returns>The <see cref="ISectionGroupRequestBuilder"/>.</returns>
        ISectionGroupRequestBuilder ParentSectionGroup { get; }

        /// <summary>
        /// Gets the request builder for Pages.
        /// </summary>
        /// <returns>The <see cref="IOnenoteSectionPagesCollectionRequestBuilder"/>.</returns>
        IOnenoteSectionPagesCollectionRequestBuilder Pages { get; }
    
        /// <summary>
        /// Gets the request builder for OnenoteSectionCopyToNotebook.
        /// </summary>
        /// <returns>The <see cref="IOnenoteSectionCopyToNotebookRequestBuilder"/>.</returns>
        IOnenoteSectionCopyToNotebookRequestBuilder CopyToNotebook(
            string id = null,
            string groupId = null,
            string renameAs = null,
            string siteCollectionId = null,
            string siteId = null);

        /// <summary>
        /// Gets the request builder for OnenoteSectionCopyToSectionGroup.
        /// </summary>
        /// <returns>The <see cref="IOnenoteSectionCopyToSectionGroupRequestBuilder"/>.</returns>
        IOnenoteSectionCopyToSectionGroupRequestBuilder CopyToSectionGroup(
            string id = null,
            string groupId = null,
            string renameAs = null,
            string siteCollectionId = null,
            string siteId = null);
    
    }
}

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
    /// The interface IEducationAssignmentRequestBuilder.
    /// </summary>
    public partial interface IEducationAssignmentRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IEducationAssignmentRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IEducationAssignmentRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Resources.
        /// </summary>
        /// <returns>The <see cref="IEducationAssignmentResourcesCollectionRequestBuilder"/>.</returns>
        IEducationAssignmentResourcesCollectionRequestBuilder Resources { get; }

        /// <summary>
        /// Gets the request builder for Submissions.
        /// </summary>
        /// <returns>The <see cref="IEducationAssignmentSubmissionsCollectionRequestBuilder"/>.</returns>
        IEducationAssignmentSubmissionsCollectionRequestBuilder Submissions { get; }

        /// <summary>
        /// Gets the request builder for Categories.
        /// </summary>
        /// <returns>The <see cref="IEducationAssignmentCategoriesCollectionRequestBuilder"/>.</returns>
        IEducationAssignmentCategoriesCollectionRequestBuilder Categories { get; }

        /// <summary>
        /// Gets the request builder for Rubric.
        /// </summary>
        /// <returns>The <see cref="IEducationRubricRequestBuilder"/>.</returns>
        IEducationRubricRequestBuilder Rubric { get; }
    
        /// <summary>
        /// Gets the request builder for EducationAssignmentPublish.
        /// </summary>
        /// <returns>The <see cref="IEducationAssignmentPublishRequestBuilder"/>.</returns>
        IEducationAssignmentPublishRequestBuilder Publish();

        /// <summary>
        /// Gets the request builder for EducationAssignmentGetResourcesFolderUrl.
        /// </summary>
        /// <returns>The <see cref="IEducationAssignmentGetResourcesFolderUrlRequestBuilder"/>.</returns>
        IEducationAssignmentGetResourcesFolderUrlRequestBuilder GetResourcesFolderUrl();
    
    }
}

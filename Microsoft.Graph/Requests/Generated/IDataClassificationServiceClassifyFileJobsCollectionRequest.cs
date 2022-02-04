// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDataClassificationServiceClassifyFileJobsCollectionRequest.
    /// </summary>
    public partial interface IDataClassificationServiceClassifyFileJobsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified JobResponseBase to the collection via POST.
        /// </summary>
        /// <param name="jobResponseBase">The JobResponseBase to add.</param>
        /// <returns>The created JobResponseBase.</returns>
        System.Threading.Tasks.Task<JobResponseBase> AddAsync(JobResponseBase jobResponseBase);

        /// <summary>
        /// Adds the specified JobResponseBase to the collection via POST.
        /// </summary>
        /// <param name="jobResponseBase">The JobResponseBase to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created JobResponseBase.</returns>
        System.Threading.Tasks.Task<JobResponseBase> AddAsync(JobResponseBase jobResponseBase, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDataClassificationServiceClassifyFileJobsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDataClassificationServiceClassifyFileJobsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDataClassificationServiceClassifyFileJobsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDataClassificationServiceClassifyFileJobsCollectionRequest Expand(Expression<Func<JobResponseBase, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDataClassificationServiceClassifyFileJobsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDataClassificationServiceClassifyFileJobsCollectionRequest Select(Expression<Func<JobResponseBase, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDataClassificationServiceClassifyFileJobsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDataClassificationServiceClassifyFileJobsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDataClassificationServiceClassifyFileJobsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDataClassificationServiceClassifyFileJobsCollectionRequest OrderBy(string value);
    }
}

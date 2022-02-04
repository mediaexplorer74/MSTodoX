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
    /// The interface IWorkbookWorksheetChartsCollectionRequestBuilder.
    /// </summary>
    public partial interface IWorkbookWorksheetChartsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IWorkbookWorksheetChartsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IWorkbookWorksheetChartsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IWorkbookChartRequestBuilder"/> for the specified WorkbookChart.
        /// </summary>
        /// <param name="id">The ID for the WorkbookChart.</param>
        /// <returns>The <see cref="IWorkbookChartRequestBuilder"/>.</returns>
        [System.Runtime.CompilerServices.IndexerName("ThisItem")]
        IWorkbookChartRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for WorkbookChartAdd.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartAddRequestBuilder"/>.</returns>
        IWorkbookChartAddRequestBuilder Add(
            string type,
            string seriesBy,
            Newtonsoft.Json.Linq.JToken sourceData = null);

        /// <summary>
        /// Gets the request builder for WorkbookChartItem.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartItemRequestBuilder"/>.</returns>
        IWorkbookChartItemRequestBuilder Item(
            string name = null);

        /// <summary>
        /// Gets the request builder for WorkbookChartItemAt.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartItemAtRequestBuilder"/>.</returns>
        IWorkbookChartItemAtRequestBuilder ItemAt(
            Int32 index);

        /// <summary>
        /// Gets the request builder for WorkbookChartCount.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartCountRequestBuilder"/>.</returns>
        IWorkbookChartCountRequestBuilder Count();
    }
}

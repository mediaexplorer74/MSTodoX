// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type WorkbookWorksheetChartsCollectionRequestBuilder.
    /// </summary>
    public partial class WorkbookWorksheetChartsCollectionRequestBuilder : BaseRequestBuilder, IWorkbookWorksheetChartsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new WorkbookWorksheetChartsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookWorksheetChartsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWorkbookWorksheetChartsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWorkbookWorksheetChartsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookWorksheetChartsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWorkbookChartRequestBuilder"/> for the specified WorkbookWorksheetWorkbookChart.
        /// </summary>
        /// <param name="id">The ID for the WorkbookWorksheetWorkbookChart.</param>
        /// <returns>The <see cref="IWorkbookChartRequestBuilder"/>.</returns>
        [System.Runtime.CompilerServices.IndexerName("ThisItem")]
        public IWorkbookChartRequestBuilder this[string id]
        {
            get
            {
                return new WorkbookChartRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for WorkbookChartAdd.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartAddRequestBuilder"/>.</returns>
        public IWorkbookChartAddRequestBuilder Add(
            string type,
            string seriesBy,
            Newtonsoft.Json.Linq.JToken sourceData = null)
        {
            return new WorkbookChartAddRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.add"),
                this.Client,
                type,
                seriesBy,
                sourceData);
        }

        /// <summary>
        /// Gets the request builder for WorkbookChartItem.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartItemRequestBuilder"/>.</returns>
        public IWorkbookChartItemRequestBuilder Item(
            string name = null)
        {
            return new WorkbookChartItemRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.item"),
                this.Client,
                name);
        }

        /// <summary>
        /// Gets the request builder for WorkbookChartItemAt.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartItemAtRequestBuilder"/>.</returns>
        public IWorkbookChartItemAtRequestBuilder ItemAt(
            Int32 index)
        {
            return new WorkbookChartItemAtRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.itemAt"),
                this.Client,
                index);
        }

        /// <summary>
        /// Gets the request builder for WorkbookChartCount.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartCountRequestBuilder"/>.</returns>
        public IWorkbookChartCountRequestBuilder Count()
        {
            return new WorkbookChartCountRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.count"),
                this.Client);
        }
    }
}

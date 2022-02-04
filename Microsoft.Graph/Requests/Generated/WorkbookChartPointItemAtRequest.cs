// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type WorkbookChartPointItemAtRequest.
    /// </summary>
    public partial class WorkbookChartPointItemAtRequest : BaseRequest, IWorkbookChartPointItemAtRequest
    {
        /// <summary>
        /// Constructs a new WorkbookChartPointItemAtRequest.
        /// </summary>
        public WorkbookChartPointItemAtRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        public System.Threading.Tasks.Task<WorkbookChartPoint> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<WorkbookChartPoint> GetAsync(
            CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return this.SendAsync<WorkbookChartPoint>(null, cancellationToken);
        }


        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="workbookchartpoint">The WorkbookChartPoint object set with the properties to update.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<WorkbookChartPoint> PatchAsync(WorkbookChartPoint workbookchartpoint)
        {
            return this.PatchAsync(workbookchartpoint, CancellationToken.None);
        }

        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="workbookchartpoint">The WorkbookChartPoint object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<WorkbookChartPoint> PatchAsync(WorkbookChartPoint workbookchartpoint, 
            CancellationToken cancellationToken)
        {
            this.Method = "PATCH";
            return this.SendAsync<WorkbookChartPoint>(workbookchartpoint, cancellationToken);
        }        

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="workbookchartpoint">The WorkbookChartPoint object to update.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<WorkbookChartPoint> PutAsync(WorkbookChartPoint workbookchartpoint)
        {
            return this.PutAsync(workbookchartpoint, CancellationToken.None);
        }

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="workbookchartpoint">The WorkbookChartPoint object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<WorkbookChartPoint> PutAsync(WorkbookChartPoint workbookchartpoint, 
            CancellationToken cancellationToken)
        {
            this.Method = "PUT";
            return this.SendAsync<WorkbookChartPoint>(workbookchartpoint, cancellationToken);
        }        

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartPointItemAtRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartPointItemAtRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
    }
}

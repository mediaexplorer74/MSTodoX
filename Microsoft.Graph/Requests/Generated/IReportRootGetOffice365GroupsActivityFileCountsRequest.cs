// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IMethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IReportRootGetOffice365GroupsActivityFileCountsRequest.
    /// </summary>
    public partial interface IReportRootGetOffice365GroupsActivityFileCountsRequest : IBaseRequest
    {


        /// <summary>
        /// Issues the GET request.
        /// </summary>
        System.Threading.Tasks.Task<IReportRootGetOffice365GroupsActivityFileCountsCollectionPage> GetAsync();
        
        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetOffice365GroupsActivityFileCountsCollectionPage> GetAsync(
            CancellationToken cancellationToken);
  


        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="office365groupsactivityfilecounts">The Office365GroupsActivityFileCounts object set with the properties to update.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetOffice365GroupsActivityFileCountsCollectionPage> PatchAsync(Office365GroupsActivityFileCounts office365groupsactivityfilecounts);

        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="office365groupsactivityfilecounts">The Office365GroupsActivityFileCounts object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetOffice365GroupsActivityFileCountsCollectionPage> PatchAsync(Office365GroupsActivityFileCounts office365groupsactivityfilecounts, 
            CancellationToken cancellationToken);
          

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="office365groupsactivityfilecounts">The Office365GroupsActivityFileCounts object to update.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetOffice365GroupsActivityFileCountsCollectionPage> PutAsync(Office365GroupsActivityFileCounts office365groupsactivityfilecounts);

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="office365groupsactivityfilecounts">The Office365GroupsActivityFileCounts object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetOffice365GroupsActivityFileCountsCollectionPage> PutAsync(Office365GroupsActivityFileCounts office365groupsactivityfilecounts, 
            CancellationToken cancellationToken);




        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOffice365GroupsActivityFileCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOffice365GroupsActivityFileCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOffice365GroupsActivityFileCountsRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOffice365GroupsActivityFileCountsRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOffice365GroupsActivityFileCountsRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOffice365GroupsActivityFileCountsRequest OrderBy(string value);
    }
}

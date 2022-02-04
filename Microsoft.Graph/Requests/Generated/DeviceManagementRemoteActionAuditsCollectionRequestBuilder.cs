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
    /// The type DeviceManagementRemoteActionAuditsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementRemoteActionAuditsCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementRemoteActionAuditsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementRemoteActionAuditsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementRemoteActionAuditsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementRemoteActionAuditsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementRemoteActionAuditsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementRemoteActionAuditsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IRemoteActionAuditRequestBuilder"/> for the specified DeviceManagementRemoteActionAudit.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementRemoteActionAudit.</param>
        /// <returns>The <see cref="IRemoteActionAuditRequestBuilder"/>.</returns>
        public IRemoteActionAuditRequestBuilder this[string id]
        {
            get
            {
                return new RemoteActionAuditRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}

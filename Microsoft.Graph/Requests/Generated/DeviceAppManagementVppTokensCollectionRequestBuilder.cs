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
    /// The type DeviceAppManagementVppTokensCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceAppManagementVppTokensCollectionRequestBuilder : BaseRequestBuilder, IDeviceAppManagementVppTokensCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceAppManagementVppTokensCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceAppManagementVppTokensCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementVppTokensCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementVppTokensCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceAppManagementVppTokensCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IVppTokenRequestBuilder"/> for the specified DeviceAppManagementVppToken.
        /// </summary>
        /// <param name="id">The ID for the DeviceAppManagementVppToken.</param>
        /// <returns>The <see cref="IVppTokenRequestBuilder"/>.</returns>
        public IVppTokenRequestBuilder this[string id]
        {
            get
            {
                return new VppTokenRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for VppTokenGetLicensesForApp.
        /// </summary>
        /// <returns>The <see cref="IVppTokenGetLicensesForAppRequestBuilder"/>.</returns>
        public IVppTokenGetLicensesForAppRequestBuilder GetLicensesForApp(
            string bundleId = null)
        {
            return new VppTokenGetLicensesForAppRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getLicensesForApp"),
                this.Client,
                bundleId);
        }
    }
}
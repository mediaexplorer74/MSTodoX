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
    /// The type DeviceAppManagementManagedAppPoliciesCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceAppManagementManagedAppPoliciesCollectionRequestBuilder : BaseRequestBuilder, IDeviceAppManagementManagedAppPoliciesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceAppManagementManagedAppPoliciesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceAppManagementManagedAppPoliciesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementManagedAppPoliciesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementManagedAppPoliciesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceAppManagementManagedAppPoliciesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagedAppPolicyRequestBuilder"/> for the specified DeviceAppManagementManagedAppPolicy.
        /// </summary>
        /// <param name="id">The ID for the DeviceAppManagementManagedAppPolicy.</param>
        /// <returns>The <see cref="IManagedAppPolicyRequestBuilder"/>.</returns>
        public IManagedAppPolicyRequestBuilder this[string id]
        {
            get
            {
                return new ManagedAppPolicyRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}

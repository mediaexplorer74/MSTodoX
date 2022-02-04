// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type AndroidEnterpriseWiFiConfigurationRequestBuilder.
    /// </summary>
    public partial class AndroidEnterpriseWiFiConfigurationRequestBuilder : AndroidWiFiConfigurationRequestBuilder, IAndroidEnterpriseWiFiConfigurationRequestBuilder
    {

        /// <summary>
        /// Constructs a new AndroidEnterpriseWiFiConfigurationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AndroidEnterpriseWiFiConfigurationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IAndroidEnterpriseWiFiConfigurationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IAndroidEnterpriseWiFiConfigurationRequest Request(IEnumerable<Option> options)
        {
            return new AndroidEnterpriseWiFiConfigurationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for RootCertificateForServerValidation.
        /// </summary>
        /// <returns>The <see cref="IAndroidTrustedRootCertificateWithReferenceRequestBuilder"/>.</returns>
        public IAndroidTrustedRootCertificateWithReferenceRequestBuilder RootCertificateForServerValidation
        {
            get
            {
                return new AndroidTrustedRootCertificateWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("rootCertificateForServerValidation"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for IdentityCertificateForClientAuthentication.
        /// </summary>
        /// <returns>The <see cref="IAndroidCertificateProfileBaseWithReferenceRequestBuilder"/>.</returns>
        public IAndroidCertificateProfileBaseWithReferenceRequestBuilder IdentityCertificateForClientAuthentication
        {
            get
            {
                return new AndroidCertificateProfileBaseWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("identityCertificateForClientAuthentication"), this.Client);
            }
        }
    
    }
}

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
    /// The type GroupPolicyConfigurationRequestBuilder.
    /// </summary>
    public partial class GroupPolicyConfigurationRequestBuilder : EntityRequestBuilder, IGroupPolicyConfigurationRequestBuilder
    {

        /// <summary>
        /// Constructs a new GroupPolicyConfigurationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GroupPolicyConfigurationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IGroupPolicyConfigurationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IGroupPolicyConfigurationRequest Request(IEnumerable<Option> options)
        {
            return new GroupPolicyConfigurationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for DefinitionValues.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyConfigurationDefinitionValuesCollectionRequestBuilder"/>.</returns>
        public IGroupPolicyConfigurationDefinitionValuesCollectionRequestBuilder DefinitionValues
        {
            get
            {
                return new GroupPolicyConfigurationDefinitionValuesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("definitionValues"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyConfigurationAssignmentsCollectionRequestBuilder"/>.</returns>
        public IGroupPolicyConfigurationAssignmentsCollectionRequestBuilder Assignments
        {
            get
            {
                return new GroupPolicyConfigurationAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("assignments"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for GroupPolicyConfigurationAssign.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyConfigurationAssignRequestBuilder"/>.</returns>
        public IGroupPolicyConfigurationAssignRequestBuilder Assign(
            IEnumerable<GroupPolicyConfigurationAssignment> assignments = null)
        {
            return new GroupPolicyConfigurationAssignRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.assign"),
                this.Client,
                assignments);
        }
    
    }
}

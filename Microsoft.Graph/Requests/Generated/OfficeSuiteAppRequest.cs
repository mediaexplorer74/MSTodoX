// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type OfficeSuiteAppRequest.
    /// </summary>
    public partial class OfficeSuiteAppRequest : BaseRequest, IOfficeSuiteAppRequest
    {
        /// <summary>
        /// Constructs a new OfficeSuiteAppRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OfficeSuiteAppRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified OfficeSuiteApp using POST.
        /// </summary>
        /// <param name="officeSuiteAppToCreate">The OfficeSuiteApp to create.</param>
        /// <returns>The created OfficeSuiteApp.</returns>
        public System.Threading.Tasks.Task<OfficeSuiteApp> CreateAsync(OfficeSuiteApp officeSuiteAppToCreate)
        {
            return this.CreateAsync(officeSuiteAppToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified OfficeSuiteApp using POST.
        /// </summary>
        /// <param name="officeSuiteAppToCreate">The OfficeSuiteApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OfficeSuiteApp.</returns>
        public async System.Threading.Tasks.Task<OfficeSuiteApp> CreateAsync(OfficeSuiteApp officeSuiteAppToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<OfficeSuiteApp>(officeSuiteAppToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified OfficeSuiteApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified OfficeSuiteApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<OfficeSuiteApp>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified OfficeSuiteApp.
        /// </summary>
        /// <returns>The OfficeSuiteApp.</returns>
        public System.Threading.Tasks.Task<OfficeSuiteApp> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified OfficeSuiteApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OfficeSuiteApp.</returns>
        public async System.Threading.Tasks.Task<OfficeSuiteApp> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<OfficeSuiteApp>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified OfficeSuiteApp using PATCH.
        /// </summary>
        /// <param name="officeSuiteAppToUpdate">The OfficeSuiteApp to update.</param>
        /// <returns>The updated OfficeSuiteApp.</returns>
        public System.Threading.Tasks.Task<OfficeSuiteApp> UpdateAsync(OfficeSuiteApp officeSuiteAppToUpdate)
        {
            return this.UpdateAsync(officeSuiteAppToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified OfficeSuiteApp using PATCH.
        /// </summary>
        /// <param name="officeSuiteAppToUpdate">The OfficeSuiteApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OfficeSuiteApp.</returns>
        public async System.Threading.Tasks.Task<OfficeSuiteApp> UpdateAsync(OfficeSuiteApp officeSuiteAppToUpdate, CancellationToken cancellationToken)
        {
			if (officeSuiteAppToUpdate.AdditionalData != null)
			{
				if (officeSuiteAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					officeSuiteAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, officeSuiteAppToUpdate.GetType().Name)
						});
				}
			}
            if (officeSuiteAppToUpdate.AdditionalData != null)
            {
                if (officeSuiteAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    officeSuiteAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, officeSuiteAppToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<OfficeSuiteApp>(officeSuiteAppToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOfficeSuiteAppRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOfficeSuiteAppRequest Expand(Expression<Func<OfficeSuiteApp, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IOfficeSuiteAppRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOfficeSuiteAppRequest Select(Expression<Func<OfficeSuiteApp, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="officeSuiteAppToInitialize">The <see cref="OfficeSuiteApp"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(OfficeSuiteApp officeSuiteAppToInitialize)
        {

        }
    }
}
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
    /// The type DataClassificationServiceRequest.
    /// </summary>
    public partial class DataClassificationServiceRequest : BaseRequest, IDataClassificationServiceRequest
    {
        /// <summary>
        /// Constructs a new DataClassificationServiceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DataClassificationServiceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DataClassificationService using POST.
        /// </summary>
        /// <param name="dataClassificationServiceToCreate">The DataClassificationService to create.</param>
        /// <returns>The created DataClassificationService.</returns>
        public System.Threading.Tasks.Task<DataClassificationService> CreateAsync(DataClassificationService dataClassificationServiceToCreate)
        {
            return this.CreateAsync(dataClassificationServiceToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DataClassificationService using POST.
        /// </summary>
        /// <param name="dataClassificationServiceToCreate">The DataClassificationService to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DataClassificationService.</returns>
        public async System.Threading.Tasks.Task<DataClassificationService> CreateAsync(DataClassificationService dataClassificationServiceToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DataClassificationService>(dataClassificationServiceToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified DataClassificationService.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DataClassificationService.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DataClassificationService>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DataClassificationService.
        /// </summary>
        /// <returns>The DataClassificationService.</returns>
        public System.Threading.Tasks.Task<DataClassificationService> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DataClassificationService.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DataClassificationService.</returns>
        public async System.Threading.Tasks.Task<DataClassificationService> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DataClassificationService>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified DataClassificationService using PATCH.
        /// </summary>
        /// <param name="dataClassificationServiceToUpdate">The DataClassificationService to update.</param>
        /// <returns>The updated DataClassificationService.</returns>
        public System.Threading.Tasks.Task<DataClassificationService> UpdateAsync(DataClassificationService dataClassificationServiceToUpdate)
        {
            return this.UpdateAsync(dataClassificationServiceToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DataClassificationService using PATCH.
        /// </summary>
        /// <param name="dataClassificationServiceToUpdate">The DataClassificationService to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DataClassificationService.</returns>
        public async System.Threading.Tasks.Task<DataClassificationService> UpdateAsync(DataClassificationService dataClassificationServiceToUpdate, CancellationToken cancellationToken)
        {
			if (dataClassificationServiceToUpdate.AdditionalData != null)
			{
				if (dataClassificationServiceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					dataClassificationServiceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, dataClassificationServiceToUpdate.GetType().Name)
						});
				}
			}
            if (dataClassificationServiceToUpdate.AdditionalData != null)
            {
                if (dataClassificationServiceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    dataClassificationServiceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, dataClassificationServiceToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DataClassificationService>(dataClassificationServiceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDataClassificationServiceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDataClassificationServiceRequest Expand(Expression<Func<DataClassificationService, object>> expandExpression)
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
        public IDataClassificationServiceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDataClassificationServiceRequest Select(Expression<Func<DataClassificationService, object>> selectExpression)
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
        /// <param name="dataClassificationServiceToInitialize">The <see cref="DataClassificationService"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DataClassificationService dataClassificationServiceToInitialize)
        {

            if (dataClassificationServiceToInitialize != null && dataClassificationServiceToInitialize.AdditionalData != null)
            {

                if (dataClassificationServiceToInitialize.ExactMatchDataStores != null && dataClassificationServiceToInitialize.ExactMatchDataStores.CurrentPage != null)
                {
                    dataClassificationServiceToInitialize.ExactMatchDataStores.AdditionalData = dataClassificationServiceToInitialize.AdditionalData;

                    object nextPageLink;
                    dataClassificationServiceToInitialize.AdditionalData.TryGetValue("exactMatchDataStores@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        dataClassificationServiceToInitialize.ExactMatchDataStores.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (dataClassificationServiceToInitialize.SensitiveTypes != null && dataClassificationServiceToInitialize.SensitiveTypes.CurrentPage != null)
                {
                    dataClassificationServiceToInitialize.SensitiveTypes.AdditionalData = dataClassificationServiceToInitialize.AdditionalData;

                    object nextPageLink;
                    dataClassificationServiceToInitialize.AdditionalData.TryGetValue("sensitiveTypes@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        dataClassificationServiceToInitialize.SensitiveTypes.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (dataClassificationServiceToInitialize.Jobs != null && dataClassificationServiceToInitialize.Jobs.CurrentPage != null)
                {
                    dataClassificationServiceToInitialize.Jobs.AdditionalData = dataClassificationServiceToInitialize.AdditionalData;

                    object nextPageLink;
                    dataClassificationServiceToInitialize.AdditionalData.TryGetValue("jobs@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        dataClassificationServiceToInitialize.Jobs.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (dataClassificationServiceToInitialize.ClassifyFileJobs != null && dataClassificationServiceToInitialize.ClassifyFileJobs.CurrentPage != null)
                {
                    dataClassificationServiceToInitialize.ClassifyFileJobs.AdditionalData = dataClassificationServiceToInitialize.AdditionalData;

                    object nextPageLink;
                    dataClassificationServiceToInitialize.AdditionalData.TryGetValue("classifyFileJobs@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        dataClassificationServiceToInitialize.ClassifyFileJobs.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (dataClassificationServiceToInitialize.ClassifyTextJobs != null && dataClassificationServiceToInitialize.ClassifyTextJobs.CurrentPage != null)
                {
                    dataClassificationServiceToInitialize.ClassifyTextJobs.AdditionalData = dataClassificationServiceToInitialize.AdditionalData;

                    object nextPageLink;
                    dataClassificationServiceToInitialize.AdditionalData.TryGetValue("classifyTextJobs@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        dataClassificationServiceToInitialize.ClassifyTextJobs.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (dataClassificationServiceToInitialize.EvaluateLabelJobs != null && dataClassificationServiceToInitialize.EvaluateLabelJobs.CurrentPage != null)
                {
                    dataClassificationServiceToInitialize.EvaluateLabelJobs.AdditionalData = dataClassificationServiceToInitialize.AdditionalData;

                    object nextPageLink;
                    dataClassificationServiceToInitialize.AdditionalData.TryGetValue("evaluateLabelJobs@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        dataClassificationServiceToInitialize.EvaluateLabelJobs.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (dataClassificationServiceToInitialize.ClassifyText != null && dataClassificationServiceToInitialize.ClassifyText.CurrentPage != null)
                {
                    dataClassificationServiceToInitialize.ClassifyText.AdditionalData = dataClassificationServiceToInitialize.AdditionalData;

                    object nextPageLink;
                    dataClassificationServiceToInitialize.AdditionalData.TryGetValue("classifyText@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        dataClassificationServiceToInitialize.ClassifyText.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (dataClassificationServiceToInitialize.ClassifyFile != null && dataClassificationServiceToInitialize.ClassifyFile.CurrentPage != null)
                {
                    dataClassificationServiceToInitialize.ClassifyFile.AdditionalData = dataClassificationServiceToInitialize.AdditionalData;

                    object nextPageLink;
                    dataClassificationServiceToInitialize.AdditionalData.TryGetValue("classifyFile@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        dataClassificationServiceToInitialize.ClassifyFile.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (dataClassificationServiceToInitialize.SensitivityLabels != null && dataClassificationServiceToInitialize.SensitivityLabels.CurrentPage != null)
                {
                    dataClassificationServiceToInitialize.SensitivityLabels.AdditionalData = dataClassificationServiceToInitialize.AdditionalData;

                    object nextPageLink;
                    dataClassificationServiceToInitialize.AdditionalData.TryGetValue("sensitivityLabels@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        dataClassificationServiceToInitialize.SensitivityLabels.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (dataClassificationServiceToInitialize.ExactMatchUploadAgents != null && dataClassificationServiceToInitialize.ExactMatchUploadAgents.CurrentPage != null)
                {
                    dataClassificationServiceToInitialize.ExactMatchUploadAgents.AdditionalData = dataClassificationServiceToInitialize.AdditionalData;

                    object nextPageLink;
                    dataClassificationServiceToInitialize.AdditionalData.TryGetValue("exactMatchUploadAgents@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        dataClassificationServiceToInitialize.ExactMatchUploadAgents.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}

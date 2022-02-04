// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookFunctionsDbRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsDbRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsDbRequest>, IWorkbookFunctionsDbRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsDbRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="cost">A cost parameter for the OData method call.</param>
        /// <param name="salvage">A salvage parameter for the OData method call.</param>
        /// <param name="life">A life parameter for the OData method call.</param>
        /// <param name="period">A period parameter for the OData method call.</param>
        /// <param name="month">A month parameter for the OData method call.</param>
        public WorkbookFunctionsDbRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken cost,
            Newtonsoft.Json.Linq.JToken salvage,
            Newtonsoft.Json.Linq.JToken life,
            Newtonsoft.Json.Linq.JToken period,
            Newtonsoft.Json.Linq.JToken month)
            : base(requestUrl, client)
        {
            this.SetParameter("cost", cost, true);
            this.SetParameter("salvage", salvage, true);
            this.SetParameter("life", life, true);
            this.SetParameter("period", period, true);
            this.SetParameter("month", month, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsDbRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsDbRequest(functionUrl, this.Client, options);

            if (this.HasParameter("cost"))
            {
                request.RequestBody.Cost = this.GetParameter<Newtonsoft.Json.Linq.JToken>("cost");
            }

            if (this.HasParameter("salvage"))
            {
                request.RequestBody.Salvage = this.GetParameter<Newtonsoft.Json.Linq.JToken>("salvage");
            }

            if (this.HasParameter("life"))
            {
                request.RequestBody.Life = this.GetParameter<Newtonsoft.Json.Linq.JToken>("life");
            }

            if (this.HasParameter("period"))
            {
                request.RequestBody.Period = this.GetParameter<Newtonsoft.Json.Linq.JToken>("period");
            }

            if (this.HasParameter("month"))
            {
                request.RequestBody.Month = this.GetParameter<Newtonsoft.Json.Linq.JToken>("month");
            }

            return request;
        }
    }
}

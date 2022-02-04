// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Vendor.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Vendor : Entity
    {
    
        /// <summary>
        /// Gets or sets number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number", Required = Newtonsoft.Json.Required.Default)]
        public string Number { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "address", Required = Newtonsoft.Json.Required.Default)]
        public PostalAddressType Address { get; set; }
    
        /// <summary>
        /// Gets or sets phone number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "phoneNumber", Required = Newtonsoft.Json.Required.Default)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Gets or sets email.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email", Required = Newtonsoft.Json.Required.Default)]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or sets website.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "website", Required = Newtonsoft.Json.Required.Default)]
        public string Website { get; set; }
    
        /// <summary>
        /// Gets or sets tax registration number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "taxRegistrationNumber", Required = Newtonsoft.Json.Required.Default)]
        public string TaxRegistrationNumber { get; set; }
    
        /// <summary>
        /// Gets or sets currency id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currencyId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? CurrencyId { get; set; }
    
        /// <summary>
        /// Gets or sets currency code.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currencyCode", Required = Newtonsoft.Json.Required.Default)]
        public string CurrencyCode { get; set; }
    
        /// <summary>
        /// Gets or sets payment terms id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "paymentTermsId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? PaymentTermsId { get; set; }
    
        /// <summary>
        /// Gets or sets payment method id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "paymentMethodId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? PaymentMethodId { get; set; }
    
        /// <summary>
        /// Gets or sets tax liable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "taxLiable", Required = Newtonsoft.Json.Required.Default)]
        public bool? TaxLiable { get; set; }
    
        /// <summary>
        /// Gets or sets blocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "blocked", Required = Newtonsoft.Json.Required.Default)]
        public string Blocked { get; set; }
    
        /// <summary>
        /// Gets or sets balance.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "balance", Required = Newtonsoft.Json.Required.Default)]
        public Decimal? Balance { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets picture.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "picture", Required = Newtonsoft.Json.Required.Default)]
        public IVendorPictureCollectionPage Picture { get; set; }
    
        /// <summary>
        /// Gets or sets currency.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency", Required = Newtonsoft.Json.Required.Default)]
        public Currency Currency { get; set; }
    
        /// <summary>
        /// Gets or sets payment term.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "paymentTerm", Required = Newtonsoft.Json.Required.Default)]
        public PaymentTerm PaymentTerm { get; set; }
    
        /// <summary>
        /// Gets or sets payment method.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "paymentMethod", Required = Newtonsoft.Json.Required.Default)]
        public PaymentMethod PaymentMethod { get; set; }
    
    }
}


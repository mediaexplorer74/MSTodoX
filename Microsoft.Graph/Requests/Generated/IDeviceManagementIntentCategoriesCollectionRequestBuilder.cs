// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IDeviceManagementIntentCategoriesCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementIntentCategoriesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceManagementIntentCategoriesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceManagementIntentCategoriesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDeviceManagementIntentSettingCategoryRequestBuilder"/> for the specified DeviceManagementIntentSettingCategory.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementIntentSettingCategory.</param>
        /// <returns>The <see cref="IDeviceManagementIntentSettingCategoryRequestBuilder"/>.</returns>
        IDeviceManagementIntentSettingCategoryRequestBuilder this[string id] { get; }

        
    }
}

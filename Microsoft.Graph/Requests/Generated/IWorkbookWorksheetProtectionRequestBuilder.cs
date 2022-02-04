// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IWorkbookWorksheetProtectionRequestBuilder.
    /// </summary>
    public partial interface IWorkbookWorksheetProtectionRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IWorkbookWorksheetProtectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IWorkbookWorksheetProtectionRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for WorkbookWorksheetProtectionProtect.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetProtectionProtectRequestBuilder"/>.</returns>
        IWorkbookWorksheetProtectionProtectRequestBuilder Protect(
            WorkbookWorksheetProtectionOptions options = null);

        /// <summary>
        /// Gets the request builder for WorkbookWorksheetProtectionUnprotect.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetProtectionUnprotectRequestBuilder"/>.</returns>
        IWorkbookWorksheetProtectionUnprotectRequestBuilder Unprotect();
    
    }
}

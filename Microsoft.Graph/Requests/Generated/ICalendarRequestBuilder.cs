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
    /// The interface ICalendarRequestBuilder.
    /// </summary>
    public partial interface ICalendarRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new ICalendarRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new ICalendarRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for SingleValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="ICalendarSingleValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        ICalendarSingleValueExtendedPropertiesCollectionRequestBuilder SingleValueExtendedProperties { get; }

        /// <summary>
        /// Gets the request builder for MultiValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="ICalendarMultiValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        ICalendarMultiValueExtendedPropertiesCollectionRequestBuilder MultiValueExtendedProperties { get; }

        /// <summary>
        /// Gets the request builder for Events.
        /// </summary>
        /// <returns>The <see cref="ICalendarEventsCollectionRequestBuilder"/>.</returns>
        ICalendarEventsCollectionRequestBuilder Events { get; }

        /// <summary>
        /// Gets the request builder for CalendarView.
        /// </summary>
        /// <returns>The <see cref="ICalendarCalendarViewCollectionRequestBuilder"/>.</returns>
        ICalendarCalendarViewCollectionRequestBuilder CalendarView { get; }
    
        /// <summary>
        /// Gets the request builder for CalendarGetSchedule.
        /// </summary>
        /// <returns>The <see cref="ICalendarGetScheduleRequestBuilder"/>.</returns>
        ICalendarGetScheduleRequestBuilder GetSchedule(
            IEnumerable<string> Schedules = null,
            DateTimeTimeZone EndTime = null,
            DateTimeTimeZone StartTime = null,
            Int32? AvailabilityViewInterval = null);
    
    }
}

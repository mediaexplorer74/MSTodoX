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
    /// The type DriveItemRequestBuilder.
    /// </summary>
    public partial class DriveItemRequestBuilder : BaseItemRequestBuilder, IDriveItemRequestBuilder
    {

        /// <summary>
        /// Constructs a new DriveItemRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DriveItemRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDriveItemRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDriveItemRequest Request(IEnumerable<Option> options)
        {
            return new DriveItemRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Workbook.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRequestBuilder"/>.</returns>
        public IWorkbookRequestBuilder Workbook
        {
            get
            {
                return new WorkbookRequestBuilder(this.AppendSegmentToRequestUrl("workbook"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Activities.
        /// </summary>
        /// <returns>The <see cref="IDriveItemActivitiesCollectionRequestBuilder"/>.</returns>
        public IDriveItemActivitiesCollectionRequestBuilder Activities
        {
            get
            {
                return new DriveItemActivitiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("activities"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Analytics.
        /// </summary>
        /// <returns>The <see cref="IItemAnalyticsWithReferenceRequestBuilder"/>.</returns>
        public IItemAnalyticsWithReferenceRequestBuilder Analytics
        {
            get
            {
                return new ItemAnalyticsWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("analytics"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Children.
        /// </summary>
        /// <returns>The <see cref="IDriveItemChildrenCollectionRequestBuilder"/>.</returns>
        public IDriveItemChildrenCollectionRequestBuilder Children
        {
            get
            {
                return new DriveItemChildrenCollectionRequestBuilder(this.AppendSegmentToRequestUrl("children"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ListItem.
        /// </summary>
        /// <returns>The <see cref="IListItemRequestBuilder"/>.</returns>
        public IListItemRequestBuilder ListItem
        {
            get
            {
                return new ListItemRequestBuilder(this.AppendSegmentToRequestUrl("listItem"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Permissions.
        /// </summary>
        /// <returns>The <see cref="IDriveItemPermissionsCollectionRequestBuilder"/>.</returns>
        public IDriveItemPermissionsCollectionRequestBuilder Permissions
        {
            get
            {
                return new DriveItemPermissionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("permissions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Subscriptions.
        /// </summary>
        /// <returns>The <see cref="IDriveItemSubscriptionsCollectionRequestBuilder"/>.</returns>
        public IDriveItemSubscriptionsCollectionRequestBuilder Subscriptions
        {
            get
            {
                return new DriveItemSubscriptionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("subscriptions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Thumbnails.
        /// </summary>
        /// <returns>The <see cref="IDriveItemThumbnailsCollectionRequestBuilder"/>.</returns>
        public IDriveItemThumbnailsCollectionRequestBuilder Thumbnails
        {
            get
            {
                return new DriveItemThumbnailsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("thumbnails"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Versions.
        /// </summary>
        /// <returns>The <see cref="IDriveItemVersionsCollectionRequestBuilder"/>.</returns>
        public IDriveItemVersionsCollectionRequestBuilder Versions
        {
            get
            {
                return new DriveItemVersionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("versions"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for Content.
        /// </summary>
        /// <returns>The <see cref="IDriveItemContentRequestBuilder"/>.</returns>
        public IDriveItemContentRequestBuilder Content
        {
            get
            {
                return new DriveItemContentRequestBuilder(this.AppendSegmentToRequestUrl("content"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for DriveItemCheckin.
        /// </summary>
        /// <returns>The <see cref="IDriveItemCheckinRequestBuilder"/>.</returns>
        public IDriveItemCheckinRequestBuilder Checkin(
            string checkInAs = null,
            string comment = null)
        {
            return new DriveItemCheckinRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.checkin"),
                this.Client,
                checkInAs,
                comment);
        }

        /// <summary>
        /// Gets the request builder for DriveItemCheckout.
        /// </summary>
        /// <returns>The <see cref="IDriveItemCheckoutRequestBuilder"/>.</returns>
        public IDriveItemCheckoutRequestBuilder Checkout()
        {
            return new DriveItemCheckoutRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.checkout"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for DriveItemCopy.
        /// </summary>
        /// <returns>The <see cref="IDriveItemCopyRequestBuilder"/>.</returns>
        public IDriveItemCopyRequestBuilder Copy(
            string name = null,
            ItemReference parentReference = null)
        {
            return new DriveItemCopyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.copy"),
                this.Client,
                name,
                parentReference);
        }

        /// <summary>
        /// Gets the request builder for DriveItemCreateLink.
        /// </summary>
        /// <returns>The <see cref="IDriveItemCreateLinkRequestBuilder"/>.</returns>
        public IDriveItemCreateLinkRequestBuilder CreateLink(
            string type,
            string scope = null,
            DateTimeOffset? expirationDateTime = null,
            string password = null,
            string message = null,
            IEnumerable<DriveRecipient> recipients = null)
        {
            return new DriveItemCreateLinkRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.createLink"),
                this.Client,
                type,
                scope,
                expirationDateTime,
                password,
                message,
                recipients);
        }

        /// <summary>
        /// Gets the request builder for DriveItemCreateUploadSession.
        /// </summary>
        /// <returns>The <see cref="IDriveItemCreateUploadSessionRequestBuilder"/>.</returns>
        public IDriveItemCreateUploadSessionRequestBuilder CreateUploadSession(
            DriveItemUploadableProperties item = null,
            bool? deferCommit = null)
        {
            return new DriveItemCreateUploadSessionRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.createUploadSession"),
                this.Client,
                item,
                deferCommit);
        }

        /// <summary>
        /// Gets the request builder for DriveItemFollow.
        /// </summary>
        /// <returns>The <see cref="IDriveItemFollowRequestBuilder"/>.</returns>
        public IDriveItemFollowRequestBuilder Follow()
        {
            return new DriveItemFollowRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.follow"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for DriveItemUnfollow.
        /// </summary>
        /// <returns>The <see cref="IDriveItemUnfollowRequestBuilder"/>.</returns>
        public IDriveItemUnfollowRequestBuilder Unfollow()
        {
            return new DriveItemUnfollowRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.unfollow"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for DriveItemInvite.
        /// </summary>
        /// <returns>The <see cref="IDriveItemInviteRequestBuilder"/>.</returns>
        public IDriveItemInviteRequestBuilder Invite(
            IEnumerable<DriveRecipient> recipients,
            bool? requireSignIn = null,
            IEnumerable<string> roles = null,
            bool? sendInvitation = null,
            string message = null,
            string expirationDateTime = null,
            string password = null)
        {
            return new DriveItemInviteRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.invite"),
                this.Client,
                recipients,
                requireSignIn,
                roles,
                sendInvitation,
                message,
                expirationDateTime,
                password);
        }

        /// <summary>
        /// Gets the request builder for DriveItemPreview.
        /// </summary>
        /// <returns>The <see cref="IDriveItemPreviewRequestBuilder"/>.</returns>
        public IDriveItemPreviewRequestBuilder Preview(
            string viewer = null,
            bool? chromeless = null,
            bool? allowEdit = null,
            string page = null,
            double? zoom = null)
        {
            return new DriveItemPreviewRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.preview"),
                this.Client,
                viewer,
                chromeless,
                allowEdit,
                page,
                zoom);
        }

        /// <summary>
        /// Gets the request builder for DriveItemRestore.
        /// </summary>
        /// <returns>The <see cref="IDriveItemRestoreRequestBuilder"/>.</returns>
        public IDriveItemRestoreRequestBuilder Restore(
            ItemReference parentReference = null,
            string name = null)
        {
            return new DriveItemRestoreRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.restore"),
                this.Client,
                parentReference,
                name);
        }

        /// <summary>
        /// Gets the request builder for DriveItemValidatePermission.
        /// </summary>
        /// <returns>The <see cref="IDriveItemValidatePermissionRequestBuilder"/>.</returns>
        public IDriveItemValidatePermissionRequestBuilder ValidatePermission(
            string password,
            string challengeToken = null)
        {
            return new DriveItemValidatePermissionRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.validatePermission"),
                this.Client,
                password,
                challengeToken);
        }

        /// <summary>
        /// Gets the request builder for DriveItemDelta.
        /// </summary>
        /// <returns>The <see cref="IDriveItemDeltaRequestBuilder"/>.</returns>
        public IDriveItemDeltaRequestBuilder Delta(
            string token = null)
        {
            return new DriveItemDeltaRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.delta"),
                this.Client,
                token);
        }

        /// <summary>
        /// Gets the request builder for DriveItemDelta.
        /// </summary>
        /// <returns>The <see cref="IDriveItemDeltaRequestBuilder"/>.</returns>
        public IDriveItemDeltaRequestBuilder Delta()
        {
            return new DriveItemDeltaRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.delta"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for DriveItemGetActivitiesByInterval.
        /// </summary>
        /// <returns>The <see cref="IDriveItemGetActivitiesByIntervalRequestBuilder"/>.</returns>
        public IDriveItemGetActivitiesByIntervalRequestBuilder GetActivitiesByInterval()
        {
            return new DriveItemGetActivitiesByIntervalRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getActivitiesByInterval"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for DriveItemSearch.
        /// </summary>
        /// <returns>The <see cref="IDriveItemSearchRequestBuilder"/>.</returns>
        public IDriveItemSearchRequestBuilder Search(
            string q = null)
        {
            return new DriveItemSearchRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.search"),
                this.Client,
                q);
        }
    
    }
}

using System;
using System.Collections.Generic;
using MrCMS.Entities.Documents;
using MrCMS.Entities.Documents.Metadata;
using MrCMS.Web.Apps.SocialEvents.Pages;

namespace MrCMS.Web.Apps.SocialEvents.Metadata
{
    public class SocialEventListMetaData : DocumentMetadataMap<SocialEventList>
    {
        public override string WebGetController
        {
            get { return "SocialEvent"; }
        }
        public override string IconClass
        {
            get { return "glyphicon glyphicon-th-list"; }
        }
        
        public override ChildrenListType ChildrenListType
        {
            get { return ChildrenListType.WhiteList; }
        }

        public override IEnumerable<Type> ChildrenList
        {
            get { yield return typeof(Pages.SocialEvent); }
        }

        public override string DefaultLayoutName
        {
            get { return "Two Column"; }
        }

        public override SortBy SortBy
        {
            get
            {
                return SortBy.PublishedOn;
            }
        }

        public override int MaxChildNodes
        {
            get { return 5; }
        }
    }
}


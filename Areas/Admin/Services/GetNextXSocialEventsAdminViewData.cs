using System.Web.Mvc;
using MrCMS.Helpers;
using MrCMS.Web.Apps.SocialEvents.Pages;
using MrCMS.Web.Apps.SocialEvents.Widgets;
using MrCMS.Web.Areas.Admin.Services;
using MrCMS.Website;
using NHibernate;

namespace MrCMS.Web.Apps.SocialEvents.Areas.Admin.Services
{
    public class GetNextXSocialEventsAdminViewData : BaseAssignWidgetAdminViewData<NextXSocialEvents>
    {
        private readonly ISession _session;

        public GetNextXSocialEventsAdminViewData(ISession session)
        {
            _session = session;
        }

        public override void AssignViewData(NextXSocialEvents widget, ViewDataDictionary viewData)
        {
            viewData["socialEventsList"] = _session.QueryOver<SocialEventList>()
                .Where(socialEvent => socialEvent.PublishOn != null && socialEvent.PublishOn <= CurrentRequestData.Now)
                .Cacheable()
                .List()
                .BuildSelectItemList(item => item.Name,
                    item => item.Id.ToString(),
                    emptyItemText: "Please select social events list");
        }
    }
}
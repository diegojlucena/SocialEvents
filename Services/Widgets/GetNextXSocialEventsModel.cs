using MrCMS.Services.Widgets;
using MrCMS.Web.Apps.SocialEvents.Models;
using MrCMS.Web.Apps.SocialEvents.Pages;
using MrCMS.Web.Apps.SocialEvents.Widgets;
using MrCMS.Website;
using NHibernate;

namespace MrCMS.Web.Apps.SocialEvents.Services.Widgets
{
    public class GetNextXSocialEventsModel : GetWidgetModelBase<NextXSocialEvents>
    {
        private readonly ISession _session;

        public GetNextXSocialEventsModel(ISession session)
        {
            _session = session;
        }

        public override object GetModel(NextXSocialEvents widget)
        {
            if (widget.RelatedSocialEventList == null)
                return null;


            return new NextXSocialEventsViewModel
            {
                SocialEvents = _session.QueryOver<SocialEvent>()
                    .Where(socialEvent => socialEvent.Parent.Id == widget.RelatedSocialEventList.Id && socialEvent.PublishOn != null && socialEvent.EndsAt >= CurrentRequestData.Now)
                    .OrderBy(x => x.BeginsAt).Asc
                    .Take(widget.NumberOfSocialEvents)
                    .Cacheable()
                    .List(),
                Title = widget.Name
            };
        }
    }
}
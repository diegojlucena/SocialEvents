using System;
using MrCMS.Helpers;
using MrCMS.Paging;
using MrCMS.Web.Apps.SocialEvents.Models;
using MrCMS.Web.Apps.SocialEvents.Pages;
using NHibernate;

namespace MrCMS.Web.Apps.SocialEvents.Services
{
    public class SocialEventService : ISocialEventService
    {
        private readonly ISession _session;

        public SocialEventService(ISession session)
        {
            _session = session;
        }

        public IPagedList<SocialEvent> GetSocialEvents(SocialEventList page, SocialEventSearchModel model)
        {
            
            var query = _session.QueryOver<SocialEvent>()
                                .Where(a => a.Parent == page && a.EndsAt >= DateTime.Today);

            

            return query.OrderBy(x => x.BeginsAt).Asc.Paged(model.Page, page.PageSize);
        }

        
    }
}
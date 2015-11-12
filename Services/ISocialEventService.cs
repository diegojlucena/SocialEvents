using MrCMS.Paging;
using MrCMS.Web.Apps.SocialEvents.Models;
using MrCMS.Web.Apps.SocialEvents.Pages;

namespace MrCMS.Web.Apps.SocialEvents.Services
{
    public interface ISocialEventService
    {
        IPagedList<SocialEvent> GetSocialEvents(SocialEventList page, SocialEventSearchModel model);
    }
}

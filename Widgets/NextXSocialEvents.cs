using MrCMS.Entities.Widget;
using MrCMS.Web.Apps.SocialEvents.Pages;
using MrCMS.Website;

namespace MrCMS.Web.Apps.SocialEvents.Widgets
{
    [OutputCacheable]
    public class NextXSocialEvents : Widget
    {
        public virtual int NumberOfSocialEvents { get; set; }
        public virtual SocialEventList RelatedSocialEventList { get; set; }
    }
}
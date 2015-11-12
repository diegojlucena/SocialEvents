using System.Collections.Generic;
using MrCMS.Web.Apps.SocialEvents.Pages;

namespace MrCMS.Web.Apps.SocialEvents.Models
{
    public class NextXSocialEventsViewModel
    {
        public IList<SocialEvent> SocialEvents { get; set; }
        public string Title { get; set; }
    }
}
using System.Web.Mvc;
using MrCMS.Web.Apps.SocialEvents.ModelBinders;
using MrCMS.Web.Apps.SocialEvents.Models;
using MrCMS.Web.Apps.SocialEvents.Pages;
using MrCMS.Web.Apps.SocialEvents.Services;
using MrCMS.Website.Binders;
using MrCMS.Website.Controllers;

namespace MrCMS.Web.Apps.SocialEvents.Controllers
{
    public class SocialEventController : MrCMSAppUIController<SocialEventsApp>
    {
        private readonly ISocialEventService _socialEventService;

        public SocialEventController(ISocialEventService socialEventService)
        {
            _socialEventService = socialEventService;
        }

        public ActionResult Show(SocialEventList page, [IoCModelBinder(typeof(SocialEventListModelBinder))]SocialEventSearchModel model)
        {
            ViewData["paged-socialevents"] = _socialEventService.GetSocialEvents(page,model);
            return View(page);
        }
    }
}
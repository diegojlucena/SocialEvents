using System.Web.Mvc;
using MrCMS.Web.Apps.SocialEvents.Models;
using MrCMS.Website.Binders;
using Ninject;

namespace MrCMS.Web.Apps.SocialEvents.ModelBinders
{
    public class SocialEventListModelBinder : MrCMSDefaultModelBinder
    {
        public SocialEventListModelBinder(IKernel kernel)
            : base(kernel)
        {
        }

        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            int page;
            int.TryParse(GetValueFromContext(controllerContext, "page"), out page);
            
            return new SocialEventSearchModel
                       {
                           Page = page,
                       };
        }
    }
}
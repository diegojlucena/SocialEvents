using MrCMS.Apps;
using MrCMS.Entities.Multisite;
using MrCMS.Installation;
using NHibernate;
using Ninject;

namespace MrCMS.Web.Apps.SocialEvents
{
    public class SocialEventsApp : MrCMSApp
    {
        public override string AppName
        {
            get { return "SocialEvents"; }
        }

        public override string Version
        {
            get { return "0.1"; }
        }

        protected override void RegisterServices(IKernel kernel)
        {
            
        }

        protected override void RegisterApp(MrCMSAppRegistrationContext context)
        {
        }
    }
}
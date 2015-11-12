using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using MrCMS.Web.Apps.SocialEvents.Pages;

namespace MrCMS.Web.Apps.SocialEvents.DbConfiguration
{
    public class SocialEventOverride : IAutoMappingOverride<SocialEvents.Pages.SocialEvent>
    {
        public void Override(AutoMapping<SocialEvent> mapping)
        {
            mapping.Map(item => item.Location).Length(500);
        }
    }
}
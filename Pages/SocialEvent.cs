using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MrCMS.Web.Apps.Core.Pages;

namespace MrCMS.Web.Apps.SocialEvents.Pages
{
    public class SocialEvent : TextPage
    {
        [StringLength(500, ErrorMessage = "Location cannot be longer than 500 characters.")]
        public virtual string Location { get; set; }

        [DataType(DataType.DateTime)]
        [UIHint("DateTime")]
        [DisplayName("Begins At")]
        public virtual DateTime? BeginsAt { get; set; }

        [DataType(DataType.DateTime)]
        [UIHint("DateTime")]
        [DisplayName("Ends At")]
        public virtual DateTime? EndsAt { get; set; }

        [DisplayName("Website")]
        [DataType(DataType.Url)]
        public virtual string Website { get; set; }
    }
}
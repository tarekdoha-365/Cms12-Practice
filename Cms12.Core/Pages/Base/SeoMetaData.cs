using Cms12.Core.Resources;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms12.Core.Pages.Base
{
    public class SeoMetaData : PageData
    {
        [Display(
        Name = "MetaDescrption",
        Description = GlobalConstants.TabNames.Seo,
        Order = 50
        )]
        public virtual string MetaDescription { get; set; }
        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            MetaDescription = "A responsive HTML5 site template. Manufactured by HTML5 UP.";
        }
    }
}

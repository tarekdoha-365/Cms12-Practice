using Cms12.Core.Pages.Base;
using Cms12.Core.Resources;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms12.Core.Pages
{
    [ContentType(
        DisplayName = "Blog Page",
        GUID = "032f5caa-f3f3-4802-8b5d-984831afffbd",
        GroupName = GlobalConstants.GroupName.Blog
        )]
    public class BlogPage : SeoMetaData
    {
        [Display(
            Name = "Title",
            GroupName = SystemTabNames.Content,
            Order =50
            )]
        public virtual string Title { get; set; }

        [Display(
            Name = "Sub Title",
            GroupName = SystemTabNames.Content,
            Order = 100
            )]
        public virtual string SubTitle { get; set; }

        [Display(
            Name= "Content",
            GroupName = SystemTabNames.Content,
            Order = 150
            )]
        public virtual XhtmlString Content { get; set; }

        [Display(
            Name="Blog Image",
            GroupName = SystemTabNames.Content,
            Order = 200
            )]
        public virtual ContentReference BlogImage { get; set; }
    }
}

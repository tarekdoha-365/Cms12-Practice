using Cms12.Core.Pages.Base;
using Cms12.Core.Resources;
using EPiServer.DataAnnotations;

namespace Cms12.Core.Pages
{
    [ContentType(
        DisplayName = "Blog Listing Page",
        GUID = "c7989fa4-f0a5-440a-86dd-7f867b82facb",
        GroupName =GlobalConstants.GroupName.Blog
        )]
    [ImageUrl("/images/pic01.jpg")]
    [AvailableContentTypes(Include = new[] { typeof(BlogPage) })]
    public class BlogListingPage : SeoMetaData
    {
    }
}
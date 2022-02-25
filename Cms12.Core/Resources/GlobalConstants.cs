using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms12.Core.Resources
{
    public static class GlobalConstants
    {
        [GroupDefinitions]
        public static class TabNames
        {
            public const string Seo = "Seo";
        }
        public static class GroupName
        {
            public const string Common = "Common";
            public const string Blog = "Blog";
        }
    }
}

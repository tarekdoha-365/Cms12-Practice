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
    [ContentType(GUID = "0b6d46cf-9676-40e4-a292-55ebd0b65313", DisplayName ="Homepage")]
    public class Homepage: PageData
    {
        [Display(Order = 100, GroupName = SystemTabNames.Content)]
        public virtual ContentArea Main { get; set; }
    }
}

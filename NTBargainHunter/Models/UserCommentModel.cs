
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NTBargainHunter.Models
{
    public class UserCommentsModel 
    {
        public int BlogPostID { get; set; }

        public string ItemID { get; set; }

    //    [Column(TypeName = "ntext")]
        
        public string Body { get; set; }

    }
}
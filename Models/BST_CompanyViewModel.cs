using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BizSolTracker.Reporting.Models
{
    public class BST_CompanyViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
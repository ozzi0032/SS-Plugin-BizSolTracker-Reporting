using SmartStore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BizSolTracker.Reporting.Models
{
    public class BST_Company_Customer_MappingModel : BaseEntity
    {
        public int CompanyId { get; set; }
        public int CustomerId { get; set; }
    }
}
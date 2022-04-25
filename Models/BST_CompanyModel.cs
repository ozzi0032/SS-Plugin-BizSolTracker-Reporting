using SmartStore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BizSolTracker.Reporting.Models
{
    public class BST_CompanyModel : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string KeyRef { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string TimeZone { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedOnUtc { get; set; }
        public Nullable<DateTime> UpdatedOnUtc { get; set; } = null;
        public Nullable<DateTime> DeletedOnUtc { get; set; } = null;
        public int ModifiedBy { get; set; }
        public int CreatedBy { get; set; }
    }
}
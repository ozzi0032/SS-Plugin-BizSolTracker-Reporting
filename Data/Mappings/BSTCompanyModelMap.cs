using BizSolTracker.Reporting.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BizSolTracker.Reporting.Data.Mappings
{
    public class BSTCompanyModelMap : EntityTypeConfiguration<BST_CompanyModel>
    {
        public BSTCompanyModelMap()
        {
            ToTable("BST_Company");
            HasKey(r => r.Id);
        }
    }
}
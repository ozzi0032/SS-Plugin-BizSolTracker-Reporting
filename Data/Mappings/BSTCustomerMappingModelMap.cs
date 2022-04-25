using BizSolTracker.Reporting.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BizSolTracker.Reporting.Data.Mappings
{
    public class BSTCustomerMappingModelMap : EntityTypeConfiguration<BST_Company_Customer_MappingModel>
    {
        public BSTCustomerMappingModelMap()
        {
            ToTable("BST_Company_Customer_Mapping");
            HasKey(r => r.Id);
        }
    }
}
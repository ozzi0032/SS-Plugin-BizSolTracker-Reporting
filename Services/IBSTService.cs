using BizSolTracker.Reporting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BizSolTracker.Reporting.Services
{
    public partial interface IBSTService
    {
        void InsertCompanyInfo(BST_CompanyModel model);
        BST_CompanyModel GetCompanyInfo(int customerId);
        void InsertCustomerMapping(BST_Company_Customer_MappingModel model);
    }
}
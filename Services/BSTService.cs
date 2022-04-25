using BizSolTracker.Reporting.Models;
using SmartStore.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BizSolTracker.Reporting.Services
{
    public partial class BSTService : IBSTService
    {
        private readonly IRepository<BST_CompanyModel> _bstCompanyRepo;
        private readonly IRepository<BST_Company_Customer_MappingModel> _bstCustomerMappingRepo;

        public BSTService(IRepository<BST_CompanyModel> bstRepository,IRepository<BST_Company_Customer_MappingModel> customerMappingRepo)
        {
            _bstCompanyRepo = bstRepository;
            _bstCustomerMappingRepo = customerMappingRepo;
        }

        public void InsertCompanyInfo(BST_CompanyModel model)
        {
            try
            {
                if (model.Id == 0)
                {
                    _bstCompanyRepo.Insert(model);
                }
                else
                {
                    _bstCompanyRepo.Update(model);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public BST_CompanyModel GetCompanyInfo(int customerId)
        {
            try
            {
                var bst_companyModel = _bstCompanyRepo.Table.Where(company => company.CreatedBy == customerId).First();
                return bst_companyModel;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void InsertCustomerMapping(BST_Company_Customer_MappingModel model)
        {
            try
            {
                if (model.Id == 0)
                {
                    _bstCustomerMappingRepo.Insert(model);
                }
                else
                {
                    _bstCustomerMappingRepo.Update(model);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
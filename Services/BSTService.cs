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

        public BST_CompanyModel GetCompanyInfoByKey(string key)
        {
            try
            {
                var bst_companyModel = _bstCompanyRepo.Table.Where(company => company.KeyRef == key).First();
                return bst_companyModel;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public BST_CompanyModel GetCompanyInfoByUserId(int id)
        {
            try
            {
                var bst_companyModel = _bstCompanyRepo.Table.Where(company => company.CreatedBy == id).First();
                return bst_companyModel;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IQueryable<BST_CompanyModel> GetCompanyInfoList()
        {
            try
            {
                var list = _bstCompanyRepo.Table.Where(company => company.DeletedOnUtc == null);
                return list;
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

        public IQueryable<BST_Company_Customer_MappingModel> GetCustomerMapping(int companyId)
        {
            try
            {
                var list = _bstCustomerMappingRepo.Table.Where(mapping => mapping.CompanyId == companyId);
                return list;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using BizSolTracker.Reporting.Data;
using BizSolTracker.Reporting.Filters;
using BizSolTracker.Reporting.Models;
using BizSolTracker.Reporting.Services;
using SmartStore.Core.Data;
using SmartStore.Core.Infrastructure;
using SmartStore.Core.Infrastructure.DependencyManagement;
using SmartStore.Data;
using SmartStore.Web.Controllers;

namespace BizSolTracker.Reporting
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder, bool isActiveModule)
        {
            if (!isActiveModule && DataSettings.DatabaseIsInstalled())
                return;

            builder.Register<IDbContext>(c => new BSTReportingObjectContext(DataSettings.Current.DataConnectionString))
                           .Named<IDbContext>(BSTReportingObjectContext.ALIASKEY)
                           .InstancePerRequest();

            builder.RegisterType<BSTService>().As<IBSTService>().InstancePerRequest();

            builder.RegisterType<TrackerReportingFilter>()
                    .AsActionFilterFor<CustomerController>().InstancePerRequest();

            builder.RegisterType<EfRepository<BST_CompanyModel>>()
                .As<IRepository<BST_CompanyModel>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>(BSTReportingObjectContext.ALIASKEY))
                .InstancePerRequest();
            builder.RegisterType<EfRepository<BST_Company_Customer_MappingModel>>()
                .As<IRepository<BST_Company_Customer_MappingModel>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>(BSTReportingObjectContext.ALIASKEY))
                .InstancePerRequest();

        }

        public int Order
        {
            get { return 1; }
        }
    }
}
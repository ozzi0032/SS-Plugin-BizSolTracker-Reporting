using BizSolTracker.Reporting.Data.Mappings;
using SmartStore.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BizSolTracker.Reporting.Data
{
    public class BSTReportingObjectContext : ObjectContextBase
    {
		public const string ALIASKEY = "bs_object_context_bstreporting";
		/// <summary>
		/// For tooling support, e.g. EF Migrations
		/// </summary>
		public BSTReportingObjectContext(string nameOrConnectionString)
			: base(nameOrConnectionString, ALIASKEY)
		{
			AutoCommitEnabled = true;
		}
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new BSTCompanyModelMap());
			modelBuilder.Configurations.Add(new BSTCustomerMappingModelMap());

			Database.SetInitializer<BSTReportingObjectContext>(null);
			base.OnModelCreating(modelBuilder);
		}
	}
}

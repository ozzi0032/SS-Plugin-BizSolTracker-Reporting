using System.Linq;
using BizSolTracker.Reporting.Models;
using SmartStore.Core.Data;
using System.Collections.Generic;

namespace BizSolTracker.Reporting.Services
{
    public class EmailNotificationService
    {
        private readonly IDbContext _context;

        public EmailNotificationService(IDbContext dbContext)
        {
            _context = dbContext;
        }

        public List<RegNotificationModel> GetMessageTemplates()
        {
            var query = @"select id, name from MessageTemplate where isactive = 1 and name like 'RegConfirmation.%'";
            var templates = _context.SqlQuery<RegNotificationModel>(query).ToList();
            return templates;
        }

        public string GetMessageTemplateNameById(int messageTemplateId)
        {
            var query = @"select name from MessageTemplate where Id = " + messageTemplateId.ToString();
            var messageTemplate = _context.SqlQuery<string>(query).ToList();
            return messageTemplate.FirstOrDefault();
        }
    }
}
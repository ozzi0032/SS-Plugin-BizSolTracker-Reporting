using SmartStore;
using SmartStore.Core.Domain.Messages;
using SmartStore.Services.Messages;

namespace BizSolTracker.Reporting.Notification
{
    public partial class EmailNotificationExtension
    {
        //public  CreateMessageResult SendRegConfirmationNotification(this IMessageFactory factory,
        //MessageContext messageContext, string toAddress, string firmName, string message)
        //{
        //    var model = new NamedModelPart("RegConfirmation")
        //    {
        //        ["ToAddress"] = toAddress.NullEmpty(),
        //        ["FirmName"] = firmName.NullEmpty(),
        //        ["Message"] = message.NullEmpty()
        //    };
        //    return factory.CreateMessage(messageContext, true, model);
        //}
    }
}
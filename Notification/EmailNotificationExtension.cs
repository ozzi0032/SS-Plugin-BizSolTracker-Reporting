using SmartStore;
using SmartStore.Core.Domain.Messages;
using SmartStore.Services.Messages;

namespace BizSolTracker.Reporting.Notification
{
    public static class EmailNotificationExtension
    {
        //Send Registration Invitation Link with Company Reference Keys 

        public static CreateMessageResult SendRegInvitationNotification(this IMessageFactory factory,
        MessageContext messageContext, string toAddress, string firmName, string url)
        {
            var model = new NamedModelPart("RegInvitation")
            {
                ["ToAddress"] = toAddress.NullEmpty(),
                ["FirmName"] = firmName.NullEmpty(),
                ["Url"] = url.NullEmpty()
            };
            return factory.CreateMessage(messageContext, true, model);
        }

        //Sends a registration confirmation message

        public static CreateMessageResult SendRegConfirmationNotification(this IMessageFactory factory,
        MessageContext messageContext, string toAddress, string firmName, string message)
        {
            var model = new NamedModelPart("RegConfirmation")
            {
                ["ToAddress"] = toAddress.NullEmpty(),
                ["FirmName"] = firmName.NullEmpty(),
                ["Message"] = message.NullEmpty()
            };
            return factory.CreateMessage(messageContext, true, model);
        }
    }
}
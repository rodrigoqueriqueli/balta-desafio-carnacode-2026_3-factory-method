

namespace DesignPatternChallenge
{
    public class WhatsAppNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new WhatsAppNotification();
        }
    }
}
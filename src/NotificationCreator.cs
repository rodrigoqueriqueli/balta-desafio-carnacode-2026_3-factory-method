// DESAFIO: Sistema de Notificações Multi-Canal
// PROBLEMA: Uma aplicação de e-commerce precisa enviar notificações por diferentes canais
// (Email, SMS, Push, WhatsApp) dependendo da preferência do cliente e tipo de notificação
// O código atual viola o Open/Closed Principle ao usar condicionais para criar notificações

namespace DesignPatternChallenge
{
    public abstract class NotificationCreator
    {
        public abstract INotification CreateNotification();

        public void SendOrderConfirmation(string recipient, string orderNumber)
        {
            var notification = CreateNotification();
            notification.SendOrderConfirmation(recipient, orderNumber);
        }

        public void SendShippingUpdate(string recipient, string trackingCode)
        {
            var notification = CreateNotification();
            notification.SendShippingUpdate(recipient, trackingCode);
        }

        public void SendPaymentReminder(string recipient, decimal amount)
        {
            var notification = CreateNotification();
            notification.SendPaymentReminder(recipient, amount);
        }
    }
}
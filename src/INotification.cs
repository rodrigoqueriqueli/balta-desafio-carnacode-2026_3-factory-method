// DESAFIO: Sistema de Notificações Multi-Canal
// PROBLEMA: Uma aplicação de e-commerce precisa enviar notificações por diferentes canais
// (Email, SMS, Push, WhatsApp) dependendo da preferência do cliente e tipo de notificação
// O código atual viola o Open/Closed Principle ao usar condicionais para criar notificações

namespace DesignPatternChallenge
{
    public interface INotification
    {
        void SendOrderConfirmation(string recipient, string orderNumber);

        void SendShippingUpdate(string recipient, string trackingCode);

        void SendPaymentReminder(string recipient, decimal amount);

    }
}
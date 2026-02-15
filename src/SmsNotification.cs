// DESAFIO: Sistema de Notificações Multi-Canal
// PROBLEMA: Uma aplicação de e-commerce precisa enviar notificações por diferentes canais
// (Email, SMS, Push, WhatsApp) dependendo da preferência do cliente e tipo de notificação
// O código atual viola o Open/Closed Principle ao usar condicionais para criar notificações

namespace DesignPatternChallenge
{
    public class SmsNotification : INotification
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public void Send() { }
        public void SendOrderConfirmation(string recipient, string orderNumber)
        {
            PhoneNumber = recipient;
            Message = $"Pedido {orderNumber} confirmado!";

            Console.WriteLine($"📱 Enviando SMS para {PhoneNumber}");
            Console.WriteLine($"   Mensagem: {Message}");
        }

        public void SendPaymentReminder(string recipient, decimal amount)
        {
            PhoneNumber = recipient;
            Message = $"Pagamento pendente: R$ {amount:N2}";

            Console.WriteLine($"📱 Enviando SMS para {PhoneNumber}");
            Console.WriteLine($"   Mensagem: {Message}");
        }

        public void SendShippingUpdate(string recipient, string trackingCode)
        {
            PhoneNumber = recipient;
            Message = $"Pedido enviado! Rastreamento: {trackingCode}";

            Console.WriteLine($"📱 Enviando SMS para {PhoneNumber}");
            Console.WriteLine($"   Mensagem: {Message}");
        }
    }
}
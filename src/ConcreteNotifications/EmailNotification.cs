// DESAFIO: Sistema de Notificações Multi-Canal
// PROBLEMA: Uma aplicação de e-commerce precisa enviar notificações por diferentes canais
// (Email, SMS, Push, WhatsApp) dependendo da preferência do cliente e tipo de notificação
// O código atual viola o Open/Closed Principle ao usar condicionais para criar notificações

namespace DesignPatternChallenge
{
    // Classes concretas de notificação
    public class EmailNotification : INotification
    {
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsHtml { get; set; }


        public void SendOrderConfirmation(string recipient, string orderNumber)
        {
            Recipient = recipient;
            Subject = "Confirmação de Pedido";
            Body = $"Seu pedido {orderNumber} foi confirmado!";
            IsHtml = true;

            PrintNotification();
        }

        public void SendPaymentReminder(string recipient, decimal amount)
        {
            Recipient = recipient;
            Subject = "Lembrete de Pagamento";
            Body = $"Você tem um pagamento pendente de R$ {amount:N2}";
            IsHtml = true;


            PrintNotification();
        }

        public void SendShippingUpdate(string recipient, string trackingCode)
        {
            Recipient = recipient;
            Subject = "Pedido Enviado";
            Body = $"Seu pedido foi enviado! Código de rastreamento: {trackingCode}";
            IsHtml = true;

            PrintNotification();
        }

        public void PrintNotification()
        {
            Console.WriteLine($"📧 Enviando Email para {Recipient}");
            Console.WriteLine($"   Assunto: {Subject}");
            Console.WriteLine($"   Mensagem: {Body}");
        }
    }
}
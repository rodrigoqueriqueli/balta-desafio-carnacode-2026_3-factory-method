

namespace DesignPatternChallenge
{
    public class WhatsAppNotification : INotification
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public bool UseTemplate { get; set; }


        public void SendOrderConfirmation(string recipient, string orderNumber)
        {
            PhoneNumber = recipient;
            Message = $"✅ Seu pedido {orderNumber} foi confirmado!";
            UseTemplate = true;

            PrintNotification();
        }

        public void SendPaymentReminder(string recipient, decimal amount)
        {
            PhoneNumber = recipient;
            Message = $"Você tem um pagamento pendente de R$ {amount:N2}";
            UseTemplate = true;

            PrintNotification();
        }

        public void SendShippingUpdate(string recipient, string trackingCode)
        {
            PhoneNumber = recipient;
            Message = $"📦 Pedido enviado! Rastreamento: {trackingCode}";
            UseTemplate = true;

            PrintNotification();
        }

        public void PrintNotification()
        {
            Console.WriteLine($"💬 Enviando WhatsApp para {PhoneNumber}");
            Console.WriteLine($"   Mensagem: {Message}");
            Console.WriteLine($"   Template: {UseTemplate}");
        }
    }
}
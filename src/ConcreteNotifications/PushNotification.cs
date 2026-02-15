
namespace DesignPatternChallenge
{
    public class PushNotification : INotification
    {
        public string DeviceToken { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public int Badge { get; set; }

        public void SendOrderConfirmation(string recipient, string orderNumber)
        {
            DeviceToken = recipient;
            Title = "Pedido Confirmado";
            Message = $"Pedido {orderNumber} confirmado!";
            Badge = 1;

            PrintNotification();
        }

        public void SendPaymentReminder(string recipient, decimal amount)
        {
            DeviceToken = recipient;
            Message = $"Você tem um pagamento pendente de R$ {amount:N2}";
            Title = "Pagamento Pendente";
            Badge = 1;

            PrintNotification();
        }

        public void SendShippingUpdate(string recipient, string trackingCode)
        {
           DeviceToken = recipient;
           Title = "Pedido Enviado";
           Message = $"Rastreamento: {trackingCode}";
           Badge = 1;

            PrintNotification();
        }

        public void PrintNotification()
        {
            Console.WriteLine($"🔔 Enviando Push para dispositivo {DeviceToken}");
            Console.WriteLine($"   Título: {Title}");
            Console.WriteLine($"   Mensagem: {Message}");
        }
    }
}
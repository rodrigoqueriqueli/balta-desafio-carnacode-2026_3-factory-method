// DESAFIO: Sistema de Notificações Multi-Canal
// PROBLEMA: Uma aplicação de e-commerce precisa enviar notificações por diferentes canais
// (Email, SMS, Push, WhatsApp) dependendo da preferência do cliente e tipo de notificação
// O código atual viola o Open/Closed Principle ao usar condicionais para criar notificações

using System;

namespace DesignPatternChallenge
{
    // Contexto: Sistema de notificações que envia mensagens para clientes
    // Cada tipo de notificação tem requisitos e formatação diferentes

    public class NotificationManager
    {
        public void SendOrderConfirmation(string recipient, string orderNumber, string notificationType)
        {

            if (notificationType == "email")
            {
                NotificationCreator creator = new EmailNotificationCreator();
                creator.SendOrderConfirmation(recipient, orderNumber);
            }
            else if (notificationType == "sms")
            {
                NotificationCreator creator = new SmsNotificationCreator();
                creator.SendOrderConfirmation(recipient, orderNumber);
            }
            else if (notificationType == "push")
            {
                NotificationCreator creator = new PushNotificationCreator();
                creator.SendOrderConfirmation(recipient, orderNumber);
            }
            else if (notificationType == "whatsapp")
            {
                NotificationCreator creator = new WhatsAppNotificationCreator();
                creator.SendOrderConfirmation(recipient, orderNumber);
            }
            else
            {
                throw new ArgumentException($"Tipo de notificação '{notificationType}' não suportado");
            }
        }

        public void SendShippingUpdate(string recipient, string trackingCode, string notificationType)
        {
            // Problema: Código duplicado - mesma estrutura condicional repetida
            if (notificationType == "email")
            {
                NotificationCreator creator = new EmailNotificationCreator();
                creator.SendShippingUpdate(recipient, trackingCode);
            }
            else if (notificationType == "sms")
            {
                NotificationCreator creator = new SmsNotificationCreator();
                creator.SendShippingUpdate(recipient, trackingCode);
            }
            else if (notificationType == "push")
            {
                NotificationCreator creator = new PushNotificationCreator();
                creator.SendShippingUpdate(recipient, trackingCode);
            }
            else if (notificationType == "whatsapp")
            {
                NotificationCreator creator = new WhatsAppNotificationCreator();
                creator.SendShippingUpdate(recipient, trackingCode);
            }
        }

        public void SendPaymentReminder(string recipient, decimal amount, string notificationType)
        {
            // Problema: Cada novo método repete a mesma lógica condicional
            if (notificationType == "email")
            {
                NotificationCreator creator = new EmailNotificationCreator();
                creator.SendPaymentReminder(recipient, amount);
            }
            else if (notificationType == "sms")
            {
                NotificationCreator creator = new SmsNotificationCreator();
                creator.SendPaymentReminder(recipient, amount);
            }
            else if (notificationType == "push")
            {
                NotificationCreator creator = new PushNotificationCreator();
                creator.SendPaymentReminder(recipient, amount);
            }
            else if (notificationType == "whatsapp")
            {
                NotificationCreator creator = new WhatsAppNotificationCreator();
                creator.SendPaymentReminder(recipient, amount);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Notificações ===\n");

            var manager = new NotificationManager();

            // Cliente 1 prefere Email
            manager.SendOrderConfirmation("cliente@email.com", "12345", "email");
            Console.WriteLine();

            // Cliente 2 prefere SMS
            manager.SendOrderConfirmation("+5511999999999", "12346", "sms");
            Console.WriteLine();

            // Cliente 3 prefere Push
            manager.SendShippingUpdate("device-token-abc123", "BR123456789", "push");
            Console.WriteLine();

            // Cliente 4 prefere WhatsApp
            manager.SendPaymentReminder("+5511888888888", 150.00m, "whatsapp");

            // Perguntas para reflexão:
            // - Como adicionar novos tipos de notificação (Telegram, Slack) sem modificar NotificationManager?
            // - Como evitar duplicação da lógica condicional em cada método?
            // - Como permitir que subclasses decidam qual tipo de notificação criar?
            // - Como tornar o código mais extensível e manutenível?
        }
    }
}
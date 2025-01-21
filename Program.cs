using Azure.Messaging.ServiceBus;

namespace ServiceBusEmualtorTest
{
    class Program
    {
        private const string ConnectionString = "Endpoint=sb://localhost:5672;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=localkey;UseDevelopmentEmulator=true;";
        private const string QueueName = "queue.1";

        static async Task Main(string[] args)
        {
            Console.WriteLine("Service Bus Emulator Test");
            Console.WriteLine("1. Send a message");
            Console.WriteLine("2. Receive messages");
            Console.Write("Choose an option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    await SendMessageAsync();
                    break;
                case "2":
                    await ReceiveMessagesAsync();
                    break;
                default:
                    Console.WriteLine("Invalid option. Exiting...");
                    break;
            }
        }

        private static async Task SendMessageAsync()
        {
            Console.Write("Enter the message to send: ");
            var messageContent = Console.ReadLine();

            var client = new ServiceBusClient(ConnectionString);
            var sender = client.CreateSender(QueueName);

            try
            {
                var message = new ServiceBusMessage(messageContent);
                await sender.SendMessageAsync(message);

                Console.WriteLine($"Message sent to queue '{QueueName}': {messageContent}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending message: {ex.Message}");
            }
            finally
            {
                await sender.DisposeAsync();
                await client.DisposeAsync();
            }
        }

        private static async Task ReceiveMessagesAsync()
        {
            var client = new ServiceBusClient(ConnectionString);
            var receiver = client.CreateReceiver(QueueName);

            try
            {
                Console.WriteLine($"Receiving messages from queue '{QueueName}'...");
        
                // Receive up to 10 messages
                IReadOnlyList<ServiceBusReceivedMessage> messages = await receiver.ReceiveMessagesAsync(maxMessages: 10);

                foreach (var message in messages)
                {
                    Console.WriteLine($"Received message: {message.Body.ToString()}");

                    // Complete the message to remove it from the queue
                    await receiver.CompleteMessageAsync(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error receiving messages: {ex.Message}");
            }
            finally
            {
                await receiver.DisposeAsync();
                await client.DisposeAsync();
            }
        }
    }
}
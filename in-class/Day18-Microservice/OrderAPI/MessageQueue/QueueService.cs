using Azure.Messaging.ServiceBus;
using System.Text;
using System.Text.Json;

namespace OrderAPI.MessageQueue
{
    public class QueueService
    {
        private readonly IConfiguration _config;
        public QueueService(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendMessageAsync<T>(T msg, string queueName)
        {
            var queueClient = new ServiceBusClient(_config.GetConnectionString("AzureServiceBus"));
            var sender = queueClient.CreateSender(queueName);

            string msgBody = JsonSerializer.Serialize(msg);
            byte[] msgBytes = Encoding.UTF8.GetBytes(msgBody);

            var msgData = new ServiceBusMessage(msgBytes);
            await sender.SendMessageAsync(msgData);
        }
    }
}

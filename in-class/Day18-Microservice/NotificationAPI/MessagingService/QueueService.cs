using Azure.Messaging.ServiceBus;
using SharedMessageService;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace NotificationAPI.MessagingService
{
    public class QueueService
    {
        private readonly IConfiguration _config;
        public QueueService(IConfiguration config)
        {
            _config = config;
        }

        public async Task<OrderDetail> ReadMsgAsync(string queueName)
        {
            var queueClient = new ServiceBusClient(_config.GetConnectionString("AzureServiceBus"));
            var receiver = queueClient.CreateReceiver(queueName);            

            var msg = await receiver.ReceiveMessageAsync();
            await receiver.CompleteMessageAsync(msg);

            var msgStr = Encoding.UTF8.GetString(msg.Body);

            var od = JsonSerializer.Deserialize<OrderDetail>(msgStr);

            return od;
        }
    }
}

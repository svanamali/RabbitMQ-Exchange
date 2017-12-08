using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Common;

namespace GreenClient
{
    class Program
    {
        static void Main(string[] args)
        {

            ConnectionFactory factory = new ConnectionFactory();
            factory.HostName = RabbitMqConstants.HostName;
            factory.UserName = RabbitMqConstants.UserName;
            factory.Password = RabbitMqConstants.Password;

            var connection = factory.CreateConnection();

            var channel = connection.CreateModel();
            connection.AutoClose = true;

            ReceiveSerializationMessage(channel);
        }

        private static void ReceiveSerializationMessage(IModel model)
        {
            model.BasicQos(0, 1, false);

            EventingBasicConsumer consumer = new EventingBasicConsumer(model);
            model.BasicConsume(RabbitMqConstants.GreenQueue, false, consumer);
            consumer.Received += Consumer_Received;
            model.BasicConsume(RabbitMqConstants.GreenQueue, true, consumer);
        }

        private static void Consumer_Received(object sender, BasicDeliverEventArgs e)
        {
            String jsonString = Encoding.UTF8.GetString(e.Body);
            MessageColor message = JsonConvert.DeserializeObject<MessageColor>(jsonString);
            Console.WriteLine("Color: {0}", message.colorName);
        }
    }
}

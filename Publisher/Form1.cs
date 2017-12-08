using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RabbitMQ.Client;
using Common;
using Newtonsoft.Json;

namespace Publisher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private IConnection connection;
        private IModel channel;

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.HostName = RabbitMqConstants.HostName;
            factory.UserName = RabbitMqConstants.UserName;
            factory.Password = RabbitMqConstants.Password;

            connection = factory.CreateConnection();
            channel = connection.CreateModel();
            connection.AutoClose = true;

            channel.ExchangeDeclare(exchange: RabbitMqConstants.ColorExchange, type: ExchangeType.Direct);

            channel.QueueDeclare(queue: RabbitMqConstants.RedQueue, durable: false, exclusive: false, autoDelete: false, arguments: null);
            channel.QueueBind(queue: RabbitMqConstants.RedQueue, exchange: RabbitMqConstants.ColorExchange, routingKey: "red");

            channel.QueueDeclare(queue: RabbitMqConstants.GreenQueue, durable: false, exclusive: false, autoDelete: false, arguments: null);
            channel.QueueBind(queue: RabbitMqConstants.GreenQueue, exchange: RabbitMqConstants.ColorExchange, routingKey: "green");

            channel.QueueDeclare(queue: RabbitMqConstants.BlueQueue, durable: false, exclusive: false, autoDelete: false, arguments: null);
            channel.QueueBind(queue: RabbitMqConstants.BlueQueue, exchange: RabbitMqConstants.ColorExchange, routingKey: "blue");
        }

        private void cmdRed_Click(object sender, EventArgs e)
        {
            MessageColor message = new MessageColor();
            message.colorName = "Red";
            SendMessage(message, "red");
        }

        private void cmdBlue_Click(object sender, EventArgs e)
        {
            MessageColor message = new MessageColor();
            message.colorName = "Blue";
            SendMessage(message, "blue");
        }

        private void cmdGreen_Click(object sender, EventArgs e)
        {
            MessageColor message = new MessageColor();
            message.colorName = "Green";
            SendMessage(message, "green");
        }

        private void SendMessage(MessageColor message, string color)
        {
            var serializeCommand = JsonConvert.SerializeObject(message);
            var messageProperties = channel.CreateBasicProperties();
            messageProperties.ContentType = RabbitMqConstants.JsonMimeType;
            channel.BasicPublish(exchange: RabbitMqConstants.ColorExchange, 
                routingKey: color, 
                basicProperties: messageProperties, 
                body: Encoding.UTF8.GetBytes(serializeCommand));

        }
    }
}

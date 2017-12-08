using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class RabbitMqConstants
    {
        public const string RabbitMqUri = "ampq://guest:guest@localhost:15672";
        public const string JsonMimeType = "application/json";

        public const string ColorExchange = "ColorExchange";
        public const string RedQueue = "RedQueue";
        public const string GreenQueue = "GreenQueue";
        public const string BlueQueue = "BlueQueue";

        public const string HostName = "localhost";
        public const string UserName = "guest";
        public const string Password = "guest";
    }

    public class MessageColor
    {
        public string colorName;
    }
}

namespace Livraria.Infrastructure.Configurations
{
    public static class RabbitMQConfig
    {
        public static partial class ConnectionString
        {
            public static string HostName { get { return "jackal.rmq.cloudamqp.com"; } }
            public static string VirtualHost { get { return "xgkonjqg"; } }
            public static string UserName { get { return "xgkonjqg"; } }
            public static string Password { get { return "Z-TGcSiJF2vM-AD1HfQ9NVeKkqkQAZDc"; } }
        }
        public static partial class Queues
        {
            public static string Promocoes { get { return "promocoes"; } }
        }

    }
}

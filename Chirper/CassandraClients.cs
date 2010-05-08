using HectorSharp;

namespace Friends
{
    public class CassandraClients
    {
        internal static KeyedCassandraClientFactory Factory { get; set; }
        
        internal static Endpoint Endpoint { get; set; }

        public static ICassandraClient Make()
        {
            return Factory.Make(Endpoint);
        }
    }
}
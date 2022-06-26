using SignalRChatServerExample.Models;
using System.Collections.Generic;

namespace SignalRChatServerExample.Data
{
    public static class ClientSource
    {
        public static List<Client> clients = new List<Client>();
        public static List<Client> Clients { get; } = new List<Client>();
    }
}

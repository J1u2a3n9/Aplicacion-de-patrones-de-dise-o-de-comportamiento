using McNutResources.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace McNutResources.Service
{
    public interface ModelClient
    {
        public bool RegisterClient(ClientModel newClient);
        public bool DeleteClient(ClientModel deleteClient);
        public bool BuyPeanutFlavor(long ci, string flavor, int amount);
        public ClientModel GetClient(long ci);
        public List<ClientModel> GetClients();
        public List<IPeanutService> GetPeanuts(long ci);

    }
}

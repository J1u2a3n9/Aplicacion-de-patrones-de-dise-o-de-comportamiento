using McNutResources.Model;
using McNutResources.Notifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McNutResources.Service
{
    class ClientService:ModelClient
    {
        private List<ClientModel> _clients;
        public ClientService()
        {
            _clients = new List<ClientModel>();
            _clients.Add(new ClientModel()
            {
                Ci = 14419455,
                Name = "Juan Luis",
                Address = "Av Blanco Galindo",
                SurName = "Canedo Villarroel",
                DateOfBirth = new DateTime(1999, 11, 06),
                Phone = 78348873
            });
            _clients.Add(new ClientModel()
            {
                Ci = 3003688,
                Name = "Jose Luis",
                Address = "Av Papa Paulo",
                SurName = "Villarroel Gonzales",
                DateOfBirth = new DateTime(2000, 10, 06),
                Phone = 71745068
            });
            _clients.Add(new ClientModel()
            {
                Ci = 15519844,
                Name = "Maria",
                Address = "Av America",
                SurName = "Espinoza Castro",
                DateOfBirth = new DateTime(2000, 08, 06),
                Phone = 78348873
            });

        }
        public bool BuyPeanutFlavor(long ci, string flavor, int amount)
        {
            List<IPeanutService> peanuts;
            string codPeanut;
            IPeanutService peanut;
            switch (flavor.ToLower())
            {
                  case "coco":
                  case "leche condensada":
                  case "coco y leche condensada":
                  case "Mc Nuts Sabor Leche condensada con Coco":
                       peanut = new PeanutLecheCondensadaService();
                       break;
                  case "miel":
                  case "mostaza":
                  case "miel y mostaza":
                  case "Mc Nuts Sabor Miel y Mostaza":
                       peanut = new PeanutMielYMostazaService();
                       break;
                  case "picante":
                  case "Mc Nuts Sabor Picante":
                       peanut = new PeanutPicanteService();
                       break;
                  default:
                       peanut = new PeanutPicanteService();
                       break;
            }
            var client = GetClient(ci);
            if(GetPeanuts(ci)==null)
            {
                peanuts = new List<IPeanutService>();
            } 
            else
            {
                peanuts = GetPeanuts(ci);
            }
            peanuts.Add(peanut);
            client.Peanuts = peanuts;

            return true;
        }

        public bool DeleteClient(ClientModel deleteClient)
        {
            if (ExistingClient(deleteClient.Ci) == false)
            {
                throw new Exception($"El cliente con id {deleteClient.Ci} no existe ");
            }
            _clients.Remove(deleteClient);
            return true;
        }

        public ClientModel GetClient(long ci)
        {
            return _clients.FirstOrDefault(c => c.Ci == ci);
        }

        public List<ClientModel> GetClients()
        {
            return _clients;
        }

        public List<IPeanutService> GetPeanuts(long ci)
        {
            return GetClient(ci).Peanuts;
        }

        public bool RegisterClient(ClientModel newClient)
        {
            ExistingClient(newClient.Ci);
            _clients.Add(newClient);
            return true;
        }

        private bool ExistingClient(long ci)
        {
            bool answer = false;
            var client = _clients.FirstOrDefault(c => c.Ci == ci);
            if (client != null)
            {
                answer = true;
            }
            return answer;
        }
    }
}

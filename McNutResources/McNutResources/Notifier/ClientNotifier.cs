using McNutResources.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace McNutResources.Notifier
{
    public class ClientNotifier:INotifier
    {
        private ModelClient _clientService;
        public ClientNotifier(ModelClient clientService)
        {
            _clientService = clientService;
        }

        public void Show()
        {
            int counter = 1;
            var clients = _clientService.GetClients();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("         LISTA ADMINISTRADORES MCNUTS        ");
            foreach (var client in clients)
            {
                Console.WriteLine(counter);
                Console.WriteLine($"Nombre: {client.Name}");
                Console.WriteLine($"Apellido: {client.SurName}");
                Console.WriteLine($"Ci: {client.Ci}");
                Console.WriteLine($"Fecha Nacimiento: {client.DateOfBirth.ToString()}");
                Console.WriteLine($"Numero: {client.Phone}");
                Console.WriteLine($"Direccion: {client.Address}");
                counter++;
            }
        }

        public void ShowClient(long ci)
        {
            Console.WriteLine("-------------------------------------------");
            var client = _clientService.GetClient(ci);
            Console.WriteLine($"Nombre: {client.Name}");
            Console.WriteLine($"Apellido: {client.SurName}");
            Console.WriteLine($"Ci: {client.Ci}");
            Console.WriteLine($"Fecha Nacimiento: {client.DateOfBirth.ToString()}");
            Console.WriteLine($"Numero: {client.Phone}");
            Console.WriteLine($"Direccion: {client.Address}");
        }

        public void ShowBuyAgain()
        {
            Console.WriteLine("Por favor vuelva a seleccionar un nuevo sabor");
        }
    }
}


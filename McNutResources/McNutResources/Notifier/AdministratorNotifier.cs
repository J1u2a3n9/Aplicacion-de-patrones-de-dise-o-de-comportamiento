using McNutResources.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace McNutResources.Notifier
{
    public class AdministratorNotifier:INotifier
    {
        private IAdministratorService _administratorService;
        public AdministratorNotifier(IAdministratorService administratorService)
        {
            _administratorService = administratorService;
        }

        public void Show()
        {
            int counter = 1;
            var administrators = _administratorService.GetAdministrators();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("         LISTA ADMINISTRADORES MCNUTS        ");
            foreach (var administrator in administrators)
            {
                Console.WriteLine(counter);
                Console.WriteLine($"Nombre: {administrator.Name}");
                Console.WriteLine($"Apellido: {administrator.SurName}");
                Console.WriteLine($"Ci: {administrator.Ci}");
                Console.WriteLine($"Fecha Nacimiento: {administrator.DateOfBirth.ToString()}");
                Console.WriteLine($"Numero: {administrator.Phone}");
                Console.WriteLine($"Direccion: {administrator.Address}");
                counter++;
            }
        }

        public void ShowAdministrator(long ci)
        {
            Console.WriteLine("-------------------------------------------");
            var administrator = _administratorService.GetAdministrator(ci);
            Console.WriteLine($"Nombre: {administrator.Name}");
            Console.WriteLine($"Apellido: {administrator.SurName}");
            Console.WriteLine($"Ci: {administrator.Ci}");
            Console.WriteLine($"Fecha Nacimiento: {administrator.DateOfBirth.ToString()}");
            Console.WriteLine($"Numero: {administrator.Phone}");
            Console.WriteLine($"Direccion: {administrator.Address}");
        }


    }
}

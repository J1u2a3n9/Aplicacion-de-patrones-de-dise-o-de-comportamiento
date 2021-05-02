using McNutResources.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace McNutResources.Notifier
{
    public class PeanutNotifier:INotifier
    {
        private IPeanutService _peanutModelAndService;
        public PeanutNotifier(IPeanutService peanutModelAndService)
        {
            _peanutModelAndService = peanutModelAndService;
        }

        public void Show()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Nombre: {_peanutModelAndService.Peanut.Name}");
            Console.WriteLine($"Fecha de elaboracion: {_peanutModelAndService.Peanut.ElaborationDate.ToString()}");
            Console.WriteLine($"Fecha de expiracion: {_peanutModelAndService.Peanut.ExpirationDate.ToString()}");
            Console.WriteLine($"Precio Unitario: {_peanutModelAndService.Peanut.UnitCost}");
            Console.WriteLine($"Precio Por mayor: {_peanutModelAndService.Peanut.WholesalePrice}");
            Console.WriteLine($"Cantidad en stock: {_peanutModelAndService.Peanut.Amount}");
            Console.WriteLine($"La produccion de este sabor es {(_peanutModelAndService.Peanut.ProductionStatus.ToString())}");
        }

        public void ShowProductionStatus()
        {
            Console.WriteLine("-------------------------------------------");
            switch(_peanutModelAndService.Peanut.ProductionStatus.ToString())
            {
                case "true":
                    Console.WriteLine($"El mani de sabor : {_peanutModelAndService.Peanut.Name} esta siendo producido");
                    break;
                case "false":
                    Console.WriteLine($"El mani de sabor : {_peanutModelAndService.Peanut.Name} no esta siendo producido :(, disculpe las molestias");
                    break;
            }

        }

    }
}

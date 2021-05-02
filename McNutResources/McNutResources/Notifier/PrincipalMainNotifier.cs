using McNutResources.Model;
using McNutResources.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace McNutResources.Notifier
{
    class PrincipalMainNotifier
    {
        private AdministratorModel _administratorModel;
        private IPeanutService _peanut;

        public PrincipalMainNotifier()
        {
            _administratorModel = new AdministratorModel();

        }
        public void LaunchPrincipalMenu()
        {
            int opc;
            do
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("         BIENVENIDO AL SISTEMA DE CLIENTES MCNUTS        ");
                Console.WriteLine("1) Comprar");
                Console.WriteLine("2) Administracion");
                Console.WriteLine("3) Visualizar");
                Console.Write("Que opcion desea ? :");
                opc = Convert.ToInt32(Console.ReadLine());
                SelectOption(opc);
            } while (opc < 5);

        }

        private void SelectOption(int opc)
        {
            switch (opc)
            {
                case 1:
                    LaunchBuy();
                    break;
                case 2:
                    LaunchAdministration();
                    break;
                case 3:
                    LauchVisualizeAdministrators();
                    break;
            }
        }

        private void SelectOptionAdministration(int opc)
        {
            PeanutsFactory factory = new ConcretePeanutFactory();
            int flavor;
            switch(opc)
            {
                case 1:
                    flavor=LaunchPeanutSelection();
                    _peanut=factory.GetPeanut(flavor.ToString());
                    ClientAccess.Access.RestoreProduction(_peanut);
                    break;
            }
        }

        private void LaunchBuy()
        {
            int flavor = LaunchPeanutSelection();
            long ci = LaunchRequestCi();
            int amount = LaunchRequestAmount();
            ClientAccess.Access.BuyPeanutFlavor(ci, flavor, amount);
        }

        private int LaunchPeanutSelection()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("         ESTOS SON NUESTROS SABORES DISPONIBLES EN MCNUTS        ");
            Console.WriteLine(" 1)Miel y Mostaza");
            Console.WriteLine(" 2)Leche condesada y coco");
            Console.WriteLine(" 3)Oreo");
            Console.WriteLine(" 4)Picante");
            Console.Write("Que opcion desea ? :");
            return Convert.ToInt32(Console.ReadLine());
        }


        private void LauchVisualizeAdministrators()
        {
            int opc;
            do
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("         Que desea ver?        ");
                Console.WriteLine(" 1)Nuestros Clientes");
                Console.WriteLine(" 2)Nuestros Sabores");
                Console.WriteLine(" 3)Nuestros Administradores");
                Console.Write("Que opcion desea ? :");
                opc = Convert.ToInt32(Console.ReadLine());
                ClientAccess.Access.ShowAdministrators(opc);
            } while (opc < 4);
           
        }

        private long LaunchRequestCi()
        {
            long ci;
            Console.Write("Ingrese su Ci: ");
            ci = Convert.ToInt64(Console.ReadLine());
            return ci;
        }

        private int LaunchRequestAmount()
        {
            int amount;
            Console.Write("Ingrese la cantidad de mani que comprara ");
            amount = Convert.ToInt32(Console.ReadLine());
            return amount;
        }
        private void LaunchAdministration()
        {
            int opc;
            do
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("         BIENVENIDO AL SISTEMA DE ADMINISTRACION DE  MCNUTS        ");
                Console.WriteLine("1) Actualizar produccion de un sabor de Mani");
                Console.WriteLine("2) Salir");
                Console.Write("Que opcion desea ? :");
                opc = Convert.ToInt32(Console.ReadLine());
                SelectOptionAdministration(opc);
            } while (opc < 2);
            
            


        }
    }
}

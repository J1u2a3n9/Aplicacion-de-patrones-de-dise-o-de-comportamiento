using System;
using System.Collections.Generic;
using System.Text;

namespace McNutResources.Service
{
    public class ConcretePeanutFactory:PeanutsFactory
    {
        public override IPeanutService GetPeanut(string peanutFlavor)
        {
            switch (peanutFlavor.ToLower())
            {
                case "miel":
                case "mostaza":
                case "miel y mostaza":
                case "1":
                case "mc nuts sabor miel y mostaza":
                    return new PeanutMielYMostazaService();
                case "coco":
                case "leche condensada y coco":
                case "leche condensada":
                case "2":
                case "mc nuts sabor leche condensada con coco":

                    return new PeanutLecheCondensadaService();
                case "oreo":
                case "3":
                case "mc nuts sabor oreo":
                    return new PeanutOreoService();
                case "picante":
                case "4":
                case "mc nuts sabor picante":
                    return new PeanutPicanteService();
                default:
                    throw new Exception($"No existe el sabor  {peanutFlavor} dentro nuestro catalogo :C");

            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace McNutResources.Service
{
    public class PeanutLecheCondensadaService:IPeanutService
    {
        public PeanutLecheCondensadaService()
        {
            CreatePeanutFlavor();
        }
        public override void CreatePeanutFlavor()
        {
            Peanut.Id = "Coco1";
            Peanut.Name = "Mc Nuts Sabor Leche condensada con Coco";
            Peanut.ElaborationDate = DateTime.Now;
            Peanut.ExpirationDate = Peanut.ElaborationDate.AddMonths(2);
            Peanut.UnitCost = 10;
            Peanut.WholesalePrice = 8;
            Peanut.Amount = 25;
            Peanut.ProductionStatus = true;
            Peanut.DiscontinuationDate = null;
            Peanut.ProductionStartDate = DateTime.Now;
        }
    }
}

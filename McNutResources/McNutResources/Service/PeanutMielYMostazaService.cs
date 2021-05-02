using System;
using System.Collections.Generic;
using System.Text;

namespace McNutResources.Service
{
    public class PeanutMielYMostazaService:IPeanutService
    {
        public PeanutMielYMostazaService()
        {
            CreatePeanutFlavor();
        }
        public override void CreatePeanutFlavor()
        {
            Peanut.Id = "MM1";
            Peanut.Name = "Mc Nuts Sabor Miel y Mostaza";
            Peanut.ElaborationDate = DateTime.Now;
            Peanut.ExpirationDate = Peanut.ElaborationDate.AddMonths(2);
            Peanut.UnitCost = 15;
            Peanut.WholesalePrice = 10;
            Peanut.Amount = 50;
            Peanut.ProductionStatus = true;
            Peanut.DiscontinuationDate = null;
            Peanut.ProductionStartDate = DateTime.Now;
        }
    }
}

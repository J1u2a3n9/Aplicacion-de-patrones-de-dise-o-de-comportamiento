using System;
using System.Collections.Generic;
using System.Text;

namespace McNutResources.Service
{
    public class PeanutPicanteService:IPeanutService
    {
        public PeanutPicanteService()
        {
            CreatePeanutFlavor();
        }
        public override void CreatePeanutFlavor()
        {
            Peanut.Id = "Picante1";
            Peanut.Name = "Mc Nuts Sabor Picante";
            Peanut.ElaborationDate = DateTime.Now;
            Peanut.ExpirationDate = Peanut.ElaborationDate.AddMonths(2);
            Peanut.UnitCost = 5;
            Peanut.WholesalePrice = 3;
            Peanut.Amount = 25;
            Peanut.ProductionStatus = true;
            Peanut.DiscontinuationDate = null;
            Peanut.ProductionStartDate = DateTime.Now;
        }
    }
}

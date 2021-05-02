using System;
using System.Collections.Generic;
using System.Text;

namespace McNutResources.Service
{
    public class PeanutOreoService:IPeanutService
    {
        public PeanutOreoService()
        {
            CreatePeanutFlavor();
        }
        public override void CreatePeanutFlavor()
        {
            Peanut.Id = "Oreo1";
            Peanut.Name = "Mc Nuts Sabor Oreo";
            Peanut.ElaborationDate = DateTime.Now;
            Peanut.ExpirationDate = Peanut.ElaborationDate.AddMonths(2);
            Peanut.UnitCost = 14;
            Peanut.WholesalePrice = 7;
            Peanut.Amount = 55;
            Peanut.ProductionStatus = true;
            Peanut.DiscontinuationDate = null;
            Peanut.ProductionStartDate = DateTime.Now;
        }
    }
}

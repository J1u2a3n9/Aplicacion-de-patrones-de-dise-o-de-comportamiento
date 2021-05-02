using McNutResources.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace McNutResources.Service
{
    public abstract class IPeanutService
    {
        public PeanutModel Peanut = new PeanutModel();
        public void AddAmount(int amount)
        {
            if (amount < 0 && Peanut.Amount > 0 || amount > 0)
            {
                Peanut.Amount = Peanut.Amount + amount;
            }
        }
        public void RestoreProduction()
        {
            if(Peanut.ProductionStatus==false)
            {
                Peanut.ProductionStatus = true;
                Peanut.ProductionStartDate = DateTime.Now.ToUniversalTime();

            }
            else
            {
                Peanut.ProductionStatus = false;
                Peanut.DiscontinuationDate = DateTime.Now.ToUniversalTime();
            }
        }
        public abstract void CreatePeanutFlavor();
    }
}


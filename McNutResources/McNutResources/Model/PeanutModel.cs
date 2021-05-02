using System;
using System.Collections.Generic;
using System.Text;

namespace McNutResources.Model
{
    public class PeanutModel
    {
        public string Id{ get; set; }
        public string Name{ get; set; }
        public DateTime ElaborationDate{ get; set; }
        public DateTime ExpirationDate{ get; set; }
        public long UnitCost{ get; set; }
        public long WholesalePrice{ get; set; }
        public int Amount{ get; set; }
        public bool ProductionStatus{ get; set; }
        public DateTime? DiscontinuationDate{ get; set; }
        public DateTime ProductionStartDate{ get; set; }

    }
}

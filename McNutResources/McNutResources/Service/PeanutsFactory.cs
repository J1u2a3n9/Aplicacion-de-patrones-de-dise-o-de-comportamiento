using System;
using System.Collections.Generic;
using System.Text;

namespace McNutResources.Service
{
    public abstract class PeanutsFactory
    {
        public abstract IPeanutService GetPeanut(string peanutFlavor);

    }
}

using McNutResources.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace McNutResources.Service
{
    public interface IAdministratorService
    {
        public bool CreateAdministrator(AdministratorModel newAdministrator);
        public bool DeleteAdministrator(long ci);
        public AdministratorModel GetAdministrator(long ci);
        public List<AdministratorModel> GetAdministrators();
        public AdministratorModel UpdateAdministrator(long ci, AdministratorModel updateAdministrator);
        public IPeanutService RestoreProduction(IPeanutService peanut);
        public void Notify(IPeanutService peanut);

    }
}

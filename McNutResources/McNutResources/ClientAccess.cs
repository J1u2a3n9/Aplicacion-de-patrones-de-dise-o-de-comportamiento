using McNutResources.Model;
using McNutResources.Notifier;
using McNutResources.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace McNutResources
{
    public class ClientAccess
    {
        private static ClientAccess _access = null;
        private static object _syncLock = new object();
        private ClientService _client;
        private IAdministratorService _administrator;
        private IPeanutService _peanutNoProduction;
        private PeanutNotifier notificadorMani;
        //private ClientNotifier _clientNotifier;

        private ClientAccess()
        {
            _client = new ClientService();
            _administrator = new AdministratorService();
            //_clientNotifier = new ClientNotifier(_client);
        }
        public static ClientAccess Access
        {
            get
            {
                lock (_syncLock)
                {
                    if (_access == null)
                        _access = new ClientAccess();
                    return _access;
                }
            }
        }

        public bool RestoreProduction(IPeanutService peanut)
        {
            _peanutNoProduction = peanut;
            _peanutNoProduction=_administrator.RestoreProduction(peanut);
            return true;
        }
        public bool BuyPeanutFlavor(long ci, int flavor, int amount)
        {
            string namePeanut="";
            switch(flavor)
            {
                case 1:
                    namePeanut = "Mc Nuts Sabor Miel y Mostaza";
                    break;
                case 2:
                    namePeanut = "Mc Nuts Sabor Leche condensada con Coco";
                    break;
                case 3:
                    namePeanut = "Mc Nuts Sabor Oreo";
                    break;
                case 4:
                    namePeanut = "Mc Nuts Sabor Picante";
                    break;
            }
            if(_peanutNoProduction==null)
            {
                _client.BuyPeanutFlavor(ci, namePeanut, amount);
            }
            else
            {
                if (namePeanut == _peanutNoProduction.Peanut.Name)
                {
                    notificadorMani = new PeanutNotifier(_peanutNoProduction);
                    notificadorMani.ShowProductionStatus();
                }

            }
            return true;
        }

        public void ShowAdministrators(int opc)
        {
            INotifier notificador;
            IPeanutService peanut;
            switch(opc)
            {
                case 1:
                    _client = new ClientService();
                    notificador = new ClientNotifier(_client);
                    notificador.Show();
                    break;
                case 2:
                    peanut = new PeanutMielYMostazaService();
                    notificador = new PeanutNotifier(peanut);
                    notificador.Show();
                    peanut = new PeanutLecheCondensadaService();
                    notificador = new PeanutNotifier(peanut);
                    notificador.Show();
                    peanut = new PeanutOreoService();
                    notificador = new PeanutNotifier(peanut);
                    notificador.Show();
                    peanut = new PeanutPicanteService();
                    notificador = new PeanutNotifier(peanut);
                    notificador.Show();
                    break;
                case 3:
                    notificador = new AdministratorNotifier(_administrator);
                    notificador.Show();
                    break;
            }
            
        }
        
    }
}

using Supermarket.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Bussines
{
    internal class ProvidersDAO
    {
        private readonly Dictionary<int, Providers> ProvidersList;
        private static int ProviderSecuencial;

        public ProvidersDAO()
        {
            ProvidersList = new Dictionary<int, Providers>();
            ProviderSecuencial = 0;
        } 
        public bool AddProvider(Providers providers) {
            try {
                providers.IdProvider = ++ProviderSecuencial;
                ProvidersList.Add((int)providers.IdProvider, providers);
            } catch (ArgumentException e) {
                return false;
            }
            return true;
        }
        public bool RemoveProvider(int id) {
            bool idExists = ProvidersList.ContainsKey(id);
            if (idExists) { 
                ProvidersList.Remove(id);
                return true;
            }
            return false;
        }
        public Providers GetProvider(int id) {
            bool idExists = ProvidersList.ContainsKey(id);
            if (idExists) { 
                return ProvidersList[id];
            }
            return null;
        }
        public bool UpdateProviders(int id, Providers providers) {
            bool idExists = ProvidersList.ContainsKey(id);
            if (!idExists)
            {
                try
                {
                    ProvidersList[id] = providers;
                    return true;
                }
                catch {
                    return false;
                }
            }
            return false;
        }
        public Dictionary<int, Providers> GetProviders() { 
            return ProvidersList;
        }
    }
}

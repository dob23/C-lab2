using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Model
{
    class Providers
    {
        public int? IdProvider { get; set; }
        public string NombreCompañia { get; set; }
        public string FrecuenciaEntrega { get; set; }
        public float TelefonoContacto { get; set; }

        public Providers(int? idProvider, string nombreCompañia, string frecuenciaEntrega, float telefonoContacto)
        {
            IdProvider = idProvider;
            NombreCompañia = nombreCompañia;
            FrecuenciaEntrega = frecuenciaEntrega;
            TelefonoContacto = telefonoContacto;
        }
    }
}

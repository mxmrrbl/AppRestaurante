using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public sealed class Repositorio
    {
        public static Repositorio Instancia { get; } = new Repositorio();

        public List<Orden> ListadoOrdenes1 { get; set; } = new List<Orden>();
        public List<Orden> ListadoOrdenes2 { get; set; } = new List<Orden>();
        public List<Orden> ListadoOrdenes3 { get; set; } = new List<Orden>();
        public List<Orden> ListadoOrdenes4 { get; set; } = new List<Orden>();



        private Repositorio()   
        {

        }

    }
}

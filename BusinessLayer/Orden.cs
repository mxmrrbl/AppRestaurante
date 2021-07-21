using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Orden
    {
        public string Nombre { get; set; }
        public string Mesa { get; set; }
        public string Entrada { get; set; }
        public string Plato { get; set; }
        public string Bebida { get; set; }
        public string Postre { get; set; }

        public string Datos
        {
            get { return $"Cliente: {Nombre};\n Entrada: {Entrada}; Plato fuerte: {Plato}; Bebida: {Bebida}; Postre: {Postre}";  }
        }
    }

}

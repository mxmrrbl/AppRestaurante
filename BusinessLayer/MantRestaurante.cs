using System;
using System.Collections.Generic;


namespace BusinessLayer
{
    public class MantRestaurante    
    {
        public void Agregar (int mesa, Orden item)
        {
            if (mesa == 1)
            {
                Repositorio.Instancia.ListadoOrdenes1.Add(item);

            }
            if (mesa == 2)
            {
                Repositorio.Instancia.ListadoOrdenes2.Add(item);
               
            }
            if (mesa == 3)
            {
                Repositorio.Instancia.ListadoOrdenes3.Add(item);
             
            }
            if (mesa == 4)
            {
                Repositorio.Instancia.ListadoOrdenes4.Add(item);
                
            }
        }

        public List<Orden> Visualizar(int mesa)
        {
            try
            {
                switch (mesa)
                {
                    case 1:
                        return Repositorio.Instancia.ListadoOrdenes1;
                        break;
                    case 2:
                        return Repositorio.Instancia.ListadoOrdenes2;
                        break;
                    case 3:
                        return Repositorio.Instancia.ListadoOrdenes3;
                        break;
                    case 4:
                        return Repositorio.Instancia.ListadoOrdenes4;
                        break;

                    default:
                        return Repositorio.Instancia.ListadoOrdenes1;
                        break;
                }
            }catch
            {
                return Repositorio.Instancia.ListadoOrdenes1;
            }
      

        }

        public void Limpiar(int mesa)
        {
            if (mesa == 1)
            {
                Repositorio.Instancia.ListadoOrdenes1.RemoveAt(1);
                Repositorio.Instancia.ListadoOrdenes1.RemoveAt(2);
                Repositorio.Instancia.ListadoOrdenes1.RemoveAt(3);
                Repositorio.Instancia.ListadoOrdenes1.RemoveAt(4);

            }
            if (mesa == 2)
            {
                Repositorio.Instancia.ListadoOrdenes2.RemoveAt(1);
                Repositorio.Instancia.ListadoOrdenes2.RemoveAt(2);
                Repositorio.Instancia.ListadoOrdenes2.RemoveAt(3);
                Repositorio.Instancia.ListadoOrdenes2.RemoveAt(4);
            }
            if (mesa == 3)
            {
                Repositorio.Instancia.ListadoOrdenes3.RemoveAt(1);
                Repositorio.Instancia.ListadoOrdenes3.RemoveAt(2);
                Repositorio.Instancia.ListadoOrdenes3.RemoveAt(3);
                Repositorio.Instancia.ListadoOrdenes3.RemoveAt(4);
            }
            if (mesa == 4)
            {
                Repositorio.Instancia.ListadoOrdenes4.RemoveAt(1);
                Repositorio.Instancia.ListadoOrdenes4.RemoveAt(2);
                Repositorio.Instancia.ListadoOrdenes4.RemoveAt(3);
                Repositorio.Instancia.ListadoOrdenes4.RemoveAt(4);
            }
        }

    }
}

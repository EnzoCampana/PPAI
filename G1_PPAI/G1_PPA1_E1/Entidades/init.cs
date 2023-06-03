using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_PPA1_E1.Entidades
{
    internal class init
    {
        //Clase que inicializa la BD Mock

        public static CambioDeEstado crearCambioDeEstado(Estado estado)
        {
            DateTime time = DateTime.Today;
            CambioDeEstado cambioEstado = new CambioDeEstado(time, estado);
            return cambioEstado;
        }
        public static Cliente crearCliente()
        {
            Cliente cliente = new Cliente(44474631, "Lautaro Martinez", 351488386);
            return cliente;
        }
        public static Estado crearEstado(String value)
        {
            Estado estado = new Estado(value);
            return estado;
        }

        //public static Llamada crearLlamada(Cliente cliente, OpcionLlamada opcionLlamada, SubOpcionLlamada subOpcionLlamada, CategoriaLlamada categoria)
        //{
        //    Estado estado1 = crearEstado("Inicial");
        //    CambioEstado estInicial = crearCambioEstado(estado1);
        //    TimeSpan duracion = new TimeSpan(0, 0, 0); // Duración de 0 hora y 0 minutos
        //    List<CambioEstado> cambiosEstado = new List<CambioEstado>(); // Crear una lista vacía de cambios de estado
        //    cambiosEstado.Add(estInicial);
        //    // Crear una instancia de OpcionLlamada

        //    Llamada llamada = new Llamada("Descripción", duracion, cliente, cambiosEstado, opcionLlamada, subOpcionLlamada, categoria); // Agregamos una categoría momentánea para evitar errores
        //    return llamada;
        //}






    }
}

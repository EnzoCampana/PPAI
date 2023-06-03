using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_PPA1_E1.Entidades
{
    public class RespuestaDeCliente
    {
        //Atributos
        private DateTime fechaEncuesta;
        private RespuestaPosible respuestaSeleccionada;

        //Constructor
        public RespuestaDeCliente(DateTime fechaEncuesta, RespuestaPosible respuestaSeleccionada)
        {
            this.fechaEncuesta = fechaEncuesta;
            this.respuestaSeleccionada = respuestaSeleccionada;
        }
        //Metodos
        public string getDescripcionRta()
        {
            return respuestaSeleccionada.getDescripcionRta();
        }
    }
}

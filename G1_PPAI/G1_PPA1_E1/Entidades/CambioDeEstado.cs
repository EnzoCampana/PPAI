using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_PPA1_E1.Entidades
{
    public class CambioDeEstado
    {
        //Atributos
        private DateTime fechaHoraInicio;
        private Estado estado;

        //Constructor
        public CambioDeEstado(DateTime fechaHoraInicio, Estado estado) 
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = estado;
        }
        //Metodos
        public DateTime getFechaHoraInicio()
        {
            return fechaHoraInicio;
        }
        public Estado getEstado()
        {
            return estado;
        }
        public void esEstadoInicial()
        {

        }
        public void esUltimoEstado()
        {

        }
    }
}

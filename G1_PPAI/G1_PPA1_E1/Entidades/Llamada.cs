using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace G1_PPA1_E1.Entidades
{
    public class Llamada
    {
        //Atributos 
        private float duracion;
        private bool encuestaEnviada;
        private Cliente cliente;
        private List<CambioDeEstado> CambioDeEstado;
        private List<RespuestaDeCliente> respuestasDeEncuesta; 

        //Constructor
        public Llamada(float duracion, bool encuestaEnviada,  Cliente cliente, List<CambioDeEstado> cambioDeEstado, List<RespuestaDeCliente> respuestasDeEncuesta)
        {
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
            this.cliente = cliente;
            this.CambioDeEstado = cambioDeEstado;
            this.respuestasDeEncuesta = respuestasDeEncuesta;
        }
        //Metodos
        //public bool esDePeriodo(fechaInicio, fechaFin)
        //{
       
        //}
        public bool tieneRespuestaDeCliente()
        {
            return respuestasDeEncuesta.Count > 0;
        }
        public string getNombreClienteDeLlamada()
        {
            return cliente.getNombre();
        }
        public float getDuracion()
        {
            return duracion;
        }
        public float calcularDuracion()
        {
            return duracion;
        }
        //public Estado getEstadoActual()
        //{

        //}
        public List<RespuestaDeCliente> getRespuestas()
        {
            return respuestasDeEncuesta;
        }
    }
}

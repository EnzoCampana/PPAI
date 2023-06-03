using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_PPA1_E1.Entidades
{
    public class Encuesta
    {
        //Atributos
        private string descripcion;
        private List<Pregunta> pregunta;

        //Constructor
        public Encuesta(string descripcion, List<Pregunta> pregunta)
        {
            this.descripcion = descripcion;
            this.pregunta = pregunta;
        }
        //Metodos
        public string getDescripcionEncuesta()
        {
            return descripcion;
        }
        public bool esEncuestaDeCliente()
        {
            //Este metodo compara la descripcion de la coleccion de preguntas que se le hicieron al cliente con la descripcion de las preguntas de la encuesta CREO
            return true;
        }
        public void armarEncuesta()
        {
            //me mataste flaco
        }
    }
}

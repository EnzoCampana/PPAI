using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_PPA1_E1.Entidades
{
    public class Pregunta
    {
        //Atributos
        private string pregunta;
        private List<RespuestaPosible> respuesta;

        //Constructor
        Pregunta(string pregunta, List<RespuestaPosible> respuesta)
        {
            this.pregunta = pregunta;
            this.respuesta = respuesta;
        }
        //Metodos
        public string getDescripcion()
        {
            return pregunta;
        }
        public List<RespuestaPosible> listarRespuestasPosibles()
        {
            return respuesta;
        }
    }
}

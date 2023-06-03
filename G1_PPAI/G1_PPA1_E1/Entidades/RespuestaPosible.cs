using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_PPA1_E1.Entidades
{
    public class RespuestaPosible
    {
        //Atributos
        private string descripcion;
        private int valor;

        //Constructor
        public RespuestaPosible (string descripcion, int valor)
        {
            this.descripcion = descripcion;
            this.valor = valor;
        }
        //Metodos
        public string getDescripcionRta()
        {
            return descripcion;
        }
    }
}

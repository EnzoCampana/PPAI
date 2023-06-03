using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_PPA1_E1.Entidades
{
    public class Cliente
    {
        //Atributos
        private int dni;
        private string nombreCompleto;
        private int nroCelular;

        //Constructor
        public Cliente(int dni, string nombreCompleto, int nroCelular)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.nroCelular = nroCelular;
        }

        //Metodos
        public string getNombre()
        {
            return nombreCompleto;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    sealed internal class ClaseHija : ClaseAbstracta
    {
        private int Edad;
        private string Ciudad;

        public ClaseHija(int edad, string ciudad)
        {
            Edad = edad;
            Ciudad = ciudad;
        }

        public void DecirQuienEs()
        {
            Console.WriteLine("Soy la hija");
        }

        public int DevolverEdad()
        {
            return Edad;
        }
    }
}

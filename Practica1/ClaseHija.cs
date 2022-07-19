using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    sealed internal class ClaseHija : ClaseAbstracta
    {
        private int _edad;
        private string _ciudad;

        public ClaseHija(int edad, string ciudad)
        {
            _edad = edad;
            _ciudad = ciudad;
        }

        public void DecirQuienEs()
        {
            Console.WriteLine("Soy la hija");
        }

        public int DevolverEdad()
        {
            return _edad;
        }
    }
}

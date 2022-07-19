using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    abstract internal class ClaseAbstracta
    {
        protected string Name { get; set; }
        protected string Description { get; set; }

        protected void TestMethod()
        {
            Console.WriteLine("Hi!");
        }

        protected string GiveDesription()
        {
            return Description;
        }
    }
}

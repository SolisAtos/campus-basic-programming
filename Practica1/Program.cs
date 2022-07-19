using System;
using System.IO;

namespace Practica1
{
    class Program
    { 
        /// <summary>
        /// Toma las lineas del archivo de entrada y las escribe al archivo de salida en formato "Saludos hasta XXXX!"
        /// </summary>
        /// <param name="InputFile">Archivo de entrada con los paises</param>
        /// <param name="OutputFile">Nombre y ruta del archivo con el resultado de la funcion</param>
        static void GreetCountries(string InputFile, string OutputFile)
        {
            // Almacena los paises para despues escribirlos
            List<string> countries = new List<string>();

            // Lee el archivo
            using (StreamReader sr = new StreamReader(InputFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    countries.Add(line);
                }
            }

            // Escribe el archivo de salida
            using (StreamWriter sw = new StreamWriter(OutputFile))
            {
                foreach(string country in countries)
                {
                    sw.WriteLine($"Saludos hasta {country}!");
                }
            }
        }
        static void Main(string[] args)
        {
            string OutputString = @"C:\Users\a875025\Downloads\Saludos Paises ";
            DateTime CurrentDate = DateTime.Now;
            OutputString += $"{CurrentDate.ToString("yyyy-MMMM-dd")}.txt";

            GreetCountries(@"C:\Users\a875025\Downloads\countries.txt", OutputString);
        }
    }

}

using System;

namespace VeteriBosS
{
    class Program
    {
        static void Main(string[] args)
        {
            Proyecto veterinaria = new Proyecto();

            veterinaria.IngresarProyecto();
            veterinaria.ImprimirProyecto();
            veterinaria.AumentoS();


        }
    }
}

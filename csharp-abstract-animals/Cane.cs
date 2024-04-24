using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Cane : Animale, INuotabile
    {
        public override string Cibo { get; set; } = "Carne";

        public override string Verso()
        {
            return "Bau Bau";
        }

        public void Nuota()
        {
            Console.WriteLine("Sto nuotando!!!");
        }
    }
}

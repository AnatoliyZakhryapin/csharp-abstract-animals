using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal abstract class Animale
    {
        public abstract string Cibo { get; set; }
        public string Dormi()
        {
            return "Zzz";
        }
        public abstract string Verso();

        public string Mangia()
        {
            return Cibo;
        }
    }
}

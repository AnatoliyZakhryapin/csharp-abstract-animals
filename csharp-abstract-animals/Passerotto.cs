using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Passerotto : Animale
    {
        public override string Cibo { get; set; } = "Semi";

        public override string Verso()
        {
            return "Chirik Chirik";
        }
    }
}

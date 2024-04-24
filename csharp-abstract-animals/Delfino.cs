using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Delfino : Animale
    {
        public override string Cibo { get; set; } = "Pesce";

        public override string Verso()
        {
            return "Verso di Delfino";
        }
    }
}

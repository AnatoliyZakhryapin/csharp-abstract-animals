﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Aquila : Animale
    {
        public override string Cibo { get; set; } = "Picoli mammiferi";

        public override string Verso()
        {
            return "Verso di Aquila";
        }
    }
}

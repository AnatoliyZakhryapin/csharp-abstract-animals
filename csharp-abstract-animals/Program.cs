﻿namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Animale> listaAnimali = new List<Animale>();
            listaAnimali.Add(new Cane());
            listaAnimali.Add(new Passerotto());
            listaAnimali.Add(new Aquila());
            listaAnimali.Add(new Delfino());

            foreach (Animale animale in listaAnimali)
            {
                Console.WriteLine($"Io sono: {animale.GetType().Name}");
                Console.WriteLine($"Il mio verso è: {animale.Verso()}");
                Console.WriteLine($"Quando dormo faccio: {animale.Dormi()}");
                Console.WriteLine($"Io mangio: {animale.Mangia()}");

                //animale is IVolabile ? animale.Vola() : animale.Nuota();
                //animale is IVolabile ? FaiVolare((IVolabile)animale)
                //       : (animale is INuotabile ? FaiNuotare((INuotabile)animale)
                //                                 : Console.WriteLine("Non posso né nuotare né volare"));

                if (animale is IVolabile)
                    FaiVolare((IVolabile)animale);
                //FaiVolare(animale);

                if (animale is INuotabile)
                    FaiNuotare((INuotabile)animale);

                Console.WriteLine();
            }
        }

        static void FaiVolare(IVolabile animale)
        {
            animale.Vola();
        }
        static void FaiNuotare(INuotabile animale)
        {
            animale.Nuota();
        }
    }
}


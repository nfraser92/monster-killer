using System;

namespace monsterkiller
{
    class Program
    {

            public static void Main()
            {
                Hunter VonRimmersmark = new Hunter("Erich", "Von Rimmersmark");

                Mummy tuts = new Mummy();

                VonRimmersmark.Burn(tuts);

                Vampire Vinny = new Vampire();

                VonRimmersmark.WieldSilver(Vinny);

                Ghoul Gary = new Ghoul();

                VonRimmersmark.SplashWater(Gary);

                Ghast Glen = new Ghast();

                VonRimmersmark.Burn(Glen);

                Wight Willie = new Wight();

                VonRimmersmark.WieldSilver(Willie);

                Demon Donny = new Demon();

                VonRimmersmark.SplashWater(Donny);

                Zombie Zak = new Zombie();

                VonRimmersmark.Burn(Zak);

                Console.WriteLine(VonRimmersmark);


            }
        }
    }

using System;
using System.Collections.Generic;

namespace monsterkiller {

public class Vampire : ICombustable, IStabbable
{
    public void Burn (string attack)
    {
        if (attack == "Fire") {
            Console.WriteLine("You just killed the Vampire");
        }
    }
    public void Stab (string attack)
    {
        if (attack == "Silver") {
            Console.WriteLine("You just killed the Vampire");
        }
    }
}
}
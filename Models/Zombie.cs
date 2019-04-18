using System;
using System.Collections.Generic;

namespace monsterkiller {

public class Zombie : ICombustable
{
    public void Burn (string attack)
    {
        if (attack == "Fire") {
            Console.WriteLine("You just killed the Zombie");
        }
    }
}
}
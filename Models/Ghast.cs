using System;
using System.Collections.Generic;

namespace monsterkiller {

public class Ghast : ICombustable, IDousable
{
    public void Burn (string attack)
    {
        if (attack == "Fire") {
            Console.WriteLine("You just killed the Ghoul");
        }
    }
    public void Douse (string attack)
    {
        if (attack == "Holy Water") {
            Console.WriteLine("You just killed the Ghoul");
        }
    }
}
}
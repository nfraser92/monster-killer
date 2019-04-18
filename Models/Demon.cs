using System;
using System.Collections.Generic;

namespace monsterkiller {

public class Demon : IStabbable, IDousable, ICombustable
{
    public void Stab (string attack)
    {
        if (attack == "Silver") {
            Console.WriteLine("You just killed the Demon");
        }
    }
    public void Douse (string attack)
    {
        if (attack == "Holy Water") {
            Console.WriteLine("You just killed the Demon");
        }
    }
    public void Burn (string attack)
    {
        if (attack == "Fire") {
            Console.WriteLine("You just killed the Demon");
        }
    }
}
}
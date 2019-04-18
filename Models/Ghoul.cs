using System;
using System.Collections.Generic;

namespace monsterkiller {

public class Ghoul : IStabbable, IDousable
{
    public void Stab (string attack)
    {
        if (attack == "Silver") {
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
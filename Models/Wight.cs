using System;
using System.Collections.Generic;

namespace monsterkiller {

public class Wight : IStabbable
{
    public void Stab (string attack)
    {
        if (attack == "Silver") {
            Console.WriteLine("You just killed the Wight one");
        }
    }
}
}
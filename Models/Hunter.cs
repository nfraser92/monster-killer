using System;
using System.Collections.Generic;

namespace monsterkiller
{

public class Hunter
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public List<string> Weapons { get; } = new List<string>() {
        "Silver", "Fire", "Holy Water"
    };

    public Hunter (string first, string last) {
        FirstName = first;
        LastName = last;
    }

    public void SplashWater (IDousable enemy) {
        enemy.Douse("Holy Water");  // Kills with holy water
    }

    public void Burn (ICombustable enemy) {
        enemy.Burn("Fire");  // Kills with fire
    }

    public void WieldSilver (IStabbable enemy) {
        enemy.Stab("Silver");   // Stabs with silver knife
    }

    public override string ToString () {
        return $"{FirstName} {LastName} kills monsters with the following weapons: {String.Join(", ", Weapons)}";
    }
}
}
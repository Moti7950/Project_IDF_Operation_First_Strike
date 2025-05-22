using System;

class FighterJet:StrikeWeapon
{
       public FighterJet():base("FitherJet",8, "buildings")
    {
        Console.WriteLine("operated by pilot");
    }

    public override void Strike(int amount)
    {
        if (amount > 3)
        {
            Console.WriteLine("can not strike more then one times at the same time");
        }
        if (this.AmmunitionCapacity <= 0)
        {
            Console.WriteLine("you have no a Ammunition to complete this strike");
        }
        else
        {
            Console.WriteLine($"{nameOfWeapon} strikes a {EffectiveAgainst} target {amount} of times!");
            this.AmmunitionCapacity -= amount;
        }

    }
}


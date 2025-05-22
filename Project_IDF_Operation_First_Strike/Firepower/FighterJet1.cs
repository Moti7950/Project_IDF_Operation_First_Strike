using System;

class FighterJet:StrikeWeapon
{
       public FighterJet():base("FitherJet",8, "buildings")
    {
        Console.WriteLine("operated by pilot");
    }

    public override void Strike(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("must be a positive number");
        }
        else if (amount > this.AmmunitionCapacity)
        {
            Console.WriteLine("you have no a Ammunition to complete this strike");
        }
        else if (amount > 3)
        {
            Console.WriteLine("can not strike more then three times at once");
        }
        else
        {
            Console.WriteLine($"{nameOfWeapon} is unleashing {amount} powerful strikes on an {EffectiveAgainst} target!");
            this.AmmunitionCapacity -= amount;
        }

    }
}


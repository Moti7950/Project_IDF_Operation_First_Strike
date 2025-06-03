using System;

class FighterJet:StrikeWeapon
{
       public FighterJet():base("FitherJet",4500,8, "building")
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
        else if (this.fuelSuplly < (500 * amount))
        {
            Console.WriteLine("you have no  fuel to complete this strike");
        }
        else
        {
            Console.WriteLine($"{nameOfWeapon} is unleashing {amount} powerful strikes on an {EffectiveAgainst} target!");
            this.AmmunitionCapacity -= amount;
            this.fuelSuplly -= 500;
        }

    }
}


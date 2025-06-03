using System;
using System.Drawing;

class Artillery:StrikeWeapon
{
    public Artillery():base("Artillery",100,40, "open area")
    {

    }
    public override void Strike(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("must be a positive number");
        }
        else if (amount >3)
        {
            Console.WriteLine("cannot strike more then three times at once");
        }
        else if (amount > this.AmmunitionCapacity )
        {
            Console.WriteLine("You don't have enough ammunition to complete this strike.");
        }
        else if (this.fuelSuplly < (40 * amount))
        {
            Console.WriteLine("you have no  fuel to complete this strike");
        }

        else
        {
            Console.WriteLine($"{nameOfWeapon} is unleashing {amount} powerful strikes on an {EffectiveAgainst} target!");
            this.AmmunitionCapacity -= amount;
            this.fuelSuplly -= 40;
        }
            
    }
}
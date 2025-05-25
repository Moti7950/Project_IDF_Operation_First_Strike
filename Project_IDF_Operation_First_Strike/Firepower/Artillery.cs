using System;
using System.Drawing;

class Artillery:StrikeWeapon
{
    public Artillery():base("Artillery",40, "open areas")
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
            Console.WriteLine("can not strike more then three times at once");
        }
        else if (amount > this.AmmunitionCapacity )
        {
            Console.WriteLine("you have no a Ammunition to complete this strike");
        }
        
        else
        {
            Console.WriteLine($"{nameOfWeapon} is unleashing {amount} powerful strikes on an {EffectiveAgainst} target!");
            this.AmmunitionCapacity -= amount;
        }
            
    }
    public override string ToString()
    {
        return $"{nameOfWeapon} - Ammo: {AmmunitionCapacity}, Effective Against: {EffectiveAgainst}";
    }

}
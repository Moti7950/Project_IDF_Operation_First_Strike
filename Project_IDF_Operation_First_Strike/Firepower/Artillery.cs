using System;
using System.Drawing;

class Artillery:StrikeWeapon
{
    public Artillery():base("Artillery",40, "open areas")
    {

    }
    public override void Strike(int amount)
    {
        if (amount >3)
        {
            Console.WriteLine("can not strike more then three times at the same time");
        }
        if (this.AmmunitionCapacity <= 0)
        {
            Console.WriteLine("you have no a Ammunition to complete this strike");
        }
        else
        {
            Console.WriteLine($"{nameOfWeapon} strikes a {EffectiveAgainst} {amount} of times target {amount} of times!");
            this.AmmunitionCapacity -= amount;
        }
            
    }
}
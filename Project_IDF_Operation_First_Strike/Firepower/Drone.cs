using System;

class Drone: StrikeWeapon
{
    public Drone() : base("Drone",3 , "people, vehicles")
    {
    }
    public override void Strike(int amount)
    {
        if (amount > 1)
        {
            Console.WriteLine("can not strike more then  once at the same time");
        }
        if (amount > this.AmmunitionCapacity )
        {
            Console.WriteLine("you have no  Ammunition to complete this strike");
        }
        
        else
        {
            Console.WriteLine($"{nameOfWeapon} strikes a {EffectiveAgainst}  target {amount} of times!");
            this.AmmunitionCapacity -= amount;
        }
    }
}
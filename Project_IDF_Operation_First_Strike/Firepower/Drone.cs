using System;

class Drone: StrikeWeapon
{
    public Drone() : base("Drone",3 , "people, vehicles")
    {
    }
    public override void Strike(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("must be a positive number");
        }

        else if (amount > this.AmmunitionCapacity)
        {
            Console.WriteLine("you have no  Ammunition to complete this strike");
        }
        else if (amount > 1)
        {
            Console.WriteLine("can not strike more then one time at once");
        }      
        
        else
        {
            Console.WriteLine($"{nameOfWeapon} is unleashing {amount} powerful strikes on an {EffectiveAgainst} target!");
            this.AmmunitionCapacity -= amount;
        }
    }
}
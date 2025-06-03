using System;

class Drone: StrikeWeapon
{
    public Drone(string name) : base("Drone",250,3 , "vehicle")
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
        else if (this.fuelSuplly < 30)
        {
            Console.WriteLine("you have no  fuel to complete this strike");
        }

         
        else
        {
            Console.WriteLine($"{nameOfWeapon} is unleashing {amount} powerful strikes on an {EffectiveAgainst} target!");
            this.AmmunitionCapacity -= amount;
            this.fuelSuplly -= 30;
        }
    }
}
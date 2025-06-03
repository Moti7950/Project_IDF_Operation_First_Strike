using System.Collections.Generic;
using System.Windows.Forms;

abstract class StrikeWeapon
{
    public string nameOfWeapon;
    public int AmmunitionCapacity;
    public string EffectiveAgainst;
    public double fuelSuplly;
    public static List<StrikeWeapon> ListOfWeapons = new List<StrikeWeapon>();

    public StrikeWeapon(string nameOfweapon ,int AmmunitionCapacity,double fuelSuplly,string EffectiveAgainst)
    {
        this.nameOfWeapon = nameOfweapon;
        this.AmmunitionCapacity = AmmunitionCapacity;
        this.EffectiveAgainst = EffectiveAgainst;
        this.fuelSuplly = fuelSuplly;
        ListOfWeapons.Add(this);

        



    }
    abstract public void Strike(int amount);
    
}
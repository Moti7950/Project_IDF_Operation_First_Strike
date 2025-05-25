using System.Windows.Forms;

abstract class StrikeWeapon
{
    public string nameOfWeapon;
    public int AmmunitionCapacity;
    public string EffectiveAgainst;

    public StrikeWeapon(string nameOfweapon,int AmmunitionCapacity,string EffectiveAgainst)
    {
        this.nameOfWeapon = nameOfWeapon;
        this.AmmunitionCapacity = AmmunitionCapacity;
        this.EffectiveAgainst = EffectiveAgainst;
    }
    abstract public void Strike(int amount);
    
}
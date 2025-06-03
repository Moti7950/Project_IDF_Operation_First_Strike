class Strike
{
    Intel intel { set; get; }
    StrikeWeapon Weapon { set; get; }
    TerroristData Terrorist { set; get; }

    public Strike(Intel intel, StrikeWeapon Weapon,  TerroristData Terrorist)
    {
        this.intel = intel;
        this.Weapon = Weapon;
        this.Terrorist = Terrorist;
    } 
    
}

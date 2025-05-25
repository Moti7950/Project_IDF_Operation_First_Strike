using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public class TerroristData
{
    //name
    private string _name;
    //Rank
    private int _rank;
    //Status = Bool
    private bool _status;
    //Weapons
    private string _weapons;
    //Location
    private string _location;
    public TerroristData(string name, int rank, bool status, string weapons, string location)
    {
        this._name = name;
        this._rank = rank;
        this._status = status;
        this._weapons = weapons;
        this._location = location;
    }

        //Method for get or set a name.
        public void setname(string namei)
        {
            this._name = namei;
        }
        public string getname()
        { 
            return this._name; 
        }

        //Method for get or set a rank.
        public void setrank(int ranki)
        {
            this._rank = ranki;
        }
        public int getrank(int ranki)
        { 
            return this._rank;
        }

        //Method for get or set a status.
        public void setstatus(bool statusi)
        { 
            this._status = statusi; 
        }
        public bool getstatus()
        {
            return this._status;
        }

        //Method for get or set a weapons.
        public void setWeapons(string weaponsi)
        {
            this._weapons = weaponsi; 
        }
        public string getWeapons(string weaponsi)
        {
            return this._weapons; 
        }

        //Method fpr get or set a location.
        public void setLocation(string location)
        {
        this._location = location;
        }
        public string getLocation(string location)
        {
        return this._location;
        }

    public override string ToString()
    {
        return $"Name: {_name}, Rank: {_rank}, Status: {_status}, Weapon: {_weapons}, Location: {_location}";
    }


}


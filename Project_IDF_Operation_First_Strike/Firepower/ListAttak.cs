using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Xml.Linq;

public class ListAttak
{
    private Dictionary<string, StrikeWeapon> ListAt = new Dictionary<string, StrikeWeapon>();
    public ListAttak()
    {
        FighterJet F16_1 = new FighterJet();
        Drone Hermes_460 = new Drone();
        Artillery M109 = new Artillery();
        ListAt.Add("F16", F16_1);
        ListAt.Add("Drone", Hermes_460);
        ListAt.Add("Artillery", M109);
    }
    public override string ToString()
    {
        string result = "Available Strike Units:\n";
        foreach (var kvp in ListAt)
        {
            result += $"Type: {kvp.Key}, Info: {kvp.Value}\n";
        }
        return result;

    }
    public StrikeWeapon GetStrikeUnit(string type)
    {
        if (ListAt.ContainsKey(type))
            return ListAt[type];
        else
            return null;
    }

}
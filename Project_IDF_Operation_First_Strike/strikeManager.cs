using System;
using System.Collections.Generic;
using System.Linq;

class strikeManager
{ 
    public  TerroristData GetMostDangerousTerrorist()
    {
        TerroristData mostDangerousTerrorist = null;

        foreach (TerroristData Terrorist in TerroristData.listOfTerrorist)
        {
            if (Terrorist.getStatus())
            {
                if (mostDangerousTerrorist == null || Terrorist.LevelOfDangour() > mostDangerousTerrorist.LevelOfDangour())
                {
                    mostDangerousTerrorist = Terrorist;
                }
            }
        }
        
        return mostDangerousTerrorist;
    }

    public Intel FindIntelOfTerrorist(TerroristData targetTerrorist)
    {
        foreach (Intel intel in Intel.listOfIntel)
        {
            if (intel.Terrorist == targetTerrorist)
            {
                return intel;
            }
        }
        return null;
    }


    public StrikeWeapon FindTheRightWeapon(Intel terrorist) 
    {
        foreach (var weapon in StrikeWeapon.ListOfWeapons)
        {
            
            if (terrorist.Location == weapon.EffectiveAgainst)
            {
                return weapon;
            }
        }
        return null;
    }

    public  void Strike(int amount)
    {

        //TerroristData mostDangrousTerrorist = TerroristData.listOfTerrorist[0];

        while (TerroristData.listOfTerrorist.Any(t => t.getStatus()))
        {
            
            TerroristData mostDangerous = GetMostDangerousTerrorist();
            if (mostDangerous == null)
            {
                Console.WriteLine("No more alive terrorists to strike.");
                break;
            }
            Intel intelOfTerrorist = FindIntelOfTerrorist(mostDangerous);
            if (intelOfTerrorist == null)
            {
                Console.WriteLine($"No intel found for {mostDangerous.getName()}. Skipping...");
                continue;
            }
            
            
            StrikeWeapon apropiateWeapon = FindTheRightWeapon(intelOfTerrorist);
            if (apropiateWeapon == null)
            {
                Console.WriteLine($"No suitable weapon found for {mostDangerous.getName()} in location '{intelOfTerrorist.Location}'. Skipping...");
                continue;
            }
            apropiateWeapon.Strike(amount);
            mostDangerous.setStatus(false);   

            }
        }
    }
    

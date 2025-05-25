using System; using System.Collections.Generic; using System.Linq; using System.Threading.Tasks; using System.Windows.Forms;

namespace Project_IDF_Operation_First_Strike
{
    internal static class Program 
    {
        static int GetWeaponPoints(string weapon)
        {
            switch (weapon.ToLower())
            {
                case "knife": return 1;
                case "gun": return 2;
                case "m16":
                case "ak47": return 3;
                default: return 0;
            }
        }

        static TerroristData FindMostDangerous(Dictionary<string, TerroristData> terrorists)
        {
            TerroristData mostDangerous = null;
            int maxScore = -1;

            foreach (var t in terrorists.Values)
            {
                if (!t.getstatus()) continue; 

                int rank = t.getrank(0);
                string weapon = t.getWeapons("");
                int score = rank * GetWeaponPoints(weapon);

                if (score > maxScore)
                {
                    maxScore = score;
                    mostDangerous = t;
                }
            }

            return mostDangerous;
        }


        static string RecommendStrikeUnit(string location)
        {
            location = location.ToLower();
            if (location.Contains("building")) return "F16";
            if (location.Contains("people") || location.Contains("vehicle")) return "Drone";
            if (location.Contains("open")) return "Artillery";
            return null;
        }

        static void Main()
            {
                // Loding Data
                Data dataManager = new Data();
                dataManager.HamasData();

                // craiting arry terorist
                ListofTerrorist terroristList = new ListofTerrorist();

                // Craiting array attak
                ListAttak firepowerList = new ListAttak();

                // Menu
                bool run = true;
                while (run)
                {
                    Console.WriteLine("\n=== IDF STRIKE MENU ===");
                    Console.WriteLine("1 - Show Available Strike Units");
                    Console.WriteLine("2 - Execute Manual Strike");
                    Console.WriteLine("3 - Show Terrorist Info");
                    Console.WriteLine("4 - Smart Auto Strike on Most Dangerous Terrorist");
                    Console.WriteLine("0 - Exit");
                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine(firepowerList);
                            break;

                        case "2":
                            Console.Write("Enter Unit Type (F16 / Drone / Artillery): ");
                            string unitType = Console.ReadLine();
                            Console.Write("How many strikes to execute? ");
                            if (int.TryParse(Console.ReadLine(), out int amount))
                            {
                                StrikeWeapon selectedUnit = firepowerList.GetStrikeUnit(unitType);
                                if (selectedUnit != null)
                                {
                                    selectedUnit.Strike(amount);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid strike unit type.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount.");
                            }
                            break;

                        case "3":
                            terroristList.getInfo();
                            break;

                    case "4":
                        Dictionary<string, TerroristData> terrorDict = terroristList.GetDictionary();
                        TerroristData topTerrorist = FindMostDangerous(terrorDict);

                        if (topTerrorist == null)
                        {
                            Console.WriteLine("No valid terrorists left to strike.");
                            break;
                        }

                        Console.WriteLine($"\nMost Dangerous Terrorist:");
                        Console.WriteLine(topTerrorist);

                        string location = topTerrorist.getLocation("");
                        string recommendedUnit = RecommendStrikeUnit(location);

                        Console.WriteLine($"Recommended Strike Unit: {recommendedUnit}");

                        StrikeWeapon strikeUnit = firepowerList.GetStrikeUnit(recommendedUnit);

                        if (strikeUnit != null && strikeUnit.AmmunitionCapacity > 0)
                        {
                            strikeUnit.Strike(1);
                            topTerrorist.setstatus(false); 
                            Console.WriteLine("Strike executed successfully.");
                            Console.WriteLine($"Target '{topTerrorist.getname()}' has been eliminated.");
                        }
                        else
                        {
                            Console.WriteLine("❌ Not enough ammunition. Strike aborted.");
                        }

                        break;

                    case "0":
                            run = false;
                            Console.WriteLine("Exiting simulation...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
            }

        }

    }
    

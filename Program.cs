using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESERT.con_Main
{
    public class Game
    {
        public static string playerName;
        public static bool insideOldBuilding = false;
        public static bool insideTownHall = false;
        public static bool insideCourtRoom = false;
        public static bool insideWarehouse = false;
        public static bool nameChosen = false;
        public static bool done = false;
        public static bool foundArea2 = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the DESERT.");
            Intro();
        }

        static void Intro()
        {
            Console.WriteLine("What is your name?");

            playerName = Console.ReadLine();
            if (playerName.Length == 0)
            {
                Console.WriteLine("Please enter a name.");
                Intro();
            }

            Console.WriteLine("Your name is {0}, is this correct? Y/N", playerName);

            do
            {
                string confirmName = Console.ReadLine().ToUpper();

                switch (confirmName)
                {
                    case "Y":
                        {
                            Console.WriteLine("Confirm. Thank you, {0}.", playerName);
                            nameChosen = true;
                            break;
                        }

                    case "N":
                        {
                            Intro();
                            nameChosen = false;
                            break;
                        }

                    default:
                        Console.WriteLine("Select an option!\n");
                        nameChosen = false;
                        break;
                }
            }
            while (nameChosen == false);

            Console.WriteLine("\nThe year is 2037. Russia and the \"West\" have been engaged in Cold War 2 since October 2018." +
                "\nThe cause? An assassination of a Russian national in Salisbury, 03 March of the same year." +
                "\nYou are a British Special Forces operative - codenamed Sandman. The MoD have referred to you as such since \n2024 - the locals know you as \"{0}\".", playerName);

            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

            Console.Write("You were assigned to Turkey - the Federation and Turkey have gotten close." +
                "\nYour job is to gather Russian Intelligence." +
                "\n");

            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

            VillageDesc();
        }

        private static void VillageDesc()
        {
            {
                Console.Write("You are in Adalar, a small district in Istanbul. There was recently an attack here." +
                "\nIn the centre of the village, there are 4 buildings surrounding you.\n");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();

                VillageBuildings();
            }
        }
        private static void VillageBuildings()
        {
            Console.Write("Choose a building by typing your response and hitting \"enter\"." +
            "\nOld Building" +
            "\nTown Hall" +
            "\nCourt" +
            "\nWarehouse\n");

            string building = Console.ReadLine().ToLower();

            switch (building)
            {
                case "old building":
                    Console.WriteLine("You enter the building.");
                    done = true;
                    inOldBuilding();
                    break;

                case "town hall":
                    Console.WriteLine("You enter the town hall.");
                    done = true;
                    InTownHall();
                    break;

                case "court":
                    done = true;
                    InCourt();
                    break;

                case "warehouse":
                    done = true;
                    InWarehouse();
                    break;

                default:
                    Console.WriteLine("Select a building.");
                    done = false;
                    VillageBuildings();
                    break;
            }

        }

        private static void VillageBuildings2()
        {

            Console.WriteLine("Choose an area by typing your response and hitting \"enter\"." +
            "\nOld building" +
            "\nTown Hall" +
            "\nCourt" +
            "\nWarehouse\n" +
            "Atasehir"
            );

            string building = Console.ReadLine().ToLower();

            switch (building)
            {
                case "Old building":
                    Console.WriteLine("You enter the building.");
                    done = true;
                    inOldBuilding();
                    break;

                case "town hall":
                    Console.WriteLine("You enter the town hall.");
                    done = true;
                    InTownHall();
                    break;

                case "court":
                    done = true;
                    InCourt();
                    break;

                case "warehouse":
                    done = true;
                    InWarehouse();
                    break;

                case "atasehir":
                    done = true;
                    Atasehir();
                    break;

                default:
                    Console.WriteLine("Select a building.");
                    done = false;
                    VillageBuildings();
                    break;
            }
        }


        private static void inOldBuilding()
        {
            Console.WriteLine("The building is empty of people. You approach the main room.\nThere appears to be a book on the floor - it is not a strange book. Do you open it? Y/N");
            string action1 = Console.ReadLine().ToUpper();

            switch (action1)
            {
                case "Y":
                    {
                        Console.WriteLine("There is a note in the book. It gives co-ordinates to a location unknown to you." +
                              "\nUpon checking your GPS, it appears to refer to a district called Ataşehir." +
                              "\nYou know little about this area, except that it is extremely densely populated." +
                              "\nIf there was an attack here, you wonder if the attack on Adalar was part of a larger plan." +
                              "\nThere is nothing else of note in here.");
                        foundArea2 = false;
                        insideOldBuilding = false;
                        done = false;
                        AtasehirAvailable();
                        break;
                    }
                case "N":
                    {
                        Console.WriteLine("You exit the building.");
                        VillageBuildings();
                        insideOldBuilding = false;
                        done = false;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You have not selected an action!");
                        inOldBuilding();
                        break;
                    }
            }

        }

        private static void InTownHall()
        {
            {
                Console.WriteLine("\nThe council is currently in a state of emergency.\nThe Town Hall is locked.\nPress enter to continue.");
                Console.ReadLine();
                VillageBuildings();
            }
        }

        private static void InCourt()
        {
            {
                Console.WriteLine("You enter the court.");
                Console.WriteLine("There is a trial ongoing in the court. Would you like to sit in on the trial? Y/N");
                string option1 = Console.ReadLine().ToUpper();

                while (option1.Contains("Y"))
                {
                    Console.WriteLine("The trial is about the attack on the town last week. They believe to have found the perpertrator." +
                        "\nHe was sentenced to 10 years unpaid labour. From what you understand, they're reopening the abandoned warehouse nearby.\nYou should check there to try and find a reason why.\n" +
                        "\nPress enter to continue.");
                    Console.ReadLine();
                    VillageDesc();
                    break;
                }
                if (option1.Contains("N"))
                {
                    VillageBuildings();
                }
            }
        }

        private static void InWarehouse()
        {
            {
                Console.WriteLine("You enter the warehouse." +
                    "Immediately, you hear a knocking noises from underneath the facility.\n You are not armed." +
                    "Continue searching? Y/N\n");
                string option1 = Console.ReadLine().ToUpper();

                switch (option1)
                {
                    case "Y":
                        {
                            Console.WriteLine("\nWalking deeper into the warehouse, you hear more strange noises coming from what you assume is the basement of the facility." +
                                "\n\nYou find a note! \n\nIt says \"Sandman:\nReal Name --> {0}. Expect them.\" " +
                                "\nSomeone has discovered your double identity!.", playerName);
                            Console.WriteLine("Upon searching for someone whom may have left the note, \nyou discover there is nothing else here - the knocking noise was a decrepit generator.\nPress enter to leave the warehouse.");
                            Console.WriteLine("Press enter to continue.");
                            Console.ReadLine();

                            VillageBuildings();
                            break;
                        }
                    case "N":
                        {
                            Console.WriteLine("You leave the warehouse.");
                            Console.WriteLine("Press enter to continue.");
                            Console.ReadLine();

                            VillageBuildings();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Select an action!");
                            Console.WriteLine("Press enter to continue.");
                            Console.ReadLine();

                            InWarehouse();
                            break;
                        }
                }
            }
        }

        private static void AtasehirAvailable()
        {
            Console.WriteLine("You are in Adalar, a small district in Istanbul. There was recently an attack here." +
               "\nIn the centre of the village, there are 4 buildings surrounding you.\n");
            Console.WriteLine("\nChoose a building by typing your response and hitting \"enter\"." +
              "\nOld building" +
              "\nTown Hall" +
              "\nCourt" +
              "\nWarehouse\n");
            Console.WriteLine("Atasehir is now available. Type \"Atasehir\" to go there or continue searching in Adalar.\n");
            foundArea2 = true;
            VillageBuildings2();
        }

        private static void Atasehir()
        {
            Console.WriteLine("Your taxi has taken you to a hotel named CityLoft 81. This is where you'll be staying.\nIt seems nice, but you want to get on with your job.");
            Console.WriteLine("End of act 1. Press enter to exit.");
        }

    }

    /*start inventory class creation
    Inventory system to be in use from Act 2*/

    public class Weapons
    {
        List<string> weaponList = new List<string>
        { "Combat Knife", "M1911", "Silenced sniper" };
    }

    public abstract class OwnableItems
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int MaximumStackableQuantity { get; set; }

        protected OwnableItems()
        {
            MaximumStackableQuantity = 1;
        }
    }

    public class Weaponry : OwnableItems
    {

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLabb2
{
    class ListManager
    {

        #region Klassvarabler
        static List<Reptile> reptileList = new List<Reptile>();
        static List<Fish> fishList = new List<Fish>();
        static List<Bird> birdList = new List<Bird>();
        static List<Mammal> mammalList = new List<Mammal>();
        static List<Insects> insectsList = new List<Insects>();
        #endregion

        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("*                                         Choose List                                                    *");
            Console.WriteLine("*                                  -----------------------------                                         *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("*                                       1. Reptiles                                                      *");
            Console.WriteLine("*                                       2. Fishes                                                        *");
            Console.WriteLine("*                                       3. Bird                                                          *");
            Console.WriteLine("*                                       4. Mammal                                                        *");
            Console.WriteLine("*                                       5. Insects                                                       *");
            Console.WriteLine("*                                       6. Show all lists                                                *");
            Console.WriteLine("*                                       7. Back to main menu                                             *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("*                                  ------------------------------                                        *");
            Console.WriteLine("**********************************************************************************************************");

            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                    ShowRpetiles();
                    break;
                case ConsoleKey.NumPad2:
                    ShowFish();
                    break;
                case ConsoleKey.NumPad3:
                    ShowBird();
                    break;
                case ConsoleKey.NumPad4:
                    ShowMammal();
                    break;
                case ConsoleKey.NumPad5:
                    ShowInsects();
                    break;
                case ConsoleKey.NumPad6:
                    ShowAll();
                    break;
                case ConsoleKey.NumPad7:
                    List.MainMenu();
                    break;
                case ConsoleKey.D1:
                    ShowRpetiles();
                    break;
                case ConsoleKey.D2:
                    ShowFish();
                    break;
                case ConsoleKey.D3:
                    ShowBird();
                    break;
                case ConsoleKey.D4:
                    ShowMammal();
                    break;
                case ConsoleKey.D5:
                    ShowInsects();
                    break;
                case ConsoleKey.D6:
                    ShowAll();
                    break;
                case ConsoleKey.D7:
                    List.MainMenu();
                    break;

            }
        }
        #region Show under-methods
        private static void ShowAll()
        {
            Console.Clear();
            Console.WriteLine("************************************************************************************************************************************");
            Console.WriteLine("*********************************************    All lists     *********************************************************************");
            Console.WriteLine("\n************************************************************************************************************************************");

            Console.WriteLine("***********************************************************************************************************************************");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                               The list of reptiles                                                              *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");


            for (int i = 1; i < reptileList.Count; i++)
            {
                Console.WriteLine("*   " + i + ". " + reptileList[i - 1]);
            }
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");
            Console.WriteLine("*                                               The list of reptiles                                                              *");
            Console.WriteLine("***********************************************************************************************************************************");

            Console.WriteLine("***********************************************************************************************************************************");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                               The list of fishes                                                                *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");


            for (int i = 1; i < fishList.Count; i++)
            {
                Console.WriteLine("*   " + i + ". " + fishList[i - 1]);
            }
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");
            Console.WriteLine("*                                               The list of fishes                                                                *");
            Console.WriteLine("***********************************************************************************************************************************");

            Console.WriteLine("***********************************************************************************************************************************");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                               The list of mammals                                                               *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");


            for (int i = 1; i < mammalList.Count; i++)
            {
                Console.WriteLine("*   " + i + ". " + mammalList[i - 1]);
            }
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");
            Console.WriteLine("*                                               The list of mammals                                                               *");
            Console.WriteLine("***********************************************************************************************************************************");

            Console.WriteLine("***********************************************************************************************************************************");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                               The list of mammals                                                               *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");


            for (int i = 1; i < mammalList.Count; i++)
            {
                Console.WriteLine("*   " + i + ". " + mammalList[i - 1]);
            }
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");
            Console.WriteLine("*                                               The list of mammals                                                               *");
            Console.WriteLine("***********************************************************************************************************************************");

            Console.WriteLine("***********************************************************************************************************************************");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                               The list of insects                                                               *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");


            for (int i = 1; i < insectsList.Count; i++)
            {
                Console.WriteLine("*   " + i + ". " + insectsList[i - 1]);
            }
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");
            Console.WriteLine("*                                               The list of insects                                                               *");
            Console.WriteLine("\n***********************************************************************************************************************************");

            Console.WriteLine("*************************     Press any key to Go back to Main Menu    *************************************************************");
            Console.ReadKey(true);
            List.MainMenu();
        }

        private static void ShowInsects()
        {
            Console.Clear();
            Console.WriteLine("***********************************************************************************************************************************");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                               The list of insects                                                               *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");


            for (int i = 1; i < insectsList.Count; i++)
            {
                Console.WriteLine("*   " + i + ". " + insectsList[i - 1]);
            }
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");
            Console.WriteLine("*                                               The list of insects                                                               *");
            Console.WriteLine("\n***********************************************************************************************************************************");

            Console.WriteLine("*************************     Press any key to Go back to Main Menu    *************************************************************");
            Console.ReadKey(true);
            List.MainMenu();
        }

        private static void ShowMammal()
        {
            Console.Clear();
            Console.WriteLine("***********************************************************************************************************************************");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                               The list of mammals                                                               *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");


            for (int i = 1; i < mammalList.Count; i++)
            {
                Console.WriteLine("*   " + i + ". " + mammalList[i - 1]);
            }
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");
            Console.WriteLine("*                                               The list of mammals                                                               *");
            Console.WriteLine("\n***********************************************************************************************************************************");

            Console.WriteLine("*************************     Press any key to Go back to Main Menu    *************************************************************");
            Console.ReadKey(true);
            List.MainMenu();
        }

        private static void ShowBird()
        {
            Console.Clear();
            Console.WriteLine("***********************************************************************************************************************************");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                               The list of birds                                                                 *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");


            for (int i = 1; i < birdList.Count; i++)
            {
                Console.WriteLine("*   " + i + ". " + birdList[i - 1]);
            }
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");
            Console.WriteLine("*                                               The list of birds                                                                 *");
            Console.WriteLine("\n***********************************************************************************************************************************");

            Console.WriteLine("*************************     Press any key to Go back to Main Menu    *************************************************************");
            Console.ReadKey(true);
            List.MainMenu();
        }

        private static void ShowFish()
        {
            Console.Clear();
            Console.WriteLine("***********************************************************************************************************************************");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                               The list of fishes                                                                *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");


            for (int i = 1; i < fishList.Count; i++)
            {
                Console.WriteLine("*   " + i + ". " + fishList[i - 1]);
            }
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");
            Console.WriteLine("*                                               The list of fishes                                                                *");
            Console.WriteLine("\n***********************************************************************************************************************************");

            Console.WriteLine("*************************     Press any key to Go back to Main Menu    *************************************************************");
            Console.ReadKey(true);
            List.MainMenu();
        }

        private static void ShowRpetiles()
        {
            Console.Clear();
            Console.WriteLine("***********************************************************************************************************************************");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                               The list of reptiles                                                              *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");


            for (int i = 1; i < reptileList.Count; i++)
            {
                Console.WriteLine("*   " + i + ". " + reptileList[i - 1]);
            }
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");
            Console.WriteLine("*                                               The list of reptiles                                                              *");
            Console.WriteLine("\n***********************************************************************************************************************************");

            Console.WriteLine("*************************     Press any key to Go back to Main Menu    *************************************************************");
            Console.ReadKey(true);
            List.MainMenu();
        }
        #endregion

        public static void Add()
        {
            Console.Clear();
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("*                                         Choose List                                                    *");
            Console.WriteLine("*                                  -----------------------------                                         *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("*                                       1. Reptiles                                                      *");
            Console.WriteLine("*                                       2. Fishes                                                        *");
            Console.WriteLine("*                                       3. Bird                                                          *");
            Console.WriteLine("*                                       4. Mammal                                                        *");
            Console.WriteLine("*                                       5. Insects                                                       *");
            Console.WriteLine("*                                       6. Back to main menu                                             *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("*                                  ------------------------------                                        *");
            Console.WriteLine("**********************************************************************************************************");

            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                    AddRpetiles();
                    break;
                case ConsoleKey.NumPad2:
                    AddFish();
                    break;
                case ConsoleKey.NumPad3:
                    AddBird();
                    break;
                case ConsoleKey.NumPad4:
                    AddMammal();
                    break;
                case ConsoleKey.NumPad5:
                    AddInsects();
                    break;
                case ConsoleKey.NumPad6:
                    List.MainMenu();
                    break;
                case ConsoleKey.D1:
                    AddRpetiles();
                    break;
                case ConsoleKey.D2:
                    AddFish();
                    break;
                case ConsoleKey.D3:
                    AddBird();
                    break;
                case ConsoleKey.D4:
                    AddMammal();
                    break;
                case ConsoleKey.D5:
                    AddInsects();
                    break;
                case ConsoleKey.D6:
                    List.MainMenu();
                    break;
            }
        }
        #region Add under-methods
        private static void AddMammal()
        {
            var newMammal = new Mammal();

            Console.Write("Write th name: ");
            newMammal.Name = Console.ReadLine();
            Console.Write("Write the age: ");
            newMammal.Age = int.Parse(Console.ReadLine());
            Console.Write("Write the colour: ");
            newMammal.Colour = Console.ReadLine();
            Console.Write("Write the Genre (Male/Female): ");//--------------------------
            newMammal.Genre = Console.ReadLine();
            Console.Write("Write if this animal have fur or not (Y/N): ");//----------------------
            newMammal.FurOrNot = Console.ReadLine();
            Console.Write("Write the food type: ");
            newMammal.FoodType = Console.ReadLine();
            Console.Write("Write the weight: ");
            newMammal.Weight = int.Parse(Console.ReadLine());
            Console.Write("Write if this animal can Swim/Run/Fly: ");//------------------------
            newMammal.SwimRunFly = Console.ReadLine();

            mammalList.Add(newMammal);
            Add();
        }

        private static void AddInsects()
        {
            var newInsect = new Insects();

            Console.Write("Write th name: ");
            newInsect.Name = Console.ReadLine();
            Console.Write("Write the age: ");
            newInsect.Age = int.Parse(Console.ReadLine());
            Console.Write("Write the colour: ");
            newInsect.Colour = Console.ReadLine();
            Console.Write("Write the Genre (Male/Female): ");//--------------------------
            newInsect.Genre = Console.ReadLine();
            newInsect.FurOrNot = "not fur ";
            Console.Write("Write the food type: ");
            newInsect.FoodType = Console.ReadLine();
            Console.Write("Write the weight: ");
            newInsect.Weight = int.Parse(Console.ReadLine());
            Console.Write("Write if this animal can Fly/Swim/Walk: ");//------------------------
            newInsect.FlySwimWalk = Console.ReadLine();
            Console.Write("Write the number of legs: ");
            newInsect.NumberOfLegs = int.Parse(Console.ReadLine());

            insectsList.Add(newInsect);
            Add();
        }

        private static void AddBird()
        {
            var newBird = new Bird();

            Console.Write("Write th name: ");
            newBird.Name = Console.ReadLine();
            Console.Write("Write the age: ");
            newBird.Age = int.Parse(Console.ReadLine());
            Console.Write("Write the colour: ");
            newBird.Colour = Console.ReadLine();
            Console.Write("Write the Genre (Male/Female): ");//--------------------------
            newBird.Genre = Console.ReadLine();
            newBird.FurOrNot = "feather";
            Console.Write("Write the food type: ");
            newBird.FoodType = Console.ReadLine();
            Console.Write("Write the weight: ");
            newBird.Weight = int.Parse(Console.ReadLine());
            Console.Write("Write if this bird can fly or not: ");//------------------------
            newBird.CanFlyOrnot = Console.ReadLine();


            birdList.Add(newBird);
            Add();
        }

        private static void AddFish()
        {
            var newFish = new Fish();

            Console.Write("Write th name: ");
            newFish.Name = Console.ReadLine();
            Console.Write("Write the age: ");
            newFish.Age = int.Parse(Console.ReadLine());
            Console.Write("Write the colour: ");
            newFish.Colour = Console.ReadLine();
            Console.Write("Write the Genre (Male/Female): ");//--------------------------
            newFish.Genre = Console.ReadLine();
            newFish.FurOrNot = "not fur ";
            Console.Write("Write the food type: ");
            newFish.FoodType = Console.ReadLine();
            Console.Write("Write the weight: ");
            newFish.Weight = int.Parse(Console.ReadLine());
            Console.Write("Write if this fish Swim/Walk/Fly/Burrow: ");//------------------------
            newFish.SwimWalkFlyBurrow = Console.ReadLine();
            Console.Write("Describe the encironement that this fish live in exempel (salt lake, sweet water etc..):");
            newFish.Environement = Console.ReadLine();

            fishList.Add(newFish);
            Add();
        }

        private static void AddRpetiles()
        {
            var newReptile = new Reptile();

            Console.Write("Write th name: ");
            newReptile.Name = Console.ReadLine();
            Console.Write("Write the age: ");
            newReptile.Age = int.Parse(Console.ReadLine());
            Console.Write("Write the colour: ");
            newReptile.Colour = Console.ReadLine();
            Console.Write("Write the Genre (Male/Female): ");//--------------------------
            newReptile.Genre = Console.ReadLine();
            Console.Write("Write if this animal have fur or not (Y/N): ");//----------------------
            newReptile.FurOrNot = Console.ReadLine();
            Console.Write("Write the food type: ");
            newReptile.FoodType = Console.ReadLine();
            Console.Write("Write the weight: ");
            newReptile.Weight = int.Parse(Console.ReadLine());
            Console.Write("Write if this animal can Slither/Walk/Swim: ");//------------------------
            newReptile.SlitherWalkSwim = Console.ReadLine();
            Console.Write("Write the number of legs: ");
            newReptile.NumberOfLegs = int.Parse(Console.ReadLine());

            reptileList.Add(newReptile);
            Add();
        }
        #endregion

        public static void Remove()
        {
            Console.Clear();
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("*                                  Choose List there you want remove                                     *");
            Console.WriteLine("*                                  ----------------------------------                                    *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("*                                       1. Reptiles                                                      *");
            Console.WriteLine("*                                       2. Fishes                                                        *");
            Console.WriteLine("*                                       3. Bird                                                          *");
            Console.WriteLine("*                                       4. Mammal                                                        *");
            Console.WriteLine("*                                       5. Insects                                                       *");
            Console.WriteLine("*                                       6. Back to main menu                                             *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("*                                  -----------------------------------                                   *");
            Console.WriteLine("**********************************************************************************************************");

            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                    RemoveRpetiles();
                    break;
                case ConsoleKey.NumPad2:
                    RemoveFish();
                    break;
                case ConsoleKey.NumPad3:
                    RemoveBird();
                    break;
                case ConsoleKey.NumPad4:
                    RemoveMammal();
                    break;
                case ConsoleKey.NumPad5:
                    RemoveInsects();
                    break;
                case ConsoleKey.NumPad6:
                    List.MainMenu();
                    break;
                case ConsoleKey.D1:
                    RemoveRpetiles();
                    break;
                case ConsoleKey.D2:
                    RemoveFish();
                    break;
                case ConsoleKey.D3:
                    RemoveBird();
                    break;
                case ConsoleKey.D4:
                    RemoveMammal();
                    break;
                case ConsoleKey.D5:
                    RemoveInsects();
                    break;
                case ConsoleKey.D6:
                    List.MainMenu();
                    break;
            }
        }
        #region Remove under-methods
        private static void RemoveBird()
        {
            Console.Clear();
            Console.WriteLine("***********************************************************************************************************************************");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                               The list of birds                                                                 *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");


            for (int i = 1; i < birdList.Count; i++)
            {
                Console.WriteLine("*   " + i + ". " + birdList[i - 1]);
            }
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");
            Console.WriteLine("*                                               The list of birds                                                                 *");
            Console.WriteLine("\n***********************************************************************************************************************************");
            while (true)
            {
                Console.WriteLine("Which one do you want to remove, choose between 1 and {0}", birdList.Count);
                var input = Console.ReadLine();
                int controllInput = Convert.ToInt32(input);
                if (controllInput <= birdList.Count && controllInput >= 1)
                {
                    birdList.RemoveAt(controllInput - 1);
                    return;
                }
                else input = null;

            }
        }

        private static void RemoveFish()
        {
            Console.Clear();
            Console.WriteLine("***********************************************************************************************************************************");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                               The list of fishes                                                                *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");


            for (int i = 1; i < fishList.Count; i++)
            {
                Console.WriteLine("*   " + i + ". " + fishList[i - 1]);
            }
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");
            Console.WriteLine("*                                               The list of fishes                                                                *");
            Console.WriteLine("\n***********************************************************************************************************************************");
            while (true)
            {
                Console.WriteLine("Which one do you want to remove, choose between 1 and {0}", fishList.Count);
                var input = Console.ReadLine();
                int controllInput = Convert.ToInt32(input);
                if (controllInput <= fishList.Count && controllInput >= 1)
                {
                    fishList.RemoveAt(controllInput - 1);
                    return;
                }
                else input = null;

            }
        }

        private static void RemoveInsects()
        {
            Console.Clear();
            Console.WriteLine("***********************************************************************************************************************************");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                               The list of insects                                                               *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");


            for (int i = 1; i < insectsList.Count; i++)
            {
                Console.WriteLine("*   " + i + ". " + insectsList[i - 1]);
            }
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");
            Console.WriteLine("*                                               The list of insects                                                               *");
            Console.WriteLine("\n***********************************************************************************************************************************");
            while (true)
            {
                Console.WriteLine("Which one do you want to remove, choose between 1 and {0}", insectsList.Count);
                var input = Console.ReadLine();
                int controllInput = Convert.ToInt32(input);
                if (controllInput <= insectsList.Count && controllInput >= 1)
                {
                    insectsList.RemoveAt(controllInput - 1);
                    return;
                }
                else input = null;

            }
        }

        private static void RemoveMammal()
        {
            Console.Clear();
            Console.WriteLine("***********************************************************************************************************************************");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                               The list of mammals                                                               *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");


            for (int i = 1; i < mammalList.Count; i++)
            {
                Console.WriteLine("*   " + i + ". " + mammalList[i - 1]);
            }
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");
            Console.WriteLine("*                                               The list of mammals                                                               *");
            Console.WriteLine("\n***********************************************************************************************************************************");
            while (true)
            {
                Console.WriteLine("Which one do you want to remove, choose between 1 and {0}", mammalList.Count);
                var input = Console.ReadLine();
                int controllInput = Convert.ToInt32(input);
                if (controllInput <= mammalList.Count && controllInput >= 1)
                {
                    mammalList.RemoveAt(controllInput - 1);
                    return;
                }
                else input = null;

            }
        }

        private static void RemoveRpetiles()
        {
            Console.Clear();
            Console.WriteLine("***********************************************************************************************************************************");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                               The list of reptiles                                                              *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");


            for (int i = 1; i < reptileList.Count; i++)
            {
                Console.WriteLine("*   " + i + ". " + reptileList[i - 1]);
            }
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                                                                                                                                 *");
            Console.WriteLine("*                      -------------------------------------------------------------------------------                            *");
            Console.WriteLine("*                                               The list of reptiles                                                              *");
            Console.WriteLine("\n***********************************************************************************************************************************");
            while (true)
            {
                Console.WriteLine("Which one do you want to remove, choose between 1 and {0}", reptileList.Count);
                var input = Console.ReadLine();
                int controllInput = Convert.ToInt32(input);
                if (controllInput <= reptileList.Count && controllInput >= 1)
                {
                    reptileList.RemoveAt(controllInput - 1);
                    return;
                }
                else input = null;

            }
        }
        #endregion
    }
}

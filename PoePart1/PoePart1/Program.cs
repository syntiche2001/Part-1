using PoePart1;

namespace PoePart1
{

    class program
    {
        static void Main(string[] args)
        {

            RecipeManager recipeManager = new
                        RecipeManager();
            bool exit = false;
            while (!exit)
            { //application options 
                Console.WriteLine("1.Enter recipe ");
                Console.WriteLine("2.Display recipe ");
                Console.WriteLine("3.Scale Recipe ");
                Console.WriteLine("4.Reset quantities ");
                Console.WriteLine("5.Clear all data ");
                Console.WriteLine("6.Exit");
                Console.WriteLine();

                //Enter details of recipe

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                Console.WriteLine();
                switch (choice)
                {
                    case "1":
                        recipeManager.EnterRecipeDetails();
                        break;
                    case "2":
                        recipeManager.DisplayRecipe();
                        break;
                    case "3":
                        recipeManager.ScaleRecipe();
                        break;
                    case "4":
                        recipeManager.ResetQuantities();
                        break;
                    case "5":
                        recipeManager.ClearData();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:

                        //this will display if the user inputs the incorrect details.

                        Console.WriteLine("Invalid Choice. Please try again");
                        Console.WriteLine();
                        break;



                }



            }

        }
    }
}
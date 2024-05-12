using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POE_Part_1
{
    internal class addClass
    {
       //Creating variables

        public static String nameOfing; //Variable for name of Recipe
        public static int steps;        //Variable for steps
        public static int numOfIng;     //Variable for number of ingredients
        
       
        private int choice;

        //Creating arrays

        public static String[] ingArray;        //stores ingredints
        public static double[] amountArray;     //stores the amount of ingredients 
        public static String[] measureArray;    //stores the unit of measurement
        public static String[] stepArray;
        public static double[] calorieTot;
        public static String[] foodGroup;
        public static List<String> ingL;
        public static List<double> amountL;
        public static List<String> measureL;
        public static List<String> stepL;

        //Arrays to store the original values
        public static String[] ingArray2;
        public static double[] amountArray2;
        public static String[] measureArray2;
        public static String[] stepArray2;
        public static List<String> ingL2;
        public static List<double> amountL2;
        public static List<String> measureL2;
        public static List<String> stepL2;


        public void addRun() //Method that will run the recIng method to record recipe
        {
            addClass l = new addClass();  //Creates object
            l.recordRec();                    //Object is used to run recIng() method

        }

       
        public void recordRec() //method to run the recipe recording
        {
            Console.WriteLine("WELCOME TO RECIPE APP: ");  //Outputs message inside parameters

            //Console.WriteLine("Enter the recipe name");
            //nameOfing = Console.ReadLine(); 


            Console.ForegroundColor = ConsoleColor.Blue;
                //Accepts user input and stores in the variable

            Console.WriteLine("Enter number of ingredients ");
            numOfIng = int.Parse(Console.ReadLine());

            //List<String> ingL = new List<string>(numOfIng);
            //List<double> amountL = new List<string>(numOfIng);
            //List<String> measureL = new List<string>(numOfIng);
            //List<String> stepL = new List<string>(numOfIng);
            ingArray = new String[numOfIng];            //Declaring list size with numOfIng inputted by user
            amountArray = new double[numOfIng];
            measureArray = new String[numOfIng];
            calorieTot=new double[numOfIng];
            foodGroup= new String[numOfIng];


            ingArray2 = new String[numOfIng];            //Declaring original array size with numOfIng inputted by user
            amountArray2 = new double[numOfIng];
            measureArray2 = new String[numOfIng];
            


            int ingNo = 0;                              //Created variable with 0 as value
            for (int i = 0; i < numOfIng; i++)          //A for loop that will loop through the statement the number of times numOfIng represents
            {
                ingNo++;
                Console.WriteLine("Ingredient no." + ingNo + ":");
                ingArray[i] = Console.ReadLine();       //User input is inserted into arrays
                ingArray2[i] += ingArray[i];


                
                do
                {
                    Console.WriteLine("Enter quantity of ingredient: ");
                     
                } while (!double.TryParse(Console.ReadLine(), out amountArray[i]));
                amountArray2[i] += amountArray[i];

                Console.WriteLine("Enter unit of measurement: ");
                measureArray[i] = Console.ReadLine();
                measureArray2[i] += measureArray[i];

                
                do
                {
                    Console.WriteLine("Enter calorie count: ");

                } while (!double.TryParse(Console.ReadLine(), out calorieTot[i]));


                Console.WriteLine("Enter food group: ");
                foodGroup[i] = Console.ReadLine();

            }

            double calLimit = calorieMeth(calorieTot);
            Console.WriteLine(calLimit);
            if(calLimit > 300)
            {
                Console.WriteLine("CALORY LIMIT EXCEEDED!!!");
            }


           
            
            do {
                Console.WriteLine("Enter the number of steps to be taken: ");
            } while (!int.TryParse(Console.ReadLine(), out steps));


            stepArray = new string[steps];
            stepArray2 = new string[steps];

            int stepsNo = 0;
            for (int a = 0; a < stepArray.Length; a++)
            {
                stepsNo++;
                Console.WriteLine("Enter step No." + stepsNo);
                stepArray[a] = Console.ReadLine();
               
            }
            Console.WriteLine();
            choices();


        }
        public void choices() //Method for the options that user will choose
        {
            while (true)
            {   Console.ForegroundColor=ConsoleColor.Blue;
                Console.WriteLine("1. Add recipe \n2. Scale existing ingredients \n3. View Recipe \n4. Reset to original values \n5. Exit Application");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)                        //responds to user choice by running statement if matched with user input
                {
                    recordRec();
                    break;
                }
                else if (choice == 2)
                {
                    scalingClass t = new scalingClass();
                    t.adjust();
                    break;
                }
                else if (choice == 3)
                {
                    viewRec();
                    break;
                }
                else if (choice == 4)
                {
                    scalingClass t = new scalingClass();
                    t.resetOriginal();
                    break;
                }
                else if (choice == 5)
                {
                    Environment.Exit(1);
                }
            }
            

        }

        public double calorieMeth(double[] calorieTot)
        {
            double result = 0;
            for(int i = 0; i < calorieTot.Length; i++)
            {
                result+= calorieTot[i];
            }
            return result;
        }
        public void viewRec()                   //Method for viewing the recipe
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your recipe: " + nameOfing + "\nYour ingredients: ");
            for (int p = 0; p < numOfIng; p++)
            {
                Console.WriteLine($"- {amountArray[p]} {measureArray[p]} of {ingArray[p]}");
            }
            

            int st = 0;
            for (int j = 0; j < stepArray.Length; j++)
            {
                st++;
                Console.WriteLine($"Description for step No." + st + ": " + stepArray[j]);
            }
            Console.WriteLine();
            choices();
        }
        public void menu()
        {
            while (true)
            {
                Console.WriteLine("Please choose one of the following: ");
                Console.WriteLine("1. Create Recipe ");
                Console.WriteLine("2. Search Recipe ");
                Console.WriteLine("3. Display Recipe ");
                Console.WriteLine("4. Exit Application ");
                String ch=Console.ReadLine();
                switch (ch)
                {
                    
                        
                }
            }
        }
    
    }
    class recipeCount
    {
        private Dictionary<String, addClass> recDictionary;     //Declaring the Dictionary for the class
        public recipeCount(Dictionary<String, addClass> recDictionary)  //assigning the dictionary to the recipeCount class
        {
            this.recDictionary = recDictionary;
        }


        public void logRecipe()
        {
            Console.WriteLine("Enter number or recipes you wish to record: ");
            int recipeNum;
            if (!int.TryParse(Console.ReadLine(), out recipeNum))
            {
                for (int i = 0; i < recipeNum; i++) {
                    Console.WriteLine("Enter Recipe Name: ");
                    String recName = Console.ReadLine();
                    addClass recipe = new addClass();
                    recipe.recordRec();
                    recDictionary.Add(recName, recipe);

                }
            }

        }
    }

}



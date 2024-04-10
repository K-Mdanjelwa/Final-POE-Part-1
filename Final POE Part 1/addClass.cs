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
        public static int numOfIng2;    //Variable for name of ingredients
        private int choice;

        //Creating arrays

        public static String[] ingArray;        //stores ingredints
        public static double[] amountArray;     //stores the amount of ingredients 
        public static String[] measureArray;    //stores the unit of measurement
        public static String[] stepArray;       //stores the steps descriptions

        public static String[] ingArray2;
        public static double[] amountArray2;
        public static String[] measureArray2;
        public static String[] stepArray2;


        public void addRun()
        {
            addClass l = new addClass();  //Creates object
            l.recIng();                    //Object is used to run recIng() method

        }
        public void recIng()
        {

            Console.WriteLine("WELCOME TO RECIPE APP: ");  //Outputs message inside parameters

            Console.WriteLine("Enter the recipe name");
            nameOfing = Console.ReadLine();                 //Accepts user input and stores in the variable

            Console.WriteLine("Enter number of ingredients ");
            numOfIng = int.Parse(Console.ReadLine());
          

            ingArray = new String[numOfIng];            //Declaring array size with numOfIng inputted by user
            amountArray = new double[numOfIng];
            measureArray = new String[numOfIng];

           

            int ingNo = 0;                              //Created variable with 0 as value
            for (int i = 0; i < numOfIng; i++)          //A for loop that will loop through the statement the number of times numOfIng represents
            {
                ingNo++;
                Console.WriteLine("Ingredient no." + ingNo + ":");
                ingArray[i] = Console.ReadLine();       //User input is inserted into arrays
                


                Console.WriteLine("Enter quantity of ingredient: ");
                amountArray[i] = double.Parse(Console.ReadLine());
               

                Console.WriteLine("Enter unit of measurement: ");
                measureArray[i] = Console.ReadLine();
                
            }

            Console.WriteLine("Enter the number of steps to be taken: ");
            steps = Convert.ToInt32(Console.ReadLine());


            stepArray = new string[steps];
            

            int stepsNo = 0;
            for (int a = 0; a < stepArray.Length; a++)
            {
                stepsNo++;
                Console.WriteLine("Enter step No." + stepsNo);
                stepArray[a] = Console.ReadLine();
               
            }

          



        }
        public void choices()
        {
            Console.WriteLine("1. Add recipe \n2. Scale existing ingredients \n3. View Recipe \n4. Reset to original values \n5. Exit Application");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                recIng();
            }
            else if (choice == 2)
            {
                scalingClass t = new scalingClass();
                t.adjust();
            }
            else if (choice == 3)
            {
                viewRec();
            }
            else if (choice == 4)
            {
                scalingClass t = new scalingClass();
                t.resetOriginal();
            }
            else if (choice == 5)
            {
                Environment.Exit(1);
            }


        }
        public void viewRec()
        {
        }

    }

}

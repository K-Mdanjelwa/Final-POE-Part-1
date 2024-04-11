using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POE_Part_1
{
    internal class scalingClass
    {
        addClass p = new addClass(); //Creating object of addClass


        public void run()
        {


            p.choices();  //Calling methos from addClass class
        }
        public void adjust()  //Creating adjust method for selection of scaling
        {
            while (true)
            {
                Console.WriteLine("Choose one of the following: \n1. Double all quantities \n2. Half all quantities \n3. Triple \n4. Clear all data");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    double_();
                    Console.WriteLine("Ingredients are Doubled!");
                    Console.WriteLine();
                    run();
                    break;
                }
                else if (choice2 == 2)
                {
                    half();
                    Console.WriteLine("Ingredients are Halved!");
                    Console.WriteLine();
                    run();
                    break;
                }
                else if (choice2 == 3)
                {
                    triple();
                    Console.WriteLine("Ingredients are Tripled!");
                    Console.WriteLine();
                    run();
                    break;
                }
                else if (choice2 == 4)
                {
                    clear();
                    run();
                    break;
                }

            }
        }
        public void half()   //Creating method for halving the arrays
        {
            for (int i = 0; i < addClass.amountArray.Length; i++)
            {
                addClass.amountArray[i] /= 2;
            }
            Console.WriteLine("Divied by 2 applied to all quantities");
            Console.WriteLine();
            run();

        }
        public void double_()   //Creating method for doubling the arrays
        {
            for (int i = 0; i < addClass.amountArray.Length; i++)
            {

                addClass.amountArray[i] *= 2;
            }
            Console.WriteLine("Times 2 applied to all quantities");
            Console.WriteLine();
            run();

        }
        public void triple()    //Creating method for tripling the arrays
        {
            for (int i = 0; i < addClass.amountArray.Length; i++)
            {
                addClass.amountArray[i] *= 3;
            }
            Console.WriteLine("Triple applied to all quantities");
            Console.WriteLine();
            run();

        }
        public void clear()     //Creating method for clearing the arrays and variables
        {
            Console.WriteLine("Are you sure Y/N");

            String c = Console.ReadLine();
            if (c.Equals("y") || c.Equals("N"))
            {
                addClass.nameOfing = "";

                addClass.steps = 0;
                addClass.numOfIng = 0;
                addClass.ingArray = null;
                addClass.amountArray = null;
                addClass.measureArray = null;
                addClass.stepArray = null;

                Console.WriteLine("Data has been deleted");
                Console.WriteLine();
                run();
            }
            else if (c.Equals("n") || c.Equals("N"))
            {
                run();
            }
            else
            {
                Console.WriteLine("Please choose one of the options");

                        clear();

            }
        }

         public void resetOriginal()     //Creating method for rest the values to original values
         {
            for (int m = 0; m < addClass.numOfIng; m++)
            {

                addClass.amountArray[m] = addClass.amountArray2[m];         //copying over the original array values 
                addClass.measureArray[m] = addClass.measureArray2[m];
            }

            Console.WriteLine();
            Console.WriteLine("Successfully reset to original values");
            Console.WriteLine();
            run();
         }


    }

















}

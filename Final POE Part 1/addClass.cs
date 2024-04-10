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

        }
        public void choices()
        {

        }
        public void viewRec()
        {
        }

    }

}

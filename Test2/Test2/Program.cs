/*Vikramjeet Singh*/
/*Student ID 30014464*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program 
    {
        static void Main(string[] args)
        { //method
            Console.WriteLine("Welcome to the staff payroll system");
            Console.WriteLine("enter 1. to display salary");
            Console.WriteLine("enter 2. to display wages");
            Console.Write("Please enter the button"); ;
            int button = int.Parse(Console.ReadLine());

            
            {
                // salary class// 
                Salary s1 = new Salary();
                Console.WriteLine($"In per week is youe salary${Math.Round(s1.DisplaySalary(), 2)}");

                // 2blank lines
                Console.WriteLine();
                Console.WriteLine();
            }


            
            {
                // wages class//
                Wages w1 = new Wages();
                Console.Write("please enter the hour worked");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine($"Wages per week ${Math.Round(w1.DisplayWages(hours), 2)}");
                Console.ReadLine();
            }




        }
        public class Salary
        {
            //variables//
            public double annualsalary = 80000;
            public double weekely;
            
            /*getters and setters*/
            public double Annualsalary { get { return annualsalary; } set { annualsalary = 80000; } }
            public double weeklysalary { get { return weeklysalary; } set { weeklysalary = value; } }

            //Display the method of salary
            //number of weeks 365/7 = 52
            public double DisplaySalary()
            { double 80000/52;
                return $"per week salary is $ {Math.Round(income, 2)}";

            //create the constructor//
                public  Salary()
                {
                    Console.WriteLine("your salary is 80000 per year");
                    Annualsalary = 80000;
                }
            

            public class wages
            { //variables//
                private double hourlyrate;
                private double numHours;
                private double weeklyWages;

                /*getters and setters*/
                public double hourlyRate { get { return hourlyRate; } set { hourlyRate = 33.72; } }
                public double NumHours { get { return numHours; } set { numHours = value; } }
                public double WeeklyWages { get { return weeklyWages; } set { weeklyWages = value; } }

                //method of display wages//
                public string Displaywages(int hours)
                { double hourly = 33.72;
                    return $" wages per week is $ {Math.Round(hourly, 2)}";

                    //create the constructor//
                    public wages()
                    {
                        Console.WriteLine($"i will provide dispaly salary");
                    }
                }
            }
        }   
    }
}

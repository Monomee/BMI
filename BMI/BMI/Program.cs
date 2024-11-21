using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height, weight;
            Console.Write("Please enter a height (m): ");
            height = double.Parse(Console.ReadLine());
            Console.Write("Please enter your weight (kg): ");
            weight = double.Parse(Console.ReadLine());
            double bmi = weight / Math.Pow(height, 2);
            bmi = Math.Round(bmi, 1);
            Console.Write("BMI: " + bmi);

            if (bmi < 18.0)
                Console.WriteLine(" Underweight");
            else if (bmi < 25.0)
                Console.WriteLine(" Normal");
            else if (bmi < 30.0)
                Console.WriteLine(" Overweight");
            else
                Console.WriteLine(" Obese");

            Console.ReadLine();
        }
    }
}

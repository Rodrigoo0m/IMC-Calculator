using System;

public class BMICalculator
{
    public static void Main(string[] args)
    {
        double weightKg = 70;  
        double heightM = 1.75; 

        double bmi = CalculateBMI(weightKg, heightM);
        Console.WriteLine("O teu IMC e de: " + Math.Round(bmi, 2));
    }

    public static double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }
}

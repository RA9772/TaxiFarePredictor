using System;
using TaxiFarePredictionML.Model;


namespace TaxiFarePrediction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput();
            Console.Write("Enter Distance: ");
            input.Trip_distance = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Time: ");
            input.Trip_time_in_secs = Convert.ToInt32(Console.ReadLine());

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine("The estimated fare is: " + result.Score);
        }
    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string heightOption = "";
            string weightOption = "";
            for (int i =0; i<args.Length; i++)
            {
                if (i == 0) heightOption = args[i];
                if (i == 1) weightOption = args[i];
            }
        
            float height = InputAndParse(heightOption,"身長を入力してください");

            float weight = InputAndParse(weightOption,"体重を入力して下さい");

            float bmi = weight / (height * height);
            Console.WriteLine("BMIは" + bmi.ToString());

        }
        static float CalculateBMI(float weight, float height)
        {
            return weight / (height * height);
        }
        static float InputAndParse(string defaultInput, string massage)
        {
            float bmi = 0f;
            bool parseSuccess = float.TryParse(defaultInput, out bmi);
            while (!parseSuccess)
            {

                Console.WriteLine(massage);

                string inputbmi = Console.ReadLine();

                parseSuccess = float.TryParse(inputbmi, out bmi);

                if (!parseSuccess)
                    Console.WriteLine("エラー");
            }
            return bmi;
        }


    }
    
}

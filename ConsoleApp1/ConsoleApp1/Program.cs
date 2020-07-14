using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("オプション:" + args[i]);
            }
            float height = InputAndParse("身長を入力してください");

            float weight = InputAndParse("体重を入力して下さい");

            float bmi = weight / (height * height);
            Console.WriteLine("BMIは" + bmi.ToString());

        }
        static float CalculateBMI(float weight, float height)
        {
            return weight / (height * height);
        }
        static float InputAndParse(string massage)
        {
            float bmi = 0f;
            bool parseSuccess = false;
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

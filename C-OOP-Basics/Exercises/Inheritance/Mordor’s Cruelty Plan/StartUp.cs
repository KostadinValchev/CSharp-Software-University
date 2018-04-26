namespace Mordor_s_Cruelty_Plan
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<FoodFactory> food = new List<FoodFactory>();

            string[] input = Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var item in input)
            {
                switch (item)
                {
                    case "cram":
                        food.Add(new Cram());
                        break;
                    case "lembas":
                        food.Add(new Lembas());
                        break;
                    case "apple":
                        food.Add(new Apple());
                        break;
                    case "melon":
                        food.Add(new Melon());
                        break;
                    case "honeycake":
                        food.Add(new HoneyCake());
                        break;
                    case "mushrooms":
                        food.Add(new Mushrooms());
                        break;
                    default:
                        food.Add(new Else());
                        break;
                }
            }
            Console.WriteLine(food.Sum(x => x.Points));
            Console.WriteLine(new Mood(food.Sum(x => x.Points)));
        }
    }
}

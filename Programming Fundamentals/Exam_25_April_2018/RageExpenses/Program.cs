namespace RageExpenses
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int lostCount = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal dysplayPrice = decimal.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int dysplayCount = 0;
            int dysplayKeyboardCount = 0;

            bool headBool = false;
            bool mouseBool = false;

            
            for (int i = 1; i <= lostCount; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCount++;
                    headBool = true;

                }
                if (i % 3 == 0 && i != 1)
                {
                    mouseCount++;
                    mouseBool = true;
                }
                if (headBool == true && mouseBool == true)
                {
                    keyboardCount++;
                    dysplayKeyboardCount++;
                }
                if (dysplayKeyboardCount == 2)
                {
                    dysplayCount++;
                    dysplayKeyboardCount = 0;
                }

                headBool = false;
                mouseBool = false;
            }

            decimal headset = headsetPrice * headsetCount;
            decimal mouse = mousePrice * mouseCount;
            decimal keyboard = keyboardPrice * keyboardCount;
            decimal dyplay = dysplayPrice * dysplayCount;

            decimal result = headset + mouse + keyboard + dyplay;
            Console.WriteLine($"Rage expenses: {result:f2} lv.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;


namespace AsynchronousCakeMaking
{
    class SynchronousMaker
    {
        public void Run()
        {
            PreheatOven();
            MixIngredients();
            BakeCake();
            PrepareIcing();
            LetCakeCool();
            PutIcingOn();
            Console.WriteLine("Synchronous Cake is Complete!");
            Console.WriteLine("Time Taken: 17 seconds");
        }

        public void PreheatOven()
        {
            Console.WriteLine("Preheating Oven...");
            Delay(3000);
            Console.WriteLine("Oven Ready!");
        }

        static void MixIngredients()
        {
            Console.WriteLine("Adding flour...");
            Console.WriteLine("Adding Eggs...");
            Console.WriteLine("Adding Sugar...");
            Console.WriteLine("Adding Milk...");
            Console.WriteLine("Mixing...");
            Delay(3000);
            Console.WriteLine("Cake Mix Ready!");
        }

        static void BakeCake()
        {
            Console.WriteLine("Placing Cake in the Oven...");
            Console.WriteLine("Cake is in the Oven...");
            Delay(3000);
            Console.WriteLine("Cake is Baked!");
        }

        static void PrepareIcing()
        {
            Console.WriteLine("Adding Icing Sugar...");
            Console.WriteLine("Adding Butter...");
            Console.WriteLine("Adding Vanilla...");
            Delay(3000);
            Console.WriteLine("Icing Ready!");
        }

        static void LetCakeCool()
        {
            Console.WriteLine("Placing Cake out to Cool...");
            Delay(3000);
            Console.WriteLine("Cake has Cooled!");
        }

        static void PutIcingOn()
        {
            Console.WriteLine("Putting Icing on...");
            Delay(1500);
            Console.WriteLine("Icing on Cake!");
        }

        private static void Delay(int Time_delay)
        {
            int i = 0;
            //  ameTir = new System.Timers.Timer
            System.Timers.Timer _delayTimer = new System.Timers.Timer();
            _delayTimer.Interval = Time_delay;
            _delayTimer.AutoReset = false; //so that it only calls the method once
            _delayTimer.Elapsed += (s, args) => i = 1;
            _delayTimer.Start();
            while (i == 0) { };
        }
    }
}

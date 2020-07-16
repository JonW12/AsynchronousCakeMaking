using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousCakeMaking
{
    class AsynchronousMaker
    {
        public async Task Run()
        {
            Task<bool> preheatTask = PreheatOven();
            MixIngredients();
            _ = await preheatTask;
            Task<bool> bakeCakeTask = BakeCake();
            PrepareIcing();
            _ = await bakeCakeTask;
            LetCakeCool();
            PutIcingOn();
            Console.WriteLine("Asynchronous Cake is Complete!");
            Console.WriteLine("Time taken: 10.5 seconds");
            Console.ReadKey();
        }

        async Task<bool> PreheatOven()
        {
            Console.WriteLine("Preheating Oven...");
            await Task.Delay(3000);
            Console.WriteLine("Oven Ready!");

            return true;
        }

        void MixIngredients()
        {
            Console.WriteLine("Adding flour...");
            Console.WriteLine("Adding Eggs...");
            Console.WriteLine("Adding Sugar...");
            Console.WriteLine("Adding Milk...");
            Console.WriteLine("Mixing...");
            Delay(3000);
            Console.WriteLine("Cake Mix Ready!");
        }

        async Task<bool> BakeCake()
        {
            Console.WriteLine("Placing Cake in the Oven...");
            Console.WriteLine("Cake is in the Oven...");
            await Task.Delay(3000);
            Console.WriteLine("Cake is Baked!");

            return true;
        }

        void PrepareIcing()
        {
            Console.WriteLine("Adding Icing Sugar...");
            Console.WriteLine("Adding Butter...");
            Console.WriteLine("Adding Vanilla...");
            Delay(3000);
            Console.WriteLine("Icing Ready!");
        }

        void LetCakeCool()
        {
            Console.WriteLine("Placing Cake out to Cool...");
            Delay(3000);
            Console.WriteLine("Cake has Cooled!");
        }

        void PutIcingOn()
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

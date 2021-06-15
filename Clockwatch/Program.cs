using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clockwatch
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Quantos segundos gostaria de contar");
            //int x = int.Parse(Console.ReadLine());
            //Start(x);
            // Console.Clear();
            // Console.WriteLine("Pronto!");
            Menu();
          
            Console.ReadLine();
            
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos");
            Console.WriteLine("M = Minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string Data = Console.ReadLine().ToLower();
            char type = char.Parse(Data.Substring(Data.Length - 1, 1));
            int time = int.Parse(Data.Substring(0, Data.Length - 1));
            int multiplayer = 1;

            if (type == 'm')
                multiplayer = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplayer);

        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
            {
                int currentTime = time;
                while (currentTime != 0)
                {
                    Console.Clear();
                    currentTime--;
                    Console.WriteLine(currentTime);
                    Thread.Sleep(1000);
                    
                }
            }
  
 
    }

}


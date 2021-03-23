using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fortnite_Console
{
    class Program
    {
        static readonly string binPath = @"C:\Program Files\Epic Games\Fortnite\FortniteGame\Binaries\Win64\";
        static readonly string launcherExe = $"{binPath}FortniteLauncher.exe";
        static readonly string shippingExe = $"{binPath}FortniteClient-Win64-Shipping.exe";
        static readonly string eacShippingExe = $"{binPath}FortniteClient-Win64-Shipping_EAC.exe";
        static void Main(string[] args)
        {
            Console.WriteLine("Fortnite Console Tools. Made by Storm.\n\n\n");
            Thread.Sleep(2000);
            Console.WriteLine("FFFFFFFFFFFFFFFFFFFFFFNNNNNNNN        NNNNNNNN             CCCCCCCCCCCCC                                                                     lllllll                     ");
            Console.WriteLine("F::::::::::::::::::::FN:::::::N       N::::::N          CCC::::::::::::C                                                                     l:::::l                     ");
            Console.WriteLine("F::::::::::::::::::::FN::::::::N      N::::::N        CC:::::::::::::::C                                                                     l:::::l                     ");
            Console.WriteLine("FF::::::FFFFFFFFF::::FN:::::::::N     N::::::N       C:::::CCCCCCCC::::C                                                                     l:::::l                     ");
            Console.WriteLine("  F:::::F       FFFFFFN::::::::::N    N::::::N      C:::::C       CCCCCC   ooooooooooo   nnnn  nnnnnnnn        ssssssssss      ooooooooooo    l::::l     eeeeeeeeeeee    ");
            Console.WriteLine("  F:::::F             N:::::::::::N   N::::::N     C:::::C               oo:::::::::::oo n:::nn::::::::nn    ss::::::::::s   oo:::::::::::oo  l::::l   ee::::::::::::ee  ");
            Console.WriteLine("  F::::::FFFFFFFFFF   N:::::::N::::N  N::::::N     C:::::C              o:::::::::::::::on::::::::::::::nn ss:::::::::::::s o:::::::::::::::o l::::l  e::::::eeeee:::::ee");
            Console.WriteLine("  F:::::::::::::::F   N::::::N N::::N N::::::N     C:::::C              o:::::ooooo:::::onn:::::::::::::::ns::::::ssss:::::so:::::ooooo:::::o l::::l e::::::e     e:::::e");
            Console.WriteLine("  F:::::::::::::::F   N::::::N  N::::N:::::::N     C:::::C              o::::o     o::::o  n:::::nnnn:::::n s:::::s  ssssss o::::o     o::::o l::::l e:::::::eeeee::::::e");
            Console.WriteLine("  F::::::FFFFFFFFFF   N::::::N   N:::::::::::N     C:::::C              o::::o     o::::o  n::::n    n::::n   s::::::s      o::::o     o::::o l::::l e:::::::::::::::::e ");
            Console.WriteLine("  F:::::F             N::::::N    N::::::::::N     C:::::C              o::::o     o::::o  n::::n    n::::n      s::::::s   o::::o     o::::o l::::l e::::::eeeeeeeeeee  ");
            Console.WriteLine("  F:::::F             N::::::N     N:::::::::N      C:::::C       CCCCCCo::::o     o::::o  n::::n    n::::nssssss   s:::::s o::::o     o::::o l::::l e:::::::e           ");
            Console.WriteLine("FF:::::::FF           N::::::N      N::::::::N       C:::::CCCCCCCC::::Co:::::ooooo:::::o  n::::n    n::::ns:::::ssss::::::so:::::ooooo:::::ol::::::le::::::::e          ");
            Console.WriteLine("F::::::::FF           N::::::N       N:::::::N        CC:::::::::::::::Co:::::::::::::::o  n::::n    n::::ns::::::::::::::s o:::::::::::::::ol::::::l e::::::::eeeeeeee  ");
            Console.WriteLine("F::::::::FF           N::::::N        N::::::N          CCC::::::::::::C oo:::::::::::oo   n::::n    n::::n s:::::::::::ss   oo:::::::::::oo l::::::l  ee:::::::::::::e  ");
            Console.WriteLine("FFFFFFFFFFF           NNNNNNNN         NNNNNNN             CCCCCCCCCCCCC   ooooooooooo     nnnnnn    nnnnnn  sssssssssss       ooooooooooo   llllllll    eeeeeeeeeeeeee  ");
            Thread.Sleep(9000);
            Console.Clear();
            Console.WriteLine("Y = Launch Fortnite");
            Console.WriteLine("F = Verify your Fortnite");
            Console.WriteLine("L = Credits & Developer");
            Console.WriteLine("O = Gets your Fortnite Path, if you lost it.");
            Console.WriteLine("G = Source Code of Fortnite Console");
            Thread.Sleep(2000);
            
            if (Console.ReadKey().Key == ConsoleKey.G)
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine("Loading....");
                Thread.Sleep(2000);

                Console.WriteLine("Soure Code Of Fortnite Console: https://github.com/Mysa99/FNConsole");
                Thread.Sleep(1000);
            }
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine("Launching...");
                Thread.Sleep(2000);
                Process.Start("com.epicgames.launcher://apps/Fortnite?action=launch&silent=true");
                Console.WriteLine("Launched Fortnite!");
                Thread.Sleep(1000);
            }
            if (Console.ReadKey().Key == ConsoleKey.F)
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine("Verifying...");
                Thread.Sleep(2000);
                Process.Start("com.epicgames.launcher://apps/Fortnite?action=verify&silent=true");
                Console.WriteLine("Verified Fortnite!");
                Thread.Sleep(10000);
            }
            if (Console.ReadKey().Key == ConsoleKey.L)
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine("Fortnite Console Made with <3 By Storm.");
    
                Thread.Sleep(3000);
            }
            if (Console.ReadKey().Key == ConsoleKey.O)
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine(launcherExe + " ==> FortniteLauncher.exe Path");
                Thread.Sleep(20000);
            }


        }
        

}

}



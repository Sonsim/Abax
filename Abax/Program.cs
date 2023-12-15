using System.ComponentModel.Design;
using System.Net.Http.Headers;

namespace Abax
{
    internal class Program
    {
        public static Cars Bil1 = new Cars(147, "NF123456", 200, "grønn", "lett kjøretøy");
        public static Cars bil2 = new Cars(150, "NF654321", 195, "blå", "lett kjøretøy");
        public static Plane plane = new Plane(1000, "LN1234", 30, 2, 10, "jetfly");
        public static Boats boat = new Boats(30, 500, 100, "ABC123");

        List<Cars> AllCars = new List<Cars>{Bil1, bil2};
        static void Main()
        {
            Startmenu();
        }

        public static void Startmenu()
        {
            Console.WriteLine("Hva vil du gjøre?");
            Console.WriteLine("1. Printe ut info om alle kjøretøy");
            Console.WriteLine("2. Printe ut info om bil1");
            Console.WriteLine("3. Printe ut info om bil2");
            Console.WriteLine("4. Se flyet fly");
            Console.WriteLine("5. Se bilen kjøre");
            Console.WriteLine("6. Sammenligne bilene og se om de er like");
            Console.WriteLine("7. Avslutt");
            var ans = Convert.ToInt32(Console.ReadLine());

            switch (ans)
            {
                case 1: 
                    Console.Clear();
                    ShowAll();
                    break;
                case 2:
                    Console.Clear();
                    Bil1.PrintInfo();
                    ReturnToMenu();
                    break;
                case 3:
                    Console.Clear();
                    bil2.PrintInfo();
                    ReturnToMenu();
                    break;
                case 4:
                    Console.Clear();
                    plane.Fly();
                    ReturnToMenu();
                    break;
                case 5: 
                    Console.Clear();
                    Bil1.Drive();
                    ReturnToMenu();
                    break;
                case 6:
                    Console.Clear();
                    CompareCars(Bil1, bil2);
                    ReturnToMenu();
                    break;
                case 7:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;

            }
        }

        public static void ShowAll()
        {
            Bil1.PrintInfo();
            bil2.PrintInfo();
            plane.PrintInfo();
            plane.Fly();
            boat.PrintInfo();
            ReturnToMenu();
        }

        public static void ReturnToMenu()
        {
            Console.WriteLine("Y for å gå tilbake til meny og N for å avslutte");
            var ans = Console.ReadLine();

            switch (ans.ToLower())
            {
                case "y":
                    Console.Clear();
                    Startmenu();
                    break;
                case "n":
                    System.Environment.Exit(0);
                    break;
            }
        }

        public static void CompareCars(Cars car, Cars car2)
        {
            if (car.GetColor() == car2.GetColor() && car.GetMaxSpeed() == car2.GetMaxSpeed() &&
                car.GetType() == car2.GetType()
                && car.Idnr == car2.Idnr && car.Effect == car2.Effect)
            {
                Console.WriteLine("Bilene er like");
            }
            else
            {
                Console.WriteLine($"{car.Idnr} og {car2.Idnr} er ikke like");
            }
        }
    }

    
}
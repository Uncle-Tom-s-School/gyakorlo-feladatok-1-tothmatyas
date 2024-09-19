using System.Reflection.Metadata;

namespace vegyes_feladatok
{
    internal class Program
    {
        static void feladat1() {
            Console.WriteLine("Mennyien értékelték a programot?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Mennyien értékeltek pozitívan?");
            int p = int.Parse(Console.ReadLine());

            double szazalek = (p % n);
            
            if (szazalek >= 90) { 
                Console.WriteLine("A játék értékelése nagyon pozitív.");
            }
            if (szazalek >= 75 && szazalek <=89) 
            {
                Console.WriteLine("A játék értékelése  pozitív.");
            }
            if (szazalek >= 55 && szazalek <= 74)
            {
                Console.WriteLine("A játék értékelése többnyire pozitív.");
            }
            if (szazalek >= 45 && szazalek <= 54)
            {
                Console.WriteLine("A játék értékelése vegyes.");
            }
            if (szazalek >= 25 && szazalek <=44)
            {
                Console.WriteLine("A játék értékelése többnyire negatív.");
            }
            if (szazalek >= 10 && szazalek <= 24)
            {
                Console.WriteLine("A játék értékelése negatív.");
            }
            if (szazalek < 10)
            {
                Console.WriteLine("A játék értékelése nagyon negatív.");
            }

        }

        static void feladat2()
        {

            Random rnd = new Random();
            int enemy = rnd.Next(1, 3);

            Console.WriteLine("Kő, Parpír, vagy olló?(1,2,3)");
            int player = int.Parse(Console.ReadLine());

            // Nagyon csúnya :(
            if (enemy == player)
            {
                Console.WriteLine("Döntetlen");
            }
            if (enemy == 1 && player == 2)
            {
                Console.WriteLine("Nyertél");
            }
            if (enemy == 1 && player == 3)
            {
                Console.WriteLine("Vesztettél");
            }
            if (enemy == 2 && player == 1)
            {
                Console.WriteLine("Vesztettél");
            }
            if (enemy == 2 && player == 3)
            {
                Console.WriteLine("Nyertél");
            }
            if (enemy == 3 && player == 1)
            {
                Console.WriteLine("Nyertél");
            }
            if (enemy == 3 && player == 2)
            {
                Console.WriteLine("Vesztettél");
            }

        }
        static void feladat3() { 
        
        }

        static void feladat4() { }

        static void Main(string[] args)
        {
           // feladat2();
           // feladat1();
        }
    }
}

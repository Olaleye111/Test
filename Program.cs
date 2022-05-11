using System;

namespace Name
{
    class Human
    {
        public string name = "Adam";
        public string skinColor = "black";
        public int height;
        public int weight;
        public string hairColor = "Black";
        public void Talk()
        {
            Console.WriteLine("im talking");
        }
    }
    class Cars
    {
        public int tyres = 4;
        public string carColor = "grey";
        public string model = "Audi";
    }

        class Program
    {
        static void Main(string[] args)
        {
            Human Shefik = new Human();
            Shefik.hairColor = "Gold";
            Shefik.skinColor = "Yellow";
            Shefik.height = 5;
            Shefik.weight = 123;
            Shefik.Talk();
            Console.WriteLine(Shefik.name);

            Console.WriteLine("Boss car info");
            Cars Boss = new Cars();
            //Boss.carColor = Console.ReadLine();
            //Boss.model = Console.ReadLine();
            //Boss.tyres = int.Parse(Console.ReadLine());
            Console.WriteLine(Boss.carColor);
            Console.WriteLine(Boss.model);
            Console.WriteLine(Boss.tyres);

            //Car People = new Car();
            //People.color = "red";
        }
    }
}


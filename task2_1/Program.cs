namespace task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storage = new Storage();
            storage[0] = new Meat("Chicken", 100, Grade.extra, MeatType.Chicken);
            storage[1] = new Meat("Pork", 100, Grade.second_grade, MeatType.Pork);
            storage[2] = new DailyProduct("Apple", 100, Term.Week);
            storage[3] = new DailyProduct("Cake", 100, Term.Day);
            storage[4] = new Product("Magazine", 100);

            Console.WriteLine("Input meat name:");
            string meatName = Console.ReadLine();

            Console.WriteLine("Input meat price:");
            double meatPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Input meat grade:");
            string meatGrade = Console.ReadLine();

            Console.WriteLine("Input meat type:");
            string meatType = Console.ReadLine();




            storage.PrintMeat();
            storage.IncrisePrice(10);
            storage.Printall();
        }
    }
}
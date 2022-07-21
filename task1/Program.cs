namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //add new products
            var thing1 = new Product("Вода \"Моршинська\"");
            thing1.Price = 18;
            thing1.Wight = 1;
            var thing2 = new Product("Цукор", 35, 1);

            //buy product
            var buy1 = new Buy(thing1);
            buy1.SetCount(2);
            var buy2 = new Buy(thing2, 3);

            //checking
            var check = new Check();
            check.Add(buy1);
            check.Add(buy2);
            check.Print();
        }
    }
}
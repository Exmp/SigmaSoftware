namespace task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lenght:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Hight:");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];

            Matrix.FillSnake(matrix);
            Console.WriteLine("Snake");
            Matrix.PrintMatrix(matrix);

            matrix = new int[n, n];
            Matrix.FillDiagonalSnake(matrix);
            Console.WriteLine("Diagonal snake");
            Matrix.PrintMatrix(matrix);

            matrix = new int[n, m];
            Matrix.FillSpiralSnake(matrix);
            Console.WriteLine("Spiral snake");
            Matrix.PrintMatrix(matrix);
        }
    }
}
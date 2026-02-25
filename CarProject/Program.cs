namespace CarProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", "Red");

            Console.ReadLine();

            myCar.Accelerate(300);

            Console.ReadLine(); 
            
            myCar.Accelerate(10);

            Console.ReadLine();

            myCar.Stop();

            Console.ReadLine();

        }
    }
}

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Tacoma TRD Pro";
            myCar.Year = 2023;

            Console.WriteLine($"This is a {myCar.Make} {myCar.Model}, made in the year {myCar.Year}.");
        }
    }
}

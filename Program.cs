namespace Enum
{

    public enum days
    {
        sunday,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            days d = days.monday;
            Console.WriteLine("day is " + d);

            if (d==days.saturday || d==days.sunday)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("today is weeken");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("today is not weekend");


            }
            Console.ReadLine();
        }
        
    }
}

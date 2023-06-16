namespace _01._Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysPlundering = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double plunder = 0;

            for (int i = 1; i <= daysPlundering; i++)
            {
                plunder += dailyPlunder;
                if (i % 3 == 0)
                {
                    plunder += dailyPlunder * 0.50;
                }
                if (i % 5 == 0)
                {
                    plunder -= plunder * 0.30;
                }
            }
            if (expectedPlunder <= plunder)
            {
                Console.WriteLine($"Ahoy! {plunder:f2} plunder gained.");
            }
            else 
            {
                double percentage = plunder * 100 / expectedPlunder;
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}
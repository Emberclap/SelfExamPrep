using System.Threading.Channels;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            numbers.Sort();

            double avarage = numbers.Sum() / (double)numbers.Count;

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > avarage)
                {
                    result.Add(numbers[i]);
                }
            }
            result.Reverse();
            if (result.Count > 0)
            {
                 for (int i = 0; i < result.Count && i<5; i++)
                 {
                     Console.Write($"{result[i]} ");
                 }
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
        
    }
}
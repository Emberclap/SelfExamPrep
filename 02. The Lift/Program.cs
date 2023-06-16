namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxLoad = wagons.Count * 4;
            
            while (peopleWaiting > 0)
            {
                for (int i = 0; i < wagons.Count; i++)
                {
                    for(int j = wagons[i]; j < 4; j++)
                    {
                        if (peopleWaiting > 0)
                        {
                        peopleWaiting--;
                        wagons[i]++;
                        }
                        else
                        {
                            Console.WriteLine("The lift has empty spots!");
                            Console.WriteLine(string.Join(" ", wagons));
                            return;
                        }
                    }
                }
                if (wagons.Sum() == maxLoad && peopleWaiting > 0)
                {
                    Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                    Console.WriteLine(string.Join(" ", wagons));
                    return;
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
           
        }
    }
}
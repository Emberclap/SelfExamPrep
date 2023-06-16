namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> listWithNumbers = Console.ReadLine()
                .Split()
                .ToList();

            string input = " ";
            int movesCounter = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> commands = input
                    .Split()
                    .ToList();
                int firstIndex = int.Parse(commands[0]);
                int secondIndex = int.Parse(commands[1]);
                if (listWithNumbers.Count <= 0)
                {
                    break;
                    
                }
                movesCounter++;
                if (firstIndex == secondIndex || firstIndex < 0 || secondIndex < 0 || firstIndex > listWithNumbers.Count-1|| secondIndex > listWithNumbers.Count-1)
                {
                    listWithNumbers.Insert(listWithNumbers.Count / 2, $"-{movesCounter}a");
                    listWithNumbers.Insert(listWithNumbers.Count / 2, $"-{movesCounter}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }
                if (listWithNumbers[firstIndex] == listWithNumbers[secondIndex])
                {
                    string temp = listWithNumbers[firstIndex];
                    Console.WriteLine($"Congrats! You have found matching elements - {listWithNumbers[firstIndex]}!");
                    listWithNumbers.Remove(temp);
                    listWithNumbers.Remove(temp);
                }
                else if (listWithNumbers[firstIndex] != listWithNumbers[secondIndex])
                {
                    Console.WriteLine("Try again!");
                }
                
            }
            if (listWithNumbers.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", listWithNumbers));
            }
            else 
            {
                Console.WriteLine($"You have won in {movesCounter} turns!");
            }

        }
    }
}
namespace Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tresureChestState = Console.ReadLine()
                .Split('|')
                .ToList();
            string input = " ";
            while ((input = Console.ReadLine()) != "Yohoho!")
            {
                List<string> commands = input
                    .Split()
                    .ToList();
                
                switch (commands[0])
                {
                    case "Loot": 
                        for (int i = 1; i < commands.Count; i++)
                        {
                            if (!tresureChestState.Contains(commands[i]))
                            {
                                tresureChestState.Insert(0, commands[i]);
                            }
                        }
                        break;
                    case "Drop":
                        int index = int.Parse(commands[1]);
                        if (index >= 0 && index < tresureChestState.Count-1)
                        {
                            string temp = tresureChestState[index];
                            tresureChestState.RemoveAt(index);
                            tresureChestState.Add(temp);
                        }
                        break;
                    case "Steal":
                        int stealCount = int.Parse(commands[1]);
                        if (stealCount > 0)
                        {

                            List<string> stealedItems = new List<string>();
                            for (int i = 0;i < stealCount;i++)
                            {
                                if (tresureChestState.Count > 0)
                                {
                                stealedItems.Add(tresureChestState[tresureChestState.Count - 1]);
                                tresureChestState.RemoveAt(tresureChestState.Count - 1);
                                }
                            }
                            stealedItems.Reverse();
                            Console.WriteLine(string.Join(", ", stealedItems));
                        }
                        break;
                }
            }
            if (tresureChestState.Count > 0)
                {
                double sum = 0;
                    for (int i = 0; i < tresureChestState.Count; i++)
                    {
                        sum += tresureChestState[i].Length;
                    }
                
                double averageGain = sum / tresureChestState.Count;
                
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
                }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
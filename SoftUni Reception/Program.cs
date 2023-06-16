namespace SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirtEmployee = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int allEmployeeForOneHour = firstEmployee + secondEmployee+ thirtEmployee;
            int timeNeed = 0;
            while (studentsCount > 0)
            {
                timeNeed++;                        
                if (timeNeed % 4 == 0)
                {        
                    continue;
                }
                studentsCount -= allEmployeeForOneHour;        

            }

            Console.WriteLine($"Time needed: {timeNeed}h.");
        }
    }
}
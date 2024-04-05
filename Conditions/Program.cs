namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE FIRST LIMIT :");
            int limiteInf = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER THE SECOND LIMIT :");
            int limiteSup = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER YOUR NUMBER :");
            int entier = int.Parse(Console.ReadLine());

            if (entier < limiteInf)
            {
                Console.WriteLine($"You entered {entier}, which is less than the first limit ({limiteInf}).");
                Console.WriteLine($"RESULT : {limiteInf}");
            }
            else if (entier > limiteSup)
            {
                Console.WriteLine($"You entered {entier}, which is superior than the second limit ({limiteSup}).");
                Console.WriteLine($"RESULT : {limiteSup}");
            }
            else
            {
                Console.WriteLine($"The entered integer ({entier}) is within the specified limits.");
                Console.WriteLine("No action needed.");
            }
        }
    }
}

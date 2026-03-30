using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Arrays_Mcelhannon_cj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a wholle number for any array size");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("enter a whole number for the array");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }
            Console.WriteLine($"the sum of the array is {sum}");

            Array.Sort(numbers);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

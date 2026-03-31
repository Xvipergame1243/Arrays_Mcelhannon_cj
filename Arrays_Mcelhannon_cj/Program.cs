using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Arrays_Mcelhannon_cj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a wholle number for any array size"); //asks user for array size
            int arraySize = Convert.ToInt32(Console.ReadLine()); //converts user input to an integer and stores it in arraySize variable
            int[] numbers = new int[arraySize]; //creates an array of integers with the size specified by the user and stores it in the numbers variable
            int sum = 0; //initializes a variable called sum to 0, which will be used to keep track of the sum of the numbers in the array

            for (int i = 0; i < numbers.Length; i++) //starts a for loop that iterates through each index of the numbers array
            {
                Console.WriteLine("enter a whole number for the array"); //asks user to enter a whole number for the array
                numbers[i] = Convert.ToInt32(Console.ReadLine()); //converts user input to an integer and stores it in the current index of the numbers array
                sum += numbers[i]; //adds the value of the current index of the numbers array to the sum variable
            }
            Console.WriteLine($"the sum of the array is {sum}"); //prints the sum of the numbers in the array to the console using string interpolation

            Array.Sort(numbers); //sorts the numbers array in ascending order using the Array.Sort method

            foreach (int number in numbers) //starts a foreach loop that iterates through each number in the sorted numbers array
            {
                Console.WriteLine(number); //prints each number in the sorted numbers array to the console
            }
        }
    }
}

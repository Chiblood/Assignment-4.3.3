/* Assignment 4.3.3
3. Write a program in C# Sharp to print all unique elements in an array.
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 1
element - 1 : 5
element - 2 : 1
Expected Output :
The unique elements found in the array are :
5
*/
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input the number of elements to be stored in the array :");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr1 = new int[n];
        int[] arr2 = new int[n];
        int i, j, k = 0, count;

        Console.WriteLine("Input {0} elements in the array :", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < n; i++)
        {
            count = 0;
            for (j = 0; j < n; j++)
            {
                if (arr1[i] == arr1[j])
                {
                    count++;
                }
            }
            if (count < 2)
            {
                arr2[k] = arr1[i];
                k++;
            }
        }

        Console.WriteLine("The unique elements found in the array are :");
        for (i = 0; i < k; i++)
        {
            Console.WriteLine(arr2[i]);
        }
    }
}
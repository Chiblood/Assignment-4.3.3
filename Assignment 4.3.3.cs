/* Assignment 4.3.3
3. Write a program in C# Sharp to print all unique elements in an array using a dictionary.
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
        int [] arr1 = {1 , 5 , 1};
        Dictionary<int, int> numCountDict = new Dictionary<int, int>();

        // Count the occurrences of each number in the array
        foreach (int num in arr1)
        {
            if (numCountDict.ContainsKey(num))
            {
                numCountDict[num]++;
            }
            else
            {
                numCountDict[num] = 1;
            }
        }

        Console.WriteLine("The unique elements found in the array are :");
        // Print numbers that occurred only once
        foreach (var item in numCountDict)
        {
            if (item.Value == 1)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
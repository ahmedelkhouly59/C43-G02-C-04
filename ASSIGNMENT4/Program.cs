using System.Reflection.Metadata;

namespace ASSIGNMENT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.Write("Enter a number : ");
            //int num = int.Parse(Console.ReadLine() ?? "0");
            //int i = 1;
            //while (i <= num)
            //{
            //    if (i == num)
            //        Console.Write(i);
            //    else
            //        Console.Write(i + ",");
            //    i++;
            //}
            #endregion
            #region Q2 Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.Write("Enter a number : ");
            //int num = int.Parse(Console.ReadLine() ?? "0");
            //int i = 1;
            //while (i <= 12)
            //{
            //    if (i == 12)
            //        Console.Write((num * i));
            //    else
            //        Console.Write((i * num) + " ");
            //    i++;
            //}
            #endregion
            #region Q3 Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine() ?? "0");
            //int i = 1;
            //while (i <= num)
            //{
            //    if (i % 2 == 0)
            //    {
            //        if (i == num || (i + 1) == num)
            //            Console.Write(i);
            //        else
            //            Console.Write(i + " ");
            //    }
            //    i++;
            //}
            #endregion
            #region Q4 Write a program that takes two integers then prints the power.
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine() ?? "0");
            //Console.Write("Enter a power: ");
            //int pow = int.Parse(Console.ReadLine() ?? "0");
            //double result = Math.Pow(num, pow);
            //Console.WriteLine($"{num} ^ {pow} = {result}");
            #endregion
            #region Q5 Write a program to enter marks of five subjects and calculate total, average and percentage.
            //int[] marks = new int[5];
            //float total = 0f;
            //for (int i = 0; i < (marks.Length);)
            //{
            //    Console.Write($"Enter grade of subject {i + 1}: ");
            //    bool isParsed = int.TryParse(Console.ReadLine(), out int grade);
            //    if (isParsed)
            //    {
            //        marks[i] = grade;
            //        total += grade;
            //        i++;
            //    }
            //}
            //float avg = total / (marks.Length);
            //float percent = (total / 500) * 100;        //if each subject is out of 100
            //Console.WriteLine($"Total Marks is {total}");
            //Console.WriteLine($"Average of the marks is {avg}");
            //Console.WriteLine($"Percentage of the marks  is {percent}%");
            #endregion
            #region Q6 Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.Write("Enter a string: ");
            //string inp = Console.ReadLine();
            //string res = "";
            //int i = inp.Length;
            //while (i > 0)
            //{
            //    res += inp[i - 1];
            //    i--;
            //}
            //Console.WriteLine($"The reverse of word {inp} is {res}");
            #endregion
            #region Q7  Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine() ?? "0");
            //int x = num;
            //int reverse = 0;
            //while (num > 0)
            //{
            //    int remainder = num % 10;
            //    reverse = (reverse * 10) + remainder;
            //    num = num / 10;
            //}
            //Console.WriteLine($"The reverse of number {x} is {reverse}");
            #endregion
            #region Q8  Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.Write("Enter starting range of numbers : ");
            //int n = int.Parse(Console.ReadLine() ?? "0");
            //Console.Write("Enter ending range of numbers : ");
            //int m = int.Parse(Console.ReadLine() ?? "0");
            //int count = 0;
            //for (int i = n; i < m; i++)
            //{
            //    for (int z = 1; z <= i; z++)
            //    {
            //        if (i % z == 0)
            //            count++;
            //    }
            //    if (count == 2)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //    count = 0;
            //}
            #endregion
            #region Q9 Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.Write("Enter a number to convert: ");
            //int n = int.Parse(Console.ReadLine() ?? "0");
            //int[] arr = new int[20];
            //int i;
            //for (i = 0; n > 0; i++)
            //{
            //    arr[i] = n % 2;
            //    n = n / 2;
            //}
            //for (int j = i - 1; j >= 0; j--)
            //{
            //    Console.Write(arr[j]);
            //}
            #endregion
            #region Q10 Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //int[,] arr = new int[3, 2];
            //for (int z = 0; z < 3; z++)
            //{
            //    for (int m = 0; m < 2; m++)
            //    {
            //        if (m == 1)
            //        {
            //            Console.Write($"Enter y for point {z}: ");
            //            arr[z, m] = int.Parse(Console.ReadLine() ?? "0");
            //        }
            //        else
            //        {
            //            Console.Write($"Enter x for point {z}: ");
            //            arr[z, m] = int.Parse(Console.ReadLine() ?? "0");
            //        }
            //    }
            //}
            //float slope1 = (arr[1, 1] - arr[0, 1])*(arr[2, 0] - arr[1, 0]);
            //float slope2 = (arr[2, 1] - arr[1, 1])*(arr[1, 0] - arr[0, 0]);
            //if (slope1 == slope2)
            //    Console.WriteLine("They are on same straight line");
            //else
            //    Console.WriteLine("They aren't on same straight line");
            #endregion
            #region Q11 Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("Enter n for identity matrix: ");
            //int n = int.Parse(Console.ReadLine() ?? "0");
            //for (int z = 0; z < n; z++)
            //{
            //    for (int m = 0; m < n; m++)
            //    {
            //        if (m == n)
            //            Console.Write("1");
            //        else
            //    Console.Write("1 ");
            //    }
            //    Console.WriteLine("\n");
            //}
            #endregion
            #region Q12 Write a program in C# Sharp to find the sum of all elements of the array.
            //Console.Write("Enter the number of elements in array: ");
            //int len = int.Parse(Console.ReadLine() ?? "");
            //int[] arr = new int[len];
            //int sum = 0;
            //for (int i = 0; i < (arr.Length);)
            //{
            //    Console.Write($"Enter input of array of index {i}: ");
            //    bool isParsed = int.TryParse(Console.ReadLine(), out int x);
            //    if (isParsed)
            //    {
            //        arr[i] = x;
            //        sum += x;
            //        i++;
            //    }
            //}
            //Console.WriteLine($"The sum in the array is {sum}");

            #endregion
            #region Q13 Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] arr1 = new int[4]{ 4, 3, 7, 8 };
            //int[] arr2 = new int[4]{ 2, 30, 10, 12 };
            //int[] arr3 = new int[8];
            //Array.Sort(arr1);
            //Array.Sort(arr2);
            //int x = 0;
            //int y = 0;
            //for (int i = 0; i < ((arr1.Length*2)); i++)
            //{
            //    if ( x<arr1.Length && y<arr1.Length && arr1[x] <= arr2[y] )
            //    {
            //        arr3[i] = arr1[x];
            //        x++;
            //    }
            //    else if ( x < arr1.Length && y<arr1.Length && arr1[x] > arr2[y] )
            //    {
            //         arr3[i] = arr2[y];
            //         y++;
            //    }
            //    else if (y < arr1.Length && x>=arr1.Length) {
            //        arr3[i] = arr2[y];
            //        y++;
            //    }
            //    else 
            //    {
            //        arr3[i] = arr1[x];
            //        x++;
            //    }
            //}
            //for (int j = 0; j < (arr1.Length * 2); j++)
            //{
            //    Console.Write($"{arr3[j]} ");
            //}
            #endregion
            #region Q14  Write a program in C# Sharp to count the frequency of each element of an array.
            //int[] arr = new int[13] { 3, 5, 3, 5, 6, 7, 2, 3, 6, 8, 10, 12, 42 };
            //bool[] visit= new bool[arr.Length];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (visit[i])
            //        continue;
            //    int count = 1;
            //    for (int j = i + 1; j < arr.Length; j++){
            //        if (arr[i] == arr[j])
            //        {
            //            visit[j] = true;
            //            count++;
            //        }
            //    }
            //    Console.WriteLine($"DATA: {arr[i]}  --  COUNT:{count}");
            //}
            #endregion
            #region Q15 Write a program in C# Sharp to find maximum and minimum element in an array
            //Console.Write("Enter the number of elements in array: ");
            //int len = int.Parse(Console.ReadLine() ?? "");
            //int[] arr = new int[len];

            //for (int i = 0; i < (arr.Length);)
            //{
            //    Console.Write($"Enter input of array of index {i}: ");
            //    bool isParsed = int.TryParse(Console.ReadLine(), out int x);
            //    if (isParsed)
            //    {
            //        arr[i] = x;
            //        i++;
            //    }
            //}
            //int min = arr[0];
            //int max = arr[0];
            //for (int m = 0; m < (arr.Length); m++)
            //{
            //    if (arr[m] > max)
            //    {
            //        max = arr[m];
            //    }
            //    if (arr[m] < min)
            //    {
            //        min = arr[m];
            //    }
            //}
            //Console.WriteLine($"Maximum is {max} ");
            //Console.WriteLine($"Minimum is {min} ");
            #endregion
            #region Q16 Write a program in C# Sharp to find the second largest element in an array
            //Console.Write("Enter the number of elements in array: ");
            //int len = int.Parse(Console.ReadLine() ?? "");
            //int[] arr = new int[len];

            //for (int i = 0; i < (arr.Length);)
            //{
            //    Console.Write($"Enter input of array of index {i}: ");
            //    bool isParsed = int.TryParse(Console.ReadLine(), out int x);
            //    if (isParsed)
            //    {
            //        arr[i] = x;
            //        i++;
            //    }
            //}

            //int max = arr[0];
            //for (int m = 0; m < (arr.Length); m++)
            //{
            //    if (arr[m] > max)
            //    {
            //        max = arr[m];
            //    }
            //}

            //int secondlargest = arr[0];
            //for (int m = 0; m < (arr.Length); m++)
            //{
            //    if (arr[m] > secondlargest && (arr[m] != max))
            //    {
            //        secondlargest = arr[m];
            //    }
            //}

            //Console.WriteLine($"Second Largest is {secondlargest} ");
            #endregion
            #region Q17 Consider an Array of Integer values with size N, having values as in this Example
            //Console.Write("Enter the number of elements in array : ");
            //int n= int.Parse(Console.ReadLine()??"0");
            //int[] arr= new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Enter data of element {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine() ?? "0");
            //}
            //int distance = 0;
            //for (int j = 0; j < arr.Length-1; j++)
            //{
            //    for (int m = j + 1; m < arr.Length; m++)
            //    {
            //        if (arr[j] == arr[m])
            //        {
            //            distance = Math.Max(distance, m - j);
            //        }
            //    }
            //}
            //Console.WriteLine($"The maximum distance between two equal cells is {distance-1}");
            #endregion
            #region Q18  Given a list of space separated words, reverse the order of the words.
            //Console.Write("Enter the string : ");
            //String y = Console.ReadLine();
            //String[] x = y.Split(" ");
            //for (int i = x.Length; i > 0; i--)
            //{
            //    Console.Write($"{x[i - 1]} ");
            //}
            #endregion
            #region Q19 Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //Console.Write("Enter the first dimension of array : ");
            //int n = int.Parse(Console.ReadLine() ?? "0");
            //Console.Write("Enter the second dimension of array : ");
            //int m = int.Parse(Console.ReadLine() ?? "0");
            //int[,] firstarr = new int[n, m];
            //int[,] secondarr = new int[n, m];
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write($"Enter the data of the row {i} and column {j} : ");
            //        firstarr[i, j] = int.Parse(Console.ReadLine() ?? "0");
            //    }
            //}
            //for (int a = 0; a < n; a++)
            //{
            //    for (int b = 0; b < m; b++)
            //    {
            //        secondarr[a, b] = firstarr[a, b];
            //    }
            //}
            //Console.Clear();
            //Console.WriteLine("SECOND ARRAY ELEMENTS");

            //for (int t = 0; t < n; t++)
            //{
            //    for (int y = 0; y < m; y++)
            //    {
            //        Console.WriteLine($"row {t} column {y} ::: data {secondarr[t, y]}");
            //    }
            //}
            #endregion
            #region Q20 Write a Program to Print One Dimensional Array in Reverse Order
            //Console.Write("Enter the number of elements in array: ");
            //int n = int.Parse(Console.ReadLine() ?? "0");
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine() ?? "");
            //}
            //Console.Clear();
            //for (int m = n; m > 0; m--)
            //{
            //    Console.Write($"{arr[m - 1]} ");
            //}
            #endregion

        }
    }
}

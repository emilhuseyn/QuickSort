using System;

class Program
{
    static void Quicksort(int[] number, int first, int last)
    {
        int i, j, pivot, temp;
        if (first < last)
        {
            pivot = first;
            i = first;
            j = last;
            while (i < j)
            {
                while (number[i] <= number[pivot] && i < last)
                    i++;
                while (number[j] > number[pivot])
                    j--;
                if (i < j)
                {
                    temp = number[i];
                    number[i] = number[j];
                    number[j] = temp;
                }
            }
            temp = number[pivot];
            number[pivot] = number[j];
            number[j] = temp;
            Quicksort(number, first, j - 1);
            Quicksort(number, j + 1, last);
        }
    }

    static void Main()
    {
        int i, count;
        int[] number = new int[25];
        Console.Write("How many elements are u going to enter?: ");
        count = int.Parse(Console.ReadLine());
        Console.Write("Enter {0} elements: ", count);
        for (i = 0; i < count; i++)
            number[i] = int.Parse(Console.ReadLine());
        Quicksort(number, 0, count - 1);
        Console.Write("Order of Sorted elements: ");
        for (i = 0; i < count; i++)
            Console.Write(" {0}", number[i]);
    }
}

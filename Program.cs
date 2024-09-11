using System;

public static class ArrayReverser
{
    public static int[] Reverse(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left < right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;

            left++;
            right--;
        }

        return array;
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 5, 3 };
        Console.WriteLine("Оригінальний масив: " + string.Join(", ", numbers));

        ArrayReverser.Reverse(numbers);
        Console.WriteLine("Обернений масив: " + string.Join(", ", numbers));
    }
}
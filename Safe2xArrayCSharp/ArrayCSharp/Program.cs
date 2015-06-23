using System;

namespace ArrayCSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SafeArray safeArray;
            Console.WriteLine("Введите количество строк двумерного массива (если рваный - введите 0)");
            int numberOfLines = Convert.ToInt32(Console.ReadLine());
            if (numberOfLines == 0)
            {
                Console.WriteLine("Введите количество строк рваного массива");
                int numberOfJaggedLines = Convert.ToInt32(Console.ReadLine());
                safeArray = new SafeArray(false, numberOfJaggedLines);
            }
            else
                safeArray = new SafeArray(true, numberOfLines);
            string firstIndex = "zero";
            string secondIndex = "one";
            try
            {
                Console.WriteLine("array[{0}][{1}] = " + safeArray[firstIndex, secondIndex], firstIndex, secondIndex);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message.ToString() + ex.TargetSite.ToString());
            }
            safeArray.Show();
        }
    }
}
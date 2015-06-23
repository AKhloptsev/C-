using System;

namespace ArrayCSharp
{
    internal class SafeArray
    {
        private double[,] Array;
        private double[][] JaggedArray;
        private string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

        private int rows { set; get; }

        private int columns { set; get; }

        private bool flag;  // if false - jagged array

        public SafeArray()
            : this(true, 10)
        {
        }

        public SafeArray(bool _flag, int _rows)
        {
            rows = _rows;
            flag = _flag;
            int i = 0, j = 0;
            if (rows < 0)
                throw new IndexOutOfRangeException();
            Random rm = new Random();
            if (flag)   // if rectangular array
            {
                Console.WriteLine("Введите количество столбцов: ");
                columns = Convert.ToInt32(Console.ReadLine());
                Array = new double[rows, columns];
                for (i = 0; i < rows; i++)
                {
                    for (j = 0; j < columns; j++)
                    {
                        Array[i, j] = rm.Next(1, 10) + 1.0 / rm.Next(1, 10);
                    }
                }
            }
                // if jagged array
            else
            {
                JaggedArray = new double[rows][];
                for (i = 0; i < rows; i++)
                {
                    Console.WriteLine("Введите количество столбцов в {0} строке", i);
                    j = Convert.ToInt32(Console.ReadLine());
                    JaggedArray[i] = new double[j];
                }
                for (i = 0; i < rows; i++)
                {
                    for (j = 0; j < JaggedArray[i].Length; j++)
                    {
                        JaggedArray[i][j] = rm.Next(1, 10) + 1.0 / rm.Next(1, 10);
                    }
                }
            }
        }

        // If did not overstep the bounds
        public bool isAllright(int index1, int index2)
        {
            if (index1 < 0 || index1 > rows || index2 < 0)
            {
                if (flag)
                    if (index2 > columns)
                        return false;
                    else if (!flag)
                        if (index2 > JaggedArray[index1].Length)
                            return false;
            }
            return true;
        }

        // indexer overload
        public double this[int index1, int index2]
        {
            get
            {
                if (isAllright(index1, index2) == true)
                {
                    if (flag)
                        return Array[index1, index2];
                    else
                        return JaggedArray[index1][index2];
                }
                else
                    throw new IndexOutOfRangeException();
            }

            set
            {
                if (isAllright(index1, index2) == true)
                {
                    if (flag)
                        Array[index1, index2] = value;
                    else
                        JaggedArray[index1][index2] = value;
                }
                else
                    throw new IndexOutOfRangeException();
            }
        }

        // indexer as string
        private int getNumber(string num)
        {
            for (int i = 0; i < numbers.Length; i++)
                if (num == numbers[i])
                    return i;
            throw new System.ArgumentOutOfRangeException(num, "number must be in the form zero/one/two/three/etc");
        }

        // indexer overload
        public double this[string str1, string str2]
        {
            get
            {
                if (flag)
                    return Array[getNumber(str1), getNumber(str2)];
                return JaggedArray[getNumber(str1)][getNumber(str2)];
            }

            set
            {
                if (flag)
                    Array[getNumber(str1), getNumber(str2)] = value;
                else
                    JaggedArray[getNumber(str1)][getNumber(str2)] = value;
            }
        }

        public void Show()
        {
            // if rectangular array
            if (flag)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                        Console.Write("{0:##.##}\t", Array[i, j]);
                    Console.WriteLine();
                }
            }
                // if jagged array
            else
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < JaggedArray[i].Length; j++)
                        Console.Write("{0:##.##}\t", JaggedArray[i][j]);
                    Console.WriteLine();
                }
        }
    }
}
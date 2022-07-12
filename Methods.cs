namespace Seminar6
{
    class Methods
    {
        public static int[] CreateManualArray()
        {
            Console.Write(
                "\n\tПожалуйста введите количество обрабатываемых чисел,\n"
                    + "\tчтоб подсчитать сколько из них больше нуля:\n"
            );
            int length = 0;
            Console.Write("\t");
            string? sizeOfArray = Console.ReadLine();
            if (!String.IsNullOrEmpty(sizeOfArray))
                length = Convert.ToInt32(sizeOfArray.ToString());
            Console.WriteLine();

            int[] result = new int[length];
            int i = 0;
            while (i < length)
            {
                try
                {
                    Console.Write($"\tПожалуйста введите число No {i + 1}: ");
                    string? element = Console.ReadLine();
                    if (!String.IsNullOrEmpty(element))
                    {
                        result[i] = Convert.ToInt32(element.ToString());
                        i++;
                    }
                }
                catch
                {
                    Console.WriteLine("\tПроверьте ввод, он не корректный!");
                    continue;
                }
            }
            return result;
        }

        public static void PrintGotArray(ref int[] array)
        {
            int sizeOfArray = array.Length;
            if (sizeOfArray >= 3)
            {
                Console.WriteLine("\n\tВы ввели следующие цифры:\n");
                Console.Write($"\t({array[0]},");
                for (int i = 1; i < sizeOfArray - 1; i++)
                {
                    Console.Write($" {array[i]},");
                }
                Console.WriteLine($" {array[sizeOfArray - 1]})");
            }
            else if (sizeOfArray == 2)
            {
                Console.WriteLine("\n\tВы ввели следующие цифры:\n");
                Console.WriteLine($"\t({array[0]}, {array[1]})");
            }
            else if (sizeOfArray == 1)
            {
                Console.WriteLine("\n\tВы ввели следующие цифры:\n");
                Console.WriteLine($"\t{array[0]}");
            }
            else
            {
                Console.WriteLine("\tИзвините, но Вы не ввели ни одного числа!");
            }
        }
    }
}

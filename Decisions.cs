namespace Seminar6
{
    class Decisions
    {
        public static int NumberOfPositive(ref int[] values)
        {
            int count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static double[] GetDataForLines()
        {
            Console.Write(
                "\n\tПожалуйста введите данные для двух прямых,\n"
                    + "\tзаданных уравнениями y = k1 * x + b1, y = k2 * x + b2,\n"
                    + "\tчтоб определить координаты точки их пересечения\n\n"
            );
            int length = 4;
            double[] result = new double[length];
            int i = 0;
            while (i < length)
            {
                try
                {
                    switch (i)
                    {
                        case 0:
                            Console.Write($"\tПожалуйста введите k1: ");
                            break;
                        case 1:
                            Console.Write($"\tПожалуйста введите b1: ");
                            break;
                        case 2:
                            Console.Write($"\tПожалуйста введите k2: ");
                            break;
                        case 3:
                            Console.Write($"\tПожалуйста введите b2: ");
                            break;
                    }

                    string? element = Console.ReadLine();
                    if (!String.IsNullOrEmpty(element))
                    {
                        result[i] = Convert.ToDouble(element.ToString());
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

        public static void IntersectionPoint(double[] coordinates)
        {
            // прямая 1 : y = k1 * x + b1;
            // прямая 2 : y = k2 * x + b2;
            double k1 = coordinates[0],
                b1 = coordinates[1],
                k2 = coordinates[2],
                b2 = coordinates[3],
                x = 0,
                y = 0;

            if (k1 == k2 && b1 != b2)
            {
                Console.WriteLine(
                    "\n\tВаши получившиеся линии параллельны\n"
                        + "\tи не имеют точек пересечения!\n"
                );
            }
            else if (k1 == k2 && b1 == b2)
            {
                Console.WriteLine("\n\tВаши получившиеся линии совпадают!");
            }
            else
            {
                x = (b1 - b2) / (k2 - k1);
                y = k1 * x + b1;
                Console.WriteLine(
                    "\n\tКоординаты точки пересечения прямых:\n"
                        + $"\tдля х = {Math.Round(x, 3)}\n"
                        + $"\tдля y = {Math.Round(y, 3)}\n"
                );
            }
        }
    }
}

namespace Seminar6
{
    class Menu
    {
        public static void ReturnMenu()
        {
            Console.WriteLine(
                "\n\tПриветствую! Выберете пожалуйста задачу для проверки:\n"
                    + "\n"
                    + "\t\t1.Задача No 41:\n\n"
                    + "\tПользователь вводит с клавиатуры M чисел.\n"
                    + "\tПосчитайте, сколько чисел больше 0 ввёл пользователь.\n"
                    + "\n"
                    + "\t\t2.Задача No 43:\n\n"
                    + "\tНапишите программу, которая найдёт точку пересечения двух прямых,\n"
                    + "\tзаданных уравнениями y = k1 * x + b1, y = k2 * x + b2;\n"
                    + "\tзначения b1, k1, b2 и k2 задаются пользователем.\n"
            );
            Console.Write(
                "\tВведите номер пункта для перехода к задаче или q для выхода из программы: "
            );
        }
    }
}

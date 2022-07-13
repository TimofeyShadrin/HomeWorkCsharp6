namespace Seminar6
{
    class Task41
    {
        public static void ReturnTask41()
        {
            Console.Clear();
            int[] numbers = Methods.CreateManualArray();
            Methods.PrintGotArray(ref numbers);
            int quantity = Decisions.NumberOfPositive(ref numbers);
            Console.WriteLine($"\n\tВы ввели {quantity} положительных(-ое) числа(-ел, -ло).\n");
            Console.Write("\tНажмите любую клавишу для выхода в основное меню: ");
        }

    }
}
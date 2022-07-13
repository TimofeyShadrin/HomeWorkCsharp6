namespace Seminar6
{
    class Task43
    {
        public static void ReturnTask43()
        {
            Console.Clear();
            double[] linesData = Decisions.GetDataForLines();
            Decisions.IntersectionPoint(linesData);
            Console.Write("\tНажмите любую клавишу для выхода в основное меню: ");
        }
    }
}

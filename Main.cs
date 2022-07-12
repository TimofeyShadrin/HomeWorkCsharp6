namespace Seminar6
{
    class Program
    {
        static public string? answer = "0";
        public static void Main(string[] args)
        {
            while (true)
            {
                if (answer == "0")
                {
                    Console.Clear();
                    Console.Write("\n\tВыберите пункт: ");
                    answer = Console.ReadLine();
                    if (!String.IsNullOrEmpty(answer))
                        answer = answer.ToLower();
                }
                else if (answer == "1")
                {
                    Task41.ReturnTask41();
                    Console.ReadKey();
                    answer = "0";
                }
                else if (answer == "2")
                {
                    Task43.ReturnTask43();
                    Console.ReadKey();
                    answer = "0";
                }
                else if (answer == "q")
                    break;
                else
                    answer = "0";
            }
            Console.Clear();
        }

    }
}
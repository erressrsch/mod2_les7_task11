namespace mod2_les7_task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the grade [1-6]");

            int grade = int.Parse(Console.ReadLine());
            switch (grade)
            {
                case 1:
                    Console.WriteLine("Unsatisfactory");
                    break;

                case 2:
                    Console.WriteLine("Poor");
                    break;

                case 3:
                    Console.WriteLine("Satisfactory");
                    break;

                case 4:
                    Console.WriteLine("Good");
                    break;

                case 5:
                    Console.WriteLine("Very good");
                    break;

                case 6:
                    Console.WriteLine("Excellent");
                    break;
            }
        }
    }
}

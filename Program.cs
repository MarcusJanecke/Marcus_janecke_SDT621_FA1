namespace Marcus_Janecke_SDT621_FA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student name: ");
            string studentName = Console.ReadLine();

            double[] marks = new double[5];

            for (int i = 0; i < marks.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Enter mark for subject {i + 1}: ");
                    if (double.TryParse(Console.ReadLine(), out double mark) && mark >= 0 && mark <= 100)
                    {
                        marks[i] = mark;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                    }
                }
            }
            double total = marks[0] + marks[1] + marks[2] + marks[3] + marks[4];
            double average = total / marks.Length;
            string results = average >= 50 ? "Pass" : "Fsail";
            string issuedAt = DateTime.Now.ToString("dd mm yyyy");

            Console.WriteLine();
            Console.WriteLine("=====STUDENT REPORT CARD=====");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Average Marks: {average:F2}");
            Console.WriteLine($"Results: {results}");
            Console.WriteLine($"Issued At: {issuedAt}");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();


        }
    }
}

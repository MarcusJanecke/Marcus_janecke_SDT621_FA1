namespace StudentResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            double[] marks = new double[3];

            for (int i = 0; i < 3; i++)
            {
                while (true)
                {
                    Console.Write($"Enter mark for Subject {i + 1}: ");
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out double mark))
                    {
                        marks[i] = mark;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a numeric value.");
                    }
                }
            }

            double total = marks[0] + marks[1] + marks[2];
            double average = total / 3;
            string result = average >= 50 ? "PASS" : "FAIL";
            string issuedAt = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");

            Console.WriteLine();
            Console.WriteLine("===== STUDENT RESULTS =====");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Average Marks: {average:F1}");
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Result Issued At: {issuedAt}");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

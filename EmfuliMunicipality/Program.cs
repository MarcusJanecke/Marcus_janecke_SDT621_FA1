using System;
using System.Collections.Generic;

namespace EmfuleniMunicipality
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to Emfuleni Municipality Service Desk ===");

            // --- Capture Residents ---
            int residentCount = 0;
            while (true)
            {
                Console.Write("How many residents do you want to register? ");
                if (int.TryParse(Console.ReadLine(), out residentCount) && residentCount > 0)
                    break;
                Console.WriteLine("Please enter a valid number.");
            }

            List<Resident> residents = new List<Resident>();

            for (int i = 0; i < residentCount; i++)
            {
                Console.WriteLine($"\n---- Resident {i + 1} ----");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Address: ");
                string address = Console.ReadLine();

                Console.Write("Account Number: ");
                string accNum = Console.ReadLine();

                double usage = 0;
                while (true)
                {
                    Console.Write("Monthly Utility Usage (kWh or litres): ");
                    if (double.TryParse(Console.ReadLine(), out usage))
                        break;
                    Console.WriteLine("Invalid input.");
                }

                residents.Add(new Resident(name, address, accNum, usage));
            }

            // --- Capture Service Requests ---
            int requestCount = 0;
            while (true)
            {
                Console.Write("\nHow many service requests do you want to log? ");
                if (int.TryParse(Console.ReadLine(), out requestCount) && requestCount > 0)
                    break;
                Console.WriteLine("Please enter a valid number.");
            }

            List<ServiceRequest> requests = new List<ServiceRequest>();

            for (int i = 0; i < requestCount; i++)
            {
                Console.WriteLine($"\nService Request {i + 1}");

                // Select resident
                Console.Write("Select resident by number (1 to {0}): ", residents.Count);
                int residentIndex = 0;
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out residentIndex) &&
                        residentIndex >= 1 && residentIndex <= residents.Count)
                        break;
                    Console.Write($"Please enter a number between 1 and {residents.Count}: ");
                }

                Console.Write("Request Type (e.g., Water Outage, Burst Pipe): ");
                string requestType = Console.ReadLine();

                int priority = 0;
                while (true)
                {
                    Console.Write("Priority Level (1-5): ");
                    if (int.TryParse(Console.ReadLine(), out priority) && priority >= 1 && priority <= 5)
                        break;
                    Console.WriteLine("Priority must be between 1 and 5.");
                }

                int severity = 0;
                while (true)
                {
                    Console.Write("Severity Level (1-10): ");
                    if (int.TryParse(Console.ReadLine(), out severity) && severity >= 1 && severity <= 10)
                        break;
                    Console.WriteLine("Severity must be between 1 and 10.");
                }

                int hours = 0;
                while (true)
                {
                    Console.Write("Estimated Resolution Hours: ");
                    if (int.TryParse(Console.ReadLine(), out hours) && hours > 0)
                        break;
                    Console.WriteLine("Please enter a valid number of hours.");
                }

                requests.Add(new ServiceRequest(requestType, priority, severity, hours,
                    residents[residentIndex - 1]));
            }

            // --- Display Pending Queue ---
            UtilitiesManager manager = new UtilitiesManager();
            List<ServiceRequest> processedRequests = new List<ServiceRequest>();

            Console.WriteLine("\n==== Pending Service Request Queue ====");
            for (int i = 0; i < requests.Count; i++)
            {
                double score = manager.CalculateUrgencyScore(requests[i]);
                Console.WriteLine($"[{i + 1}] Resident: {requests[i].AssignedResident.Name} | " +
                    $"Type: {requests[i].RequestType} | Urgency Score: {score}");
            }

            // --- Interactive Processing ---
            while (processedRequests.Count < requests.Count)
            {
                Console.Write("\nEnter request number to process (or 0 to finish): ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                    continue;

                if (choice == 0)
                    break;

                if (choice < 1 || choice > requests.Count)
                {
                    Console.WriteLine("Invalid selection.");
                    continue;
                }

                ServiceRequest selected = requests[choice - 1];

                if (selected.IsProcessed)
                {
                    Console.WriteLine("This request has already been processed.");
                    continue;
                }

                selected.IsProcessed = true;
                processedRequests.Add(selected);
                manager.GenerateReport(selected);
            }

            // --- Final Summary ---
            if (processedRequests.Count > 0)
                manager.GenerateFinalSummary(processedRequests);

            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;

namespace EmfuleniMunicipality
{
    public class UtilitiesManager
    {
        public double CalculateUrgencyScore(ServiceRequest request)
        {
            return request.PriorityLevel * request.SeverityLevel;
        }

        public int CalculateAdjustedResolution(ServiceRequest request)
        {
            return request.EstimatedResolutionHours + request.PriorityLevel;
        }

        public double CalculateHouseholdImpact(ServiceRequest request)
        {
            return request.AssignedResident.MonthlyUtilityUsage * request.SeverityLevel;
        }

        // UPDATED in v2.0: cleaner separator style and account number shown
        public void GenerateReport(ServiceRequest request)
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("           SERVICE REPORT               ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Resident       : " + request.AssignedResident.Name);
            Console.WriteLine("Account No.    : " + request.AssignedResident.AccountNumber); // NEW in v2.0
            Console.WriteLine("Service Type   : " + request.RequestType);
            Console.WriteLine("Urgency Score  : " + CalculateUrgencyScore(request));
            Console.WriteLine("Adj. Resolution: " + CalculateAdjustedResolution(request) + " hours");
            Console.WriteLine("Impact Score   : " + CalculateHouseholdImpact(request).ToString("F2"));
            Console.WriteLine("----------------------------------------");
        }

        public void GenerateFinalSummary(List<ServiceRequest> processedRequests)
        {
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("       FINAL MUNICIPAL SUMMARY         ");
            Console.WriteLine("========================================");

            ServiceRequest highest = null;
            double highestScore = -1;
            double totalScore = 0; // NEW in v2.0

            foreach (var req in processedRequests)
            {
                double score = CalculateUrgencyScore(req);
                totalScore += score; // NEW in v2.0
                if (score > highestScore)
                {
                    highestScore = score;
                    highest = req;
                }
            }

            // NEW in v2.0: show average urgency score
            double averageScore = totalScore / processedRequests.Count;
            Console.WriteLine("Requests Processed : " + processedRequests.Count);
            Console.WriteLine("Average Urgency    : " + averageScore.ToString("F1"));
            Console.WriteLine();

            if (highest != null)
            {
                Console.WriteLine("--- Highest Priority Issue ---");
                Console.WriteLine("Resident       : " + highest.AssignedResident.Name);
                Console.WriteLine("Service Type   : " + highest.RequestType);
                Console.WriteLine("Urgency Score  : " + highestScore);
                Console.WriteLine("Adj. Resolution: " + CalculateAdjustedResolution(highest) + " hours");
                Console.WriteLine("Impact Score   : " + CalculateHouseholdImpact(highest).ToString("F2"));
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using the Emfuleni Municipality Service Desk.");
            Console.WriteLine("========================================");
        }
    }
}
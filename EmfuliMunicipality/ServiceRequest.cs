namespace EmfuleniMunicipality
{
    public class ServiceRequest
    {
        public string RequestType { get; set; }
        public int PriorityLevel { get; set; }   // 1 to 5
        public int SeverityLevel { get; set; }   // 1 to 10
        public int EstimatedResolutionHours { get; set; }
        public Resident AssignedResident { get; set; }
        public bool IsProcessed { get; set; }

        public ServiceRequest(string requestType, int priorityLevel, int severityLevel,
            int estimatedResolutionHours, Resident assignedResident)
        {
            RequestType = requestType;
            PriorityLevel = priorityLevel;
            SeverityLevel = severityLevel;
            EstimatedResolutionHours = estimatedResolutionHours;
            AssignedResident = assignedResident;
            IsProcessed = false;
        }
    }
}
using System.Collections.Generic;
using System;

namespace MunicipalServicesApp.Models
{
    public class ServiceRequest : IComparable<ServiceRequest> 
    {
        public int RequestID { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int Priority { get; set; }
        public List<int> Dependencies { get; set; }

        // Constructor
        public ServiceRequest(int requestId, string description, string status, int priority, List<int> dependencies = null)
        {
            RequestID = requestId;
            Description = description;
            Status = status;
            Priority = priority;
            Dependencies = dependencies ?? new List<int>();
        }

        //
        public int CompareTo(ServiceRequest other)
        {
            if (other == null) return 1;
            return RequestID.CompareTo(other.RequestID);
        }

        public override string ToString()
        {
            return $"ID: {RequestID}, Description: {Description}, Status: {Status}, Priority: {Priority}, Dependencies: [{string.Join(", ", Dependencies)}]";
        }
    }
}

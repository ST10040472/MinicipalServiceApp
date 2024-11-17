using System;
using System.Collections.Generic;

namespace MunicipalServicesApp.Models
{
    public class DependencyGraph
    {
        private Dictionary<int, ServiceRequest> serviceRequests; // Nodes (requests)
        private Dictionary<int, List<int>> adjacencyList; // Edges (dependencies)

        public DependencyGraph()
        {
            serviceRequests = new Dictionary<int, ServiceRequest>();
            adjacencyList = new Dictionary<int, List<int>>();
        }

        // Add a service request to the graph
        public void AddServiceRequest(ServiceRequest request)
        {
            if (!serviceRequests.ContainsKey(request.RequestID))
            {
                serviceRequests[request.RequestID] = request;
                adjacencyList[request.RequestID] = new List<int>();
            }
        }

        // Add a dependency (directed edge) between requests
        public void AddDependency(int requestId, int dependencyId)
        {
            if (adjacencyList.ContainsKey(requestId) && adjacencyList.ContainsKey(dependencyId))
            {
                adjacencyList[requestId].Add(dependencyId);
            }
        }

        // Get all dependencies of a specific request
        public List<int> GetDependencies(int requestId)
        {
            return adjacencyList.ContainsKey(requestId) ? adjacencyList[requestId] : new List<int>();
        }

        // Get all requests in the graph
        public List<ServiceRequest> GetAllRequests()
        {
            return new List<ServiceRequest>(serviceRequests.Values);
        }

        // Get the request by ID
        public ServiceRequest GetRequestById(int requestId)
        {
            return serviceRequests.ContainsKey(requestId) ? serviceRequests[requestId] : null;
        }
    }
}

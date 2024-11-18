using MunicipalServicesApp.Models;
using MunicipalServicesApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalServicesApp.Managers
{
    internal class ServiceRequestStatusManager
    {
        private AVLTree serviceRequestsTree;
        private DependencyGraph dependencyGraph;
        private PriorityQueue _priorityQueue;

        public ServiceRequestStatusManager()
        {
            serviceRequestsTree = new AVLTree();
            dependencyGraph = new DependencyGraph();
            _priorityQueue = new PriorityQueue(); // Initialize PriorityQueue
        }


        // Add sample requests to the AVL Tree and Priority Queue
        public void AddSampleRequests()
        {
            var sampleRequests = new List<ServiceRequest>
            {
                new ServiceRequest(1, "Water Leakage", "In Progress", 2, new List<int> { 3, 4 }),
                new ServiceRequest(2, "Broken Road", "Completed", 3, new List<int> { }),
                new ServiceRequest(3, "Electrical Fault", "Pending", 1, new List<int> { 5 }),
                new ServiceRequest(4, "Street Light Not Working", "In Progress", 2, new List<int> { 8 }),
                new ServiceRequest(5, "Garbage Collection", "In Progress", 1, new List<int> { 6, 7 }),
                new ServiceRequest(6, "Potholes Repair", "In Progress", 1, new List<int> { 9, 10 }),
                new ServiceRequest(7, "Traffic Signal Repair", "Completed", 2, new List<int> {  }),
                new ServiceRequest(8, "Public Park Cleaning", "Completed", 3, new List<int> { }),
                new ServiceRequest(9, "Road Sign Replacement", "Pending", 2, new List<int> { }),
                new ServiceRequest(10, "Road Expansion", "In Progress", 1, new List<int> { 17 }),
                new ServiceRequest(11, "Sewer System Cleaning", "Pending", 1, new List<int> { 13 }),
                new ServiceRequest(12, "Fire Hydrant Installation", "In Progress", 2, new List<int> { 6 }),
                new ServiceRequest(13, "Street Sweeping", "Completed", 3, new List<int> { }),
                new ServiceRequest(14, "Street Light Repair", "In Progress", 1, new List<int> { 15 }),
                new ServiceRequest(15, "Sidewalk Maintenance", "Pending", 2, new List<int> { 1 }),
                new ServiceRequest(16, "Traffic Light Installation", "Completed", 3, new List<int> { 6 }),
                new ServiceRequest(17, "Drainage System Repair", "In Progress", 1, new List<int> { 13, 14 }),
                new ServiceRequest(18, "Construction Waste Removal", "Pending", 2, new List<int> { 9, 10 }),
                new ServiceRequest(19, "Electricity Line Repair", "Completed", 3, new List<int> { 11, 12 }),
                new ServiceRequest(20, "Road Expansion", "In Progress", 1, new List<int> { 17 })
            };

            // Add the requests to both AVL Tree and Priority Queue
            foreach (var request in sampleRequests)
            {
                serviceRequestsTree.Insert(request);
                _priorityQueue.Enqueue(request); // Enqueue to priority queue
                dependencyGraph.AddServiceRequest(request);
            }

            // Add dependencies
            dependencyGraph.AddDependency(1, 3);
            dependencyGraph.AddDependency(1, 4);
            dependencyGraph.AddDependency(3, 5);
            dependencyGraph.AddDependency(5, 6);
            dependencyGraph.AddDependency(5, 7);
            dependencyGraph.AddDependency(4, 8);
            dependencyGraph.AddDependency(6, 9);
            dependencyGraph.AddDependency(6, 10);
            dependencyGraph.AddDependency(7, 3);
            dependencyGraph.AddDependency(7, 4);
            dependencyGraph.AddDependency(10, 7);
            dependencyGraph.AddDependency(10, 12);
            dependencyGraph.AddDependency(11, 13);
            dependencyGraph.AddDependency(12, 6);
            dependencyGraph.AddDependency(13, 8);
            dependencyGraph.AddDependency(14, 15);
            dependencyGraph.AddDependency(15, 1);
            dependencyGraph.AddDependency(17, 13);
            dependencyGraph.AddDependency(17, 14);
            dependencyGraph.AddDependency(18, 9);
            dependencyGraph.AddDependency(18, 10);
            dependencyGraph.AddDependency(19, 11);
            dependencyGraph.AddDependency(19, 12);
            dependencyGraph.AddDependency(20, 17);
        }


        //Fetech all requests in the AVL Tree
        public List<ServiceRequest> GetAllRequests()
        {
            return serviceRequestsTree.InOrderTraversal();
        }

        // Fetching requests in priority order using the priority queue
        public List<ServiceRequest> GetRequestsInPriorityOrder()
        {
            List<ServiceRequest> sortedRequests = new List<ServiceRequest>();
            while (_priorityQueue.Count > 0)
            {
                sortedRequests.Add(_priorityQueue.Dequeue());
            }
            return sortedRequests;
        }

        //Find a request by ID
        public ServiceRequest FindRequestById(int requestId)
        {
            return serviceRequestsTree.InOrderTraversal().FirstOrDefault(r => r.RequestID == requestId);
        }

        //get all dependencies of a request
        public List<int> GetDependencies(int requestId)
        {
            return dependencyGraph.GetDependencies(requestId);
        }

        //get all requests with dependencies
        public List<ServiceRequest> GetRequestsWithDependencies()
        {
            return dependencyGraph.GetAllRequests();
        }

        // Filter requests using priority and status filters
        public List<ServiceRequest> FilterRequests(string statusFilter, string priorityFilter)
        {
            return serviceRequestsTree.InOrderTraversal().Where(request =>
            {
                bool matchesStatus = string.IsNullOrEmpty(statusFilter) ||
                                     request.Status.Equals(statusFilter, StringComparison.OrdinalIgnoreCase);
                bool matchesPriority = string.IsNullOrEmpty(priorityFilter) ||
                                       int.TryParse(priorityFilter, out int priority) &&
                                       request.Priority == priority;
                return matchesStatus && matchesPriority;
            }).ToList();
        }


        // Filter requests with dependencies using priority and status filters
        public List<ServiceRequest> FilterGraphRequests(string statusFilter, string priorityFilter)
        {
            var filteredRequests = FilterRequests(statusFilter, priorityFilter);
            return filteredRequests.Where(req => dependencyGraph.GetDependencies(req.RequestID).Count > 0).ToList();
        }


    }
}

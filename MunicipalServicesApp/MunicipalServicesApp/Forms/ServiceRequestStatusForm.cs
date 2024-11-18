using MunicipalServicesApp.Managers;
using MunicipalServicesApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalServicesApp.Forms
{
    public partial class ServiceRequestStatusForm : Form
    {
        private readonly ServiceRequestStatusManager manager;
        private float zoomFactor = 1.0f;
        private PointF offset = new PointF(0, 0);
        private Point lastMousePosition;
        private Dictionary<int, PointF> positions = new Dictionary<int, PointF>();

        public ServiceRequestStatusForm()
        {
            InitializeComponent();
            manager = new ServiceRequestStatusManager();
            manager.AddSampleRequests();
            LoadAllRequests();
            dependenciesTreeView.Invalidate();
        }


        //Populates the list view with all service requests using method PopulateListView
        private void LoadAllRequests()
        {
            PopulateListView(manager.GetAllRequests());
        }

        //searches for a service request by ID
        private void SearchButton_Click(object sender, EventArgs e)
        {
            int searchId;
            if (int.TryParse(searchTextBox.Text, out searchId))
            {
                var foundRequest = manager.FindRequestById(searchId);
                if (foundRequest != null)
                {
                    PopulateListView(new List<ServiceRequest> { foundRequest });
                }
                else
                {
                    MessageBox.Show("Service Request not found!");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID");
            }
        }

        //Populates the list view with all service requests using method from manager
        private void PopulateListView(List<ServiceRequest> serviceRequests)
        {
            serviceRequestListView.Items.Clear();

            if (serviceRequests.Count == 0)
            {
                MessageBox.Show("No requests to display.");
                return;
            }

            foreach (var request in serviceRequests)
            {
                var listItem = new ListViewItem(new[]
                {
                    request.RequestID.ToString(),
                    request.Description,
                    request.Status,
                    request.Priority.ToString(),
                    request.Dependencies.Count > 0 ? string.Join(", ", request.Dependencies) : "None"
                });
                serviceRequestListView.Items.Add(listItem);
            }
        }

        //fetches the dependencies of a service request and sets graph properties
        private void dependenciesTreeView_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            graphics.TranslateTransform(offset.X, offset.Y);
            graphics.ScaleTransform(zoomFactor, zoomFactor);

            var font = new Font("Arial", 5);
            var pen = new Pen(Color.Black);
            const int nodeSize = 30;
            const int xSpacing = 150;
            const int ySpacing = 70;

            // Get filtered requests
            string selectedStatus = statusFilterComboBox.SelectedItem?.ToString() ?? string.Empty;
            string priorityInput = priorityFilterTextBox.Text;
            var filteredRequests = manager.FilterGraphRequests(selectedStatus, priorityInput);

            // Dictionary to track positions of nodes
            var processed = new HashSet<int>();

            float startX = 50;
            float startY = 50;

            foreach (var request in filteredRequests)
            {
                if (!processed.Contains(request.RequestID))
                {
                    DrawRequestAndDependencies(graphics, request, startX, startY, nodeSize, xSpacing, ySpacing, positions, processed, font, pen);
                    startY += ySpacing * 2;
                }
            }
        }

        //draws the dependency graph of service requests
        private void DrawRequestAndDependencies(Graphics graphics, ServiceRequest request, float x, float y, int nodeSize, int xSpacing, int ySpacing, Dictionary<int, PointF> positions, HashSet<int> processed, Font font, Pen pen)
        {
            if (processed.Contains(request.RequestID))
                return;

            // Determine node color based on status
            Brush nodeBrush;
            if (request.Status == "Pending")
                nodeBrush = Brushes.LightGray;
            else if (request.Status == "In Progress")
                nodeBrush = Brushes.LightBlue;
            else if (request.Status == "Completed")
                nodeBrush = Brushes.LightGreen;
            else
                nodeBrush = Brushes.LightYellow;

            // Draw current node
            graphics.FillEllipse(nodeBrush, x, y, nodeSize, nodeSize);
            graphics.DrawEllipse(pen, x, y, nodeSize, nodeSize);
            graphics.DrawString(request.RequestID.ToString(), font, Brushes.Black, x + 5, y + 5);

            // Add label for clarity
            graphics.DrawString($"{request.Description} ({request.Status})", font, Brushes.Black, x + nodeSize + 10, y);

            // Record position
            positions[request.RequestID] = new PointF(x, y);
            processed.Add(request.RequestID);

            // Draw immediate dependencies only
            float childX = x + xSpacing;
            float childY = y;

            foreach (var depId in manager.GetDependencies(request.RequestID))
            {
                if (!positions.TryGetValue(depId, out var depPosition))
                {
                    depPosition = new PointF(childX, childY);
                    childY += ySpacing; // Move down for the next dependency
                }

                // Draw line to dependency
                graphics.DrawLine(pen, x + nodeSize / 2, y + nodeSize / 2, depPosition.X + nodeSize / 2, depPosition.Y + nodeSize / 2);

                // Draw dependency request node (do not recurse)
                var dependentRequest = manager.FindRequestById(depId);
                if (dependentRequest != null && !processed.Contains(depId))
                {
                    // Draw only the immediate dependency, no recursion
                    graphics.FillEllipse(nodeBrush, depPosition.X, depPosition.Y, nodeSize, nodeSize);
                    graphics.DrawEllipse(pen, depPosition.X, depPosition.Y, nodeSize, nodeSize);
                    graphics.DrawString(depId.ToString(), font, Brushes.Black, depPosition.X + 5, depPosition.Y + 5);

                    // Add label for clarity
                    graphics.DrawString($"{dependentRequest.Description} ({dependentRequest.Status})", font, Brushes.Black, depPosition.X + nodeSize + 10, depPosition.Y);

                    // Record dependency node position
                    positions[depId] = depPosition;
                    processed.Add(depId);
                }
            }
        }




        //Event handlers for zooming the graph
        private void dependenciesTreeView_MouseWheel(object sender, MouseEventArgs e)
        {
            const float zoomStep = 0.1f;
            if (e.Delta > 0)
            {
                zoomFactor += zoomStep; // Zoom in
            }
            else if (e.Delta < 0 && zoomFactor > zoomStep)
            {
                zoomFactor -= zoomStep; // Zoom out
            }

            dependenciesTreeView.Invalidate(); // Redraw the view
        }

        //Event handlers for panning the graph
        private void dependenciesTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastMousePosition = e.Location;
            }
        }

        //Event handlers for panning the graph
        private void dependenciesTreeView_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var dx = e.X - lastMousePosition.X;
                var dy = e.Y - lastMousePosition.Y;

                offset.X += dx;
                offset.Y += dy;

                lastMousePosition = e.Location;

                dependenciesTreeView.Invalidate(); // Redraw the view
            }
        }

        //Event handlers for displaying service request details
        private void dependenciesTreeView_MouseClick(object sender, MouseEventArgs e)
        {
            var clickedX = (e.X - offset.X) / zoomFactor;
            var clickedY = (e.Y - offset.Y) / zoomFactor;
            const int nodeSize = 20;

            // Check each request and its position
            foreach (var request in manager.GetRequestsWithDependencies())
            {
                if (positions.TryGetValue(request.RequestID, out var nodePosition))
                {
                    // Create a rectangle around the node's position
                    var nodeRect = new RectangleF(nodePosition.X, nodePosition.Y, nodeSize, nodeSize);

                    // Check if the mouse click is inside the node's rectangle
                    if (nodeRect.Contains(clickedX, clickedY))
                    {
                        MessageBox.Show($"Request ID: {request.RequestID}\nDescription: {request.Description}\nStatus: {request.Status}");
                        break;  // Exit the loop after finding the clicked node
                    }
                }
            }
        }


        //Filtering the graph and list view
        private void btnFilterGraph_Click(object sender, EventArgs e)
        {
            groupBoxFilterEvents.Visible = !groupBoxFilterEvents.Visible;
            btnFilterGraph.Text = groupBoxFilterEvents.Visible ? "Hide Filters" : "Show Filters";
        }

        //Applying the filter to the graph and list view
        private void btnApplyFilterRequests_Click(object sender, EventArgs e)
        {
            string selectedStatus = statusFilterComboBox.SelectedItem?.ToString() ?? string.Empty;
            string priorityInput = priorityFilterTextBox.Text;

            // Fetch filtered requests from the manager
            var filteredRequests = manager.FilterGraphRequests(selectedStatus, priorityInput);

            // Populate the graph and list view with the filtered results
            PopulateListView(filteredRequests);
            dependenciesTreeView.Invalidate(); // Redraw graph with filtered data

            groupBoxFilterEvents.Visible = !groupBoxFilterEvents.Visible;
            btnFilterGraph.Text = groupBoxFilterEvents.Visible ? "Hide Filters" : "Show Filters";
        }

        //Displaying the service requests in priority order
        private void DisplayRequestsInPriorityOrder()
        {
            serviceRequestListView.Items.Clear();

            var sortedRequests = manager.GetRequestsInPriorityOrder();

            foreach (var request in sortedRequests)
            {
                serviceRequestListView.Items.Add(new ListViewItem(new string[] {
                    request.RequestID.ToString(),
                    request.Description,
                    request.Status,
                    request.Priority.ToString(),
                    request.Dependencies.Count > 0 ? string.Join(", ", request.Dependencies) : "None"
                }));
            }
        }

        //Event handler for sorting the service requests by priority
        private void chckBxSortPriority_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBxSortPriority.Checked)
            {
                DisplayRequestsInPriorityOrder();
            }
            else
            {
                PopulateListView(manager.GetAllRequests());
            }
        }
    }
}

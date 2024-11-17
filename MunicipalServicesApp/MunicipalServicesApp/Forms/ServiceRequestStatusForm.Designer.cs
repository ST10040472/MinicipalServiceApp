using MunicipalServicesApp.Models;
using System.Windows.Forms;
using System;

namespace MunicipalServicesApp.Forms
{
    partial class ServiceRequestStatusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListView serviceRequestListView;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchLabel;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceRequestStatusForm));
            this.serviceRequestListView = new System.Windows.Forms.ListView();
            this.RequestID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dependenices = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.dependenciesTreeView = new System.Windows.Forms.Panel();
            this.statusFilterComboBox = new System.Windows.Forms.ComboBox();
            this.groupBoxFilterEvents = new System.Windows.Forms.GroupBox();
            this.priorityFilterTextBox = new System.Windows.Forms.TextBox();
            this.btnApplyFilterRequests = new System.Windows.Forms.Button();
            this.lblDateEvent = new System.Windows.Forms.Label();
            this.lblCategoryEvent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFilterGraph = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chckBxSortPriority = new System.Windows.Forms.CheckBox();
            this.groupBoxFilterEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceRequestListView
            // 
            this.serviceRequestListView.BackColor = System.Drawing.SystemColors.Info;
            this.serviceRequestListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RequestID,
            this.Description,
            this.Status,
            this.Priority,
            this.Dependenices});
            this.serviceRequestListView.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceRequestListView.FullRowSelect = true;
            this.serviceRequestListView.GridLines = true;
            this.serviceRequestListView.HideSelection = false;
            this.serviceRequestListView.Location = new System.Drawing.Point(8, 50);
            this.serviceRequestListView.Name = "serviceRequestListView";
            this.serviceRequestListView.Size = new System.Drawing.Size(737, 197);
            this.serviceRequestListView.TabIndex = 0;
            this.serviceRequestListView.UseCompatibleStateImageBehavior = false;
            this.serviceRequestListView.View = System.Windows.Forms.View.Details;
            // 
            // RequestID
            // 
            this.RequestID.Text = "RequestID";
            this.RequestID.Width = 100;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 150;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 100;
            // 
            // Priority
            // 
            this.Priority.Text = "Priority";
            this.Priority.Width = 100;
            // 
            // Dependenices
            // 
            this.Dependenices.Text = "Dependencies";
            this.Dependenices.Width = 150;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(286, 23);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(200, 21);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(496, 21);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(198, 26);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(79, 16);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Search by ID:";
            // 
            // dependenciesTreeView
            // 
            this.dependenciesTreeView.BackColor = System.Drawing.SystemColors.Info;
            this.dependenciesTreeView.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dependenciesTreeView.Location = new System.Drawing.Point(8, 272);
            this.dependenciesTreeView.Name = "dependenciesTreeView";
            this.dependenciesTreeView.Size = new System.Drawing.Size(737, 274);
            this.dependenciesTreeView.TabIndex = 5;
            this.dependenciesTreeView.Paint += new System.Windows.Forms.PaintEventHandler(this.dependenciesTreeView_Paint);
            this.dependenciesTreeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dependenciesTreeView_MouseClick);
            this.dependenciesTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dependenciesTreeView_MouseDown);
            this.dependenciesTreeView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dependenciesTreeView_MouseMove);
            this.dependenciesTreeView.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.dependenciesTreeView_MouseWheel);
            // 
            // statusFilterComboBox
            // 
            this.statusFilterComboBox.FormattingEnabled = true;
            this.statusFilterComboBox.Items.AddRange(new object[] {
            "Pending",
            "In Progress",
            "Completed"});
            this.statusFilterComboBox.Location = new System.Drawing.Point(15, 41);
            this.statusFilterComboBox.Name = "statusFilterComboBox";
            this.statusFilterComboBox.Size = new System.Drawing.Size(234, 24);
            this.statusFilterComboBox.TabIndex = 6;
            // 
            // groupBoxFilterEvents
            // 
            this.groupBoxFilterEvents.Controls.Add(this.priorityFilterTextBox);
            this.groupBoxFilterEvents.Controls.Add(this.statusFilterComboBox);
            this.groupBoxFilterEvents.Controls.Add(this.btnApplyFilterRequests);
            this.groupBoxFilterEvents.Controls.Add(this.lblDateEvent);
            this.groupBoxFilterEvents.Controls.Add(this.lblCategoryEvent);
            this.groupBoxFilterEvents.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilterEvents.Location = new System.Drawing.Point(475, 50);
            this.groupBoxFilterEvents.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFilterEvents.Name = "groupBoxFilterEvents";
            this.groupBoxFilterEvents.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFilterEvents.Size = new System.Drawing.Size(270, 161);
            this.groupBoxFilterEvents.TabIndex = 27;
            this.groupBoxFilterEvents.TabStop = false;
            this.groupBoxFilterEvents.Text = "Filter Options";
            this.groupBoxFilterEvents.Visible = false;
            // 
            // priorityFilterTextBox
            // 
            this.priorityFilterTextBox.Location = new System.Drawing.Point(14, 87);
            this.priorityFilterTextBox.Name = "priorityFilterTextBox";
            this.priorityFilterTextBox.Size = new System.Drawing.Size(234, 21);
            this.priorityFilterTextBox.TabIndex = 23;
            // 
            // btnApplyFilterRequests
            // 
            this.btnApplyFilterRequests.Location = new System.Drawing.Point(92, 125);
            this.btnApplyFilterRequests.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplyFilterRequests.Name = "btnApplyFilterRequests";
            this.btnApplyFilterRequests.Size = new System.Drawing.Size(88, 28);
            this.btnApplyFilterRequests.TabIndex = 22;
            this.btnApplyFilterRequests.Text = "Apply";
            this.btnApplyFilterRequests.UseVisualStyleBackColor = true;
            this.btnApplyFilterRequests.Click += new System.EventHandler(this.btnApplyFilterRequests_Click);
            // 
            // lblDateEvent
            // 
            this.lblDateEvent.AutoSize = true;
            this.lblDateEvent.Location = new System.Drawing.Point(11, 68);
            this.lblDateEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateEvent.Name = "lblDateEvent";
            this.lblDateEvent.Size = new System.Drawing.Size(44, 16);
            this.lblDateEvent.TabIndex = 17;
            this.lblDateEvent.Text = "Priority:";
            // 
            // lblCategoryEvent
            // 
            this.lblCategoryEvent.AutoSize = true;
            this.lblCategoryEvent.Location = new System.Drawing.Point(12, 20);
            this.lblCategoryEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryEvent.Name = "lblCategoryEvent";
            this.lblCategoryEvent.Size = new System.Drawing.Size(43, 16);
            this.lblCategoryEvent.TabIndex = 18;
            this.lblCategoryEvent.Text = "Status:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(603, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnFilterGraph
            // 
            this.btnFilterGraph.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterGraph.Location = new System.Drawing.Point(639, 26);
            this.btnFilterGraph.Name = "btnFilterGraph";
            this.btnFilterGraph.Size = new System.Drawing.Size(100, 23);
            this.btnFilterGraph.TabIndex = 29;
            this.btnFilterGraph.Text = "Show Filter";
            this.btnFilterGraph.UseVisualStyleBackColor = true;
            this.btnFilterGraph.Click += new System.EventHandler(this.btnFilterGraph_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Service Requests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Service Requests Dependency Diagram";
            // 
            // chckBxSortPriority
            // 
            this.chckBxSortPriority.AutoSize = true;
            this.chckBxSortPriority.Location = new System.Drawing.Point(642, 6);
            this.chckBxSortPriority.Name = "chckBxSortPriority";
            this.chckBxSortPriority.Size = new System.Drawing.Size(94, 17);
            this.chckBxSortPriority.TabIndex = 24;
            this.chckBxSortPriority.Text = "Sort By Priority";
            this.chckBxSortPriority.UseVisualStyleBackColor = true;
            this.chckBxSortPriority.CheckedChanged += new System.EventHandler(this.chckBxSortPriority_CheckedChanged);
            // 
            // ServiceRequestStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 558);
            this.Controls.Add(this.chckBxSortPriority);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFilterGraph);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxFilterEvents);
            this.Controls.Add(this.dependenciesTreeView);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.serviceRequestListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiceRequestStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Request Status";
            this.groupBoxFilterEvents.ResumeLayout(false);
            this.groupBoxFilterEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Panel dependenciesTreeView;
        private ComboBox statusFilterComboBox;
        private GroupBox groupBoxFilterEvents;
        private Button btnApplyFilterRequests;
        private Label lblDateEvent;
        private Label lblCategoryEvent;
        private TextBox priorityFilterTextBox;
        private PictureBox pictureBox1;
        private Button btnFilterGraph;
        private ColumnHeader RequestID;
        private ColumnHeader Description;
        private ColumnHeader Status;
        private ColumnHeader Priority;
        private ColumnHeader Dependenices;
        private Label label1;
        private Label label2;
        private CheckBox chckBxSortPriority;
    }
}

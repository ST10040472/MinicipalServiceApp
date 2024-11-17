using System.Windows.Forms;

namespace MunicipalServicesApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.pnTop = new System.Windows.Forms.Panel();
            this.btnAppClose = new System.Windows.Forms.PictureBox();
            this.lblMain = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.Panel();
            this.pnServiceStatus = new System.Windows.Forms.Panel();
            this.btnServiceStatus = new System.Windows.Forms.Button();
            this.pnReportIssues = new System.Windows.Forms.Panel();
            this.pnLocalEvents = new System.Windows.Forms.Panel();
            this.btnLocalEvents = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAppClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnServiceStatus.SuspendLayout();
            this.pnReportIssues.SuspendLayout();
            this.pnLocalEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReportIssues.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReportIssues.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportIssues.Image = ((System.Drawing.Image)(resources.GetObject("btnReportIssues.Image")));
            this.btnReportIssues.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportIssues.Location = new System.Drawing.Point(-10, -22);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReportIssues.Size = new System.Drawing.Size(244, 86);
            this.btnReportIssues.TabIndex = 0;
            this.btnReportIssues.Text = "     Report Issues";
            this.btnReportIssues.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportIssues.UseVisualStyleBackColor = false;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnTop.Controls.Add(this.btnAppClose);
            this.pnTop.Controls.Add(this.lblMain);
            this.pnTop.Controls.Add(this.btnHam);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(3, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(988, 43);
            this.pnTop.TabIndex = 3;
            // 
            // btnAppClose
            // 
            this.btnAppClose.Image = ((System.Drawing.Image)(resources.GetObject("btnAppClose.Image")));
            this.btnAppClose.Location = new System.Drawing.Point(949, 7);
            this.btnAppClose.Name = "btnAppClose";
            this.btnAppClose.Size = new System.Drawing.Size(35, 28);
            this.btnAppClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAppClose.TabIndex = 5;
            this.btnAppClose.TabStop = false;
            this.btnAppClose.Click += new System.EventHandler(this.btnAppClose_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(84, 13);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(117, 18);
            this.lblMain.TabIndex = 6;
            this.lblMain.Text = "Municipal App";
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(18, 2);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(42, 38);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 5;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sidebar.Controls.Add(this.pnServiceStatus);
            this.sidebar.Controls.Add(this.pnReportIssues);
            this.sidebar.Controls.Add(this.pnLocalEvents);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(3, 43);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(223, 574);
            this.sidebar.TabIndex = 4;
            // 
            // pnServiceStatus
            // 
            this.pnServiceStatus.Controls.Add(this.btnServiceStatus);
            this.pnServiceStatus.Location = new System.Drawing.Point(3, 104);
            this.pnServiceStatus.Name = "pnServiceStatus";
            this.pnServiceStatus.Size = new System.Drawing.Size(198, 44);
            this.pnServiceStatus.TabIndex = 6;
            // 
            // btnServiceStatus
            // 
            this.btnServiceStatus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnServiceStatus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnServiceStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnServiceStatus.Image")));
            this.btnServiceStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiceStatus.Location = new System.Drawing.Point(-10, -22);
            this.btnServiceStatus.Name = "btnServiceStatus";
            this.btnServiceStatus.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnServiceStatus.Size = new System.Drawing.Size(251, 86);
            this.btnServiceStatus.TabIndex = 0;
            this.btnServiceStatus.Text = "     Service Status";
            this.btnServiceStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServiceStatus.UseVisualStyleBackColor = false;
            this.btnServiceStatus.Click += new System.EventHandler(this.btnServiceStatus_Click);
            // 
            // pnReportIssues
            // 
            this.pnReportIssues.Controls.Add(this.btnReportIssues);
            this.pnReportIssues.Location = new System.Drawing.Point(2, 4);
            this.pnReportIssues.Name = "pnReportIssues";
            this.pnReportIssues.Size = new System.Drawing.Size(209, 44);
            this.pnReportIssues.TabIndex = 5;
            // 
            // pnLocalEvents
            // 
            this.pnLocalEvents.Controls.Add(this.btnLocalEvents);
            this.pnLocalEvents.Location = new System.Drawing.Point(3, 54);
            this.pnLocalEvents.Name = "pnLocalEvents";
            this.pnLocalEvents.Size = new System.Drawing.Size(208, 44);
            this.pnLocalEvents.TabIndex = 6;
            // 
            // btnLocalEvents
            // 
            this.btnLocalEvents.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLocalEvents.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLocalEvents.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalEvents.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalEvents.Image")));
            this.btnLocalEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalEvents.Location = new System.Drawing.Point(-10, -22);
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLocalEvents.Size = new System.Drawing.Size(243, 86);
            this.btnLocalEvents.TabIndex = 0;
            this.btnLocalEvents.Text = "     Local Events";
            this.btnLocalEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLocalEvents.UseVisualStyleBackColor = false;
            this.btnLocalEvents.Click += new System.EventHandler(this.btnLocalEvents_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(994, 620);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Municipal App";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAppClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnServiceStatus.ResumeLayout(false);
            this.pnReportIssues.ResumeLayout(false);
            this.pnLocalEvents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel pnReportIssues;
        private System.Windows.Forms.Panel pnServiceStatus;
        private System.Windows.Forms.Button btnServiceStatus;
        private System.Windows.Forms.Panel pnLocalEvents;
        private System.Windows.Forms.Button btnLocalEvents;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Timer sidebarTimer;
        private PictureBox btnAppClose;
    }
}


namespace MunicipalServicesApp
{
    partial class EventsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsForm));
            this.tabControlEventsAnnouncments = new System.Windows.Forms.TabControl();
            this.LocalEventsTab = new System.Windows.Forms.TabPage();
            this.lblReccomendedEvents = new System.Windows.Forms.Label();
            this.pnlRecommendations = new System.Windows.Forms.ListView();
            this.btnSearchEvent = new System.Windows.Forms.PictureBox();
            this.txtSearchEvents = new System.Windows.Forms.TextBox();
            this.btnViewDetailEvent = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxFilterEvents = new System.Windows.Forms.GroupBox();
            this.lblEndDateEvents = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnApplyFilterEvents = new System.Windows.Forms.Button();
            this.chkUseDateFilterEvents = new System.Windows.Forms.CheckBox();
            this.datePickerEndDateEvents = new System.Windows.Forms.DateTimePicker();
            this.lblDateEvent = new System.Windows.Forms.Label();
            this.lblCategoryEvent = new System.Windows.Forms.Label();
            this.datePickerStartDateEvents = new System.Windows.Forms.DateTimePicker();
            this.cmbCategoryEvents = new System.Windows.Forms.ComboBox();
            this.btnFilterEvents = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblLocalEvents = new System.Windows.Forms.Label();
            this.listViewEvents = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnnouncementsTab = new System.Windows.Forms.TabPage();
            this.lblAnnLogo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnViewDetailAnnouncements = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnFilterAnnouncements = new System.Windows.Forms.Button();
            this.groupBoxFilterAnnouncements = new System.Windows.Forms.GroupBox();
            this.btnApplyFilterAnnouncements = new System.Windows.Forms.Button();
            this.lblCategoryAnn = new System.Windows.Forms.Label();
            this.cmbCategoryAnnouncements = new System.Windows.Forms.ComboBox();
            this.listViewAnnouncements = new System.Windows.Forms.ListView();
            this.AnnouncementTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnnouncementCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnnouncementDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnnouncementDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlEventsAnnouncments.SuspendLayout();
            this.LocalEventsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxFilterEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.AnnouncementsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBoxFilterAnnouncements.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlEventsAnnouncments
            // 
            this.tabControlEventsAnnouncments.Controls.Add(this.LocalEventsTab);
            this.tabControlEventsAnnouncments.Controls.Add(this.AnnouncementsTab);
            this.tabControlEventsAnnouncments.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlEventsAnnouncments.Location = new System.Drawing.Point(1, 1);
            this.tabControlEventsAnnouncments.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlEventsAnnouncments.Name = "tabControlEventsAnnouncments";
            this.tabControlEventsAnnouncments.SelectedIndex = 0;
            this.tabControlEventsAnnouncments.Size = new System.Drawing.Size(755, 555);
            this.tabControlEventsAnnouncments.TabIndex = 0;
            // 
            // LocalEventsTab
            // 
            this.LocalEventsTab.Controls.Add(this.lblReccomendedEvents);
            this.LocalEventsTab.Controls.Add(this.pnlRecommendations);
            this.LocalEventsTab.Controls.Add(this.btnSearchEvent);
            this.LocalEventsTab.Controls.Add(this.txtSearchEvents);
            this.LocalEventsTab.Controls.Add(this.btnViewDetailEvent);
            this.LocalEventsTab.Controls.Add(this.pictureBox1);
            this.LocalEventsTab.Controls.Add(this.groupBoxFilterEvents);
            this.LocalEventsTab.Controls.Add(this.btnFilterEvents);
            this.LocalEventsTab.Controls.Add(this.pictureBoxLogo);
            this.LocalEventsTab.Controls.Add(this.lblLocalEvents);
            this.LocalEventsTab.Controls.Add(this.listViewEvents);
            this.LocalEventsTab.Location = new System.Drawing.Point(4, 25);
            this.LocalEventsTab.Margin = new System.Windows.Forms.Padding(4);
            this.LocalEventsTab.Name = "LocalEventsTab";
            this.LocalEventsTab.Padding = new System.Windows.Forms.Padding(4);
            this.LocalEventsTab.Size = new System.Drawing.Size(747, 526);
            this.LocalEventsTab.TabIndex = 0;
            this.LocalEventsTab.Text = "Local Events";
            this.LocalEventsTab.UseVisualStyleBackColor = true;
            // 
            // lblReccomendedEvents
            // 
            this.lblReccomendedEvents.AutoSize = true;
            this.lblReccomendedEvents.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReccomendedEvents.Location = new System.Drawing.Point(8, 342);
            this.lblReccomendedEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReccomendedEvents.Name = "lblReccomendedEvents";
            this.lblReccomendedEvents.Size = new System.Drawing.Size(306, 16);
            this.lblReccomendedEvents.TabIndex = 32;
            this.lblReccomendedEvents.Text = "Recommended Events Based on Past Searches";
            // 
            // pnlRecommendations
            // 
            this.pnlRecommendations.BackColor = System.Drawing.SystemColors.Info;
            this.pnlRecommendations.HideSelection = false;
            this.pnlRecommendations.Location = new System.Drawing.Point(8, 362);
            this.pnlRecommendations.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRecommendations.Name = "pnlRecommendations";
            this.pnlRecommendations.Size = new System.Drawing.Size(736, 159);
            this.pnlRecommendations.TabIndex = 31;
            this.pnlRecommendations.UseCompatibleStateImageBehavior = false;
            this.pnlRecommendations.View = System.Windows.Forms.View.Tile;
            // 
            // btnSearchEvent
            // 
            this.btnSearchEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchEvent.Image")));
            this.btnSearchEvent.Location = new System.Drawing.Point(475, 49);
            this.btnSearchEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchEvent.Name = "btnSearchEvent";
            this.btnSearchEvent.Size = new System.Drawing.Size(30, 33);
            this.btnSearchEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSearchEvent.TabIndex = 30;
            this.btnSearchEvent.TabStop = false;
            this.btnSearchEvent.Click += new System.EventHandler(this.btnSearchEvent_Click);
            // 
            // txtSearchEvents
            // 
            this.txtSearchEvents.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearchEvents.Location = new System.Drawing.Point(204, 56);
            this.txtSearchEvents.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchEvents.Name = "txtSearchEvents";
            this.txtSearchEvents.Size = new System.Drawing.Size(269, 21);
            this.txtSearchEvents.TabIndex = 29;
            // 
            // btnViewDetailEvent
            // 
            this.btnViewDetailEvent.Location = new System.Drawing.Point(621, 21);
            this.btnViewDetailEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewDetailEvent.Name = "btnViewDetailEvent";
            this.btnViewDetailEvent.Size = new System.Drawing.Size(124, 28);
            this.btnViewDetailEvent.TabIndex = 28;
            this.btnViewDetailEvent.Text = "View Details";
            this.btnViewDetailEvent.UseVisualStyleBackColor = true;
            this.btnViewDetailEvent.Click += new System.EventHandler(this.btnViewDetailEvent_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(584, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxFilterEvents
            // 
            this.groupBoxFilterEvents.Controls.Add(this.lblEndDateEvents);
            this.groupBoxFilterEvents.Controls.Add(this.lblStartDate);
            this.groupBoxFilterEvents.Controls.Add(this.btnApplyFilterEvents);
            this.groupBoxFilterEvents.Controls.Add(this.chkUseDateFilterEvents);
            this.groupBoxFilterEvents.Controls.Add(this.datePickerEndDateEvents);
            this.groupBoxFilterEvents.Controls.Add(this.lblDateEvent);
            this.groupBoxFilterEvents.Controls.Add(this.lblCategoryEvent);
            this.groupBoxFilterEvents.Controls.Add(this.datePickerStartDateEvents);
            this.groupBoxFilterEvents.Controls.Add(this.cmbCategoryEvents);
            this.groupBoxFilterEvents.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilterEvents.Location = new System.Drawing.Point(475, 85);
            this.groupBoxFilterEvents.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFilterEvents.Name = "groupBoxFilterEvents";
            this.groupBoxFilterEvents.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFilterEvents.Size = new System.Drawing.Size(270, 236);
            this.groupBoxFilterEvents.TabIndex = 26;
            this.groupBoxFilterEvents.TabStop = false;
            this.groupBoxFilterEvents.Text = "Filter Options";
            this.groupBoxFilterEvents.Visible = false;
            // 
            // lblEndDateEvents
            // 
            this.lblEndDateEvents.AutoSize = true;
            this.lblEndDateEvents.Location = new System.Drawing.Point(13, 146);
            this.lblEndDateEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDateEvents.Name = "lblEndDateEvents";
            this.lblEndDateEvents.Size = new System.Drawing.Size(61, 16);
            this.lblEndDateEvents.TabIndex = 24;
            this.lblEndDateEvents.Text = "End Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(12, 98);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(65, 16);
            this.lblStartDate.TabIndex = 23;
            this.lblStartDate.Text = "Start Date:";
            // 
            // btnApplyFilterEvents
            // 
            this.btnApplyFilterEvents.Location = new System.Drawing.Point(158, 199);
            this.btnApplyFilterEvents.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplyFilterEvents.Name = "btnApplyFilterEvents";
            this.btnApplyFilterEvents.Size = new System.Drawing.Size(88, 28);
            this.btnApplyFilterEvents.TabIndex = 22;
            this.btnApplyFilterEvents.Text = "Apply";
            this.btnApplyFilterEvents.UseVisualStyleBackColor = true;
            this.btnApplyFilterEvents.Click += new System.EventHandler(this.btnApplyFilterEvents_Click);
            // 
            // chkUseDateFilterEvents
            // 
            this.chkUseDateFilterEvents.AutoSize = true;
            this.chkUseDateFilterEvents.Location = new System.Drawing.Point(133, 82);
            this.chkUseDateFilterEvents.Margin = new System.Windows.Forms.Padding(4);
            this.chkUseDateFilterEvents.Name = "chkUseDateFilterEvents";
            this.chkUseDateFilterEvents.Size = new System.Drawing.Size(101, 20);
            this.chkUseDateFilterEvents.TabIndex = 21;
            this.chkUseDateFilterEvents.Text = "Use Date Filter";
            this.chkUseDateFilterEvents.UseVisualStyleBackColor = true;
            // 
            // datePickerEndDateEvents
            // 
            this.datePickerEndDateEvents.Location = new System.Drawing.Point(12, 167);
            this.datePickerEndDateEvents.Margin = new System.Windows.Forms.Padding(4);
            this.datePickerEndDateEvents.Name = "datePickerEndDateEvents";
            this.datePickerEndDateEvents.Size = new System.Drawing.Size(233, 21);
            this.datePickerEndDateEvents.TabIndex = 20;
            // 
            // lblDateEvent
            // 
            this.lblDateEvent.AutoSize = true;
            this.lblDateEvent.Location = new System.Drawing.Point(12, 80);
            this.lblDateEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateEvent.Name = "lblDateEvent";
            this.lblDateEvent.Size = new System.Drawing.Size(37, 16);
            this.lblDateEvent.TabIndex = 17;
            this.lblDateEvent.Text = "Date:";
            // 
            // lblCategoryEvent
            // 
            this.lblCategoryEvent.AutoSize = true;
            this.lblCategoryEvent.Location = new System.Drawing.Point(12, 20);
            this.lblCategoryEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryEvent.Name = "lblCategoryEvent";
            this.lblCategoryEvent.Size = new System.Drawing.Size(61, 16);
            this.lblCategoryEvent.TabIndex = 18;
            this.lblCategoryEvent.Text = "Category:";
            // 
            // datePickerStartDateEvents
            // 
            this.datePickerStartDateEvents.Location = new System.Drawing.Point(12, 117);
            this.datePickerStartDateEvents.Margin = new System.Windows.Forms.Padding(4);
            this.datePickerStartDateEvents.Name = "datePickerStartDateEvents";
            this.datePickerStartDateEvents.Size = new System.Drawing.Size(233, 21);
            this.datePickerStartDateEvents.TabIndex = 19;
            // 
            // cmbCategoryEvents
            // 
            this.cmbCategoryEvents.FormattingEnabled = true;
            this.cmbCategoryEvents.Location = new System.Drawing.Point(12, 44);
            this.cmbCategoryEvents.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoryEvents.Name = "cmbCategoryEvents";
            this.cmbCategoryEvents.Size = new System.Drawing.Size(233, 24);
            this.cmbCategoryEvents.TabIndex = 17;
            // 
            // btnFilterEvents
            // 
            this.btnFilterEvents.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnFilterEvents.Location = new System.Drawing.Point(621, 56);
            this.btnFilterEvents.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterEvents.Name = "btnFilterEvents";
            this.btnFilterEvents.Size = new System.Drawing.Size(124, 28);
            this.btnFilterEvents.TabIndex = 16;
            this.btnFilterEvents.Text = "Show Filters";
            this.btnFilterEvents.UseVisualStyleBackColor = true;
            this.btnFilterEvents.Click += new System.EventHandler(this.btnFilterEvents_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(9, 16);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(38, 39);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 22;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblLocalEvents
            // 
            this.lblLocalEvents.AutoSize = true;
            this.lblLocalEvents.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalEvents.Location = new System.Drawing.Point(55, 23);
            this.lblLocalEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalEvents.Name = "lblLocalEvents";
            this.lblLocalEvents.Size = new System.Drawing.Size(102, 19);
            this.lblLocalEvents.TabIndex = 21;
            this.lblLocalEvents.Text = "Local Events";
            // 
            // listViewEvents
            // 
            this.listViewEvents.BackColor = System.Drawing.SystemColors.Info;
            this.listViewEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderDate,
            this.columnHeaderCategory,
            this.columnHeaderDescription});
            this.listViewEvents.HideSelection = false;
            this.listViewEvents.Location = new System.Drawing.Point(8, 85);
            this.listViewEvents.Margin = new System.Windows.Forms.Padding(4);
            this.listViewEvents.Name = "listViewEvents";
            this.listViewEvents.Size = new System.Drawing.Size(737, 243);
            this.listViewEvents.TabIndex = 14;
            this.listViewEvents.UseCompatibleStateImageBehavior = false;
            this.listViewEvents.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 188;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            this.columnHeaderDate.Width = 100;
            // 
            // columnHeaderCategory
            // 
            this.columnHeaderCategory.Text = "Category";
            this.columnHeaderCategory.Width = 92;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Description";
            this.columnHeaderDescription.Width = 348;
            // 
            // AnnouncementsTab
            // 
            this.AnnouncementsTab.Controls.Add(this.lblAnnLogo);
            this.AnnouncementsTab.Controls.Add(this.pictureBox3);
            this.AnnouncementsTab.Controls.Add(this.btnViewDetailAnnouncements);
            this.AnnouncementsTab.Controls.Add(this.pictureBox2);
            this.AnnouncementsTab.Controls.Add(this.btnFilterAnnouncements);
            this.AnnouncementsTab.Controls.Add(this.groupBoxFilterAnnouncements);
            this.AnnouncementsTab.Controls.Add(this.listViewAnnouncements);
            this.AnnouncementsTab.Location = new System.Drawing.Point(4, 25);
            this.AnnouncementsTab.Margin = new System.Windows.Forms.Padding(4);
            this.AnnouncementsTab.Name = "AnnouncementsTab";
            this.AnnouncementsTab.Padding = new System.Windows.Forms.Padding(4);
            this.AnnouncementsTab.Size = new System.Drawing.Size(747, 526);
            this.AnnouncementsTab.TabIndex = 1;
            this.AnnouncementsTab.Text = "Announcements";
            this.AnnouncementsTab.UseVisualStyleBackColor = true;
            // 
            // lblAnnLogo
            // 
            this.lblAnnLogo.AutoSize = true;
            this.lblAnnLogo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnLogo.Location = new System.Drawing.Point(65, 23);
            this.lblAnnLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnLogo.Name = "lblAnnLogo";
            this.lblAnnLogo.Size = new System.Drawing.Size(137, 19);
            this.lblAnnLogo.TabIndex = 31;
            this.lblAnnLogo.Text = "Announcements";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 10);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // btnViewDetailAnnouncements
            // 
            this.btnViewDetailAnnouncements.Location = new System.Drawing.Point(617, 8);
            this.btnViewDetailAnnouncements.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewDetailAnnouncements.Name = "btnViewDetailAnnouncements";
            this.btnViewDetailAnnouncements.Size = new System.Drawing.Size(124, 28);
            this.btnViewDetailAnnouncements.TabIndex = 29;
            this.btnViewDetailAnnouncements.Text = "View Details";
            this.btnViewDetailAnnouncements.UseVisualStyleBackColor = true;
            this.btnViewDetailAnnouncements.Click += new System.EventHandler(this.btnViewDetailAnnouncements_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(588, 44);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // btnFilterAnnouncements
            // 
            this.btnFilterAnnouncements.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnFilterAnnouncements.Location = new System.Drawing.Point(617, 44);
            this.btnFilterAnnouncements.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterAnnouncements.Name = "btnFilterAnnouncements";
            this.btnFilterAnnouncements.Size = new System.Drawing.Size(124, 28);
            this.btnFilterAnnouncements.TabIndex = 18;
            this.btnFilterAnnouncements.Text = "Show Filters";
            this.btnFilterAnnouncements.UseVisualStyleBackColor = true;
            this.btnFilterAnnouncements.Click += new System.EventHandler(this.btnFilterAnnouncements_Click);
            // 
            // groupBoxFilterAnnouncements
            // 
            this.groupBoxFilterAnnouncements.Controls.Add(this.btnApplyFilterAnnouncements);
            this.groupBoxFilterAnnouncements.Controls.Add(this.lblCategoryAnn);
            this.groupBoxFilterAnnouncements.Controls.Add(this.cmbCategoryAnnouncements);
            this.groupBoxFilterAnnouncements.Location = new System.Drawing.Point(485, 80);
            this.groupBoxFilterAnnouncements.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFilterAnnouncements.Name = "groupBoxFilterAnnouncements";
            this.groupBoxFilterAnnouncements.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFilterAnnouncements.Size = new System.Drawing.Size(262, 114);
            this.groupBoxFilterAnnouncements.TabIndex = 16;
            this.groupBoxFilterAnnouncements.TabStop = false;
            this.groupBoxFilterAnnouncements.Text = "Filter Options";
            this.groupBoxFilterAnnouncements.Visible = false;
            // 
            // btnApplyFilterAnnouncements
            // 
            this.btnApplyFilterAnnouncements.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnApplyFilterAnnouncements.Location = new System.Drawing.Point(158, 79);
            this.btnApplyFilterAnnouncements.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplyFilterAnnouncements.Name = "btnApplyFilterAnnouncements";
            this.btnApplyFilterAnnouncements.Size = new System.Drawing.Size(88, 28);
            this.btnApplyFilterAnnouncements.TabIndex = 19;
            this.btnApplyFilterAnnouncements.Text = "Apply";
            this.btnApplyFilterAnnouncements.UseVisualStyleBackColor = true;
            this.btnApplyFilterAnnouncements.Click += new System.EventHandler(this.btnApplyFilterAnnouncements_Click);
            // 
            // lblCategoryAnn
            // 
            this.lblCategoryAnn.AutoSize = true;
            this.lblCategoryAnn.Location = new System.Drawing.Point(12, 20);
            this.lblCategoryAnn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryAnn.Name = "lblCategoryAnn";
            this.lblCategoryAnn.Size = new System.Drawing.Size(61, 16);
            this.lblCategoryAnn.TabIndex = 18;
            this.lblCategoryAnn.Text = "Category:";
            // 
            // cmbCategoryAnnouncements
            // 
            this.cmbCategoryAnnouncements.FormattingEnabled = true;
            this.cmbCategoryAnnouncements.Location = new System.Drawing.Point(12, 44);
            this.cmbCategoryAnnouncements.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoryAnnouncements.Name = "cmbCategoryAnnouncements";
            this.cmbCategoryAnnouncements.Size = new System.Drawing.Size(233, 24);
            this.cmbCategoryAnnouncements.TabIndex = 17;
            // 
            // listViewAnnouncements
            // 
            this.listViewAnnouncements.BackColor = System.Drawing.SystemColors.Info;
            this.listViewAnnouncements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewAnnouncements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AnnouncementTitle,
            this.AnnouncementCategory,
            this.AnnouncementDate,
            this.AnnouncementDescription});
            this.listViewAnnouncements.HideSelection = false;
            this.listViewAnnouncements.Location = new System.Drawing.Point(8, 81);
            this.listViewAnnouncements.Margin = new System.Windows.Forms.Padding(4);
            this.listViewAnnouncements.Name = "listViewAnnouncements";
            this.listViewAnnouncements.Size = new System.Drawing.Size(727, 437);
            this.listViewAnnouncements.TabIndex = 15;
            this.listViewAnnouncements.UseCompatibleStateImageBehavior = false;
            this.listViewAnnouncements.View = System.Windows.Forms.View.Tile;
            // 
            // AnnouncementTitle
            // 
            this.AnnouncementTitle.Text = "Title";
            this.AnnouncementTitle.Width = 120;
            // 
            // AnnouncementCategory
            // 
            this.AnnouncementCategory.Text = "Category";
            this.AnnouncementCategory.Width = 100;
            // 
            // AnnouncementDate
            // 
            this.AnnouncementDate.Text = "Date";
            this.AnnouncementDate.Width = 80;
            // 
            // AnnouncementDescription
            // 
            this.AnnouncementDescription.Text = "Description";
            this.AnnouncementDescription.Width = 180;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(757, 558);
            this.Controls.Add(this.tabControlEventsAnnouncments);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EventsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events and Announcements";
            this.tabControlEventsAnnouncments.ResumeLayout(false);
            this.LocalEventsTab.ResumeLayout(false);
            this.LocalEventsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxFilterEvents.ResumeLayout(false);
            this.groupBoxFilterEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.AnnouncementsTab.ResumeLayout(false);
            this.AnnouncementsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBoxFilterAnnouncements.ResumeLayout(false);
            this.groupBoxFilterAnnouncements.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControlEventsAnnouncments;
        private System.Windows.Forms.TabPage LocalEventsTab;
        private System.Windows.Forms.TabPage AnnouncementsTab;
        private System.Windows.Forms.ListView listViewEvents;
        private System.Windows.Forms.ListView listViewAnnouncements;
        private System.Windows.Forms.GroupBox groupBoxFilterAnnouncements;
        private System.Windows.Forms.ComboBox cmbCategoryAnnouncements;
        private System.Windows.Forms.Label lblCategoryAnn;
        private System.Windows.Forms.Button btnFilterEvents;
        private System.Windows.Forms.Button btnFilterAnnouncements;
        private System.Windows.Forms.Label lblLocalEvents;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderCategory;
        private System.Windows.Forms.ColumnHeader AnnouncementTitle;
        private System.Windows.Forms.ColumnHeader AnnouncementCategory;
        private System.Windows.Forms.ColumnHeader AnnouncementDate;
        private System.Windows.Forms.ColumnHeader AnnouncementDescription;
        private System.Windows.Forms.GroupBox groupBoxFilterEvents;
        private System.Windows.Forms.CheckBox chkUseDateFilterEvents;
        private System.Windows.Forms.Label lblCategoryEvent;
        private System.Windows.Forms.ComboBox cmbCategoryEvents;
        private System.Windows.Forms.Label lblDateEvent;
        private System.Windows.Forms.DateTimePicker datePickerEndDateEvents;
        private System.Windows.Forms.DateTimePicker datePickerStartDateEvents;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.Button btnApplyFilterEvents;
        private System.Windows.Forms.Label lblEndDateEvents;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnApplyFilterAnnouncements;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnViewDetailEvent;
        private System.Windows.Forms.Button btnViewDetailAnnouncements;
        private System.Windows.Forms.TextBox txtSearchEvents;
        private System.Windows.Forms.PictureBox btnSearchEvent;
        private System.Windows.Forms.ListView pnlRecommendations;
        private System.Windows.Forms.Label lblReccomendedEvents;
        private System.Windows.Forms.Label lblAnnLogo;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

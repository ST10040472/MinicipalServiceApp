using MunicipalServicesApp.Forms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class MainForm : Form
    {
        private ReportIssuesForm _reportIssuesForm;
        private EventsForm _eventsForm;
        private ServiceRequestStatusForm _serviceRequestStatusForm;

        public MainForm()
        {
            InitializeComponent();
            InitializeUI();
            ConfigureMdiProperties();
        }

        // Configures MDI properties and sets the main form background color
        private void ConfigureMdiProperties()
        {
            this.SetBevel(false);
            var mdiClient = Controls.OfType<MdiClient>().FirstOrDefault();
            if (mdiClient != null)
            {
                mdiClient.BackColor = Color.FromArgb(232, 234, 237);
            }
        }

        // Initializes UI components and settings
        private void InitializeUI()
        {
            this.IsMdiContainer = true;
            btnReportIssues.Enabled = true;
            btnLocalEvents.Enabled = true;
            btnServiceStatus.Enabled = true;
        }

        // Handles click event for the hamburger button to control sidebar toggle
        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        // Sidebar expansion and collapse logic
        private bool _sidebarExpanded = true;

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (_sidebarExpanded)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 73)
                {
                    _sidebarExpanded = false;
                    sidebarTimer.Stop();
                    AdjustSidebarPanelWidths();
                    ResizeActiveForm();
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 223)
                {
                    _sidebarExpanded = true;
                    sidebarTimer.Stop();
                    AdjustSidebarPanelWidths();
                    ResizeActiveForm();
                }
            }
        }

        // Adjusts sidebar panel widths based on sidebar expansion state
        private void AdjustSidebarPanelWidths()
        {
            pnLocalEvents.Width = sidebar.Width;
            pnReportIssues.Width = sidebar.Width;
            pnServiceStatus.Width = sidebar.Width;
        }

        // Resizes MdiChild Form in MdiContainer
        private void ResizeActiveForm()
        {
            if (this.ActiveMdiChild != null)
            {
                var activeForm = this.ActiveMdiChild;
                activeForm.Width = this.ClientSize.Width - sidebar.Width; // Adjust width based on remaining space
            }
        }

        // Handles the click event for opening the Report Issues Form
        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            // Close any currently active child forms
            CloseAllMdiChildren();

            if (_reportIssuesForm == null)
            {
                _reportIssuesForm = new ReportIssuesForm
                {
                    MdiParent = this
                };
                _reportIssuesForm.FormClosed += ReportIssueFormClosed;
                _reportIssuesForm.Show();
            }
            else
            {
                _reportIssuesForm.Activate();
            }
        }

        // Resets the ReportIssuesForm instance when the form is closed
        private void ReportIssueFormClosed(object sender, FormClosedEventArgs e)
        {
            _reportIssuesForm = null;
        }

        // Handles the click event for opening the Events Form
        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            // Close any currently active child forms
            CloseAllMdiChildren();

            if (_eventsForm == null)
            {
                _eventsForm = new EventsForm
                {
                    MdiParent = this
                };
                _eventsForm.FormClosed += EventsFormClosed;
                _eventsForm.Show();
            }
            else
            {
                _eventsForm.Activate();
            }
        }

        private void EventsFormClosed(object sender, FormClosedEventArgs e)
        {
            _eventsForm = null;
        }


        // Handles the click event for opening the Service Status Form
        private void btnServiceStatus_Click(object sender, EventArgs e)
        {
            // Close any currently active child forms
            CloseAllMdiChildren();

            if (_serviceRequestStatusForm == null)
            {
                _serviceRequestStatusForm = new ServiceRequestStatusForm
                {
                    MdiParent = this
                };
                _serviceRequestStatusForm.FormClosed += ServiceRequestStatusFormClosed;
                _serviceRequestStatusForm.Show();
            }
            else
            {
                _serviceRequestStatusForm.Activate();
            }
        }

        // Resets the Service Status instance when the form is closed
        private void ServiceRequestStatusFormClosed(object sender, FormClosedEventArgs e)
        {
            _serviceRequestStatusForm = null;
        }

        // Closes all MDI child forms before opening a new one
        private void CloseAllMdiChildren()
        {
            // Iterate through each child form in the MDI parent and close them
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        // Handles the application close button click event
        private void btnAppClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

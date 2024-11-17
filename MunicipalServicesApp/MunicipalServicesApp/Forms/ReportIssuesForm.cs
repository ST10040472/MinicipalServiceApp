// ReportIssuesForm.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class ReportIssuesForm : Form
    {
        private readonly IssueManager _issueManager;

        public ReportIssuesForm()
        {
            InitializeComponent();
            _issueManager = new IssueManager();
            InitializeUIComponents();
            AttachEventHandlers();
        }

        private void InitializeUIComponents()
        {
            picbxFileUpload.Visible = false;
            cmbCategory.Items.AddRange(_issueManager.GetCategories());
            InitializeProgressBar();
        }

        private void InitializeProgressBar()
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = _issueManager.TotalProgressSteps;
            progressBar.Value = 0;
        }

        private void AttachEventHandlers()
        {
            txtLocation.TextChanged += (s, e) => UpdateProgressBar();
            cmbCategory.SelectedIndexChanged += (s, e) => UpdateProgressBar();
            rtxtDescription.TextChanged += (s, e) => UpdateProgressBar();
            txtFileUpload.TextChanged += (s, e) => UpdateProgressBar();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_issueManager.ValidateFormInputs(txtLocation.Text, cmbCategory.SelectedItem?.ToString(), rtxtDescription.Text, txtFileUpload.Text, out string errorMessage))
            {
                _issueManager.AddIssue(txtLocation.Text, cmbCategory.SelectedItem?.ToString(), rtxtDescription.Text, txtFileUpload.Text);
                MessageBox.Show("Issue reported successfully!", "Success");
                ClearFormInputs();
            }
            else
            {
                MessageBox.Show(errorMessage, "Validation Error");
            }
        }

        private void ClearFormInputs()
        {
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtxtDescription.Clear();
            txtFileUpload.Clear();
            picbxFileUpload.Image = null;
            picbxFileUpload.Visible = false;
        }

        


        private void UpdateProgressBar()
        {
            progressBar.Value = _issueManager.CalculateProgress(txtLocation.Text, cmbCategory.SelectedItem?.ToString(), rtxtDescription.Text, txtFileUpload.Text);
        }

        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // Existing code for OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*",
                Title = "Select an Image File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFileUpload.Text = openFileDialog.FileName;
                picbxFileUpload.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                picbxFileUpload.Visible = true;
                UpdateProgressBar();
            }
        }

       
    }
}

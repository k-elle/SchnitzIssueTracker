using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using SchnitzIssueTracker.Database;

namespace SchnitzIssueTracker.Forms
{
    public partial class ResolveIssue : Form
    {
        // Sub WinForm windows.
        private ModifyUsers modifyUsers;

        // Database manager (handles connection and modification of the database).
        private DatabaseManager db;

        // Other private fields used for storage of the data in-memory.
        private BindingList<string> users;
        private Issue issue;
        public ResolveIssue(DatabaseManager db)
        {
            InitializeComponent();

            // Initialize the sub windows.
            modifyUsers = new ModifyUsers(db);

            // Inherits the database from the parent form.
            this.db = db;

            // Initialises data fields.
            users = new BindingList<string>();
        }

        private void UpdateUsers()
        {
            db.GetUsers(ref users);

            userSelectionCombo.SelectedIndex = -1;
        }

        public DialogResult ShowDialog(DataGridViewRow row)
        {
            issue = row.DataBoundItem as Issue;
            return ShowDialog();
        }

        private void ResolveIssue_Load(object sender, EventArgs e)
        {
            actionReselectBox.SelectedIndex = -1;
            if (issue.action != "TBD")
            {
                actionReselectBox.Text = issue.action;
            }
            else
            {
                resolveIssueButton.Enabled = false;
            }

            customerNameBox.Text = issue.customerName;
            customerPhoneBox.Text = issue.customerPhone;
            orderReferenceBox.Text = issue.reference;
            issueExplanationBox.Text = issue.reasonAdded;
            userAddedBox.Text = issue.userAdded;
            dateAddedBox.Text = issue.dateAdded.ToString("dd/MM/yyyy");
            valueBox.Text = $"{issue.value:C}";
            actionExplanationBox.Text = issue.actionExplanation;

            userSelectionCombo.DataSource = users;
            UpdateUsers();
        }

        private void CheckValidity(object sender, EventArgs e)
        {
            if (userSelectionCombo.SelectedIndex > -1 && actionReselectBox.SelectedIndex >= -1)
            {
                resolveIssueButton.Enabled = true;
            }
            else
            {
                resolveIssueButton.Enabled = false;
            }
        }

        private void userSelectionCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            resolveIssueButton.Enabled = userSelectionCombo.SelectedIndex > -1;
        }

        private void resolveIssueButton_Click(object sender, EventArgs e)
        {
            issue.action = actionReselectBox.Text;
            issue.resolved = true;
            issue.userResolved = userSelectionCombo.Text;
            issue.dateResolved = dateResolvedPicker.Value.Date;
            issue.resolvedExplanation = resolutionExplanationBox.Text;

            db.UpdateIssue(issue);

            Close();
        }

        private void editUsersButton_Click(object sender, EventArgs e)
        {
            modifyUsers.ShowDialog();
            UpdateUsers();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

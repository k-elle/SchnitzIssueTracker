using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchnitzIssueTracker.Database;

namespace SchnitzIssueTracker.Forms
{
    public partial class AddIssue : Form
    {
        // Sub WinForm windows.
        private ModifyUsers modifyUsers;

        // Database manager (handles connection and modification of the database).
        private DatabaseManager db;

        // Other private fields used for storage of the data in-memory.
        private BindingList<string> users;

        public AddIssue(DatabaseManager db)
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

        private void CheckValidity()
        {
            if (userSelectionCombo.SelectedIndex > -1 && !string.IsNullOrEmpty(customerNameBox.Text) && actionTakenCombo.SelectedIndex > -1)
            {
                addIssueButton.Enabled = true;
            }
            else
            {
                addIssueButton.Enabled = false;
            }
        }

        private void ClearForm()
        {
            userSelectionCombo.SelectedIndex = -1;
            actionTakenCombo.SelectedIndex = -1;
            customerNameBox.Clear();
            customerPhoneBox.Clear();
            orderReferenceBox.Clear();
            issueExplanationBox.Clear();
            valueSelection.Value = 0.0M;
            actionExplanationBox.Clear();
            dateAddedPicker.Value = DateTime.Now;

            CheckValidity();
        }

        private void AddIssue_Load(object sender, EventArgs e)
        {
            userSelectionCombo.DataSource = users;
            UpdateUsers();
            ClearForm();
        }

        private void CheckValidity(object sender, EventArgs e)
        {
            CheckValidity();
        }

        private void addIssueButton_Click(object sender, EventArgs e)
        {
            Issue newIssue = new Issue();

            newIssue.customerName = customerNameBox.Text;

            if (!string.IsNullOrEmpty(customerPhoneBox.Text))
            {
                newIssue.customerPhone = customerPhoneBox.Text;
            }

            if (!string.IsNullOrEmpty(orderReferenceBox.Text))
            {
                newIssue.reference = orderReferenceBox.Text;
            }

            newIssue.dateAdded = dateAddedPicker.Value.Date;

            if (userSelectionCombo.SelectedIndex > -1)
            {
                newIssue.userAdded = userSelectionCombo.Text;
            }

            if (!string.IsNullOrEmpty(issueExplanationBox.Text))
            {
                newIssue.reasonAdded = issueExplanationBox.Text;
            }

            newIssue.action = actionTakenCombo.Text;

            newIssue.value = valueSelection.Value;

            if (!string.IsNullOrEmpty(actionExplanationBox.Text))
            {
                newIssue.actionExplanation = actionExplanationBox.Text;
            }

            newIssue.resolved = false;

            db.AddIssue(newIssue);

            ClearForm();
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

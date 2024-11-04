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
    public partial class ModifyUsers : Form
    {
        // Database manager (handles connection and modification of the database).
        private DatabaseManager db;

        // Other private fields used for storage of the data in-memory.
        private BindingList<string> users;

        public ModifyUsers(DatabaseManager db)
        {
            InitializeComponent();

            // Inherits the database from the parent form.
            this.db = db;

            // Initialises data fields.
            users = new BindingList<string>();
        }

        private void UpdateUsers()
        {
            db.GetUsers(ref users);
            existingUserCombo.SelectedIndex = -1;
        }

        private void ClearForm()
        {
            newUserBox.Clear();
            addUserButton.Enabled = false;
            existingUserCombo.SelectedIndex = -1;
            removeUserButton.Enabled = false;
        }

        private void ModifyUsers_Load(object sender, EventArgs e)
        {
            existingUserCombo.DataSource = users;
            UpdateUsers();
            ClearForm();
        }

        private void newUserBox_TextChanged(object sender, EventArgs e)
        {
            addUserButton.Enabled = !string.IsNullOrEmpty(newUserBox.Text);
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            db.AddUser(newUserBox.Text);
            newUserBox.Clear();
            UpdateUsers();
        }

        private void existingUserCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeUserButton.Enabled = existingUserCombo.SelectedIndex > -1;
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            db.RemoveUser(existingUserCombo.Text);
            existingUserCombo.SelectedIndex = -1;
            UpdateUsers();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

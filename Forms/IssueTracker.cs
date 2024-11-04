using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchnitzIssueTracker.Database;

namespace SchnitzIssueTracker.Forms
{
    public partial class IssueTracker : Form
    {
        // Sub WinForm windows.
        private AddIssue addIssue;
        private ResolveIssue resolveIssue;

        // Database manager (handles connection and modification of the database).
        private DatabaseManager db;

        // Other private fields used for storage of the data in-memory.
        private BindingList<string> users;
        private SortableBindingList<Issue> issues;
        private Dictionary<string, SortOrder> columnSortStates;

        public IssueTracker()
        {
            InitializeComponent();

            // Initialize the database.
            db = new DatabaseManager();

            // Initialize the sub windows.
            addIssue = new AddIssue(db);
            resolveIssue = new ResolveIssue(db);

            // Initialises data fields.
            users = new BindingList<string>();
            issues = new SortableBindingList<Issue>();
            columnSortStates = new Dictionary<string, SortOrder>();

            // For custom Console.Write/WriteLine output to a Label:
            //Console.SetOut(new LabelWriter(databaseResponse));
        }

        private void UpdateUsers()
        {
            db.GetUsers(ref users);

            userFilterCombo.SelectedIndex = -1;
        }

        private IssueSearchFilter GetSearchFilter()
        {
            int date_direction;
            if (dateFilterBeforeRadio.Checked)
            {
                date_direction = -1;
            }
            else if (dateFilterAfterRadio.Checked)
            {
                date_direction = 1;
            }
            else
            {
                date_direction = 0;
            }

            IssueSearchFilter filter = new IssueSearchFilter
            {
                status_unresolved = unresolvedStatusCheckbox.Checked,
                status_resolved = resolvedStatusCheckbox.Checked,
                action_refunds = refundActionCheckbox.Checked,
                action_remakes = remakeActionCheckbox.Checked,
                action_tbd_other = tbdActionCheckbox.Checked,
                use_filter_user = userFilterCheckbox.Checked,
                filter_user = userFilterCombo.Text,
                use_filter_date = dateFilterCheckbox.Checked,
                filter_date = dateFilterPicker.Value.Date,
                filter_date_direction = date_direction,
                search_name = nameSearchBox.Text,
                search_phone = phoneSearchBox.Text,
                search_reference = referenceSearchBox.Text
            };

            return filter;
        }

        private void UpdateIssues()
        {
            db.GetIssues(GetSearchFilter(), ref issues);

            DefaultSorting();

            dataView.ClearSelection();
        }

        private void UpdateFilter(object sender, EventArgs e)
        {
            db.GetIssues(GetSearchFilter(), ref issues);

            ReapplySorting();

            dataView.ClearSelection();
        }

        private void UpdateData()
        {
            UpdateUsers();
            UpdateIssues();
        }

        private void DefaultSorting()
        {
            DataGridViewColumn dateAddedColumn = dataView.Columns["DateAdded"];

            columnSortStates[dateAddedColumn.Name] = SortOrder.Ascending;

            SortColumn(dateAddedColumn, ListSortDirection.Ascending);
        }

        private void ReapplySorting()
        {
            string columnName = columnSortStates.FirstOrDefault(x => x.Value != SortOrder.None).Key;

            if (string.IsNullOrEmpty(columnName)) return;

            ListSortDirection sortDirection = columnSortStates[columnName] == SortOrder.Ascending ? ListSortDirection.Ascending : ListSortDirection.Descending;
            DataGridViewColumn sortColumn = dataView.Columns[columnName];

            SortColumn(sortColumn, sortDirection);
        }

        private void SortColumn(DataGridViewColumn column, ListSortDirection sortDirection)
        {
            dataView.Sort(column, sortDirection);

            foreach (string key in columnSortStates.Keys.ToList())
            {
                if (key == column.Name)
                {
                    columnSortStates[key] = sortDirection == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
                    continue;
                }
                columnSortStates[key] = SortOrder.None;
            }

            column.HeaderCell.SortGlyphDirection = sortDirection == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }

        private void CycleColumnSort(DataGridViewColumn column)
        {
            // Add sort state to be tracked. Initialise with None state, as that is default, before cycling through states below.
            if (!columnSortStates.ContainsKey(column.Name))
            {
                columnSortStates[column.Name] = SortOrder.None;
            }

            // 3-way sort state cycling. This can be applied to the default sort state, as it will just cycle between two states.
            switch (columnSortStates[column.Name])
            {
                case SortOrder.None:
                    // Default / Not sorted. Cycle to ascending order.
                    SortColumn(column, ListSortDirection.Ascending);
                    break;
                case SortOrder.Ascending:
                    // Ascending order.  Cycle to descending order.
                    SortColumn(column, ListSortDirection.Descending);
                    break;
                case SortOrder.Descending:
                    // Descending order. Cycle to unordered (default sorting).
                    DefaultSorting();
                    break;
            }

            dataView.ClearSelection();
        }

        private void IssueTracker_Load(object sender, EventArgs e)
        {
            // Setup the DataGridView.
            dataView.AutoGenerateColumns = false;
            dataView.Columns.AddRange(
                new DataGridViewTextBoxColumn { Name = "CustomerName", HeaderText = "Customer Name", DataPropertyName = "customerName", SortMode = DataGridViewColumnSortMode.Programmatic },
                new DataGridViewTextBoxColumn { Name = "CustomerPhone", HeaderText = "Customer Phone", DataPropertyName = "customerPhone", SortMode = DataGridViewColumnSortMode.NotSortable },
                new DataGridViewTextBoxColumn { Name = "ReferenceNumber", HeaderText = "Reference Number", DataPropertyName = "reference", SortMode = DataGridViewColumnSortMode.NotSortable },
                new DataGridViewTextBoxColumn { Name = "DateAdded", HeaderText = "Date Added", DataPropertyName = "dateAdded", SortMode = DataGridViewColumnSortMode.Programmatic },
                new DataGridViewTextBoxColumn { Name = "UserAdded", HeaderText = "Added By", DataPropertyName = "userAdded", SortMode = DataGridViewColumnSortMode.Programmatic },
                new DataGridViewTextBoxColumn { Name = "ReasonAdded", HeaderText = "Reason Added", DataPropertyName = "reasonAdded", SortMode = DataGridViewColumnSortMode.NotSortable },
                new DataGridViewTextBoxColumn { Name = "Action", HeaderText = "Action", DataPropertyName = "action", SortMode = DataGridViewColumnSortMode.Programmatic },
                new DataGridViewTextBoxColumn { Name = "Value", HeaderText = "Value", DataPropertyName = "value", DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }, SortMode = DataGridViewColumnSortMode.Programmatic },
                new DataGridViewTextBoxColumn { Name = "ActionExplanation", HeaderText = "Action Details", DataPropertyName = "actionExplanation", SortMode = DataGridViewColumnSortMode.NotSortable },
                new DataGridViewTextBoxColumn { Name = "Resolved", HeaderText = "Resolved", DataPropertyName = "resolved", SortMode = DataGridViewColumnSortMode.Programmatic },
                new DataGridViewTextBoxColumn { Name = "DateResolved", HeaderText = "Date Resolved", DataPropertyName = "dateResolved", SortMode = DataGridViewColumnSortMode.Programmatic },
                new DataGridViewTextBoxColumn { Name = "UserResolved", HeaderText = "Resolved By", DataPropertyName = "userResolved", SortMode = DataGridViewColumnSortMode.Programmatic },
                new DataGridViewTextBoxColumn { Name = "ResolvedExplanation", HeaderText = "Resolution Details", DataPropertyName = "resolvedExplanation", SortMode = DataGridViewColumnSortMode.NotSortable }
            );

            userFilterCombo.DataSource = users;
            dataView.DataSource = issues;

            UpdateData();

            DefaultSorting();
            dataView.ClearSelection();
        }

        private void addIssueButton_Click(object sender, EventArgs e)
        {
            addIssue.ShowDialog();
            UpdateData();
        }

        private void resolveIssueButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataView.SelectedRows)
            {
                resolveIssue.ShowDialog(row);
            }

            UpdateData();
        }

        private void userFilterCheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            userFilterCombo.Enabled = userFilterCheckbox.Checked;
        }

        private void dateFilterCheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            dateFilterPicker.Enabled = dateFilterCheckbox.Checked;
            dateFilterBeforeRadio.Enabled = dateFilterCheckbox.Checked;
            dateFilterOnRadio.Enabled = dateFilterCheckbox.Checked;
            dateFilterAfterRadio.Enabled = dateFilterCheckbox.Checked;
        }

        private void dataView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = dataView.Columns[e.ColumnIndex];

            if (column.Name == "CustomerName" ||
                column.Name == "DateAdded" ||
                column.Name == "UserAdded" ||
                column.Name == "Action" ||
                column.Name == "Value" ||
                column.Name == "Resolved" ||
                column.Name == "DateResolved" ||
                column.Name == "UserResolved")
            {
                CycleColumnSort(column);
            }
        }

        private void dataView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataView.Rows)
            {
                Issue issue = row.DataBoundItem as Issue;

                if (issue.resolved)
                {
                    row.Selected = false;
                }
            }

            resolveIssueButton.Enabled = dataView.SelectedRows.Count > 0;
        }

        private void dataView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < dataView.Rows.Count)
            {
                DataGridViewRow row = dataView.Rows[rowIndex];

                if (row.Selected)
                {
                    row.Selected = false;
                }
            }
        }
    }
}

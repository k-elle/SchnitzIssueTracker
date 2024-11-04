using System.Data.SQLite;
using System.ComponentModel;
using SchnitzIssueTracker.Forms;

namespace SchnitzIssueTracker.Database
{
    public struct IssueSearchFilter
    {
        public bool status_unresolved;
        public bool status_resolved;

        public bool action_refunds;
        public bool action_remakes;
        public bool action_tbd_other;

        public bool use_filter_user;
        public string filter_user;

        public bool use_filter_date;
        public DateTime filter_date;
        public int filter_date_direction; // -1 / 0 / 1

        public string search_name;
        public string search_phone;
        public string search_reference;
    }
    public class Issue
    {
        public int ID { get; set; }
        public string customerName { get; set; }
        public string customerPhone { get; set; }
        public string reference { get; set; }
        public DateTime dateAdded { get; set; }
        public string userAdded { get; set; }
        public string reasonAdded { get; set; }
        public string action { get; set; }
        public decimal value { get; set; }
        public string actionExplanation { get; set; }
        public bool resolved { get; set; }
        public DateTime? dateResolved { get; set; }
        public string userResolved { get; set; }
        public string resolvedExplanation { get; set; }
    }
    public class SortableBindingList<T> : BindingList<T>
    {
        private bool isSorted;
        private ListSortDirection sortDirection;
        private PropertyDescriptor sortProperty;

        protected override bool SupportsSortingCore => true;
        protected override bool IsSortedCore => isSorted;
        protected override ListSortDirection SortDirectionCore => sortDirection;
        protected override PropertyDescriptor SortPropertyCore => sortProperty;

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            var items = (List<T>)Items;
            var propertyInfo = typeof(T).GetProperty(prop.Name);

            if (propertyInfo != null)
            {
                items.Sort((a, b) =>
                {
                    var aValue = propertyInfo.GetValue(a);
                    var bValue = propertyInfo.GetValue(b);
                    return direction == ListSortDirection.Ascending
                        ? Comparer<object>.Default.Compare(aValue, bValue)
                        : Comparer<object>.Default.Compare(bValue, aValue);
                });
                isSorted = true;
                sortDirection = direction;
                sortProperty = prop;
                OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            }
        }

        protected override void RemoveSortCore()
        {
            isSorted = false;
            sortProperty = null;
        }
    }
    public class DatabaseManager
    {
        private string connectionString = "Data Source=issuetracker.db;Version=3;";
        public DatabaseManager()
        {
            // Ensure database table is created.
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Create user table.
                string createUserTable = @"CREATE TABLE IF NOT EXISTS Users (
                                             Name TEXT UNIQUE NOT NULL
                                           );";
                SQLiteCommand createUsersCmd = new SQLiteCommand(createUserTable, connection);
                createUsersCmd.ExecuteNonQuery();

                // Create issues table.
                string createIssuesTable = @"CREATE TABLE IF NOT EXISTS Issues (
                                               ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                               CustomerName TEXT NOT NULL,
                                               CustomerPhone TEXT,
                                               OrderReference TEXT,
                                               DateAdded DATE,
                                               UserAdded TEXT,
                                               ReasonAdded TEXT,
                                               Action TEXT,
                                               Value REAL,
                                               ActionExplanation TEXT,
                                               Resolved BOOLEAN NOT NULL,
                                               DateResolved DATE,
                                               UserResolved TEXT,
                                               ResolvedExplanation TEXT
                                             );";
                SQLiteCommand createIssuesCmd = new SQLiteCommand(createIssuesTable, connection);
                createIssuesCmd.ExecuteNonQuery();
            }
        }
        public void AddUser(string user)
        {
            if (!string.IsNullOrEmpty(user))
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Add user to table.
                    string insertUser = "INSERT OR IGNORE INTO Users (Name) VALUES (@Name);";
                    using (SQLiteCommand insertCmd = new SQLiteCommand(insertUser, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@Name", user);
                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.Write("User successfully added.");
                        }
                        else
                        {
                            Console.Write("User already exists.");
                        }
                    }
                }
            }
        }
        public void RemoveUser(string user)
        {
            if (!string.IsNullOrEmpty(user))
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Remove user from table.
                    string removeUser = "DELETE FROM Users WHERE Name = @Name;";
                    using (SQLiteCommand deleteCmd = new SQLiteCommand(removeUser, connection))
                    {
                        deleteCmd.Parameters.AddWithValue("@Name", user);

                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.Write("User successfully deleted.");
                        }
                        else
                        {
                            Console.Write("User not found.");
                        }
                    }
                }
            }
        }
        public void GetUsers(ref BindingList<string> users)
        {
            users.Clear();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string getUser = "SELECT Name FROM Users;";
                using (SQLiteCommand getUserCmd = new SQLiteCommand(getUser, connection))
                using (SQLiteDataReader reader = getUserCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(reader["Name"].ToString());
                    }
                }
            }

            Console.Write("Users successfully retrieved.");
        }
        public void AddIssue(Issue newIssue)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string addIssue = @"INSERT INTO Issues 
                                     (CustomerName, CustomerPhone, OrderReference, DateAdded, UserAdded, ReasonAdded, Action, Value, ActionExplanation, Resolved, DateResolved, UserResolved, ResolvedExplanation) 
                                    VALUES 
                                     (@CustomerName, @CustomerPhone, @OrderReference, @DateAdded, @UserAdded, @ReasonAdded, @Action, @Value, @ActionExplanation, @Resolved, @DateResolved, @UserResolved, @ResolvedExplanation);";

                using (SQLiteCommand addIssueCmd = new SQLiteCommand(addIssue, connection))
                {
                    addIssueCmd.Parameters.AddWithValue("@CustomerName", newIssue.customerName);
                    addIssueCmd.Parameters.AddWithValue("@CustomerPhone", newIssue.customerPhone ?? (object)DBNull.Value);
                    addIssueCmd.Parameters.AddWithValue("@OrderReference", newIssue.reference ??  (object)DBNull.Value);
                    addIssueCmd.Parameters.AddWithValue("@DateAdded", newIssue.dateAdded);
                    addIssueCmd.Parameters.AddWithValue("@UserAdded", newIssue.userAdded ?? (object)DBNull.Value);
                    addIssueCmd.Parameters.AddWithValue("@ReasonAdded", newIssue.reasonAdded ?? (object)DBNull.Value);
                    addIssueCmd.Parameters.AddWithValue("@Action", newIssue.action);
                    addIssueCmd.Parameters.AddWithValue("@Value", newIssue.value);
                    addIssueCmd.Parameters.AddWithValue("@ActionExplanation", newIssue.actionExplanation ?? (object)DBNull.Value);
                    addIssueCmd.Parameters.AddWithValue("@Resolved", newIssue.resolved);
                    addIssueCmd.Parameters.AddWithValue("@DateResolved", newIssue.dateResolved ?? (object)DBNull.Value);
                    addIssueCmd.Parameters.AddWithValue("@UserResolved", newIssue.userResolved ?? (object)DBNull.Value);
                    addIssueCmd.Parameters.AddWithValue("@ResolvedExplanation", newIssue.resolvedExplanation ?? (object)DBNull.Value);

                    addIssueCmd.ExecuteNonQuery();
                }
            }

            Console.Write("Issue successfully added.");
        }
        private static T GetValueFromReader<T>(SQLiteDataReader reader, string columnName)
        {
            return reader.IsDBNull(reader.GetOrdinal(columnName)) ? default : (T)reader[columnName];
        }
        public void GetIssues(IssueSearchFilter filter, ref SortableBindingList<Issue> issues)
        {
            issues.Clear();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Define the base query, and a list to keep track of parameters.
                string getIssues = "SELECT * FROM Issues WHERE 1 = 1";
                List<SQLiteParameter> parameters = new List<SQLiteParameter>();

                // Add resolved filters. If both are included, ignore filter. If both are excluded, return nothing.
                if (filter.status_resolved && !filter.status_unresolved)
                {
                    getIssues += " AND Resolved = 1";
                }
                else if (filter.status_unresolved && !filter.status_resolved)
                {
                    getIssues += " AND Resolved = 0";
                }
                else if (!filter.status_resolved && !filter.status_unresolved)
                {
                    return;
                }

                // Add action filters. If all are included, ignore filter. If all are excluded, return nothing.
                List<string> actions = new List<string>();
                if (filter.action_refunds) actions.Add("Refund");
                if (filter.action_remakes) actions.Add("Remake");
                if (filter.action_tbd_other)
                {
                    actions.Add("TBD");
                    actions.Add("Other");
                }

                if (actions.Count > 0 && 4 > actions.Count)
                {
                    getIssues += " AND Action IN (";

                    for (int i = 0;  i < actions.Count; i++)
                    {
                        string paramName = $"@Action{i}";
                        getIssues += (i == 0 ? "" : ", ") + paramName;
                        parameters.Add(new SQLiteParameter(paramName, actions[i]));
                    }

                    getIssues += ")";
                }
                else if (actions.Count == 0)
                {
                    return;
                }

                // Filter the user added, if applicable.
                if (filter.use_filter_user && !string.IsNullOrEmpty(filter.filter_user))
                {
                    getIssues += " AND UserAdded = @UserAdded";
                    parameters.Add(new SQLiteParameter("@UserAdded", filter.filter_user));
                }

                // Filter by date, before, after or equal to.
                if (filter.use_filter_date)
                {
                    if (filter.filter_date_direction < 0)
                    {
                        // Before the date.
                        getIssues += " AND DateAdded < @FilterDate";
                    }
                    else if (filter.filter_date_direction > 0)
                    {
                        // After the date.
                        getIssues += " AND DateAdded > @FilterDate";
                    }
                    else
                    {
                        // Equal to the date.
                        getIssues += " AND DateAdded = @FilterDate";
                    }
                    parameters.Add(new SQLiteParameter("@FilterDate", filter.filter_date));
                }

                // Search filter on name.
                if (!string.IsNullOrEmpty(filter.search_name))
                {
                    getIssues += " AND CustomerName LIKE @SearchName";
                    parameters.Add(new SQLiteParameter("@SearchName", "%" + filter.search_name + "%"));
                }

                // Search filter on phone.
                if (!string.IsNullOrEmpty(filter.search_phone))
                {
                    getIssues += " AND CustomerPhone LIKE @SearchPhone";
                    parameters.Add(new SQLiteParameter("@SearchPhone", "%" + filter.search_phone + "%"));
                }

                // Search filter on reference.
                if (!string.IsNullOrEmpty(filter.search_reference))
                {
                    getIssues += " AND OrderReference LIKE @SearchReference";
                    parameters.Add(new SQLiteParameter("@SearchReference", "%" + filter.search_reference + "%"));
                }

                // Create command, add parameters, execute command, retrieve data, and insert into ref list.
                using (SQLiteCommand getIssuesCmd = new SQLiteCommand(getIssues, connection))
                {
                    getIssuesCmd.Parameters.AddRange(parameters.ToArray());
                    using (SQLiteDataReader reader = getIssuesCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Issue issue = new Issue();

                            issue.ID = Convert.ToInt32(reader["ID"]);
                            issue.customerName = GetValueFromReader<string>(reader, "CustomerName");
                            issue.customerPhone = GetValueFromReader<string>(reader, "CustomerPhone");
                            issue.reference = GetValueFromReader<string>(reader, "OrderReference");
                            issue.dateAdded = GetValueFromReader<DateTime>(reader, "DateAdded");
                            issue.userAdded = GetValueFromReader<string>(reader, "UserAdded");
                            issue.reasonAdded = GetValueFromReader<string>(reader, "ReasonAdded");
                            issue.action = GetValueFromReader<string>(reader, "Action");
                            issue.value = (decimal)GetValueFromReader<double>(reader, "Value");
                            issue.actionExplanation = GetValueFromReader<string>(reader, "ActionExplanation");
                            issue.resolved = GetValueFromReader<bool>(reader, "Resolved");
                            issue.dateResolved = GetValueFromReader<DateTime?>(reader, "DateResolved");
                            issue.userResolved = GetValueFromReader<string>(reader, "UserResolved");
                            issue.resolvedExplanation = GetValueFromReader<string>(reader, "ResolvedExplanation");

                            issues.Add(issue);
                        }
                    }
                }
            }

            Console.Write("Issues successfully retrieved.");
        }
        public void UpdateIssue(Issue issue)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateIssue = @"UPDATE Issues SET 
                                         CustomerName = @CustomerName,
                                         CustomerPhone = @CustomerPhone,
                                         OrderReference = @OrderReference,
                                         DateAdded = @DateAdded,
                                         UserAdded = @UserAdded,
                                         ReasonAdded = @ReasonAdded,
                                         Action = @Action,
                                         Value = @Value,
                                         ActionExplanation = @ActionExplanation,
                                         Resolved = @Resolved,
                                         DateResolved = @DateResolved,
                                         UserResolved = @UserResolved,
                                         ResolvedExplanation = @ResolvedExplanation
                                       WHERE ID = @ID;";

                using (SQLiteCommand updateIssueCmd = new SQLiteCommand(updateIssue, connection))
                {
                    updateIssueCmd.Parameters.AddWithValue("@CustomerName", issue.customerName);
                    updateIssueCmd.Parameters.AddWithValue("@CustomerPhone", issue.customerPhone ?? (object)DBNull.Value);  
                    updateIssueCmd.Parameters.AddWithValue("@OrderReference", issue.reference ?? (object)DBNull.Value);
                    updateIssueCmd.Parameters.AddWithValue("@DateAdded", issue.dateAdded);
                    updateIssueCmd.Parameters.AddWithValue("@UserAdded", issue.userAdded ?? (object)DBNull.Value);
                    updateIssueCmd.Parameters.AddWithValue("@ReasonAdded", issue.reasonAdded ?? (object)DBNull.Value);
                    updateIssueCmd.Parameters.AddWithValue("@Action", issue.action);
                    updateIssueCmd.Parameters.AddWithValue("@Value", issue.value);
                    updateIssueCmd.Parameters.AddWithValue("@ActionExplanation", issue.actionExplanation ?? (object)DBNull.Value);
                    updateIssueCmd.Parameters.AddWithValue("@Resolved", issue.resolved);
                    updateIssueCmd.Parameters.AddWithValue("@DateResolved", issue.dateResolved ?? (object)DBNull.Value);
                    updateIssueCmd.Parameters.AddWithValue("@UserResolved", issue.userResolved ?? (object)DBNull.Value);
                    updateIssueCmd.Parameters.AddWithValue("@ResolvedExplanation", issue.resolvedExplanation ?? (object)DBNull.Value);
                    updateIssueCmd.Parameters.AddWithValue("@ID", issue.ID);

                    updateIssueCmd.ExecuteNonQuery();
                }
            }

            Console.Write($"Issue (ID: {issue.ID}) successfully updated.");
        }
    }
}

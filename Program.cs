using SchnitzIssueTracker.Forms;

namespace SchnitzIssueTracker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Start program on main screen.
            ApplicationConfiguration.Initialize();
            Application.Run(new IssueTracker());
        }
    }
}
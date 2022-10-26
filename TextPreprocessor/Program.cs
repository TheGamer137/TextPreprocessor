using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextPreprocessor._Repositories;
using TextPreprocessor.Presenters;
using TextPreprocessor.Views;

namespace TextPreprocessor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;
            ITextView view = new TextView();
            ITextRepository repository = new TextRepository(connectionString);
            new TextPresenter(view, repository);
            Application.Run((Form)view);
        }
    }
}
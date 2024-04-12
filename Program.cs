using supermarkett_mvp._Repositories;
using supermarkett_mvp.Models;
using supermarkett_mvp.Presenters;
using supermarkett_mvp.Properties;
using supermarkett_mvp.Views;

namespace supermarkett_mvp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = Settings.Default.SqlConnection;
            IPayModeView view = new PayModeView();
            IPayModeRepository reposity = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, reposity);
            Application.Run(new Views.PayModeView());
        }
    }
}
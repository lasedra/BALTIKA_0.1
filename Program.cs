using Microsoft.Data.SqlClient;
using System.Data;
using System.IO;
using System.Text;
using System.Threading;

namespace BaltikaApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            try
            {
                #region //Автоматическое создание БД и её объектов при запуске приложения
                //Создание БД
                using (SqlConnection connection = new SqlConnection(@"Server=.\SQLEXPRESS;Integrated Security=True;TrustServerCertificate=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("CREATE DATABASE BALTIKA", connection);
                    command.ExecuteNonQuery();
                }

                DBinfo dbInfo = new DBinfo();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string query;


                //Объекты БД
                dbInfo.openConnection();
                {
                    //Создание таблиц
                    query = File.ReadAllText(@".\BALTIKA_Scripts\CreateTablesScript.sql", Encoding.GetEncoding("windows-1251"));
                    SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();

                    //Внесение тестовых данных
                    query = File.ReadAllText(Path.GetFullPath(@".\BALTIKA_Scripts\InsertTestDataScript.sql"), Encoding.GetEncoding("windows-1251"));
                    command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();

                    //Загрузка тестовых фото
                    string[] imagepaths =
                    {
                       @".\VesselImages\Dalnegorsk.jpg",
                       @".\VesselImages\Sofia.jpg",
                       @".\VesselImages\Kapitan_Maslov.jpg",
                       @".\VesselImages\Kapitan_Afanasyev.jpg",
                       @".\VesselImages\Vladivostok.jpg",
                       @".\VesselImages\Trader.jpg",
                       @".\VesselImages\Uliss.jpg",
                       @".\VesselImages\Askold.jpg",
                       @".\VesselImages\Paris.jpg",
                       @".\VesselImages\Olga.jpg"
                    };
                    int k = 101;
                    for (int i = 0; i < imagepaths.Length; i++)
                    {
                        query = "UPDATE Vessel " +
                            $"SET FilePath = '{Path.GetFullPath(imagepaths[i])}', " +
                            $"Photo = (SELECT * FROM OpenRowSet (BULK N'{Path.GetFullPath(imagepaths[i])}', SINGLE_BLOB) AS Image)" +
                            $"WHERE VesselRegNumber = {k}";
                        command = new SqlCommand(query, dbInfo.getConnection());
                        command.ExecuteNonQuery();
                        k++;
                    }


                    #region // Создание представлений
                    query = File.ReadAllText(Path.GetFullPath(@".\BALTIKA_Scripts\CreateViews\UsersDataToAdmin.sql"), Encoding.GetEncoding("windows-1251"));
                    command = new SqlCommand(query, dbInfo.getConnection());
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();

                    query = File.ReadAllText(Path.GetFullPath(@".\BALTIKA_Scripts\CreateViews\SenderView.sql"), Encoding.GetEncoding("windows-1251"));
                    command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();

                    query = File.ReadAllText(Path.GetFullPath(@".\BALTIKA_Scripts\CreateViews\ConsigneeView.sql"), Encoding.GetEncoding("windows-1251"));
                    command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();

                    query = File.ReadAllText(Path.GetFullPath(@".\BALTIKA_Scripts\CreateViews\VesselView.sql"), Encoding.GetEncoding("windows-1251"));
                    command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();

                    query = File.ReadAllText(Path.GetFullPath(@".\BALTIKA_Scripts\CreateViews\ConsignmentView.sql"), Encoding.GetEncoding("windows-1251"));
                    command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();

                    query = File.ReadAllText(Path.GetFullPath(@".\BALTIKA_Scripts\CreateViews\CMR_View.sql"), Encoding.GetEncoding("windows-1251"));
                    command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();

                    query = File.ReadAllText(Path.GetFullPath(@".\BALTIKA_Scripts\CreateViews\EmployeeView.sql"), Encoding.GetEncoding("windows-1251"));
                    command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();

                    query = File.ReadAllText(Path.GetFullPath(@".\BALTIKA_Scripts\CreateViews\EntityView.sql"), Encoding.GetEncoding("windows-1251"));
                    command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();

                    query = File.ReadAllText(Path.GetFullPath(@".\BALTIKA_Scripts\CreateViews\PostView.sql"), Encoding.GetEncoding("windows-1251"));
                    command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();

                    query = File.ReadAllText(Path.GetFullPath(@".\BALTIKA_Scripts\CreateViews\SalaryView.sql"), Encoding.GetEncoding("windows-1251"));
                    command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();

                    query = File.ReadAllText(Path.GetFullPath(@".\BALTIKA_Scripts\CreateViews\BankView.sql"), Encoding.GetEncoding("windows-1251"));
                    command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();

                    query = File.ReadAllText(Path.GetFullPath(@".\BALTIKA_Scripts\CreateViews\CargoView.sql"), Encoding.GetEncoding("windows-1251"));
                    command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();

                    query = File.ReadAllText(Path.GetFullPath(@".\BALTIKA_Scripts\CreateViews\Skipper_VesselView.sql"), Encoding.GetEncoding("windows-1251"));
                    command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();

                    query = File.ReadAllText(Path.GetFullPath(@".\BALTIKA_Scripts\CreateViews\VesselTypeView.sql"), Encoding.GetEncoding("windows-1251"));
                    command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();
                    #endregion

                    //Создание хранимых процедур
                    query = File.ReadAllText(Path.GetFullPath(@".\BALTIKA_Scripts\SPDoALogin.sql"), Encoding.GetEncoding("windows-1251"));
                    command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();

                    query = File.ReadAllText(Path.GetFullPath(@".\BALTIKA_Scripts\SPRegNewUser.sql"), Encoding.GetEncoding("windows-1251"));
                    command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();
                }
                dbInfo.closeConnection();
                #endregion

                ApplicationConfiguration.Initialize();
                Application.ThreadException += new ThreadExceptionEventHandler(exception);
                Application.Run(new LogInForm());
            }
            catch
            {
                ApplicationConfiguration.Initialize();
                Application.ThreadException += new ThreadExceptionEventHandler(exception);
                Application.Run(new LogInForm());
            }

            static void exception(object sender, ThreadExceptionEventArgs e)
            {
                MessageBox.Show(e.Exception.Message);
            }
        }
    }
}
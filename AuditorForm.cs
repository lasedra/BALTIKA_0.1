using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaltikaApp
{
    public partial class AuditorForm : Form
    {
        DBinfo dbInfo = new DBinfo();
        SqlDataAdapter adapter = new SqlDataAdapter();
        string query;

        public AuditorForm()
        {
            InitializeComponent();
        }

        private void AuditorForm_Load(object sender, EventArgs e)
        {
            #region //Заполнение вкладок TabControl данными
            dbInfo.openConnection();
            {
                query = "SELECT * FROM CMR_View";

                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                CMRGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM EmployeeView";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                EmployeeGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM ConsignmentView";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                ConsignmentGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT " +
                    "[Название], " +
                    "[Стоимость(руб.)], " +
                    "[Дата установки стоимости], " +
                    "[Страна-производитель], " +
                    "[Примечания] FROM CargoView";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                CargoGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM Skipper_VesselView";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                SkipperVesselGridView.DataSource = table;
            }
            dbInfo.closeConnection();
            #endregion
        }

        private void AuditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            LogInForm newform = new LogInForm();
            newform.Show();
        }
    }
}

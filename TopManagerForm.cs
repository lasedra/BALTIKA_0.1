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
    public partial class TopManagerForm : Form
    {
        DBinfo dbInfo = new DBinfo();
        SqlDataAdapter adapter = new SqlDataAdapter();
        string query;

        public TopManagerForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void TopManagerForm_Load(object sender, EventArgs e)
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
                    "[Фамилия отправителя], " +
                    "[Имя отправителя], " +
                    "[Отчество отправителя], " +
                    "[Компания], " +
                    "[ИНН], " +
                    "[Дата рождения], " +
                    "[Телефон], " +
                    "[Эл. почта], " +
                    "[Обслуживающий банк] " +
                    "FROM SenderView";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                SenderGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT " +
                    "[Фамилия получателя], " +
                    "[Имя получателя], " +
                    "[Отчество получателя], " +
                    "[Компания], " +
                    "[ИНН], " +
                    "[Дата рождения], " +
                    "[Телефон], " +
                    "[Эл. почта], " +
                    "[Обслуживающий банк] " +
                    "FROM ConsigneeView";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                ConsigneeGridView.DataSource = table;
            }
            dbInfo.closeConnection();
            #endregion
        }

        private void TopManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            LogInForm newform = new LogInForm();
            newform.Show();
        }
    }
}

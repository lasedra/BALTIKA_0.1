using Microsoft.Data.SqlClient;
using System;
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
    public partial class SalesManForm : Form
    {
        DBinfo dbInfo = new DBinfo();
        SqlDataAdapter adapter = new SqlDataAdapter();
        string query;

        public SalesManForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void SalesManForm_Load(object sender, EventArgs e)
        {
            #region //Заполнение вкладок TabControl данными
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

            dbInfo.openConnection();
            {
                query = "SELECT * FROM CargoView";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                CargoGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM BankView";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                BankGridView.DataSource = table;
            }
            dbInfo.closeConnection();
            #endregion
        }

        private void SalesManForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            LogInForm newform = new LogInForm();
            newform.Show();
        }
    }
}

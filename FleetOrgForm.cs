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
    public partial class FleetOrgForm : Form
    {
        DBinfo dbInfo = new DBinfo();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable photoTable = new DataTable();
        string query;

        public FleetOrgForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FleetOrg_Load(object sender, EventArgs e)
        {
            #region //Заполнение вкладок TabControl данными
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
                query = "SELECT * FROM Skipper_VesselView";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                SkipperVesselGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM VesselView";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                VesselGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM VesselTypeView";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                VesselTypeGridView.DataSource = table;
            }
            dbInfo.closeConnection();
            #endregion

            #region //Создание таблицы, содержащей фотографии
            dbInfo.openConnection();
            {
                query = "SELECT [Photo] FROM Vessel";
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(photoTable);
            }
            dbInfo.closeConnection();
            #endregion
        }


        private void VesselGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (VesselGridView.CurrentCell.OwningColumn.Name == "Фото")
            {
                OpenImageForm openImageForm = new OpenImageForm();
                DataRow newrow = photoTable.Rows[VesselGridView.CurrentCell.RowIndex];

                openImageForm.LoadImage((byte[])newrow.ItemArray[0]);
                openImageForm.Show();
            }
        }

        private void FleetOrgForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            LogInForm newform = new LogInForm();
            newform.Show();
        }
    }
}

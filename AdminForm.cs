using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaltikaApp
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        DBinfo dbInfo = new DBinfo();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DBoperation dbOperation = new DBoperation();
        DataTable photoTable = new DataTable();
        string query;

        private void AdminForm_Load(object sender, EventArgs e)
        {
            #region Заполнение вкладок TabControl 
            dbInfo.openConnection();
            {
                query = "SELECT [RowCode], [Login], [Password], [Employee_Code], [Post_Code]  FROM [Authorization]";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                AuthorizationGridView.DataSource = table;
                AuthorizationAddRowGridView.ColumnCount = AuthorizationGridView.ColumnCount;
                AuthorizationAddRowGridView.Rows[0].Cells[0].Value = "IDENTITY";
                AuthorizationAddRowGridView.Rows[0].Cells[0].ReadOnly = true;
                AuthorizationGridView.Columns[0].ReadOnly = true;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM Entity";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                EntityGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM Employee";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                EmployeeGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM Post";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                PostGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM Salary";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                SalaryGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM Sender";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                SenderGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM Consignee";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                ConsigneeGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM Bank";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                BankGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM CMR_HEADER";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                CMR_HEADERGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM [CMR_T.P.]";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                CMRGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM Consignment_Header";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                Consignment_HeaderGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM [Consignment_T.P.]";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                ConsignmentGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM Cargo";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                CargoGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM Cost";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                CostGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT [VesselRegNumber], [Name], [Capacity(cubic_meter)], [LaunchingDate], [Filepath], [VesselTypeCode] FROM Vessel";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                VesselGridView.DataSource = table;
                VesselAddRowGridView.ColumnCount = VesselGridView.ColumnCount;
                VesselAddRowGridView.Rows[0].Cells[4].Value = "NULL";
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM Vessel_Type";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                Vessel_TypeGridView.DataSource = table;
            }
            dbInfo.closeConnection();

            dbInfo.openConnection();
            {
                query = "SELECT * FROM Skipper_Vessel";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                Skipper_VesselGridView.DataSource = table;
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

        #region // CRUD Authorization
        //Add
        private void AuthorizationAddRowBttn_Click(object sender, EventArgs e)
        {
            try
            {
                dbInfo.openConnection();
                {
                    query = "INSERT INTO [Authorization] ([Login], [Password], [Hash], [Employee_Code], [Post_Code]) VALUES (" +
                        $"'{(string)AuthorizationAddRowGridView.Rows[0].Cells[1].Value}', " +
                        $"'{(string)AuthorizationAddRowGridView.Rows[0].Cells[2].Value}', " +
                        $"'{dbOperation.HashPassword((string)AuthorizationAddRowGridView.Rows[0].Cells[2].Value)}', " +
                        $"{AuthorizationAddRowGridView.Rows[0].Cells[3].Value}, " +
                        $"{AuthorizationAddRowGridView.Rows[0].Cells[4].Value})";
                    SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();
                }
                dbInfo.closeConnection();
                AuthorizationAddRowGridView.Rows.Clear();

                dbInfo.openConnection();
                {
                    query = "SELECT [RowCode], [Login], [Password], [Employee_Code], [Post_Code]  FROM [Authorization]";
                    DataTable table = new DataTable();
                    SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    AuthorizationGridView.DataSource = table;
                    AuthorizationAddRowGridView.ColumnCount = AuthorizationGridView.ColumnCount;
                    AuthorizationAddRowGridView.Rows[0].Cells[0].Value = "IDENTITY";
                    AuthorizationAddRowGridView.Rows[0].Cells[0].ReadOnly = true;
                    AuthorizationGridView.Columns[0].ReadOnly = true;
                }
                dbInfo.closeConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Refersh
        private void RefreshBttn_Click(object sender, EventArgs e)
        {
            dbInfo.openConnection();
            {
                query = "SELECT [RowCode], [Login], [Password], [Employee_Code], [Post_Code]  FROM [Authorization]";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                AuthorizationGridView.DataSource = table;
                AuthorizationAddRowGridView.ColumnCount = AuthorizationGridView.ColumnCount;
                AuthorizationAddRowGridView.Rows[0].Cells[0].Value = "IDENTITY";
                AuthorizationAddRowGridView.Rows[0].Cells[0].ReadOnly = true;
                AuthorizationGridView.Columns[0].ReadOnly = true;
            }
            dbInfo.closeConnection();
        }
        //Delete
        private void DeleteBttn_Click(object sender, EventArgs e)
        {
            try
            {
                dbInfo.openConnection();
                {
                    int selectedRowsCount = AuthorizationGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    for (int i = 0; i < selectedRowsCount; i++)
                    {
                        query = $"DELETE FROM [Authorization] WHERE [RowCode] = '{AuthorizationGridView.Rows[AuthorizationGridView.SelectedRows[i].Index].Cells[0].Value}'";
                        DataTable table = new DataTable();
                        SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                        command.ExecuteNonQuery();
                    }
                }
                dbInfo.closeConnection();

                dbInfo.openConnection();
                {
                    query = "SELECT [RowCode], [Login], [Password], [Employee_Code], [Post_Code]  FROM [Authorization]";
                    DataTable table = new DataTable();
                    SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    AuthorizationGridView.DataSource = table;
                    AuthorizationAddRowGridView.ColumnCount = AuthorizationGridView.ColumnCount;
                    AuthorizationAddRowGridView.Rows[0].Cells[0].Value = "IDENTITY";
                    AuthorizationAddRowGridView.Rows[0].Cells[0].ReadOnly = true;
                    AuthorizationGridView.Columns[0].ReadOnly = true;
                }
                dbInfo.closeConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Update
        private void AuthorizationGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dbInfo.openConnection();
                {
                    query = $"UPDATE [Authorization] " +
                            $"SET [Login] = '{AuthorizationGridView.CurrentRow.Cells[1].Value}', " +
                            $"[Password] = '{AuthorizationGridView.CurrentRow.Cells[2].Value}', " +
                            $"[Employee_Code] = {AuthorizationGridView.CurrentRow.Cells[3].Value}," +
                            $"[Post_Code] = {AuthorizationGridView.CurrentRow.Cells[4].Value}" +
                            $"WHERE [RowCode] = '{AuthorizationGridView.CurrentRow.Cells[0].Value}'";
                    DataTable table = new DataTable();
                    SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();
                }
                dbInfo.closeConnection();

                dbInfo.openConnection();
                {
                    query = "SELECT [RowCode], [Login], [Password], [Employee_Code], [Post_Code]  FROM [Authorization]";
                    DataTable table = new DataTable();
                    SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    AuthorizationGridView.DataSource = table;
                    AuthorizationAddRowGridView.ColumnCount = AuthorizationGridView.ColumnCount;
                    AuthorizationAddRowGridView.Rows[0].Cells[0].Value = "IDENTITY";
                    AuthorizationAddRowGridView.Rows[0].Cells[0].ReadOnly = true;
                    AuthorizationGridView.Columns[0].ReadOnly = true;
                }
                dbInfo.closeConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //RealTime search by attribute
        private void AuthorizationSearchTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (AuthorizationCB.SelectedIndex != -1)
                {
                    AuthorizationRegisterFilterCB.Checked = false;
                    switch (AuthorizationCB.SelectedItem.ToString())
                    {
                        case "RowCode":
                            {
                                dbInfo.openConnection();
                                {
                                    query = $"SELECT [RowCode], [Login], [Password], [Employee_Code], [Post_Code] FROM [Authorization] WHERE [RowCode] LIKE '%{AuthorizationSearchTB.Text}%'";
                                    SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                                    DataTable table = new DataTable();
                                    adapter.SelectCommand = command;
                                    adapter.Fill(table);

                                    AuthorizationGridView.DataSource = table;
                                }
                                dbInfo.closeConnection();
                                break;
                            }

                        case "Login":
                            {
                                dbInfo.openConnection();
                                {
                                    query = $"SELECT [RowCode], [Login], [Password], [Employee_Code], [Post_Code] FROM [Authorization] WHERE [Login] LIKE '%{AuthorizationSearchTB.Text}%'";
                                    SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                                    DataTable table = new DataTable();
                                    adapter.SelectCommand = command;
                                    adapter.Fill(table);

                                    AuthorizationGridView.DataSource = table;
                                }
                                dbInfo.closeConnection();
                                break;
                            }

                        case "Password":
                            {
                                dbInfo.openConnection();
                                {
                                    query = $"SELECT [RowCode], [Login], [Password], [Employee_Code], [Post_Code] FROM [Authorization] WHERE [Password] LIKE '%{AuthorizationSearchTB.Text}%'";
                                    SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                                    DataTable table = new DataTable();
                                    adapter.SelectCommand = command;
                                    adapter.Fill(table);

                                    AuthorizationGridView.DataSource = table;
                                }
                                dbInfo.closeConnection();
                                break;
                            }

                        case "Employee_Code":
                            {
                                dbInfo.openConnection();
                                {
                                    query = $"SELECT [RowCode], [Login], [Password], [Employee_Code], [Post_Code] FROM [Authorization] WHERE [Employee_Code] LIKE '%{AuthorizationSearchTB.Text}%'";
                                    SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                                    DataTable table = new DataTable();
                                    adapter.SelectCommand = command;
                                    adapter.Fill(table);

                                    AuthorizationGridView.DataSource = table;
                                }
                                dbInfo.closeConnection();
                                break;
                            }

                        case "Post_Code":
                            {
                                dbInfo.openConnection();
                                {
                                    query = $"SELECT [RowCode], [Login], [Password], [Employee_Code], [Post_Code] FROM [Authorization] WHERE [Post_Code] LIKE '%{AuthorizationSearchTB.Text}%'";
                                    SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                                    DataTable table = new DataTable();
                                    adapter.SelectCommand = command;
                                    adapter.Fill(table);

                                    AuthorizationGridView.DataSource = table;
                                }
                                dbInfo.closeConnection();
                                break;
                            }

                        default: break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Register filtration
        private void AuthorizationRegisterFilterCB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (AuthorizationRegisterFilterCB.Checked)
                {
                    AuthorizationGridView.CurrentCell = null;
                    for (int i = 0; i < AuthorizationGridView.Rows.Count - 1; i++)
                    {
                        char[] cellvalue = AuthorizationGridView.Rows[i].Cells[1].Value.ToString().ToCharArray();

                        foreach (char c in cellvalue)
                        {
                            if (Char.IsUpper(c))
                            {
                                AuthorizationGridView.Rows[i].Selected = true;
                                break;
                            }
                        }

                        cellvalue = AuthorizationGridView.Rows[i].Cells[2].Value.ToString().ToCharArray();

                        foreach (char c in cellvalue)
                        {
                            if (Char.IsUpper(c))
                            {
                                AuthorizationGridView.Rows[i].Selected = true;
                                break;
                            }
                        }
                    }

                    for (int i = 0; i < AuthorizationGridView.Rows.Count - 1; i++)
                    {
                        if (AuthorizationGridView.Rows[i].Selected)
                            AuthorizationGridView.Rows[i].Visible = false;
                    }
                }
                else
                {
                    dbInfo.openConnection();
                    {
                        query = "SELECT [RowCode], [Login], [Password], [Employee_Code], [Post_Code]  FROM [Authorization]";
                        DataTable table = new DataTable();
                        SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                        adapter.SelectCommand = command;
                        adapter.Fill(table);

                        AuthorizationGridView.DataSource = table;
                        AuthorizationAddRowGridView.ColumnCount = AuthorizationGridView.ColumnCount;
                        AuthorizationAddRowGridView.Rows[0].Cells[0].Value = "IDENTITY";
                        AuthorizationAddRowGridView.Rows[0].Cells[0].ReadOnly = true;
                        AuthorizationGridView.Columns[0].ReadOnly = true;
                    }
                    dbInfo.closeConnection();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        #endregion

        #region // CRUD Vessel
        private void VesselAddRowBttn_Click(object sender, EventArgs e)
        {
            try
            {
                dbInfo.openConnection();
                {
                    query = "INSERT INTO [Vessel] ([VesselRegNumber], [Name], [Capacity(cubic_meter)], [LaunchingDate], [Filepath], [VesselTypeCode]) VALUES (" +
                        $"{VesselAddRowGridView.Rows[0].Cells[0].Value}, " +
                        $"'{(string)VesselAddRowGridView.Rows[0].Cells[1].Value}', " +
                        $"{VesselAddRowGridView.Rows[0].Cells[2].Value}, " +
                        $"'{VesselAddRowGridView.Rows[0].Cells[3].Value}', " +
                        $"{VesselAddRowGridView.Rows[0].Cells[4].Value}, " +
                        $"{VesselAddRowGridView.Rows[0].Cells[5].Value})";
                    SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();
                }
                dbInfo.closeConnection();
                VesselAddRowGridView.Rows.Clear();

                dbInfo.openConnection();
                {
                    query = "SELECT [VesselRegNumber], [Name], [Capacity(cubic_meter)], [LaunchingDate], [Filepath], [VesselTypeCode] FROM Vessel";
                    DataTable table = new DataTable();
                    SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    VesselGridView.DataSource = table;
                    VesselAddRowGridView.ColumnCount = VesselGridView.ColumnCount;
                    VesselAddRowGridView.Rows[0].Cells[4].Value = "NULL";
                }
                dbInfo.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void VesselRefreshBttn_Click(object sender, EventArgs e)
        {
            dbInfo.openConnection();
            {
                query = "SELECT [VesselRegNumber], [Name], [Capacity(cubic_meter)], [LaunchingDate], [FilePath], [VesselTypeCode] FROM Vessel";
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                VesselGridView.DataSource = table;
                VesselAddRowGridView.ColumnCount = VesselGridView.ColumnCount;
                VesselAddRowGridView.Rows[0].Cells[4].Value = "NULL";
            }
            dbInfo.closeConnection();
        }
        private void VesselDeleteBttn_Click(object sender, EventArgs e)
        {
            try
            {
                dbInfo.openConnection();
                {
                    int selectedRowsCount = VesselGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    for (int i = 0; i < selectedRowsCount; i++)
                    {
                        query = $"DELETE FROM [Vessel] WHERE [VesselRegNumber] = {VesselGridView.Rows[VesselGridView.SelectedRows[i].Index].Cells[0].Value}";
                        DataTable table = new DataTable();
                        SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                        command.ExecuteNonQuery();
                    }
                }
                dbInfo.closeConnection();

                dbInfo.openConnection();
                {
                    query = "SELECT [VesselRegNumber], [Name], [Capacity(cubic_meter)], [LaunchingDate], [Filepath], [VesselTypeCode] FROM Vessel";
                    DataTable table = new DataTable();
                    SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    VesselGridView.DataSource = table;
                    VesselAddRowGridView.ColumnCount = VesselGridView.ColumnCount;
                    VesselAddRowGridView.Rows[0].Cells[4].Value = "NULL";
                }
                dbInfo.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void VesselGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dbInfo.openConnection();
                {
                    query = $"UPDATE [Vessel] " +
                            $"SET [Name] = '{VesselGridView.CurrentRow.Cells[1].Value}', " +
                            $"[Capacity(cubic_meter)] = {VesselGridView.CurrentRow.Cells[2].Value}, " +
                            $"[LaunchingDate] = '{VesselGridView.CurrentRow.Cells[3].Value}', " +
                            $"[Filepath] = '{VesselGridView.CurrentRow.Cells[4].Value}', " +
                            $"[VesselTypeCode] = {VesselGridView.CurrentRow.Cells[5].Value} " +
                            $"WHERE [VesselRegNumber] = {VesselGridView.CurrentRow.Cells[0].Value}";
                    DataTable table = new DataTable();
                    SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();
                }
                dbInfo.closeConnection();

                dbInfo.openConnection();
                {
                    query = "SELECT [VesselRegNumber], [Name], [Capacity(cubic_meter)], [LaunchingDate], [Filepath], [VesselTypeCode] FROM Vessel";
                    DataTable table = new DataTable();
                    SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    VesselGridView.DataSource = table;
                    VesselAddRowGridView.ColumnCount = VesselGridView.ColumnCount;
                    VesselAddRowGridView.Rows[0].Cells[4].Value = "NULL";
                }
                dbInfo.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Фотопросмотр
        private void VesselGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (VesselGridView.CurrentCell.OwningColumn.Name == "Filepath")
            {
                OpenImageForm openImageForm = new OpenImageForm();
                DataRow newrow = photoTable.Rows[VesselGridView.CurrentCell.RowIndex];

                openImageForm.LoadImage((byte[])newrow.ItemArray[0]);
                openImageForm.Show();
            }
        }
        #endregion

        public void VesselGridView_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop) && VesselGridView.CurrentCell.ColumnIndex == 4) 
                    e.Effect = DragDropEffects.Copy;
                else
                    throw new Exception("Drag and Drop работает только с полем фотографий Filepath");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            LogInForm newform = new LogInForm();
            newform.Show();
        }

        private void VesselGridView_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string file = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];


                if (file.Split('.').Last() == "jpg" || file.Split('.').Last() == "png" || file.Split('.').Last() == "gif" || file.Split('.').Last() == "jpeg")
                {
                    byte[] Image = File.ReadAllBytes(file);

                    dbInfo.openConnection();
                    {
                        query = $"UPDATE [Vessel] " +
                            $"SET Photo = @binaryValue, " +
                            $"Filepath = '{file}'" +
                            $"WHERE [VesselRegNumber] = {VesselGridView.CurrentRow.Cells[0].Value}";
                        SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                        command.Parameters.Add("@binaryValue", SqlDbType.VarBinary, Image.Length).Value = Image;
                        command.ExecuteNonQuery();
                    }
                    dbInfo.closeConnection();

                    MessageBox.Show("Успешно!");

                    dbInfo.openConnection();
                    {
                        query = "SELECT [VesselRegNumber], [Name], [Capacity(cubic_meter)], [LaunchingDate], [FilePath], [VesselTypeCode] FROM Vessel";
                        DataTable table = new DataTable();
                        SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                        adapter.SelectCommand = command;
                        adapter.Fill(table);

                        VesselGridView.DataSource = table;
                        VesselAddRowGridView.ColumnCount = VesselGridView.ColumnCount;
                        VesselAddRowGridView.Rows[0].Cells[4].Value = "NULL";
                    }
                    dbInfo.closeConnection();

                    dbInfo.openConnection();
                    {
                        query = "SELECT [Photo] FROM Vessel";
                        SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                        adapter.SelectCommand = command;
                        photoTable.Clear();
                        adapter.Fill(photoTable);
                    }
                    dbInfo.closeConnection();
                }
                else
                {
                    throw new Exception("Загрузить можно изображения, при том, лишь одно!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

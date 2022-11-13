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
    public partial class RegForm : Form
    {
        DBinfo dbInfo = new DBinfo();
        DBoperation dbOperation = new DBoperation();
        SqlDataAdapter adapter = new SqlDataAdapter();
        string query;

        public RegForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            AddUserBttn.Enabled = false;
            EmployeeLoginTB.MaxLength = 35;
            EmployeePasswordTB.MaxLength = 35;

            #region //Занесение всевозмножных должностей из [BALTIKA].[Post].[Name] в коллекцию PostComboBox
            try
            {
                DataTable table = new DataTable();

                query =
                   "SELECT [Name]" +
                   "FROM [Post],[Authorization]" +
                   "WHERE [Post].[Post_code] = [Authorization].[Post_code]";

                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    var cells = row.ItemArray;
                    foreach (object cell in cells)
                        PostComboBox.Items.Add(cell.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dbInfo.closeConnection();
            }
            #endregion

            #region //Занесение всевозмножных должностей из [BALTIKA].[Post].[Name] в коллекцию BankComboBox
            try
            {
                DataTable table = new DataTable();

                query =
                   "SELECT [Name]" +
                   "FROM [Bank]";

                SqlCommand command = new SqlCommand(query, dbInfo.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    var cells = row.ItemArray;
                    foreach (object cell in cells)
                        BankComboBox.Items.Add(cell.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dbInfo.closeConnection();
            }
            #endregion
        }

        private void AddUserBttn_Click(object sender, EventArgs e)
        {
            dbInfo.openConnection();
            {
                try
                {

                    query = "exec RegNewUser " +
                        Convert.ToInt32(EntityCodeTB.Text) + ", " +
                        Convert.ToInt32(EmployeeCodeTB.Text) + ", " +
                        $"'{EmployeeSurnameTB.Text}', " +
                        $"'{EmployeeNameTB.Text}', " +
                        $"'{EmployeePatronymicTB.Text}', " +
                        $"'{EmployeeITN_TB.Text}', " +
                        $"'{EmployeeBirthDateTB.Text.Trim()}', " +
                        $"'{EmployeePhoneTB.Text}', " +
                        $"'{EmployeeEmailTB.Text}', " +
                        $"'{BankComboBox.Text}', " +
                        $"'{EmployeeLoginTB.Text}', " +
                        $"'{EmployeePasswordTB.Text}', " +
                        $"'{dbOperation.HashPassword(EmployeePasswordTB.Text)}', " +
                        $"'{PostComboBox.Text}'";

                    SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Пользователь успешно добавлен");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    dbInfo.closeConnection();
                }
            }
            dbInfo.closeConnection();
        }

        #region //Проверка на заполненность поля логина, пароля, должности
        //Метод проверки и включения/отключения кнопки
        public void IsButtonsEnabled()
        {
            if (String.IsNullOrEmpty(EntityCodeTB.Text) == false
                && String.IsNullOrEmpty(EmployeeCodeTB.Text) == false
                && String.IsNullOrEmpty(EmployeeSurnameTB.Text) == false
                && String.IsNullOrEmpty(EmployeeNameTB.Text) == false
                && String.IsNullOrEmpty(EmployeePatronymicTB.Text) == false
                && String.IsNullOrEmpty(EmployeeBirthDateTB.Text) == false
                && String.IsNullOrEmpty(EmployeeITN_TB.Text) == false
                && String.IsNullOrEmpty(EmployeePhoneTB.Text) == false
                && String.IsNullOrEmpty(EmployeeEmailTB.Text) == false
                && String.IsNullOrEmpty(EmployeeLoginTB.Text) == false
                && String.IsNullOrEmpty(EmployeePasswordTB.Text) == false
                && String.IsNullOrEmpty(PostComboBox.Text) == false
                && String.IsNullOrEmpty(BankComboBox.Text) == false)
            {
                AddUserBttn.Enabled = true;
            }
            else
            {
                AddUserBttn.Enabled = false;
            }
        }
        //Движение мыши
        private void Regform_MouseMove(object sender, MouseEventArgs e)
        {
            IsButtonsEnabled();
        }
        //Фокус
        private void BankComboBox_Enter(object sender, EventArgs e)
        {
            IsButtonsEnabled();
        }
        private void PostComboBox_Enter(object sender, EventArgs e)
        {
            IsButtonsEnabled();
        }
        private void EmployeeLoginTB_Enter(object sender, EventArgs e)
        {
            IsButtonsEnabled();
        }
        private void EmployeePasswordTB_Enter(object sender, EventArgs e)
        {
            IsButtonsEnabled();
        }
        private void BankComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            IsButtonsEnabled();
        }
        private void PostComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            IsButtonsEnabled();
        }
        #endregion

        private void RegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            LogInForm newform = new LogInForm();
            newform.Show();
        }
    }
}

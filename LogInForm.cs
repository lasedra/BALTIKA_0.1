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
    public partial class LogInForm : Form
    {
        DBinfo dbInfo = new DBinfo();
        DBoperation dbOperation = new DBoperation();
        SqlDataAdapter adapter = new SqlDataAdapter();
        string query;

        public LogInForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            LogInBttn.Enabled = false;
            LoginTB.MaxLength = 35;
            PasswordTB.MaxLength = 35;

            #region //Занесение всевозмножных должностей из [BALTIKA].[Post].[Name] в коллекцию PostComboBox
            dbInfo.openConnection();
            {
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
            }
            dbInfo.closeConnection();
            #endregion
        }

        private void LogInBttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsLoginDataExists())
                {
                    switch(PostComboBox.Text)
                    {
                        case "Генеральный менеджер":
                            {
                                ActiveForm.Hide();
                                TopManagerForm newform = new TopManagerForm();
                                newform.Show();
                                break;
                            }

                        case "Менеджер продаж":
                            {
                                ActiveForm.Hide();
                                SalesManForm newform = new SalesManForm();
                                newform.Show();
                                break;
                            }

                        case "Сотрудник аудиторской службы":
                            {
                                ActiveForm.Hide();
                                AuditorForm newform = new AuditorForm();
                                newform.Show();
                                break;
                            }

                        case "Системный администратор":
                            {
                                ActiveForm.Hide();
                                AdminForm newform = new AdminForm();
                                newform.Show();
                                break;
                            }

                        case "Специалист по организации флота":
                            {
                                ActiveForm.Hide();
                                FleetOrgForm newform = new FleetOrgForm();
                                newform.Show();
                                break;
                            }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegFormLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (LoginTB.Text == "admin" && PasswordTB.Text == "admin")
                {
                    ActiveForm.Hide();
                    RegForm regForm = new RegForm();
                    regForm.Show();
                }
                else throw new Exception("Вы не обладаете правами админимтратора!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region//Метод проверки на существование логина и пароля
        public bool IsLoginDataExists()
        {
            dbInfo.openConnection();
            {
                try
                {
                    query = $"exec DoALogIn '{LoginTB.Text}', '{dbOperation.HashPassword(PasswordTB.Text)}', '{PostComboBox.SelectedItem.ToString()}'";

                    SqlCommand command = new SqlCommand(query, dbInfo.getConnection());
                    adapter.SelectCommand = command;
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count == 1)
                    {
                        dbInfo.closeConnection();
                        return true;
                    }
                    else
                    {
                        throw new Exception("Неверные логин, пароль или должность");
                    }
                }
                catch(Exception ex)
                {
                    dbInfo.closeConnection();
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
        #endregion

        #region //Методы для отображения/скрытия пароля
        //Показать пароль
        private void EyeVisiblePctrBox_Click(object sender, EventArgs e)
        {
            EyeVisiblePctrBox.Hide();
            PasswordTB.UseSystemPasswordChar = false;
            EyeHiddenPctrBox.Show();
        }

        //Скрыть пароль
        private void EyeHiddenPctrBox_Click(object sender, EventArgs e)
        {
            EyeHiddenPctrBox.Hide();
            PasswordTB.UseSystemPasswordChar = true;
            EyeVisiblePctrBox.Show();
        }
        #endregion

        #region //Проверка на заполненность поля логина, пароля, должности
        //Метод проверки и включения/отключения кнопки
        public void IsButtonsEnabled()
        {
            if (String.IsNullOrEmpty(LoginTB.Text) == false
                && String.IsNullOrEmpty(PasswordTB.Text) == false
                && String.IsNullOrEmpty(PostComboBox.Text) == false)
            {
                LogInBttn.Enabled = true;
            }
            else
            {
                LogInBttn.Enabled = false;
            }
        }
        //Изменение текста в текстбоксах
        private void LoginTB_TextChanged(object sender, EventArgs e)
        {
            IsButtonsEnabled();
        }
        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
            IsButtonsEnabled();
        }
        //Движение мыши
        private void LogInForm_MouseMove(object sender, MouseEventArgs e)
        {
            IsButtonsEnabled();
        }
        //Фокус
        private void PostComboBox_Enter(object sender, EventArgs e)
        {
            IsButtonsEnabled();
        }
        private void LoginTB_Enter(object sender, EventArgs e)
        {
            IsButtonsEnabled();
        }
        private void PasswordTB_Enter(object sender, EventArgs e)
        {
            IsButtonsEnabled();
        }
        private void PostComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            IsButtonsEnabled();
        }
        #endregion

        private void LogInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

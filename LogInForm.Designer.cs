namespace BaltikaApp
{
    partial class LogInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.label1 = new System.Windows.Forms.Label();
            this.PostComboBox = new System.Windows.Forms.ComboBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LogInBttn = new System.Windows.Forms.Button();
            this.EyeVisiblePctrBox = new System.Windows.Forms.PictureBox();
            this.EyeHiddenPctrBox = new System.Windows.Forms.PictureBox();
            this.RegFormLabel = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.EyeVisiblePctrBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyeHiddenPctrBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите вашу должность";
            // 
            // PostComboBox
            // 
            this.PostComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PostComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PostComboBox.Location = new System.Drawing.Point(30, 40);
            this.PostComboBox.Name = "PostComboBox";
            this.PostComboBox.Size = new System.Drawing.Size(261, 23);
            this.PostComboBox.Sorted = true;
            this.PostComboBox.TabIndex = 1;
            this.PostComboBox.SelectedValueChanged += new System.EventHandler(this.PostComboBox_SelectedValueChanged);
            this.PostComboBox.Enter += new System.EventHandler(this.PostComboBox_Enter);
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(30, 98);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(261, 23);
            this.LoginTB.TabIndex = 2;
            this.LoginTB.TextChanged += new System.EventHandler(this.LoginTB_TextChanged);
            this.LoginTB.Enter += new System.EventHandler(this.LoginTB_Enter);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(30, 141);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(232, 23);
            this.PasswordTB.TabIndex = 3;
            this.PasswordTB.UseSystemPasswordChar = true;
            this.PasswordTB.TextChanged += new System.EventHandler(this.PasswordTB_TextChanged);
            this.PasswordTB.Enter += new System.EventHandler(this.PasswordTB_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // LogInBttn
            // 
            this.LogInBttn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.LogInBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogInBttn.Location = new System.Drawing.Point(30, 170);
            this.LogInBttn.Name = "LogInBttn";
            this.LogInBttn.Size = new System.Drawing.Size(261, 38);
            this.LogInBttn.TabIndex = 6;
            this.LogInBttn.Text = "Войти";
            this.LogInBttn.UseVisualStyleBackColor = false;
            this.LogInBttn.Click += new System.EventHandler(this.LogInBttn_Click);
            // 
            // EyeVisiblePctrBox
            // 
            this.EyeVisiblePctrBox.BackColor = System.Drawing.SystemColors.Window;
            this.EyeVisiblePctrBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EyeVisiblePctrBox.Image = global::BaltikaApp.Properties.Resources.eye_visible;
            this.EyeVisiblePctrBox.Location = new System.Drawing.Point(268, 141);
            this.EyeVisiblePctrBox.Name = "EyeVisiblePctrBox";
            this.EyeVisiblePctrBox.Size = new System.Drawing.Size(23, 23);
            this.EyeVisiblePctrBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EyeVisiblePctrBox.TabIndex = 8;
            this.EyeVisiblePctrBox.TabStop = false;
            this.EyeVisiblePctrBox.Click += new System.EventHandler(this.EyeVisiblePctrBox_Click);
            // 
            // EyeHiddenPctrBox
            // 
            this.EyeHiddenPctrBox.BackColor = System.Drawing.SystemColors.Window;
            this.EyeHiddenPctrBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EyeHiddenPctrBox.Image = global::BaltikaApp.Properties.Resources.eye_hidden;
            this.EyeHiddenPctrBox.Location = new System.Drawing.Point(268, 141);
            this.EyeHiddenPctrBox.Name = "EyeHiddenPctrBox";
            this.EyeHiddenPctrBox.Size = new System.Drawing.Size(23, 23);
            this.EyeHiddenPctrBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EyeHiddenPctrBox.TabIndex = 9;
            this.EyeHiddenPctrBox.TabStop = false;
            this.EyeHiddenPctrBox.Click += new System.EventHandler(this.EyeHiddenPctrBox_Click);
            // 
            // RegFormLabel
            // 
            this.RegFormLabel.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegFormLabel.AutoSize = true;
            this.RegFormLabel.LinkColor = System.Drawing.Color.Navy;
            this.RegFormLabel.Location = new System.Drawing.Point(92, 223);
            this.RegFormLabel.Name = "RegFormLabel";
            this.RegFormLabel.Size = new System.Drawing.Size(141, 15);
            this.RegFormLabel.TabIndex = 10;
            this.RegFormLabel.TabStop = true;
            this.RegFormLabel.Text = "Добавить пользователя";
            this.RegFormLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RegFormLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegFormLabel_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Введите данные вашей учётной записи";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.EyeVisiblePctrBox);
            this.panel1.Controls.Add(this.PasswordTB);
            this.panel1.Controls.Add(this.PostComboBox);
            this.panel1.Controls.Add(this.LogInBttn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.RegFormLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LoginTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EyeHiddenPctrBox);
            this.panel1.Location = new System.Drawing.Point(39, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 261);
            this.panel1.TabIndex = 12;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(400, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInForm";
            this.Text = "Вход в личный кабинет";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogInForm_FormClosed);
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogInForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.EyeVisiblePctrBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyeHiddenPctrBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox PostComboBox;
        private TextBox LoginTB;
        private TextBox PasswordTB;
        private Label label2;
        private Label label3;
        private Button LogInBttn;
        private PictureBox EyeVisiblePctrBox;
        private PictureBox EyeHiddenPctrBox;
        private LinkLabel RegFormLabel;
        private Label label4;
        private Panel panel1;
    }
}
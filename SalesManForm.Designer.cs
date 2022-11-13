namespace BaltikaApp
{
    partial class SalesManForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesManForm));
            this.SalesManTabControl = new System.Windows.Forms.TabControl();
            this.SenderPage = new System.Windows.Forms.TabPage();
            this.SenderGridView = new System.Windows.Forms.DataGridView();
            this.ConsigneePage = new System.Windows.Forms.TabPage();
            this.ConsigneeGridView = new System.Windows.Forms.DataGridView();
            this.CargoPage = new System.Windows.Forms.TabPage();
            this.CargoGridView = new System.Windows.Forms.DataGridView();
            this.BankPage = new System.Windows.Forms.TabPage();
            this.BankGridView = new System.Windows.Forms.DataGridView();
            this.SalesManTabControl.SuspendLayout();
            this.SenderPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SenderGridView)).BeginInit();
            this.ConsigneePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsigneeGridView)).BeginInit();
            this.CargoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CargoGridView)).BeginInit();
            this.BankPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesManTabControl
            // 
            this.SalesManTabControl.Controls.Add(this.SenderPage);
            this.SalesManTabControl.Controls.Add(this.ConsigneePage);
            this.SalesManTabControl.Controls.Add(this.CargoPage);
            this.SalesManTabControl.Controls.Add(this.BankPage);
            this.SalesManTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesManTabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SalesManTabControl.Location = new System.Drawing.Point(0, 0);
            this.SalesManTabControl.Name = "SalesManTabControl";
            this.SalesManTabControl.SelectedIndex = 0;
            this.SalesManTabControl.Size = new System.Drawing.Size(1018, 450);
            this.SalesManTabControl.TabIndex = 0;
            // 
            // SenderPage
            // 
            this.SenderPage.Controls.Add(this.SenderGridView);
            this.SenderPage.Location = new System.Drawing.Point(4, 24);
            this.SenderPage.Name = "SenderPage";
            this.SenderPage.Padding = new System.Windows.Forms.Padding(3);
            this.SenderPage.Size = new System.Drawing.Size(1010, 422);
            this.SenderPage.TabIndex = 0;
            this.SenderPage.Text = "Данные об отправителях";
            this.SenderPage.UseVisualStyleBackColor = true;
            // 
            // SenderGridView
            // 
            this.SenderGridView.AllowUserToAddRows = false;
            this.SenderGridView.AllowUserToDeleteRows = false;
            this.SenderGridView.AllowUserToResizeColumns = false;
            this.SenderGridView.AllowUserToResizeRows = false;
            this.SenderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SenderGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SenderGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SenderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SenderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SenderGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.SenderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SenderGridView.GridColor = System.Drawing.Color.Turquoise;
            this.SenderGridView.Location = new System.Drawing.Point(3, 3);
            this.SenderGridView.Name = "SenderGridView";
            this.SenderGridView.RowTemplate.Height = 25;
            this.SenderGridView.Size = new System.Drawing.Size(1004, 416);
            this.SenderGridView.TabIndex = 0;
            // 
            // ConsigneePage
            // 
            this.ConsigneePage.Controls.Add(this.ConsigneeGridView);
            this.ConsigneePage.Location = new System.Drawing.Point(4, 24);
            this.ConsigneePage.Name = "ConsigneePage";
            this.ConsigneePage.Padding = new System.Windows.Forms.Padding(3);
            this.ConsigneePage.Size = new System.Drawing.Size(1010, 422);
            this.ConsigneePage.TabIndex = 1;
            this.ConsigneePage.Text = "Данные о получателях";
            this.ConsigneePage.UseVisualStyleBackColor = true;
            // 
            // ConsigneeGridView
            // 
            this.ConsigneeGridView.AllowUserToAddRows = false;
            this.ConsigneeGridView.AllowUserToDeleteRows = false;
            this.ConsigneeGridView.AllowUserToResizeColumns = false;
            this.ConsigneeGridView.AllowUserToResizeRows = false;
            this.ConsigneeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsigneeGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ConsigneeGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ConsigneeGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ConsigneeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ConsigneeGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.ConsigneeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsigneeGridView.GridColor = System.Drawing.Color.Turquoise;
            this.ConsigneeGridView.Location = new System.Drawing.Point(3, 3);
            this.ConsigneeGridView.Name = "ConsigneeGridView";
            this.ConsigneeGridView.RowTemplate.Height = 25;
            this.ConsigneeGridView.Size = new System.Drawing.Size(1004, 416);
            this.ConsigneeGridView.TabIndex = 0;
            // 
            // CargoPage
            // 
            this.CargoPage.Controls.Add(this.CargoGridView);
            this.CargoPage.Location = new System.Drawing.Point(4, 24);
            this.CargoPage.Name = "CargoPage";
            this.CargoPage.Padding = new System.Windows.Forms.Padding(3);
            this.CargoPage.Size = new System.Drawing.Size(1010, 422);
            this.CargoPage.TabIndex = 2;
            this.CargoPage.Text = "Грузы";
            this.CargoPage.UseVisualStyleBackColor = true;
            // 
            // CargoGridView
            // 
            this.CargoGridView.AllowUserToAddRows = false;
            this.CargoGridView.AllowUserToDeleteRows = false;
            this.CargoGridView.AllowUserToResizeColumns = false;
            this.CargoGridView.AllowUserToResizeRows = false;
            this.CargoGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CargoGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CargoGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CargoGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CargoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CargoGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.CargoGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CargoGridView.GridColor = System.Drawing.Color.Turquoise;
            this.CargoGridView.Location = new System.Drawing.Point(3, 3);
            this.CargoGridView.Name = "CargoGridView";
            this.CargoGridView.RowTemplate.Height = 25;
            this.CargoGridView.Size = new System.Drawing.Size(1004, 416);
            this.CargoGridView.TabIndex = 0;
            // 
            // BankPage
            // 
            this.BankPage.Controls.Add(this.BankGridView);
            this.BankPage.Location = new System.Drawing.Point(4, 24);
            this.BankPage.Name = "BankPage";
            this.BankPage.Padding = new System.Windows.Forms.Padding(3);
            this.BankPage.Size = new System.Drawing.Size(1010, 422);
            this.BankPage.TabIndex = 3;
            this.BankPage.Text = "Банки";
            this.BankPage.UseVisualStyleBackColor = true;
            // 
            // BankGridView
            // 
            this.BankGridView.AllowUserToAddRows = false;
            this.BankGridView.AllowUserToDeleteRows = false;
            this.BankGridView.AllowUserToResizeColumns = false;
            this.BankGridView.AllowUserToResizeRows = false;
            this.BankGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BankGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BankGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.BankGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BankGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.BankGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BankGridView.GridColor = System.Drawing.Color.Turquoise;
            this.BankGridView.Location = new System.Drawing.Point(3, 3);
            this.BankGridView.Name = "BankGridView";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BankGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.BankGridView.RowTemplate.Height = 25;
            this.BankGridView.Size = new System.Drawing.Size(1004, 416);
            this.BankGridView.TabIndex = 0;
            // 
            // SalesManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 450);
            this.Controls.Add(this.SalesManTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesManForm";
            this.Text = "Менеджмент продаж";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesManForm_FormClosed);
            this.Load += new System.EventHandler(this.SalesManForm_Load);
            this.SalesManTabControl.ResumeLayout(false);
            this.SenderPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SenderGridView)).EndInit();
            this.ConsigneePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsigneeGridView)).EndInit();
            this.CargoPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CargoGridView)).EndInit();
            this.BankPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BankGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl SalesManTabControl;
        private TabPage SenderPage;
        private TabPage ConsigneePage;
        private TabPage CargoPage;
        private TabPage BankPage;
        private DataGridView SenderGridView;
        private DataGridView BankGridView;
        private DataGridView ConsigneeGridView;
        private DataGridView CargoGridView;
    }
}
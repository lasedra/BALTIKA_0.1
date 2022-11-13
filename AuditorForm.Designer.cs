namespace BaltikaApp
{
    partial class AuditorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuditorForm));
            this.AuditorTabControl = new System.Windows.Forms.TabControl();
            this.CMRPage = new System.Windows.Forms.TabPage();
            this.CMRGridView = new System.Windows.Forms.DataGridView();
            this.ConsignmentPage = new System.Windows.Forms.TabPage();
            this.ConsignmentGridView = new System.Windows.Forms.DataGridView();
            this.CargoPage = new System.Windows.Forms.TabPage();
            this.CargoGridView = new System.Windows.Forms.DataGridView();
            this.EmployeePage = new System.Windows.Forms.TabPage();
            this.EmployeeGridView = new System.Windows.Forms.DataGridView();
            this.SkipperVesselPage = new System.Windows.Forms.TabPage();
            this.SkipperVesselGridView = new System.Windows.Forms.DataGridView();
            this.AuditorTabControl.SuspendLayout();
            this.CMRPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CMRGridView)).BeginInit();
            this.ConsignmentPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsignmentGridView)).BeginInit();
            this.CargoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CargoGridView)).BeginInit();
            this.EmployeePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            this.SkipperVesselPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SkipperVesselGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AuditorTabControl
            // 
            this.AuditorTabControl.Controls.Add(this.CMRPage);
            this.AuditorTabControl.Controls.Add(this.ConsignmentPage);
            this.AuditorTabControl.Controls.Add(this.CargoPage);
            this.AuditorTabControl.Controls.Add(this.EmployeePage);
            this.AuditorTabControl.Controls.Add(this.SkipperVesselPage);
            this.AuditorTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuditorTabControl.Location = new System.Drawing.Point(0, 0);
            this.AuditorTabControl.Name = "AuditorTabControl";
            this.AuditorTabControl.SelectedIndex = 0;
            this.AuditorTabControl.Size = new System.Drawing.Size(1017, 612);
            this.AuditorTabControl.TabIndex = 0;
            // 
            // CMRPage
            // 
            this.CMRPage.Controls.Add(this.CMRGridView);
            this.CMRPage.Location = new System.Drawing.Point(4, 24);
            this.CMRPage.Name = "CMRPage";
            this.CMRPage.Padding = new System.Windows.Forms.Padding(3);
            this.CMRPage.Size = new System.Drawing.Size(1009, 584);
            this.CMRPage.TabIndex = 0;
            this.CMRPage.Text = "CMR Документы";
            this.CMRPage.UseVisualStyleBackColor = true;
            // 
            // CMRGridView
            // 
            this.CMRGridView.AllowUserToAddRows = false;
            this.CMRGridView.AllowUserToDeleteRows = false;
            this.CMRGridView.AllowUserToResizeColumns = false;
            this.CMRGridView.AllowUserToResizeRows = false;
            this.CMRGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CMRGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CMRGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CMRGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CMRGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CMRGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CMRGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CMRGridView.GridColor = System.Drawing.Color.Turquoise;
            this.CMRGridView.Location = new System.Drawing.Point(3, 3);
            this.CMRGridView.Name = "CMRGridView";
            this.CMRGridView.RowTemplate.Height = 25;
            this.CMRGridView.Size = new System.Drawing.Size(1003, 578);
            this.CMRGridView.TabIndex = 4;
            // 
            // ConsignmentPage
            // 
            this.ConsignmentPage.Controls.Add(this.ConsignmentGridView);
            this.ConsignmentPage.Location = new System.Drawing.Point(4, 24);
            this.ConsignmentPage.Name = "ConsignmentPage";
            this.ConsignmentPage.Padding = new System.Windows.Forms.Padding(3);
            this.ConsignmentPage.Size = new System.Drawing.Size(1009, 584);
            this.ConsignmentPage.TabIndex = 1;
            this.ConsignmentPage.Text = "Коносаменты";
            this.ConsignmentPage.UseVisualStyleBackColor = true;
            // 
            // ConsignmentGridView
            // 
            this.ConsignmentGridView.AllowUserToAddRows = false;
            this.ConsignmentGridView.AllowUserToDeleteRows = false;
            this.ConsignmentGridView.AllowUserToResizeColumns = false;
            this.ConsignmentGridView.AllowUserToResizeRows = false;
            this.ConsignmentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsignmentGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ConsignmentGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ConsignmentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ConsignmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ConsignmentGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.ConsignmentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsignmentGridView.GridColor = System.Drawing.Color.Turquoise;
            this.ConsignmentGridView.Location = new System.Drawing.Point(3, 3);
            this.ConsignmentGridView.Name = "ConsignmentGridView";
            this.ConsignmentGridView.RowTemplate.Height = 25;
            this.ConsignmentGridView.Size = new System.Drawing.Size(1003, 578);
            this.ConsignmentGridView.TabIndex = 5;
            // 
            // CargoPage
            // 
            this.CargoPage.Controls.Add(this.CargoGridView);
            this.CargoPage.Location = new System.Drawing.Point(4, 24);
            this.CargoPage.Name = "CargoPage";
            this.CargoPage.Padding = new System.Windows.Forms.Padding(3);
            this.CargoPage.Size = new System.Drawing.Size(1009, 584);
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
            this.CargoGridView.Size = new System.Drawing.Size(1003, 578);
            this.CargoGridView.TabIndex = 6;
            // 
            // EmployeePage
            // 
            this.EmployeePage.Controls.Add(this.EmployeeGridView);
            this.EmployeePage.Location = new System.Drawing.Point(4, 24);
            this.EmployeePage.Name = "EmployeePage";
            this.EmployeePage.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeePage.Size = new System.Drawing.Size(1009, 584);
            this.EmployeePage.TabIndex = 3;
            this.EmployeePage.Text = "Данные о сотрудниках";
            this.EmployeePage.UseVisualStyleBackColor = true;
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.AllowUserToAddRows = false;
            this.EmployeeGridView.AllowUserToDeleteRows = false;
            this.EmployeeGridView.AllowUserToResizeColumns = false;
            this.EmployeeGridView.AllowUserToResizeRows = false;
            this.EmployeeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EmployeeGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.EmployeeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeGridView.GridColor = System.Drawing.Color.Turquoise;
            this.EmployeeGridView.Location = new System.Drawing.Point(3, 3);
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.RowTemplate.Height = 25;
            this.EmployeeGridView.Size = new System.Drawing.Size(1003, 578);
            this.EmployeeGridView.TabIndex = 6;
            // 
            // SkipperVesselPage
            // 
            this.SkipperVesselPage.Controls.Add(this.SkipperVesselGridView);
            this.SkipperVesselPage.Location = new System.Drawing.Point(4, 24);
            this.SkipperVesselPage.Name = "SkipperVesselPage";
            this.SkipperVesselPage.Padding = new System.Windows.Forms.Padding(3);
            this.SkipperVesselPage.Size = new System.Drawing.Size(1009, 584);
            this.SkipperVesselPage.TabIndex = 4;
            this.SkipperVesselPage.Text = "Рабочие смены";
            this.SkipperVesselPage.UseVisualStyleBackColor = true;
            // 
            // SkipperVesselGridView
            // 
            this.SkipperVesselGridView.AllowUserToAddRows = false;
            this.SkipperVesselGridView.AllowUserToDeleteRows = false;
            this.SkipperVesselGridView.AllowUserToResizeColumns = false;
            this.SkipperVesselGridView.AllowUserToResizeRows = false;
            this.SkipperVesselGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SkipperVesselGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SkipperVesselGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SkipperVesselGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.SkipperVesselGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SkipperVesselGridView.DefaultCellStyle = dataGridViewCellStyle10;
            this.SkipperVesselGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SkipperVesselGridView.GridColor = System.Drawing.Color.Turquoise;
            this.SkipperVesselGridView.Location = new System.Drawing.Point(3, 3);
            this.SkipperVesselGridView.Name = "SkipperVesselGridView";
            this.SkipperVesselGridView.RowTemplate.Height = 25;
            this.SkipperVesselGridView.Size = new System.Drawing.Size(1003, 578);
            this.SkipperVesselGridView.TabIndex = 6;
            // 
            // AuditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 612);
            this.Controls.Add(this.AuditorTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuditorForm";
            this.Text = "Аудит";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuditorForm_FormClosed);
            this.Load += new System.EventHandler(this.AuditorForm_Load);
            this.AuditorTabControl.ResumeLayout(false);
            this.CMRPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CMRGridView)).EndInit();
            this.ConsignmentPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsignmentGridView)).EndInit();
            this.CargoPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CargoGridView)).EndInit();
            this.EmployeePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.SkipperVesselPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SkipperVesselGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl AuditorTabControl;
        private TabPage ConsignmentPage;
        private TabPage CMRPage;
        private TabPage CargoPage;
        private TabPage EmployeePage;
        private TabPage SkipperVesselPage;
        private DataGridView CMRGridView;
        private DataGridView ConsignmentGridView;
        private DataGridView CargoGridView;
        private DataGridView EmployeeGridView;
        private DataGridView SkipperVesselGridView;
    }
}
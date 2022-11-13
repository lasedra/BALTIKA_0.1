namespace BaltikaApp
{
    partial class FleetOrgForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FleetOrgForm));
            this.TablesTabControl = new System.Windows.Forms.TabControl();
            this.ConsignmentPage = new System.Windows.Forms.TabPage();
            this.ConsignmentGridView = new System.Windows.Forms.DataGridView();
            this.SkipperVesselPage = new System.Windows.Forms.TabPage();
            this.SkipperVesselGridView = new System.Windows.Forms.DataGridView();
            this.VesselPage = new System.Windows.Forms.TabPage();
            this.VesselGridView = new System.Windows.Forms.DataGridView();
            this.VesselTypePage = new System.Windows.Forms.TabPage();
            this.VesselTypeGridView = new System.Windows.Forms.DataGridView();
            this.TablesTabControl.SuspendLayout();
            this.ConsignmentPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsignmentGridView)).BeginInit();
            this.SkipperVesselPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SkipperVesselGridView)).BeginInit();
            this.VesselPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VesselGridView)).BeginInit();
            this.VesselTypePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VesselTypeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TablesTabControl
            // 
            this.TablesTabControl.Controls.Add(this.ConsignmentPage);
            this.TablesTabControl.Controls.Add(this.SkipperVesselPage);
            this.TablesTabControl.Controls.Add(this.VesselPage);
            this.TablesTabControl.Controls.Add(this.VesselTypePage);
            this.TablesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablesTabControl.Location = new System.Drawing.Point(0, 0);
            this.TablesTabControl.Name = "TablesTabControl";
            this.TablesTabControl.SelectedIndex = 0;
            this.TablesTabControl.Size = new System.Drawing.Size(949, 504);
            this.TablesTabControl.TabIndex = 0;
            // 
            // ConsignmentPage
            // 
            this.ConsignmentPage.Controls.Add(this.ConsignmentGridView);
            this.ConsignmentPage.Location = new System.Drawing.Point(4, 24);
            this.ConsignmentPage.Name = "ConsignmentPage";
            this.ConsignmentPage.Padding = new System.Windows.Forms.Padding(3);
            this.ConsignmentPage.Size = new System.Drawing.Size(941, 476);
            this.ConsignmentPage.TabIndex = 0;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ConsignmentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ConsignmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ConsignmentGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ConsignmentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsignmentGridView.GridColor = System.Drawing.Color.Turquoise;
            this.ConsignmentGridView.Location = new System.Drawing.Point(3, 3);
            this.ConsignmentGridView.Name = "ConsignmentGridView";
            this.ConsignmentGridView.RowTemplate.Height = 25;
            this.ConsignmentGridView.Size = new System.Drawing.Size(935, 470);
            this.ConsignmentGridView.TabIndex = 2;
            // 
            // SkipperVesselPage
            // 
            this.SkipperVesselPage.Controls.Add(this.SkipperVesselGridView);
            this.SkipperVesselPage.Location = new System.Drawing.Point(4, 24);
            this.SkipperVesselPage.Name = "SkipperVesselPage";
            this.SkipperVesselPage.Padding = new System.Windows.Forms.Padding(3);
            this.SkipperVesselPage.Size = new System.Drawing.Size(941, 476);
            this.SkipperVesselPage.TabIndex = 1;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SkipperVesselGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SkipperVesselGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SkipperVesselGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.SkipperVesselGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SkipperVesselGridView.GridColor = System.Drawing.Color.Turquoise;
            this.SkipperVesselGridView.Location = new System.Drawing.Point(3, 3);
            this.SkipperVesselGridView.Name = "SkipperVesselGridView";
            this.SkipperVesselGridView.RowTemplate.Height = 25;
            this.SkipperVesselGridView.Size = new System.Drawing.Size(935, 470);
            this.SkipperVesselGridView.TabIndex = 3;
            // 
            // VesselPage
            // 
            this.VesselPage.Controls.Add(this.VesselGridView);
            this.VesselPage.Location = new System.Drawing.Point(4, 24);
            this.VesselPage.Name = "VesselPage";
            this.VesselPage.Padding = new System.Windows.Forms.Padding(3);
            this.VesselPage.Size = new System.Drawing.Size(941, 476);
            this.VesselPage.TabIndex = 2;
            this.VesselPage.Text = "Флот";
            this.VesselPage.UseVisualStyleBackColor = true;
            // 
            // VesselGridView
            // 
            this.VesselGridView.AllowUserToAddRows = false;
            this.VesselGridView.AllowUserToDeleteRows = false;
            this.VesselGridView.AllowUserToResizeColumns = false;
            this.VesselGridView.AllowUserToResizeRows = false;
            this.VesselGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VesselGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.VesselGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VesselGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.VesselGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VesselGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.VesselGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VesselGridView.GridColor = System.Drawing.Color.Turquoise;
            this.VesselGridView.Location = new System.Drawing.Point(3, 3);
            this.VesselGridView.Name = "VesselGridView";
            this.VesselGridView.RowTemplate.Height = 25;
            this.VesselGridView.Size = new System.Drawing.Size(935, 470);
            this.VesselGridView.TabIndex = 3;
            // 
            // VesselTypePage
            // 
            this.VesselTypePage.Controls.Add(this.VesselTypeGridView);
            this.VesselTypePage.Location = new System.Drawing.Point(4, 24);
            this.VesselTypePage.Name = "VesselTypePage";
            this.VesselTypePage.Padding = new System.Windows.Forms.Padding(3);
            this.VesselTypePage.Size = new System.Drawing.Size(941, 476);
            this.VesselTypePage.TabIndex = 3;
            this.VesselTypePage.Text = "Типы судов";
            this.VesselTypePage.UseVisualStyleBackColor = true;
            // 
            // VesselTypeGridView
            // 
            this.VesselTypeGridView.AllowUserToAddRows = false;
            this.VesselTypeGridView.AllowUserToDeleteRows = false;
            this.VesselTypeGridView.AllowUserToResizeColumns = false;
            this.VesselTypeGridView.AllowUserToResizeRows = false;
            this.VesselTypeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VesselTypeGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.VesselTypeGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VesselTypeGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.VesselTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VesselTypeGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.VesselTypeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VesselTypeGridView.GridColor = System.Drawing.Color.Turquoise;
            this.VesselTypeGridView.Location = new System.Drawing.Point(3, 3);
            this.VesselTypeGridView.Name = "VesselTypeGridView";
            this.VesselTypeGridView.RowTemplate.Height = 25;
            this.VesselTypeGridView.Size = new System.Drawing.Size(935, 470);
            this.VesselTypeGridView.TabIndex = 3;
            // 
            // FleetOrgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 504);
            this.Controls.Add(this.TablesTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FleetOrgForm";
            this.Text = "Организация работы с флотом";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FleetOrgForm_FormClosed);
            this.Load += new System.EventHandler(this.FleetOrg_Load);
            this.TablesTabControl.ResumeLayout(false);
            this.ConsignmentPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsignmentGridView)).EndInit();
            this.SkipperVesselPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SkipperVesselGridView)).EndInit();
            this.VesselPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VesselGridView)).EndInit();
            this.VesselTypePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VesselTypeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TablesTabControl;
        private TabPage ConsignmentPage;
        private TabPage SkipperVesselPage;
        private TabPage VesselPage;
        private TabPage VesselTypePage;
        private DataGridView ConsignmentGridView;
        private DataGridView SkipperVesselGridView;
        private DataGridView VesselGridView;
        private DataGridView VesselTypeGridView;
    }
}
namespace sanitizacionMejorado
{
    partial class frmDatabase
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            dtgDatos = new DataGridView();
            panel4 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            panel7 = new Panel();
            flowColumnas = new FlowLayoutPanel();
            checkBox1 = new CheckBox();
            panel6 = new Panel();
            cmbTablas = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1424, 633);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(384, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1040, 633);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(dtgDatos);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 114);
            panel5.Name = "panel5";
            panel5.Size = new Size(1040, 519);
            panel5.TabIndex = 1;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AllowUserToResizeColumns = false;
            dtgDatos.AllowUserToResizeRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.BackgroundColor = Color.WhiteSmoke;
            dtgDatos.BorderStyle = BorderStyle.None;
            dtgDatos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Red;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dtgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dtgDatos.ColumnHeadersHeight = 29;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Red;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dtgDatos.DefaultCellStyle = dataGridViewCellStyle6;
            dtgDatos.Dock = DockStyle.Fill;
            dtgDatos.GridColor = Color.FromArgb(224, 225, 221);
            dtgDatos.Location = new Point(0, 0);
            dtgDatos.Margin = new Padding(3, 4, 3, 4);
            dtgDatos.MultiSelect = false;
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtgDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.RowHeadersWidth = 51;
            dtgDatos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.WindowText;
            dtgDatos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dtgDatos.RowTemplate.Height = 25;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1040, 519);
            dtgDatos.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(button1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1040, 114);
            panel4.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.ForeColor = Color.White;
            button1.Location = new Point(780, 25);
            button1.Name = "button1";
            button1.Size = new Size(248, 46);
            button1.TabIndex = 0;
            button1.Text = "Sanitizar datos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 633);
            panel2.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(flowColumnas);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 157);
            panel7.Name = "panel7";
            panel7.Size = new Size(382, 474);
            panel7.TabIndex = 2;
            // 
            // flowColumnas
            // 
            flowColumnas.Dock = DockStyle.Fill;
            flowColumnas.FlowDirection = FlowDirection.TopDown;
            flowColumnas.Location = new Point(0, 0);
            flowColumnas.Name = "flowColumnas";
            flowColumnas.Size = new Size(382, 474);
            flowColumnas.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBox1.Location = new Point(179, 123);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(167, 30);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Seleccionar todos";
            checkBox1.TextAlign = ContentAlignment.MiddleRight;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(cmbTablas);
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(382, 114);
            panel6.TabIndex = 0;
            // 
            // cmbTablas
            // 
            cmbTablas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTablas.Location = new Point(27, 57);
            cmbTablas.Name = "cmbTablas";
            cmbTablas.Size = new Size(319, 28);
            cmbTablas.TabIndex = 1;
            cmbTablas.SelectedIndexChanged += cmbTablas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 25);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Tablas";
            // 
            // frmDatabase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 633);
            Controls.Add(panel1);
            Name = "frmDatabase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDatabase";
            Load += frmDatabase_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Panel panel2;
        public DataGridView dtgDatos;
        private Button button1;
        private CheckBox checkBox1;
        private Panel panel6;
        private ComboBox cmbTablas;
        private Label label1;
        private Panel panel7;
        private FlowLayoutPanel flowColumnas;
    }
}
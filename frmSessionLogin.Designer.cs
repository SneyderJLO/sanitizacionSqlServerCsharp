namespace sanitizacionMejorado
{
    partial class frmSessionLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            flowDB = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            lblConexionVerified = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnBuscar = new Button();
            label3 = new Label();
            btnConectar = new Button();
            txtServidor = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(flowDB);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnConectar);
            panel1.Controls.Add(txtServidor);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 424);
            panel1.TabIndex = 0;
            // 
            // flowDB
            // 
            flowDB.BorderStyle = BorderStyle.Fixed3D;
            flowDB.FlowDirection = FlowDirection.TopDown;
            flowDB.Location = new Point(377, 108);
            flowDB.Margin = new Padding(3, 2, 3, 2);
            flowDB.Name = "flowDB";
            flowDB.Size = new Size(253, 221);
            flowDB.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblConexionVerified);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(52, 108);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(319, 256);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Credenciales";
            // 
            // lblConexionVerified
            // 
            lblConexionVerified.BackColor = Color.Snow;
            lblConexionVerified.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblConexionVerified.Location = new Point(24, 176);
            lblConexionVerified.Name = "lblConexionVerified";
            lblConexionVerified.Size = new Size(253, 20);
            lblConexionVerified.TabIndex = 13;
            lblConexionVerified.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(24, 62);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(253, 26);
            txtUsuario.TabIndex = 3;
            txtUsuario.Text = "sa";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(24, 134);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(253, 26);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "123*abc*456";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Snow;
            label2.Location = new Point(24, 36);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(111, 208);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(166, 26);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Probar conexion";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Snow;
            label3.Location = new Point(24, 108);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(377, 338);
            btnConectar.Margin = new Padding(3, 2, 3, 2);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(253, 26);
            btnConectar.TabIndex = 10;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(52, 56);
            txtServidor.Margin = new Padding(3, 2, 3, 2);
            txtServidor.Multiline = true;
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(319, 26);
            txtServidor.TabIndex = 1;
            txtServidor.Text = "192.168.1.124";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Snow;
            label1.Location = new Point(52, 31);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Server/IP:";
            // 
            // frmSessionLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 424);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmSessionLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtServidor;
        private Label label1;
        private Button btnConectar;
        private TextBox txtUsuario;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private Button btnBuscar;
        private GroupBox groupBox1;
        private Label lblConexionVerified;
        private FlowLayoutPanel flowDB;
    }
}
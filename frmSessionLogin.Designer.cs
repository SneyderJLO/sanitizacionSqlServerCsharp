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
            btnProbarConexion = new Button();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnConectar = new Button();
            btnBuscar = new Button();
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
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(txtServidor);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 566);
            panel1.TabIndex = 0;
            // 
            // flowDB
            // 
            flowDB.BorderStyle = BorderStyle.Fixed3D;
            flowDB.FlowDirection = FlowDirection.TopDown;
            flowDB.Location = new Point(60, 144);
            flowDB.Name = "flowDB";
            flowDB.Size = new Size(289, 383);
            flowDB.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblConexionVerified);
            groupBox1.Controls.Add(btnProbarConexion);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(355, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 341);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Credenciales";
            // 
            // lblConexionVerified
            // 
            lblConexionVerified.BackColor = Color.Snow;
            lblConexionVerified.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblConexionVerified.Location = new Point(28, 234);
            lblConexionVerified.Name = "lblConexionVerified";
            lblConexionVerified.Size = new Size(289, 26);
            lblConexionVerified.TabIndex = 13;
            lblConexionVerified.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.Location = new Point(173, 270);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(144, 34);
            btnProbarConexion.TabIndex = 13;
            btnProbarConexion.Text = "Probar conexion";
            btnProbarConexion.UseVisualStyleBackColor = true;
            btnProbarConexion.Click += btnProbarConexion_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(28, 82);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(289, 34);
            txtUsuario.TabIndex = 3;
            txtUsuario.Text = "sa";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(28, 178);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(289, 34);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "135678";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Snow;
            label2.Location = new Point(28, 48);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Snow;
            label3.Location = new Point(28, 144);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(355, 493);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(365, 34);
            btnConectar.TabIndex = 10;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(528, 75);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(192, 34);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(60, 75);
            txtServidor.Multiline = true;
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(443, 34);
            txtServidor.TabIndex = 1;
            txtServidor.Text = "localhost";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Snow;
            label1.Location = new Point(60, 41);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Server/IP:";
            // 
            // frmSessionLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 566);
            Controls.Add(panel1);
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
        private Button btnProbarConexion;
        private Label lblConexionVerified;
        private FlowLayoutPanel flowDB;
    }
}
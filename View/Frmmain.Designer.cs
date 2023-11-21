namespace UI_UX_Dashboard_P1
{
    partial class Frmmain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmmain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblnomeusuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.btnmenu = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btmin = new System.Windows.Forms.Button();
            this.btnout = new System.Windows.Forms.Button();
            this.btnhospedes = new System.Windows.Forms.Button();
            this.btncadastros = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnreservas = new System.Windows.Forms.Button();
            this.btnindicadores = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1361, 47);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(1208, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 24);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1251, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 25);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1294, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblnomeusuario);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1361, 37);
            this.panel3.TabIndex = 2;
            // 
            // lblnomeusuario
            // 
            this.lblnomeusuario.AutoSize = true;
            this.lblnomeusuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomeusuario.Location = new System.Drawing.Point(1255, 9);
            this.lblnomeusuario.Name = "lblnomeusuario";
            this.lblnomeusuario.Size = new System.Drawing.Size(97, 19);
            this.lblnomeusuario.TabIndex = 3;
            this.lblnomeusuario.Text = "Nome Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1147, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Perfil";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(189, 84);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1172, 657);
            this.panel4.TabIndex = 19;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // sidebartimer
            // 
            this.sidebartimer.Interval = 10;
            this.sidebartimer.Tick += new System.EventHandler(this.sidebartimer_Tick);
            // 
            // btnmenu
            // 
            this.btnmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnmenu.FlatAppearance.BorderSize = 0;
            this.btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenu.ForeColor = System.Drawing.Color.Transparent;
            this.btnmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnmenu.Image")));
            this.btnmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmenu.Location = new System.Drawing.Point(0, 2);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(189, 40);
            this.btnmenu.TabIndex = 19;
            this.btnmenu.Text = "           Menu";
            this.btnmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.sidebar.Controls.Add(this.btnlogout);
            this.sidebar.Controls.Add(this.btnmenu);
            this.sidebar.Controls.Add(this.btmin);
            this.sidebar.Controls.Add(this.btnout);
            this.sidebar.Controls.Add(this.btnhospedes);
            this.sidebar.Controls.Add(this.btncadastros);
            this.sidebar.Controls.Add(this.button5);
            this.sidebar.Controls.Add(this.btnreservas);
            this.sidebar.Controls.Add(this.btnindicadores);
            this.sidebar.Controls.Add(this.btnhome);
            this.sidebar.Location = new System.Drawing.Point(0, 47);
            this.sidebar.MaximumSize = new System.Drawing.Size(189, 694);
            this.sidebar.MinimumSize = new System.Drawing.Size(40, 694);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(189, 694);
            this.sidebar.TabIndex = 1;
            // 
            // btnlogout
            // 
            this.btnlogout.AutoSize = true;
            this.btnlogout.BackColor = System.Drawing.Color.Transparent;
            this.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(0, 362);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(189, 40);
            this.btnlogout.TabIndex = 13;
            this.btnlogout.Text = "           Logout";
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btmin
            // 
            this.btmin.AutoSize = true;
            this.btmin.FlatAppearance.BorderSize = 0;
            this.btmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btmin.Image = ((System.Drawing.Image)(resources.GetObject("btmin.Image")));
            this.btmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmin.Location = new System.Drawing.Point(0, 242);
            this.btmin.Name = "btmin";
            this.btmin.Size = new System.Drawing.Size(189, 40);
            this.btmin.TabIndex = 15;
            this.btmin.Text = "           Check-in";
            this.btmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmin.UseVisualStyleBackColor = true;
            this.btmin.Click += new System.EventHandler(this.btmin_Click);
            // 
            // btnout
            // 
            this.btnout.AutoSize = true;
            this.btnout.FlatAppearance.BorderSize = 0;
            this.btnout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnout.Image = ((System.Drawing.Image)(resources.GetObject("btnout.Image")));
            this.btnout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnout.Location = new System.Drawing.Point(0, 282);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(189, 40);
            this.btnout.TabIndex = 15;
            this.btnout.Text = "           Check-out";
            this.btnout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnout.UseVisualStyleBackColor = true;
            this.btnout.Click += new System.EventHandler(this.btnout_Click);
            // 
            // btnhospedes
            // 
            this.btnhospedes.AutoSize = true;
            this.btnhospedes.FlatAppearance.BorderSize = 0;
            this.btnhospedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhospedes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhospedes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnhospedes.Image = ((System.Drawing.Image)(resources.GetObject("btnhospedes.Image")));
            this.btnhospedes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhospedes.Location = new System.Drawing.Point(0, 202);
            this.btnhospedes.Name = "btnhospedes";
            this.btnhospedes.Size = new System.Drawing.Size(189, 40);
            this.btnhospedes.TabIndex = 11;
            this.btnhospedes.Text = "           Hóspedes";
            this.btnhospedes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhospedes.UseVisualStyleBackColor = true;
            this.btnhospedes.Click += new System.EventHandler(this.btnhospedes_Click);
            // 
            // btncadastros
            // 
            this.btncadastros.AutoSize = true;
            this.btncadastros.FlatAppearance.BorderSize = 0;
            this.btncadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastros.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btncadastros.Image = ((System.Drawing.Image)(resources.GetObject("btncadastros.Image")));
            this.btncadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncadastros.Location = new System.Drawing.Point(0, 322);
            this.btncadastros.Name = "btncadastros";
            this.btncadastros.Size = new System.Drawing.Size(189, 40);
            this.btncadastros.TabIndex = 9;
            this.btncadastros.Text = "           Cadastros";
            this.btncadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncadastros.UseVisualStyleBackColor = true;
            this.btncadastros.Click += new System.EventHandler(this.btncadastros_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 122);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 40);
            this.button5.TabIndex = 7;
            this.button5.Text = "           Mapa";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnreservas
            // 
            this.btnreservas.FlatAppearance.BorderSize = 0;
            this.btnreservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreservas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreservas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnreservas.Image = ((System.Drawing.Image)(resources.GetObject("btnreservas.Image")));
            this.btnreservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreservas.Location = new System.Drawing.Point(0, 162);
            this.btnreservas.Name = "btnreservas";
            this.btnreservas.Size = new System.Drawing.Size(189, 40);
            this.btnreservas.TabIndex = 5;
            this.btnreservas.Text = "           Reservas";
            this.btnreservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreservas.UseVisualStyleBackColor = true;
            this.btnreservas.Click += new System.EventHandler(this.btnreservas_Click);
            // 
            // btnindicadores
            // 
            this.btnindicadores.FlatAppearance.BorderSize = 0;
            this.btnindicadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnindicadores.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnindicadores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnindicadores.Image = ((System.Drawing.Image)(resources.GetObject("btnindicadores.Image")));
            this.btnindicadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnindicadores.Location = new System.Drawing.Point(0, 82);
            this.btnindicadores.Name = "btnindicadores";
            this.btnindicadores.Size = new System.Drawing.Size(189, 40);
            this.btnindicadores.TabIndex = 3;
            this.btnindicadores.Text = "           Indicadores";
            this.btnindicadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnindicadores.UseVisualStyleBackColor = true;
            this.btnindicadores.Click += new System.EventHandler(this.btnindicadores_Click);
            // 
            // btnhome
            // 
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(0, 42);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(189, 40);
            this.btnhome.TabIndex = 1;
            this.btnhome.Text = "           Home";
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // Frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 741);
            this.ControlBox = false;
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmmain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnomeusuario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer sidebartimer;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button btmin;
        private System.Windows.Forms.Button btnout;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnhospedes;
        private System.Windows.Forms.Button btncadastros;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnreservas;
        private System.Windows.Forms.Button btnindicadores;
        private System.Windows.Forms.Button btnhome;
    }
}


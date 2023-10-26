namespace testando
{
    partial class Frmhospedes
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtHospede = new System.Windows.Forms.DataGridView();
            this.btnfotoh = new System.Windows.Forms.Button();
            this.txtemailh = new System.Windows.Forms.TextBox();
            this.lblEmailh = new System.Windows.Forms.Label();
            this.ptbfoto = new System.Windows.Forms.PictureBox();
            this.txttelefoneh = new System.Windows.Forms.TextBox();
            this.txtnomeh = new System.Windows.Forms.TextBox();
            this.lbltelefoneh = new System.Windows.Forms.Label();
            this.lblnomeh = new System.Windows.Forms.Label();
            this.lblcadastrousu = new System.Windows.Forms.Label();
            this.txtcpfh = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblstatush = new System.Windows.Forms.Label();
            this.cbostatush = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtHospede)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(405, 278);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 90;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(531, 278);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 89;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(279, 278);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 88;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dtHospede
            // 
            this.dtHospede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHospede.Location = new System.Drawing.Point(41, 324);
            this.dtHospede.Name = "dtHospede";
            this.dtHospede.Size = new System.Drawing.Size(1062, 182);
            this.dtHospede.TabIndex = 87;
            this.dtHospede.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtHospede_CellContentClick);
            // 
            // btnfotoh
            // 
            this.btnfotoh.Location = new System.Drawing.Point(58, 278);
            this.btnfotoh.Name = "btnfotoh";
            this.btnfotoh.Size = new System.Drawing.Size(104, 23);
            this.btnfotoh.TabIndex = 86;
            this.btnfotoh.Text = "Inserir Foto";
            this.btnfotoh.UseVisualStyleBackColor = true;
            this.btnfotoh.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // txtemailh
            // 
            this.txtemailh.Location = new System.Drawing.Point(270, 218);
            this.txtemailh.Name = "txtemailh";
            this.txtemailh.Size = new System.Drawing.Size(344, 20);
            this.txtemailh.TabIndex = 85;
            // 
            // lblEmailh
            // 
            this.lblEmailh.AutoSize = true;
            this.lblEmailh.Location = new System.Drawing.Point(267, 202);
            this.lblEmailh.Name = "lblEmailh";
            this.lblEmailh.Size = new System.Drawing.Size(35, 13);
            this.lblEmailh.TabIndex = 84;
            this.lblEmailh.Text = "Email:";
            // 
            // ptbfoto
            // 
            this.ptbfoto.Location = new System.Drawing.Point(41, 64);
            this.ptbfoto.Name = "ptbfoto";
            this.ptbfoto.Size = new System.Drawing.Size(150, 200);
            this.ptbfoto.TabIndex = 83;
            this.ptbfoto.TabStop = false;
            // 
            // txttelefoneh
            // 
            this.txttelefoneh.Location = new System.Drawing.Point(270, 162);
            this.txttelefoneh.Name = "txttelefoneh";
            this.txttelefoneh.Size = new System.Drawing.Size(344, 20);
            this.txttelefoneh.TabIndex = 80;
            // 
            // txtnomeh
            // 
            this.txtnomeh.Location = new System.Drawing.Point(270, 106);
            this.txtnomeh.Name = "txtnomeh";
            this.txtnomeh.Size = new System.Drawing.Size(344, 20);
            this.txtnomeh.TabIndex = 79;
            // 
            // lbltelefoneh
            // 
            this.lbltelefoneh.AutoSize = true;
            this.lbltelefoneh.Location = new System.Drawing.Point(268, 146);
            this.lbltelefoneh.Name = "lbltelefoneh";
            this.lbltelefoneh.Size = new System.Drawing.Size(52, 13);
            this.lbltelefoneh.TabIndex = 77;
            this.lbltelefoneh.Text = "Telefone:";
            // 
            // lblnomeh
            // 
            this.lblnomeh.AutoSize = true;
            this.lblnomeh.Location = new System.Drawing.Point(268, 90);
            this.lblnomeh.Name = "lblnomeh";
            this.lblnomeh.Size = new System.Drawing.Size(38, 13);
            this.lblnomeh.TabIndex = 76;
            this.lblnomeh.Text = "Nome:";
            // 
            // lblcadastrousu
            // 
            this.lblcadastrousu.AutoSize = true;
            this.lblcadastrousu.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblcadastrousu.ForeColor = System.Drawing.Color.Black;
            this.lblcadastrousu.Location = new System.Drawing.Point(15, 11);
            this.lblcadastrousu.Name = "lblcadastrousu";
            this.lblcadastrousu.Size = new System.Drawing.Size(150, 23);
            this.lblcadastrousu.TabIndex = 74;
            this.lblcadastrousu.Text = "Cadastro Hospede";
            // 
            // txtcpfh
            // 
            this.txtcpfh.Location = new System.Drawing.Point(682, 106);
            this.txtcpfh.Name = "txtcpfh";
            this.txtcpfh.Size = new System.Drawing.Size(200, 20);
            this.txtcpfh.TabIndex = 94;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(681, 90);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 93;
            this.lblCPF.Text = "CPF:";
            // 
            // lblstatush
            // 
            this.lblstatush.AutoSize = true;
            this.lblstatush.Location = new System.Drawing.Point(683, 145);
            this.lblstatush.Name = "lblstatush";
            this.lblstatush.Size = new System.Drawing.Size(84, 13);
            this.lblstatush.TabIndex = 95;
            this.lblstatush.Text = "Status hospede:";
            // 
            // cbostatush
            // 
            this.cbostatush.FormattingEnabled = true;
            this.cbostatush.Location = new System.Drawing.Point(682, 161);
            this.cbostatush.Name = "cbostatush";
            this.cbostatush.Size = new System.Drawing.Size(121, 21);
            this.cbostatush.TabIndex = 96;
            // 
            // Cadastroh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 580);
            this.Controls.Add(this.cbostatush);
            this.Controls.Add(this.lblstatush);
            this.Controls.Add(this.txtcpfh);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtHospede);
            this.Controls.Add(this.btnfotoh);
            this.Controls.Add(this.txtemailh);
            this.Controls.Add(this.lblEmailh);
            this.Controls.Add(this.ptbfoto);
            this.Controls.Add(this.txttelefoneh);
            this.Controls.Add(this.txtnomeh);
            this.Controls.Add(this.lbltelefoneh);
            this.Controls.Add(this.lblnomeh);
            this.Controls.Add(this.lblcadastrousu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastroh";
            this.Text = "Cadastroh";
            this.Load += new System.EventHandler(this.Cadastroh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtHospede)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dtHospede;
        private System.Windows.Forms.Button btnfotoh;
        private System.Windows.Forms.TextBox txtemailh;
        private System.Windows.Forms.Label lblEmailh;
        private System.Windows.Forms.PictureBox ptbfoto;
        private System.Windows.Forms.TextBox txttelefoneh;
        private System.Windows.Forms.TextBox txtnomeh;
        private System.Windows.Forms.Label lbltelefoneh;
        private System.Windows.Forms.Label lblnomeh;
        private System.Windows.Forms.Label lblcadastrousu;
        private System.Windows.Forms.TextBox txtcpfh;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblstatush;
        private System.Windows.Forms.ComboBox cbostatush;
    }
}
namespace testando
{
    partial class Cadastrop
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
            this.btnFoto = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.ptbfoto = new System.Windows.Forms.PictureBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkData = new System.Windows.Forms.CheckBox();
            this.data_validade = new System.Windows.Forms.DateTimePicker();
            this.lblcadastroprod = new System.Windows.Forms.Label();
            this.btnListarUsuario = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtUsuario = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(192, 247);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 23);
            this.btnFoto.TabIndex = 33;
            this.btnFoto.Text = "Inserir Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(517, 176);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "código:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(704, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Preço:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(658, 247);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 31;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "quantidade:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(517, 55);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 22;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(794, 117);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(231, 20);
            this.txtDescricao.TabIndex = 23;
            // 
            // ptbfoto
            // 
            this.ptbfoto.Location = new System.Drawing.Point(104, 55);
            this.ptbfoto.Name = "ptbfoto";
            this.ptbfoto.Size = new System.Drawing.Size(270, 180);
            this.ptbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbfoto.TabIndex = 29;
            this.ptbfoto.TabStop = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(517, 118);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(704, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Validade:";
            this.label5.Visible = false;
            // 
            // chkData
            // 
            this.chkData.AutoSize = true;
            this.chkData.Location = new System.Drawing.Point(707, 178);
            this.chkData.Name = "chkData";
            this.chkData.Size = new System.Drawing.Size(109, 17);
            this.chkData.TabIndex = 26;
            this.chkData.Text = "Produto perecivel";
            this.chkData.UseVisualStyleBackColor = true;
            // 
            // data_validade
            // 
            this.data_validade.Location = new System.Drawing.Point(794, 55);
            this.data_validade.Name = "data_validade";
            this.data_validade.Size = new System.Drawing.Size(231, 20);
            this.data_validade.TabIndex = 27;
            this.data_validade.Visible = false;
            // 
            // lblcadastroprod
            // 
            this.lblcadastroprod.AutoSize = true;
            this.lblcadastroprod.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblcadastroprod.ForeColor = System.Drawing.Color.Black;
            this.lblcadastroprod.Location = new System.Drawing.Point(12, 9);
            this.lblcadastroprod.Name = "lblcadastroprod";
            this.lblcadastroprod.Size = new System.Drawing.Size(152, 23);
            this.lblcadastroprod.TabIndex = 34;
            this.lblcadastroprod.Text = "Cadastro Produtos";
            // 
            // btnListarUsuario
            // 
            this.btnListarUsuario.Location = new System.Drawing.Point(985, 489);
            this.btnListarUsuario.Name = "btnListarUsuario";
            this.btnListarUsuario.Size = new System.Drawing.Size(108, 23);
            this.btnListarUsuario.TabIndex = 64;
            this.btnListarUsuario.Text = "Pesquisar Produto";
            this.btnListarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(625, 514);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 63;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(794, 247);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 62;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(920, 247);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 61;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(517, 247);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 60;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // dtUsuario
            // 
            this.dtUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUsuario.Location = new System.Drawing.Point(30, 302);
            this.dtUsuario.Name = "dtUsuario";
            this.dtUsuario.Size = new System.Drawing.Size(1062, 182);
            this.dtUsuario.TabIndex = 59;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(748, 490);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 20);
            this.textBox1.TabIndex = 65;
            // 
            // Cadastrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 580);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnListarUsuario);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtUsuario);
            this.Controls.Add(this.lblcadastroprod);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.ptbfoto);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkData);
            this.Controls.Add(this.data_validade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastrop";
            this.Text = "Cadastrop";
            ((System.ComponentModel.ISupportInitialize)(this.ptbfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.PictureBox ptbfoto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkData;
        private System.Windows.Forms.DateTimePicker data_validade;
        private System.Windows.Forms.Label lblcadastroprod;
        private System.Windows.Forms.Button btnListarUsuario;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dtUsuario;
        private System.Windows.Forms.TextBox textBox1;
    }
}
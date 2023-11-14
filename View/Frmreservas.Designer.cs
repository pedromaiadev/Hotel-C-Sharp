namespace testando
{
    partial class Frmreservas
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
            this.dtreservas = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnreservar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.lblquartor = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dTsaida = new System.Windows.Forms.DateTimePicker();
            this.dTentrada = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbostatus = new System.Windows.Forms.ComboBox();
            this.btnalterar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.cbonhospedesr = new System.Windows.Forms.ComboBox();
            this.cboquartor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtreservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtreservas
            // 
            this.dtreservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtreservas.Location = new System.Drawing.Point(10, 275);
            this.dtreservas.Name = "dtreservas";
            this.dtreservas.Size = new System.Drawing.Size(1125, 251);
            this.dtreservas.TabIndex = 0;
            this.dtreservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtreservas_CellClick);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(368, 537);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 1;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnreservar
            // 
            this.btnreservar.Location = new System.Drawing.Point(844, 537);
            this.btnreservar.Name = "btnreservar";
            this.btnreservar.Size = new System.Drawing.Size(75, 23);
            this.btnreservar.TabIndex = 2;
            this.btnreservar.Text = "Reservar";
            this.btnreservar.UseVisualStyleBackColor = true;
            this.btnreservar.Click += new System.EventHandler(this.btnreservar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(133, 539);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(223, 20);
            this.txtbuscar.TabIndex = 3;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(33, 542);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(89, 13);
            this.lblcpf.TabIndex = 4;
            this.lblcpf.Text = "Buscar Reserva :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CPF do hospede:";
            // 
            // txtcpf
            // 
            this.txtcpf.Enabled = false;
            this.txtcpf.Location = new System.Drawing.Point(169, 76);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(148, 20);
            this.txtcpf.TabIndex = 5;
            this.txtcpf.Leave += new System.EventHandler(this.txtcpf_Leave);
            // 
            // lblquartor
            // 
            this.lblquartor.AutoSize = true;
            this.lblquartor.Location = new System.Drawing.Point(33, 124);
            this.lblquartor.Name = "lblquartor";
            this.lblquartor.Size = new System.Drawing.Size(91, 13);
            this.lblquartor.TabIndex = 8;
            this.lblquartor.Text = "Reservar Quarto :";
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(727, 163);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.ReadOnly = true;
            this.txtpreco.Size = new System.Drawing.Size(55, 20);
            this.txtpreco.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Preço :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data/Hora entrada :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data/Hora saida :";
            // 
            // dTsaida
            // 
            this.dTsaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTsaida.Location = new System.Drawing.Point(727, 122);
            this.dTsaida.Name = "dTsaida";
            this.dTsaida.Size = new System.Drawing.Size(229, 20);
            this.dTsaida.TabIndex = 13;
            this.dTsaida.ValueChanged += new System.EventHandler(this.dTsaida_ValueChanged);
            // 
            // dTentrada
            // 
            this.dTentrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTentrada.Location = new System.Drawing.Point(727, 80);
            this.dTentrada.Name = "dTentrada";
            this.dTentrada.Size = new System.Drawing.Size(229, 20);
            this.dTentrada.TabIndex = 14;
            this.dTentrada.ValueChanged += new System.EventHandler(this.dTentrada_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Status :";
            // 
            // cbostatus
            // 
            this.cbostatus.FormattingEnabled = true;
            this.cbostatus.Location = new System.Drawing.Point(727, 206);
            this.cbostatus.Name = "cbostatus";
            this.cbostatus.Size = new System.Drawing.Size(121, 21);
            this.cbostatus.TabIndex = 16;
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(950, 536);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 23);
            this.btnalterar.TabIndex = 17;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Número de Hóspedes :";
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Location = new System.Drawing.Point(1056, 536);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarReserva.TabIndex = 21;
            this.btnCancelarReserva.Text = "Cancelar";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // cbonhospedesr
            // 
            this.cbonhospedesr.FormattingEnabled = true;
            this.cbonhospedesr.Location = new System.Drawing.Point(169, 163);
            this.cbonhospedesr.Name = "cbonhospedesr";
            this.cbonhospedesr.Size = new System.Drawing.Size(55, 21);
            this.cbonhospedesr.TabIndex = 23;
            this.cbonhospedesr.SelectedIndexChanged += new System.EventHandler(this.cbonhospedesr_SelectedIndexChanged);
            // 
            // cboquartor
            // 
            this.cboquartor.FormattingEnabled = true;
            this.cboquartor.Location = new System.Drawing.Point(169, 117);
            this.cboquartor.Name = "cboquartor";
            this.cboquartor.Size = new System.Drawing.Size(148, 21);
            this.cboquartor.TabIndex = 24;
            this.cboquartor.SelectedIndexChanged += new System.EventHandler(this.cboquartor_SelectedIndexChanged);
            // 
            // Frmreservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 657);
            this.Controls.Add(this.cboquartor);
            this.Controls.Add(this.cbonhospedesr);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.cbostatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dTentrada);
            this.Controls.Add(this.dTsaida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblquartor);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btnreservar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dtreservas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmreservas";
            this.Text = "Frmreservas";
            this.Load += new System.EventHandler(this.Frmreservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtreservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtreservas;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnreservar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Label lblquartor;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTsaida;
        private System.Windows.Forms.DateTimePicker dTentrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbostatus;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.ComboBox cbonhospedesr;
        private System.Windows.Forms.ComboBox cboquartor;
    }
}
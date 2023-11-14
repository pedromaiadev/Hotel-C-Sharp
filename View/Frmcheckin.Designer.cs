namespace testando
{
    partial class Check_in
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
            this.lblcpfhin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblreservain = new System.Windows.Forms.Label();
            this.lblvalorin = new System.Windows.Forms.Label();
            this.lblpagamento = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcpfhin = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtvalorpgin = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dTReservasin = new System.Windows.Forms.DataGridView();
            this.btnfinin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dTReservasin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcpfhin
            // 
            this.lblcpfhin.AutoSize = true;
            this.lblcpfhin.Location = new System.Drawing.Point(214, 121);
            this.lblcpfhin.Name = "lblcpfhin";
            this.lblcpfhin.Size = new System.Drawing.Size(73, 13);
            this.lblcpfhin.TabIndex = 0;
            this.lblcpfhin.Text = "CPF Hóspede";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // lblreservain
            // 
            this.lblreservain.AutoSize = true;
            this.lblreservain.Location = new System.Drawing.Point(214, 188);
            this.lblreservain.Name = "lblreservain";
            this.lblreservain.Size = new System.Drawing.Size(47, 13);
            this.lblreservain.TabIndex = 2;
            this.lblreservain.Text = "Reserva";
            // 
            // lblvalorin
            // 
            this.lblvalorin.AutoSize = true;
            this.lblvalorin.Location = new System.Drawing.Point(230, 417);
            this.lblvalorin.Name = "lblvalorin";
            this.lblvalorin.Size = new System.Drawing.Size(84, 13);
            this.lblvalorin.TabIndex = 3;
            this.lblvalorin.Text = "Valor a ser pago";
            // 
            // lblpagamento
            // 
            this.lblpagamento.AutoSize = true;
            this.lblpagamento.Location = new System.Drawing.Point(230, 449);
            this.lblpagamento.Name = "lblpagamento";
            this.lblpagamento.Size = new System.Drawing.Size(101, 13);
            this.lblpagamento.TabIndex = 4;
            this.lblpagamento.Text = "Meio de pagamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // txtcpfhin
            // 
            this.txtcpfhin.Location = new System.Drawing.Point(217, 137);
            this.txtcpfhin.Name = "txtcpfhin";
            this.txtcpfhin.Size = new System.Drawing.Size(100, 20);
            this.txtcpfhin.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(584, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // txtvalorpgin
            // 
            this.txtvalorpgin.Location = new System.Drawing.Point(325, 414);
            this.txtvalorpgin.Name = "txtvalorpgin";
            this.txtvalorpgin.Size = new System.Drawing.Size(100, 20);
            this.txtvalorpgin.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(233, 474);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // dTReservasin
            // 
            this.dTReservasin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dTReservasin.Location = new System.Drawing.Point(165, 204);
            this.dTReservasin.Name = "dTReservasin";
            this.dTReservasin.Size = new System.Drawing.Size(776, 150);
            this.dTReservasin.TabIndex = 10;
            // 
            // btnfinin
            // 
            this.btnfinin.Location = new System.Drawing.Point(770, 468);
            this.btnfinin.Name = "btnfinin";
            this.btnfinin.Size = new System.Drawing.Size(103, 23);
            this.btnfinin.TabIndex = 11;
            this.btnfinin.Text = "Finalizar Check-in";
            this.btnfinin.UseVisualStyleBackColor = true;
            this.btnfinin.Click += new System.EventHandler(this.btnfinin_Click);
            // 
            // Check_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 657);
            this.Controls.Add(this.btnfinin);
            this.Controls.Add(this.dTReservasin);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtvalorpgin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtcpfhin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblpagamento);
            this.Controls.Add(this.lblvalorin);
            this.Controls.Add(this.lblreservain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcpfhin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Check_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check_in";
            this.Load += new System.EventHandler(this.Check_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dTReservasin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcpfhin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblreservain;
        private System.Windows.Forms.Label lblvalorin;
        private System.Windows.Forms.Label lblpagamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcpfhin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtvalorpgin;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dTReservasin;
        private System.Windows.Forms.Button btnfinin;
    }
}
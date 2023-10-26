namespace testando
{
    partial class Frmcadastros
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
            this.btncusu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btncquarto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncusu
            // 
            this.btncusu.Location = new System.Drawing.Point(142, 31);
            this.btncusu.Name = "btncusu";
            this.btncusu.Size = new System.Drawing.Size(104, 23);
            this.btncusu.TabIndex = 48;
            this.btncusu.Text = "Cadastrar Usuario";
            this.btncusu.UseVisualStyleBackColor = true;
            this.btncusu.Click += new System.EventHandler(this.btncusu_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 580);
            this.panel1.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Cadastrar Produto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncquarto
            // 
            this.btncquarto.Location = new System.Drawing.Point(491, 31);
            this.btncquarto.Name = "btncquarto";
            this.btncquarto.Size = new System.Drawing.Size(104, 23);
            this.btncquarto.TabIndex = 51;
            this.btncquarto.Text = "Cadastrar Quarto";
            this.btncquarto.UseVisualStyleBackColor = true;
            this.btncquarto.Click += new System.EventHandler(this.btncquarto_Click);
            // 
            // Frmcadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 657);
            this.ControlBox = false;
            this.Controls.Add(this.btncquarto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncusu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmcadastros";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.usuario_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btncusu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btncquarto;
    }
}


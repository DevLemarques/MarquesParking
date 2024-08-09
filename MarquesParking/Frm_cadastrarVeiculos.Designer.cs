namespace MarquesParking
{
    partial class Frm_cadastrarVeiculos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.lb_cor = new System.Windows.Forms.Label();
            this.lb_placa = new System.Windows.Forms.Label();
            this.lb_modelo = new System.Windows.Forms.Label();
            this.txt_cor = new System.Windows.Forms.TextBox();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_voltar);
            this.groupBox1.Controls.Add(this.btn_cadastrar);
            this.groupBox1.Controls.Add(this.lb_cor);
            this.groupBox1.Controls.Add(this.lb_placa);
            this.groupBox1.Controls.Add(this.lb_modelo);
            this.groupBox1.Controls.Add(this.txt_cor);
            this.groupBox1.Controls.Add(this.txt_placa);
            this.groupBox1.Controls.Add(this.txt_modelo);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Veiculo";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(226, 164);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(70, 26);
            this.btn_voltar.TabIndex = 7;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(302, 164);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(70, 26);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // lb_cor
            // 
            this.lb_cor.AutoSize = true;
            this.lb_cor.Location = new System.Drawing.Point(13, 79);
            this.lb_cor.Name = "lb_cor";
            this.lb_cor.Size = new System.Drawing.Size(26, 13);
            this.lb_cor.TabIndex = 5;
            this.lb_cor.Text = "Cor:";
            // 
            // lb_placa
            // 
            this.lb_placa.AutoSize = true;
            this.lb_placa.Location = new System.Drawing.Point(193, 24);
            this.lb_placa.Name = "lb_placa";
            this.lb_placa.Size = new System.Drawing.Size(37, 13);
            this.lb_placa.TabIndex = 4;
            this.lb_placa.Text = "Placa:";
            // 
            // lb_modelo
            // 
            this.lb_modelo.AutoSize = true;
            this.lb_modelo.Location = new System.Drawing.Point(13, 24);
            this.lb_modelo.Name = "lb_modelo";
            this.lb_modelo.Size = new System.Drawing.Size(45, 13);
            this.lb_modelo.TabIndex = 3;
            this.lb_modelo.Text = "Modelo:";
            // 
            // txt_cor
            // 
            this.txt_cor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cor.Location = new System.Drawing.Point(16, 95);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.Size = new System.Drawing.Size(129, 23);
            this.txt_cor.TabIndex = 2;
            // 
            // txt_placa
            // 
            this.txt_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_placa.Location = new System.Drawing.Point(196, 40);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(129, 23);
            this.txt_placa.TabIndex = 1;
            // 
            // txt_modelo
            // 
            this.txt_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_modelo.Location = new System.Drawing.Point(16, 40);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(129, 23);
            this.txt_modelo.TabIndex = 0;
            // 
            // Frm_cadastrarVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 241);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_cadastrarVeiculos";
            this.Text = "Frm_cadastrarVeiculos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_modelo;
        private System.Windows.Forms.TextBox txt_cor;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label lb_cor;
        private System.Windows.Forms.Label lb_placa;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_cadastrar;
    }
}
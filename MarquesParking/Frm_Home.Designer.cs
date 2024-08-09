namespace MarquesParking
{
    partial class Frm_Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_Title = new System.Windows.Forms.Label();
            this.btn_cadastrarVeiculo = new System.Windows.Forms.Button();
            this.btn_removerVeiculo = new System.Windows.Forms.Button();
            this.btn_listarVeiculo = new System.Windows.Forms.Button();
            this.icon_logout = new System.Windows.Forms.PictureBox();
            this.lb_dataDinamic = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.icon_logout)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(108, 37);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(250, 33);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Marquez Parking";
            // 
            // btn_cadastrarVeiculo
            // 
            this.btn_cadastrarVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrarVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrarVeiculo.Location = new System.Drawing.Point(23, 100);
            this.btn_cadastrarVeiculo.Name = "btn_cadastrarVeiculo";
            this.btn_cadastrarVeiculo.Size = new System.Drawing.Size(128, 58);
            this.btn_cadastrarVeiculo.TabIndex = 1;
            this.btn_cadastrarVeiculo.Text = "Cadastrar Veiculo";
            this.btn_cadastrarVeiculo.UseVisualStyleBackColor = true;
            this.btn_cadastrarVeiculo.Click += new System.EventHandler(this.btn_cadastrarVeiculo_Click);
            // 
            // btn_removerVeiculo
            // 
            this.btn_removerVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_removerVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removerVeiculo.Location = new System.Drawing.Point(176, 100);
            this.btn_removerVeiculo.Name = "btn_removerVeiculo";
            this.btn_removerVeiculo.Size = new System.Drawing.Size(128, 58);
            this.btn_removerVeiculo.TabIndex = 2;
            this.btn_removerVeiculo.Text = "Remover Veiculo";
            this.btn_removerVeiculo.UseVisualStyleBackColor = true;
            this.btn_removerVeiculo.Click += new System.EventHandler(this.btn_removerVeiculo_Click);
            // 
            // btn_listarVeiculo
            // 
            this.btn_listarVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listarVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listarVeiculo.Location = new System.Drawing.Point(326, 100);
            this.btn_listarVeiculo.Name = "btn_listarVeiculo";
            this.btn_listarVeiculo.Size = new System.Drawing.Size(128, 58);
            this.btn_listarVeiculo.TabIndex = 3;
            this.btn_listarVeiculo.Text = "Listar Veiculo";
            this.btn_listarVeiculo.UseVisualStyleBackColor = true;
            this.btn_listarVeiculo.Click += new System.EventHandler(this.btn_listarVeiculo_Click);
            // 
            // icon_logout
            // 
            this.icon_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_logout.Image = global::MarquesParking.Properties.Resources.logout;
            this.icon_logout.Location = new System.Drawing.Point(431, 257);
            this.icon_logout.Name = "icon_logout";
            this.icon_logout.Size = new System.Drawing.Size(39, 35);
            this.icon_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_logout.TabIndex = 4;
            this.icon_logout.TabStop = false;
            this.toolTip1.SetToolTip(this.icon_logout, "Encerrar Sessão");
            this.icon_logout.Click += new System.EventHandler(this.icon_logout_Click);
            // 
            // lb_dataDinamic
            // 
            this.lb_dataDinamic.AutoSize = true;
            this.lb_dataDinamic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dataDinamic.Location = new System.Drawing.Point(20, 276);
            this.lb_dataDinamic.Name = "lb_dataDinamic";
            this.lb_dataDinamic.Size = new System.Drawing.Size(0, 16);
            this.lb_dataDinamic.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 304);
            this.Controls.Add(this.lb_dataDinamic);
            this.Controls.Add(this.icon_logout);
            this.Controls.Add(this.btn_listarVeiculo);
            this.Controls.Add(this.btn_removerVeiculo);
            this.Controls.Add(this.btn_cadastrarVeiculo);
            this.Controls.Add(this.lb_Title);
            this.Name = "Frm_Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon_logout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Button btn_cadastrarVeiculo;
        private System.Windows.Forms.Button btn_removerVeiculo;
        private System.Windows.Forms.Button btn_listarVeiculo;
        private System.Windows.Forms.PictureBox icon_logout;
        private System.Windows.Forms.Label lb_dataDinamic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


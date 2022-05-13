namespace atividadeCor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtnum3 = new System.Windows.Forms.TextBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnselecionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.BackColor = System.Drawing.Color.Transparent;
            this.num1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(80, 81);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(102, 20);
            this.num1.TabIndex = 0;
            this.num1.Text = "Numero 1:";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.BackColor = System.Drawing.Color.Transparent;
            this.num2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(80, 118);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(102, 20);
            this.num2.TabIndex = 1;
            this.num2.Text = "Numero 2:";
            // 
            // num3
            // 
            this.num3.AutoSize = true;
            this.num3.BackColor = System.Drawing.Color.Transparent;
            this.num3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(79, 155);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(103, 20);
            this.num3.TabIndex = 2;
            this.num3.Text = "Numero 3:";
            // 
            // txtnum1
            // 
            this.txtnum1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtnum1.Location = new System.Drawing.Point(182, 81);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(179, 20);
            this.txtnum1.TabIndex = 3;
            // 
            // txtnum2
            // 
            this.txtnum2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtnum2.Location = new System.Drawing.Point(182, 118);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(179, 20);
            this.txtnum2.TabIndex = 4;
            // 
            // txtnum3
            // 
            this.txtnum3.Location = new System.Drawing.Point(182, 155);
            this.txtnum3.Name = "txtnum3";
            this.txtnum3.Size = new System.Drawing.Size(179, 20);
            this.txtnum3.TabIndex = 5;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltitulo.Location = new System.Drawing.Point(78, 40);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(283, 30);
            this.lbltitulo.TabIndex = 6;
            this.lbltitulo.Text = "Selecione 3 numeros";
            // 
            // btnselecionar
            // 
            this.btnselecionar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnselecionar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnselecionar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselecionar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnselecionar.Location = new System.Drawing.Point(83, 196);
            this.btnselecionar.Name = "btnselecionar";
            this.btnselecionar.Size = new System.Drawing.Size(278, 35);
            this.btnselecionar.TabIndex = 7;
            this.btnselecionar.Text = "Selecionar";
            this.btnselecionar.UseVisualStyleBackColor = false;
            this.btnselecionar.Click += new System.EventHandler(this.btnselecionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(435, 273);
            this.Controls.Add(this.btnselecionar);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.txtnum3);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Atividade das Cores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label num3;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtnum3;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnselecionar;
    }
}


namespace formulario.aula2._0
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_Mostrar1 = new System.Windows.Forms.Button();
            this.button_Mostrar2 = new System.Windows.Forms.Button();
            this.button_ApagarTudo = new System.Windows.Forms.Button();
            this.button_Apagar1 = new System.Windows.Forms.Button();
            this.button_Apagar2 = new System.Windows.Forms.Button();
            this.button_MostrarTudo = new System.Windows.Forms.Button();
            this.button_Stretch = new System.Windows.Forms.Button();
            this.button_Zoom1 = new System.Windows.Forms.Button();
            this.button_Stretch2 = new System.Windows.Forms.Button();
            this.button_zoom2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(438, -16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 332);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button_Mostrar1
            // 
            this.button_Mostrar1.Location = new System.Drawing.Point(32, 309);
            this.button_Mostrar1.Name = "button_Mostrar1";
            this.button_Mostrar1.Size = new System.Drawing.Size(111, 48);
            this.button_Mostrar1.TabIndex = 1;
            this.button_Mostrar1.Text = "Mostrar imagem 1";
            this.button_Mostrar1.UseVisualStyleBackColor = true;
            this.button_Mostrar1.Click += new System.EventHandler(this.button_Mostrar1_Click);
            // 
            // button_Mostrar2
            // 
            this.button_Mostrar2.Location = new System.Drawing.Point(639, 326);
            this.button_Mostrar2.Name = "button_Mostrar2";
            this.button_Mostrar2.Size = new System.Drawing.Size(121, 45);
            this.button_Mostrar2.TabIndex = 3;
            this.button_Mostrar2.Text = "Mostrar imagem 2";
            this.button_Mostrar2.UseVisualStyleBackColor = true;
            this.button_Mostrar2.Click += new System.EventHandler(this.button_Mostrar2_Click);
            // 
            // button_ApagarTudo
            // 
            this.button_ApagarTudo.Location = new System.Drawing.Point(327, 389);
            this.button_ApagarTudo.Name = "button_ApagarTudo";
            this.button_ApagarTudo.Size = new System.Drawing.Size(154, 49);
            this.button_ApagarTudo.TabIndex = 5;
            this.button_ApagarTudo.Text = "Apagar as duas imagens";
            this.button_ApagarTudo.UseVisualStyleBackColor = true;
            this.button_ApagarTudo.Click += new System.EventHandler(this.button_ApagarTudo_Click);
            // 
            // button_Apagar1
            // 
            this.button_Apagar1.Location = new System.Drawing.Point(149, 309);
            this.button_Apagar1.Name = "button_Apagar1";
            this.button_Apagar1.Size = new System.Drawing.Size(111, 45);
            this.button_Apagar1.TabIndex = 2;
            this.button_Apagar1.Text = "Apagar imagem 1";
            this.button_Apagar1.UseVisualStyleBackColor = true;
            this.button_Apagar1.Click += new System.EventHandler(this.button_Apagar1_Click);
            // 
            // button_Apagar2
            // 
            this.button_Apagar2.Location = new System.Drawing.Point(522, 326);
            this.button_Apagar2.Name = "button_Apagar2";
            this.button_Apagar2.Size = new System.Drawing.Size(111, 45);
            this.button_Apagar2.TabIndex = 4;
            this.button_Apagar2.Text = "Apagar imagem 2";
            this.button_Apagar2.UseVisualStyleBackColor = true;
            this.button_Apagar2.Click += new System.EventHandler(this.button_Apagar2_Click);
            // 
            // button_MostrarTudo
            // 
            this.button_MostrarTudo.Location = new System.Drawing.Point(327, 322);
            this.button_MostrarTudo.Name = "button_MostrarTudo";
            this.button_MostrarTudo.Size = new System.Drawing.Size(154, 49);
            this.button_MostrarTudo.TabIndex = 6;
            this.button_MostrarTudo.Text = "Mostrar as duas imagens";
            this.button_MostrarTudo.UseVisualStyleBackColor = true;
            this.button_MostrarTudo.Click += new System.EventHandler(this.button_MostrarTudo_Click);
            // 
            // button_Stretch
            // 
            this.button_Stretch.Location = new System.Drawing.Point(32, 363);
            this.button_Stretch.Name = "button_Stretch";
            this.button_Stretch.Size = new System.Drawing.Size(131, 23);
            this.button_Stretch.TabIndex = 7;
            this.button_Stretch.Text = "StretchImage Imagem 1";
            this.button_Stretch.UseVisualStyleBackColor = true;
            this.button_Stretch.Click += new System.EventHandler(this.button_Stretch_Click);
            // 
            // button_Zoom1
            // 
            this.button_Zoom1.Location = new System.Drawing.Point(32, 392);
            this.button_Zoom1.Name = "button_Zoom1";
            this.button_Zoom1.Size = new System.Drawing.Size(111, 23);
            this.button_Zoom1.TabIndex = 8;
            this.button_Zoom1.Text = "Zoom Image 1";
            this.button_Zoom1.UseVisualStyleBackColor = true;
            this.button_Zoom1.Click += new System.EventHandler(this.button_Zoom1_Click);
            // 
            // button_Stretch2
            // 
            this.button_Stretch2.Location = new System.Drawing.Point(629, 377);
            this.button_Stretch2.Name = "button_Stretch2";
            this.button_Stretch2.Size = new System.Drawing.Size(131, 23);
            this.button_Stretch2.TabIndex = 9;
            this.button_Stretch2.Text = "StretchImage Imagem 2";
            this.button_Stretch2.UseVisualStyleBackColor = true;
            // 
            // button_zoom2
            // 
            this.button_zoom2.Location = new System.Drawing.Point(649, 406);
            this.button_zoom2.Name = "button_zoom2";
            this.button_zoom2.Size = new System.Drawing.Size(111, 23);
            this.button_zoom2.TabIndex = 10;
            this.button_zoom2.Text = "Zoom Image 2";
            this.button_zoom2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_zoom2);
            this.Controls.Add(this.button_Stretch2);
            this.Controls.Add(this.button_Zoom1);
            this.Controls.Add(this.button_Stretch);
            this.Controls.Add(this.button_MostrarTudo);
            this.Controls.Add(this.button_Apagar2);
            this.Controls.Add(this.button_Apagar1);
            this.Controls.Add(this.button_ApagarTudo);
            this.Controls.Add(this.button_Mostrar2);
            this.Controls.Add(this.button_Mostrar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Trabalhando com imagens";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_Mostrar1;
        private System.Windows.Forms.Button button_Mostrar2;
        private System.Windows.Forms.Button button_ApagarTudo;
        private System.Windows.Forms.Button button_Apagar1;
        private System.Windows.Forms.Button button_Apagar2;
        private System.Windows.Forms.Button button_MostrarTudo;
        private System.Windows.Forms.Button button_Stretch;
        private System.Windows.Forms.Button button_Zoom1;
        private System.Windows.Forms.Button button_Stretch2;
        private System.Windows.Forms.Button button_zoom2;
    }
}


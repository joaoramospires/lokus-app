namespace teste_redicionamento
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btt_maisOpcoes = new System.Windows.Forms.Button();
            this.txt_Procurar = new MetroFramework.Controls.MetroTextBox();
            this.btt_Paragens = new teste_redicionamento.BotaoRj();
            this.btt_AutoCarros = new teste_redicionamento.BotaoRj();
            this.btt_Favotito = new teste_redicionamento.BotaoRj();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 565);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Btt_maisOpcoes
            // 
            this.Btt_maisOpcoes.BackColor = System.Drawing.Color.Transparent;
            this.Btt_maisOpcoes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btt_maisOpcoes.BackgroundImage")));
            this.Btt_maisOpcoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btt_maisOpcoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btt_maisOpcoes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btt_maisOpcoes.FlatAppearance.BorderSize = 0;
            this.Btt_maisOpcoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btt_maisOpcoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btt_maisOpcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btt_maisOpcoes.ForeColor = System.Drawing.Color.Transparent;
            this.Btt_maisOpcoes.Location = new System.Drawing.Point(162, 415);
            this.Btt_maisOpcoes.Name = "Btt_maisOpcoes";
            this.Btt_maisOpcoes.Size = new System.Drawing.Size(45, 45);
            this.Btt_maisOpcoes.TabIndex = 4;
            this.Btt_maisOpcoes.UseVisualStyleBackColor = false;
            this.Btt_maisOpcoes.Click += new System.EventHandler(this.Btt_maisOpcoes_Click);
            this.Btt_maisOpcoes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btt_maisOpcoes_MouseDown);
            this.Btt_maisOpcoes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btt_maisOpcoes_MouseUp);
            // 
            // txt_Procurar
            // 
            // 
            // 
            // 
            this.txt_Procurar.CustomButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Procurar.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage")));
            this.txt_Procurar.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txt_Procurar.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txt_Procurar.CustomButton.Name = "";
            this.txt_Procurar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Procurar.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txt_Procurar.CustomButton.TabIndex = 1;
            this.txt_Procurar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Procurar.CustomButton.UseSelectable = true;
            this.txt_Procurar.CustomButton.UseVisualStyleBackColor = false;
            this.txt_Procurar.CustomButton.Visible = false;
            this.txt_Procurar.DisplayIcon = true;
            this.txt_Procurar.Icon = ((System.Drawing.Image)(resources.GetObject("txt_Procurar.Icon")));
            this.txt_Procurar.Lines = new string[0];
            this.txt_Procurar.Location = new System.Drawing.Point(94, 290);
            this.txt_Procurar.MaxLength = 32767;
            this.txt_Procurar.Name = "txt_Procurar";
            this.txt_Procurar.PasswordChar = '\0';
            this.txt_Procurar.PromptText = "Search";
            this.txt_Procurar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Procurar.SelectedText = "";
            this.txt_Procurar.SelectionLength = 0;
            this.txt_Procurar.SelectionStart = 0;
            this.txt_Procurar.ShortcutsEnabled = true;
            this.txt_Procurar.Size = new System.Drawing.Size(190, 23);
            this.txt_Procurar.TabIndex = 10;
            this.txt_Procurar.UseSelectable = true;
            this.txt_Procurar.WaterMark = "Search";
            this.txt_Procurar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Procurar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btt_Paragens
            // 
            this.btt_Paragens.BackColor = System.Drawing.Color.White;
            this.btt_Paragens.BackgroundColor = System.Drawing.Color.White;
            this.btt_Paragens.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.btt_Paragens.BorderRadius = 20;
            this.btt_Paragens.BorderSize = 2;
            this.btt_Paragens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_Paragens.FlatAppearance.BorderSize = 0;
            this.btt_Paragens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_Paragens.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Paragens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.btt_Paragens.Location = new System.Drawing.Point(148, 358);
            this.btt_Paragens.Name = "btt_Paragens";
            this.btt_Paragens.Size = new System.Drawing.Size(73, 42);
            this.btt_Paragens.TabIndex = 9;
            this.btt_Paragens.Text = "Paragens";
            this.btt_Paragens.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.btt_Paragens.UseVisualStyleBackColor = false;
            this.btt_Paragens.Visible = false;
            this.btt_Paragens.Click += new System.EventHandler(this.btt_Paragens_Click);
            this.btt_Paragens.MouseEnter += new System.EventHandler(this.btt_Paragens_MouseEnter);
            this.btt_Paragens.MouseLeave += new System.EventHandler(this.btt_Paragens_MouseLeave);
            // 
            // btt_AutoCarros
            // 
            this.btt_AutoCarros.BackColor = System.Drawing.Color.White;
            this.btt_AutoCarros.BackgroundColor = System.Drawing.Color.White;
            this.btt_AutoCarros.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.btt_AutoCarros.BorderRadius = 20;
            this.btt_AutoCarros.BorderSize = 2;
            this.btt_AutoCarros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_AutoCarros.FlatAppearance.BorderSize = 0;
            this.btt_AutoCarros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.btt_AutoCarros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_AutoCarros.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_AutoCarros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.btt_AutoCarros.Location = new System.Drawing.Point(75, 417);
            this.btt_AutoCarros.Name = "btt_AutoCarros";
            this.btt_AutoCarros.Size = new System.Drawing.Size(73, 41);
            this.btt_AutoCarros.TabIndex = 8;
            this.btt_AutoCarros.Text = "Auto Carros";
            this.btt_AutoCarros.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.btt_AutoCarros.UseVisualStyleBackColor = false;
            this.btt_AutoCarros.Visible = false;
            this.btt_AutoCarros.Click += new System.EventHandler(this.btt_AutoCarros_Click);
            this.btt_AutoCarros.MouseEnter += new System.EventHandler(this.btt_AutoCarros_MouseEnter);
            this.btt_AutoCarros.MouseLeave += new System.EventHandler(this.btt_AutoCarros_MouseLeave);
            // 
            // btt_Favotito
            // 
            this.btt_Favotito.BackColor = System.Drawing.Color.White;
            this.btt_Favotito.BackgroundColor = System.Drawing.Color.White;
            this.btt_Favotito.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.btt_Favotito.BorderRadius = 20;
            this.btt_Favotito.BorderSize = 2;
            this.btt_Favotito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_Favotito.FlatAppearance.BorderSize = 0;
            this.btt_Favotito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_Favotito.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Favotito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.btt_Favotito.Location = new System.Drawing.Point(223, 417);
            this.btt_Favotito.Name = "btt_Favotito";
            this.btt_Favotito.Size = new System.Drawing.Size(73, 41);
            this.btt_Favotito.TabIndex = 7;
            this.btt_Favotito.Text = "Favoritos";
            this.btt_Favotito.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.btt_Favotito.UseVisualStyleBackColor = false;
            this.btt_Favotito.Visible = false;
            this.btt_Favotito.Click += new System.EventHandler(this.btt_Favotito_Click);
            this.btt_Favotito.MouseEnter += new System.EventHandler(this.btt_Favotito_MouseEnter);
            this.btt_Favotito.MouseLeave += new System.EventHandler(this.btt_Favotito_MouseLeave);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(390, 565);
            this.Controls.Add(this.txt_Procurar);
            this.Controls.Add(this.btt_Paragens);
            this.Controls.Add(this.btt_AutoCarros);
            this.Controls.Add(this.btt_Favotito);
            this.Controls.Add(this.Btt_maisOpcoes);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btt_maisOpcoes;
        private BotaoRj btt_Favotito;
        private BotaoRj btt_AutoCarros;
        private BotaoRj btt_Paragens;
        private MetroFramework.Controls.MetroTextBox txt_Procurar;
        // private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}
namespace teste_redicionamento
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Procurar = new MetroFramework.Controls.MetroTextBox();
            this.btt_MenuInicial = new System.Windows.Forms.Button();
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
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.txt_Procurar.Location = new System.Drawing.Point(90, 100);
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
            this.txt_Procurar.TabIndex = 15;
            this.txt_Procurar.UseSelectable = true;
            this.txt_Procurar.WaterMark = "Search";
            this.txt_Procurar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Procurar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btt_MenuInicial
            // 
            this.btt_MenuInicial.BackColor = System.Drawing.Color.Transparent;
            this.btt_MenuInicial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_MenuInicial.BackgroundImage")));
            this.btt_MenuInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btt_MenuInicial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_MenuInicial.FlatAppearance.BorderSize = 0;
            this.btt_MenuInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_MenuInicial.ForeColor = System.Drawing.Color.Transparent;
            this.btt_MenuInicial.Location = new System.Drawing.Point(168, 45);
            this.btt_MenuInicial.Name = "btt_MenuInicial";
            this.btt_MenuInicial.Size = new System.Drawing.Size(35, 35);
            this.btt_MenuInicial.TabIndex = 16;
            this.btt_MenuInicial.UseVisualStyleBackColor = false;
            this.btt_MenuInicial.Click += new System.EventHandler(this.btt_MenuInicial_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(390, 565);
            this.Controls.Add(this.btt_MenuInicial);
            this.Controls.Add(this.txt_Procurar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txt_Procurar;
        private System.Windows.Forms.Button btt_MenuInicial;
    }
}
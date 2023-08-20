namespace teste_redicionamento
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Procurar = new MetroFramework.Controls.MetroTextBox();
            this.btt_MenuInicial = new System.Windows.Forms.Button();
            this.btt_back = new System.Windows.Forms.Button();
            this.btt_Next = new System.Windows.Forms.Button();
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
            this.txt_Procurar.TabIndex = 11;
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
            this.btt_MenuInicial.TabIndex = 12;
            this.btt_MenuInicial.UseVisualStyleBackColor = false;
            this.btt_MenuInicial.Click += new System.EventHandler(this.btt_MenuInicial_Click);
            // 
            // btt_back
            // 
            this.btt_back.BackColor = System.Drawing.Color.White;
            this.btt_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_back.BackgroundImage")));
            this.btt_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btt_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_back.FlatAppearance.BorderSize = 0;
            this.btt_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_back.ForeColor = System.Drawing.Color.White;
            this.btt_back.Location = new System.Drawing.Point(91, 45);
            this.btt_back.Name = "btt_back";
            this.btt_back.Size = new System.Drawing.Size(35, 35);
            this.btt_back.TabIndex = 13;
            this.btt_back.UseVisualStyleBackColor = false;
            this.btt_back.Click += new System.EventHandler(this.btt_back_Click);
            // 
            // btt_Next
            // 
            this.btt_Next.BackColor = System.Drawing.Color.White;
            this.btt_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_Next.BackgroundImage")));
            this.btt_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btt_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_Next.FlatAppearance.BorderSize = 0;
            this.btt_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_Next.ForeColor = System.Drawing.Color.White;
            this.btt_Next.Location = new System.Drawing.Point(246, 45);
            this.btt_Next.Name = "btt_Next";
            this.btt_Next.Size = new System.Drawing.Size(35, 35);
            this.btt_Next.TabIndex = 14;
            this.btt_Next.UseVisualStyleBackColor = false;
            this.btt_Next.Click += new System.EventHandler(this.btt_Next_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 565);
            this.Controls.Add(this.btt_Next);
            this.Controls.Add(this.btt_back);
            this.Controls.Add(this.btt_MenuInicial);
            this.Controls.Add(this.txt_Procurar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txt_Procurar;
        private System.Windows.Forms.Button btt_MenuInicial;
        private System.Windows.Forms.Button btt_back;
        private System.Windows.Forms.Button btt_Next;
    }
}
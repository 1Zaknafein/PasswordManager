namespace PasswordManager
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.btnViewPasswords = new System.Windows.Forms.Button();
            this.btnAddPassword = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.childPanel = new System.Windows.Forms.Panel();
            this.btnKey = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_enterKey = new System.Windows.Forms.Label();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.LeftPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.LeftPanel.Controls.Add(this.pictureBox1);
            this.LeftPanel.Controls.Add(this.btnGeneratePassword);
            this.LeftPanel.Controls.Add(this.btnViewPasswords);
            this.LeftPanel.Controls.Add(this.btnAddPassword);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 397);
            this.LeftPanel.TabIndex = 0;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.btnGeneratePassword.FlatAppearance.BorderSize = 0;
            this.btnGeneratePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGeneratePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneratePassword.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(250)))));
            this.btnGeneratePassword.Location = new System.Drawing.Point(0, 310);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(200, 70);
            this.btnGeneratePassword.TabIndex = 2;
            this.btnGeneratePassword.Text = "Generate password";
            this.btnGeneratePassword.UseVisualStyleBackColor = false;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnCreatePassword_Click);
            // 
            // btnViewPasswords
            // 
            this.btnViewPasswords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.btnViewPasswords.FlatAppearance.BorderSize = 0;
            this.btnViewPasswords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnViewPasswords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPasswords.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPasswords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(250)))));
            this.btnViewPasswords.Location = new System.Drawing.Point(0, 160);
            this.btnViewPasswords.Name = "btnViewPasswords";
            this.btnViewPasswords.Size = new System.Drawing.Size(200, 70);
            this.btnViewPasswords.TabIndex = 1;
            this.btnViewPasswords.Text = "View passwords";
            this.btnViewPasswords.UseMnemonic = false;
            this.btnViewPasswords.UseVisualStyleBackColor = false;
            this.btnViewPasswords.Click += new System.EventHandler(this.btnViewPasswords_Click);
            // 
            // btnAddPassword
            // 
            this.btnAddPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.btnAddPassword.FlatAppearance.BorderSize = 0;
            this.btnAddPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPassword.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(250)))));
            this.btnAddPassword.Location = new System.Drawing.Point(0, 235);
            this.btnAddPassword.Name = "btnAddPassword";
            this.btnAddPassword.Size = new System.Drawing.Size(200, 70);
            this.btnAddPassword.TabIndex = 0;
            this.btnAddPassword.Text = "Add password";
            this.btnAddPassword.UseVisualStyleBackColor = false;
            this.btnAddPassword.Click += new System.EventHandler(this.btnAddPassword_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(529, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(51, 48);
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.TopPanel.Controls.Add(this.textBox_key);
            this.TopPanel.Controls.Add(this.btnKey);
            this.TopPanel.Controls.Add(this.label_enterKey);
            this.TopPanel.Controls.Add(this.btnExit);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(200, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(580, 48);
            this.TopPanel.TabIndex = 2;
            // 
            // childPanel
            // 
            this.childPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childPanel.Location = new System.Drawing.Point(200, 48);
            this.childPanel.Name = "childPanel";
            this.childPanel.Size = new System.Drawing.Size(580, 349);
            this.childPanel.TabIndex = 3;
            // 
            // btnKey
            // 
            this.btnKey.BackColor = System.Drawing.Color.Transparent;
            this.btnKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKey.BackgroundImage")));
            this.btnKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKey.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnKey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.btnKey.FlatAppearance.BorderSize = 0;
            this.btnKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKey.Location = new System.Drawing.Point(6, 4);
            this.btnKey.Name = "btnKey";
            this.btnKey.Size = new System.Drawing.Size(40, 40);
            this.btnKey.TabIndex = 2;
            this.btnKey.UseVisualStyleBackColor = false;
            this.btnKey.Click += new System.EventHandler(this.btnKey_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::PasswordManager.Properties.Resources.lock_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label_enterKey
            // 
            this.label_enterKey.AutoSize = true;
            this.label_enterKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_enterKey.ForeColor = System.Drawing.Color.White;
            this.label_enterKey.Location = new System.Drawing.Point(60, 10);
            this.label_enterKey.Name = "label_enterKey";
            this.label_enterKey.Size = new System.Drawing.Size(223, 24);
            this.label_enterKey.TabIndex = 0;
            this.label_enterKey.Text = "Enter master password";
            this.label_enterKey.Visible = false;
            // 
            // textBox_key
            // 
            this.textBox_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_key.ForeColor = System.Drawing.Color.Black;
            this.textBox_key.Location = new System.Drawing.Point(299, 10);
            this.textBox_key.MaxLength = 100;
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(215, 29);
            this.textBox_key.TabIndex = 1;
            this.textBox_key.UseSystemPasswordChar = true;
            this.textBox_key.Visible = false;
            this.textBox_key.TextChanged += new System.EventHandler(this.textBox_key_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(780, 397);
            this.Controls.Add(this.childPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Manager";
            this.LeftPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.Button btnViewPasswords;
        private System.Windows.Forms.Button btnAddPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel childPanel;
        private System.Windows.Forms.Button btnKey;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.Label label_enterKey;
    }
}


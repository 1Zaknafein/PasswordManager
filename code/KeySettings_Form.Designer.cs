namespace PasswordManager.code
{
    partial class KeySettings_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeySettings_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBox_edit = new System.Windows.Forms.TextBox();
            this.btnEditOK = new System.Windows.Forms.Button();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.label_tick = new System.Windows.Forms.Label();
            this.btn_visibility = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your master key";
            // 
            // textBox_key
            // 
            this.textBox_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_key.Location = new System.Drawing.Point(100, 87);
            this.textBox_key.MaxLength = 100;
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_key.Size = new System.Drawing.Size(189, 29);
            this.textBox_key.TabIndex = 1;
            this.textBox_key.UseSystemPasswordChar = true;
            this.textBox_key.TextChanged += new System.EventHandler(this.textBox_key_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(100, 165);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(148, 33);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit key";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(100, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 34);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete key";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(100, 126);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 33);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBox_edit
            // 
            this.textBox_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_edit.Location = new System.Drawing.Point(300, 165);
            this.textBox_edit.MaxLength = 100;
            this.textBox_edit.Name = "textBox_edit";
            this.textBox_edit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_edit.Size = new System.Drawing.Size(189, 29);
            this.textBox_edit.TabIndex = 5;
            this.textBox_edit.UseSystemPasswordChar = true;
            this.textBox_edit.Visible = false;
            this.textBox_edit.TextChanged += new System.EventHandler(this.textBox_edit_TextChanged);
            // 
            // btnEditOK
            // 
            this.btnEditOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.btnEditOK.Enabled = false;
            this.btnEditOK.FlatAppearance.BorderSize = 0;
            this.btnEditOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btnEditOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btnEditOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOK.ForeColor = System.Drawing.Color.White;
            this.btnEditOK.Location = new System.Drawing.Point(300, 200);
            this.btnEditOK.Name = "btnEditOK";
            this.btnEditOK.Size = new System.Drawing.Size(84, 33);
            this.btnEditOK.TabIndex = 6;
            this.btnEditOK.Text = "OK";
            this.btnEditOK.UseVisualStyleBackColor = false;
            this.btnEditOK.Visible = false;
            this.btnEditOK.Click += new System.EventHandler(this.btnEditOK_Click);
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.btnEditCancel.FlatAppearance.BorderSize = 0;
            this.btnEditCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btnEditCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(84)))));
            this.btnEditCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCancel.ForeColor = System.Drawing.Color.White;
            this.btnEditCancel.Location = new System.Drawing.Point(392, 200);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(97, 33);
            this.btnEditCancel.TabIndex = 7;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = false;
            this.btnEditCancel.Visible = false;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // label_tick
            // 
            this.label_tick.AutoSize = true;
            this.label_tick.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tick.Location = new System.Drawing.Point(297, 87);
            this.label_tick.Name = "label_tick";
            this.label_tick.Size = new System.Drawing.Size(28, 29);
            this.label_tick.TabIndex = 8;
            this.label_tick.Text = "✓";
            this.label_tick.Visible = false;
            // 
            // btn_visibility
            // 
            this.btn_visibility.BackColor = System.Drawing.Color.Transparent;
            this.btn_visibility.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_visibility.BackgroundImage")));
            this.btn_visibility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_visibility.FlatAppearance.BorderSize = 0;
            this.btn_visibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visibility.Location = new System.Drawing.Point(331, 87);
            this.btn_visibility.Name = "btn_visibility";
            this.btn_visibility.Size = new System.Drawing.Size(43, 31);
            this.btn_visibility.TabIndex = 9;
            this.btn_visibility.UseVisualStyleBackColor = false;
            this.btn_visibility.Visible = false;
            this.btn_visibility.Click += new System.EventHandler(this.btn_visibility_Click);
            // 
            // KeySettings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(707, 406);
            this.Controls.Add(this.btn_visibility);
            this.Controls.Add(this.label_tick);
            this.Controls.Add(this.btnEditCancel);
            this.Controls.Add(this.btnEditOK);
            this.Controls.Add(this.textBox_edit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KeySettings_Form";
            this.Text = "KeySettings_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBox_edit;
        private System.Windows.Forms.Button btnEditOK;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Label label_tick;
        private System.Windows.Forms.Button btn_visibility;
    }
}
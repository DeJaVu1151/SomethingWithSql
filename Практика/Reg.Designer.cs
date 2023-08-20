namespace Практика
{
    partial class Reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg));
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox_hide = new System.Windows.Forms.PictureBox();
            this.pictureBox_show = new System.Windows.Forms.PictureBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_show)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(126, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Регистрация";
            // 
            // pictureBox_hide
            // 
            this.pictureBox_hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_hide.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_hide.Image")));
            this.pictureBox_hide.Location = new System.Drawing.Point(260, 141);
            this.pictureBox_hide.Name = "pictureBox_hide";
            this.pictureBox_hide.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_hide.TabIndex = 20;
            this.pictureBox_hide.TabStop = false;
            this.pictureBox_hide.Click += new System.EventHandler(this.pictureBox_hide_Click);
            // 
            // pictureBox_show
            // 
            this.pictureBox_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_show.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_show.Image")));
            this.pictureBox_show.Location = new System.Drawing.Point(260, 141);
            this.pictureBox_show.Name = "pictureBox_show";
            this.pictureBox_show.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_show.TabIndex = 19;
            this.pictureBox_show.TabStop = false;
            this.pictureBox_show.Click += new System.EventHandler(this.pictureBox_show_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(104, 141);
            this.textBox_password.MaximumSize = new System.Drawing.Size(150, 30);
            this.textBox_password.MinimumSize = new System.Drawing.Size(150, 25);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(150, 20);
            this.textBox_password.TabIndex = 18;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Location = new System.Drawing.Point(50, 191);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(250, 30);
            this.BtnRegister.TabIndex = 17;
            this.BtnRegister.Text = "Зарегестрироваться";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.enter_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.Location = new System.Drawing.Point(303, 96);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(0);
            this.btn_clear.MinimumSize = new System.Drawing.Size(50, 50);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(50, 50);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(104, 79);
            this.textBox_Login.MaximumSize = new System.Drawing.Size(150, 30);
            this.textBox_Login.MinimumSize = new System.Drawing.Size(150, 25);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(150, 20);
            this.textBox_Login.TabIndex = 15;
            this.textBox_Login.TextChanged += new System.EventHandler(this.textBox_Login_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Логин";
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 248);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox_hide);
            this.Controls.Add(this.pictureBox_show);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Reg";
            this.Text = "Reg";
            this.Load += new System.EventHandler(this.Reg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox_hide;
        private System.Windows.Forms.PictureBox pictureBox_show;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
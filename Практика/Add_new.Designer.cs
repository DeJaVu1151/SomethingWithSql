namespace Практика
{
    partial class Add_new
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_new));
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_fN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_sN = new System.Windows.Forms.TextBox();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.textBox_tN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_per = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_clear
            // 
            this.button_clear.Image = ((System.Drawing.Image)(resources.GetObject("button_clear.Image")));
            this.button_clear.Location = new System.Drawing.Point(354, 74);
            this.button_clear.Margin = new System.Windows.Forms.Padding(0);
            this.button_clear.MinimumSize = new System.Drawing.Size(45, 45);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(45, 45);
            this.button_clear.TabIndex = 0;
            this.button_clear.UseVisualStyleBackColor = true;
            // 
            // textBox_fN
            // 
            this.textBox_fN.Location = new System.Drawing.Point(208, 54);
            this.textBox_fN.Name = "textBox_fN";
            this.textBox_fN.Size = new System.Drawing.Size(131, 20);
            this.textBox_fN.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Количество ситуаций";
            // 
            // textBox_sN
            // 
            this.textBox_sN.Location = new System.Drawing.Point(208, 80);
            this.textBox_sN.Name = "textBox_sN";
            this.textBox_sN.Size = new System.Drawing.Size(131, 20);
            this.textBox_sN.TabIndex = 17;
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(208, 158);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(131, 20);
            this.textBox_count.TabIndex = 24;
            // 
            // textBox_tN
            // 
            this.textBox_tN.Location = new System.Drawing.Point(208, 106);
            this.textBox_tN.Name = "textBox_tN";
            this.textBox_tN.Size = new System.Drawing.Size(131, 20);
            this.textBox_tN.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Доверительный коэффициент";
            // 
            // textBox_per
            // 
            this.textBox_per.Location = new System.Drawing.Point(208, 132);
            this.textBox_per.Name = "textBox_per";
            this.textBox_per.Size = new System.Drawing.Size(131, 20);
            this.textBox_per.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Отчество клиента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Фамилия клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Имя клиента";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(149, 207);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(98, 31);
            this.button_Add.TabIndex = 26;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Add_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 260);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_fN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_sN);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.textBox_tN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_per);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_clear);
            this.Name = "Add_new";
            this.Text = "Add_new";
            this.Load += new System.EventHandler(this.Add_new_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_fN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_sN;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.TextBox textBox_tN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_per;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Add;
    }
}
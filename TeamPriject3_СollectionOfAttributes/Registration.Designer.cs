namespace TeamPriject3_СollectionOfAttributes
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.invented_email = new System.Windows.Forms.TextBox();
            this.invented_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Registr = new System.Windows.Forms.Button();
            this.invented_login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(122)))), ((int)(((byte)(121)))));
            this.label1.Location = new System.Drawing.Point(116, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(122)))), ((int)(((byte)(121)))));
            this.label2.Location = new System.Drawing.Point(26, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // invented_email
            // 
            this.invented_email.Location = new System.Drawing.Point(30, 159);
            this.invented_email.Multiline = true;
            this.invented_email.Name = "invented_email";
            this.invented_email.Size = new System.Drawing.Size(462, 47);
            this.invented_email.TabIndex = 2;
            // 
            // invented_password
            // 
            this.invented_password.Location = new System.Drawing.Point(30, 382);
            this.invented_password.Multiline = true;
            this.invented_password.Name = "invented_password";
            this.invented_password.Size = new System.Drawing.Size(462, 47);
            this.invented_password.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(122)))), ((int)(((byte)(121)))));
            this.label3.Location = new System.Drawing.Point(26, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            // 
            // button_Registr
            // 
            this.button_Registr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(98)))));
            this.button_Registr.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Registr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Registr.Location = new System.Drawing.Point(66, 453);
            this.button_Registr.Name = "button_Registr";
            this.button_Registr.Size = new System.Drawing.Size(371, 70);
            this.button_Registr.TabIndex = 5;
            this.button_Registr.Text = "Зарегистрироваться";
            this.button_Registr.UseVisualStyleBackColor = false;
            this.button_Registr.Click += new System.EventHandler(this.button_Registr_Click);
            // 
            // invented_login
            // 
            this.invented_login.Location = new System.Drawing.Point(30, 263);
            this.invented_login.Multiline = true;
            this.invented_login.Name = "invented_login";
            this.invented_login.Size = new System.Drawing.Size(462, 47);
            this.invented_login.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(122)))), ((int)(((byte)(121)))));
            this.label4.Location = new System.Drawing.Point(26, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Логин";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(510, 547);
            this.Controls.Add(this.invented_login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Registr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.invented_password);
            this.Controls.Add(this.invented_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox invented_email;
        private System.Windows.Forms.TextBox invented_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Registr;
        private System.Windows.Forms.TextBox invented_login;
        private System.Windows.Forms.Label label4;
    }
}
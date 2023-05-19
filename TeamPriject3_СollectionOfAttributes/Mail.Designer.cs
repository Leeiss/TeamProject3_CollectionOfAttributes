namespace TeamPriject3_СollectionOfAttributes
{
    partial class Mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mail));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.TextBox();
            this.Entry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(122)))), ((int)(((byte)(121)))));
            this.label1.Location = new System.Drawing.Point(60, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 102);
            this.label1.TabIndex = 1;
            this.label1.Text = "Подтвердите адрес\r\nэлектронной почты\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(122)))), ((int)(((byte)(121)))));
            this.label2.Location = new System.Drawing.Point(154, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите код, который мы,\r\n         вам отправили";
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(114, 281);
            this.Code.Multiline = true;
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(344, 47);
            this.Code.TabIndex = 3;
            this.Code.TextChanged += new System.EventHandler(this.Code_TextChanged);
            // 
            // Entry
            // 
            this.Entry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(98)))));
            this.Entry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Entry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Entry.Location = new System.Drawing.Point(388, 455);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(176, 52);
            this.Entry.TabIndex = 6;
            this.Entry.Text = "Войти";
            this.Entry.UseVisualStyleBackColor = false;
            this.Entry.Click += new System.EventHandler(this.Entry_Click);
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(576, 519);
            this.Controls.Add(this.Entry);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mail";
            this.Text = "Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Button Entry;
    }
}
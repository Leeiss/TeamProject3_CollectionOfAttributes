namespace TeamPriject3_СollectionOfAttributes
{
    partial class Add_new_Furnitures
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
            this.CreateNewAlbum_lable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CreateNewAlbum_lable
            // 
            this.CreateNewAlbum_lable.AutoSize = true;
            this.CreateNewAlbum_lable.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateNewAlbum_lable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CreateNewAlbum_lable.Location = new System.Drawing.Point(129, 9);
            this.CreateNewAlbum_lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreateNewAlbum_lable.Name = "CreateNewAlbum_lable";
            this.CreateNewAlbum_lable.Size = new System.Drawing.Size(534, 51);
            this.CreateNewAlbum_lable.TabIndex = 64;
            this.CreateNewAlbum_lable.Text = "Добавление предметов";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(98)))));
            this.panel1.Location = new System.Drawing.Point(8, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 10);
            this.panel1.TabIndex = 63;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(260, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 28);
            this.comboBox1.TabIndex = 65;
            // 
            // Add_new_Furnitures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 687);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CreateNewAlbum_lable);
            this.Controls.Add(this.panel1);
            this.Name = "Add_new_Furnitures";
            this.Text = "Add_new_Furnitures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateNewAlbum_lable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
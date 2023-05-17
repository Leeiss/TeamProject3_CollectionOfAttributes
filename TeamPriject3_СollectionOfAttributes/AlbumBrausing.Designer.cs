namespace TeamPriject3_СollectionOfAttributes
{
    partial class AlbumBrausing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumBrausing));
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.category_label = new System.Windows.Forms.Label();
            this.AddItems_label = new System.Windows.Forms.Label();
            this.DeleteItems_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(1, 0);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(195, 136);
            this.pictureBox_logo.TabIndex = 10;
            this.pictureBox_logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1188, 10);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // category_label
            // 
            this.category_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.category_label.Location = new System.Drawing.Point(12, 139);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(121, 50);
            this.category_label.TabIndex = 12;
            this.category_label.Text = "Кухня";
            // 
            // AddItems_label
            // 
            this.AddItems_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddItems_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddItems_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddItems_label.Location = new System.Drawing.Point(15, 205);
            this.AddItems_label.Name = "AddItems_label";
            this.AddItems_label.Size = new System.Drawing.Size(263, 39);
            this.AddItems_label.TabIndex = 13;
            this.AddItems_label.Text = "+ Добавить предметы";
            // 
            // DeleteItems_label
            // 
            this.DeleteItems_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeleteItems_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteItems_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DeleteItems_label.Location = new System.Drawing.Point(299, 205);
            this.DeleteItems_label.Name = "DeleteItems_label";
            this.DeleteItems_label.Size = new System.Drawing.Size(263, 39);
            this.DeleteItems_label.TabIndex = 14;
            this.DeleteItems_label.Text = "- Удалить предметы";
            // 
            // AlbumBrowsing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1178, 665);
            this.Controls.Add(this.DeleteItems_label);
            this.Controls.Add(this.AddItems_label);
            this.Controls.Add(this.category_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_logo);
            this.Name = "AlbumBrowsing";
            this.Text = "AlbumBrowsing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Label AddItems_label;
        private System.Windows.Forms.Label DeleteItems_label;
    }
}
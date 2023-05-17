namespace TeamPriject3_СollectionOfAttributes
{
    partial class Albums
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Albums));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.allalbums_label = new System.Windows.Forms.Label();
            this.Entered_Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AlbumsTable = new System.Windows.Forms.DataGridView();
            this.namealbums = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Альбомы ваших идей";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 10);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // allalbums_label
            // 
            this.allalbums_label.AutoSize = true;
            this.allalbums_label.Location = new System.Drawing.Point(14, 87);
            this.allalbums_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.allalbums_label.Name = "allalbums_label";
            this.allalbums_label.Size = new System.Drawing.Size(239, 32);
            this.allalbums_label.TabIndex = 13;
            this.allalbums_label.Text = "Всего альбомов : 4";
            // 
            // Entered_Text
            // 
            this.Entered_Text.Location = new System.Drawing.Point(20, 163);
            this.Entered_Text.Name = "Entered_Text";
            this.Entered_Text.Size = new System.Drawing.Size(378, 39);
            this.Entered_Text.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Искать в альбомах";
            // 
            // AlbumsTable
            // 
            this.AlbumsTable.BackgroundColor = System.Drawing.Color.White;
            this.AlbumsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlbumsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namealbums});
            this.AlbumsTable.Location = new System.Drawing.Point(20, 230);
            this.AlbumsTable.Name = "AlbumsTable";
            this.AlbumsTable.RowHeadersWidth = 62;
            this.AlbumsTable.RowTemplate.Height = 28;
            this.AlbumsTable.Size = new System.Drawing.Size(427, 389);
            this.AlbumsTable.TabIndex = 17;
            this.AlbumsTable.Visible = false;
            this.AlbumsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AlbumsTable_CellClick);
            // 
            // namealbums
            // 
            this.namealbums.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namealbums.HeaderText = "Альбомы";
            this.namealbums.MinimumWidth = 8;
            this.namealbums.Name = "namealbums";
            this.namealbums.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(404, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 29);
            this.label3.TabIndex = 18;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Albums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 631);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AlbumsTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Entered_Text);
            this.Controls.Add(this.allalbums_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Albums";
            this.Text = "AlbumsBrowsing";
            this.Load += new System.EventHandler(this.Albums_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label allalbums_label;
        private System.Windows.Forms.TextBox Entered_Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView AlbumsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn namealbums;
        private System.Windows.Forms.Label label3;
    }
}
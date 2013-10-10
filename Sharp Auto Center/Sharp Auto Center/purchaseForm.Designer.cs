namespace Sharp_Auto_Center
{
    partial class purchaseForm
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
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.subTotalBox = new System.Windows.Forms.TextBox();
            this.taxBox = new System.Windows.Forms.TextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(60, 87);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(57, 16);
            this.subTotalLabel.TabIndex = 0;
            this.subTotalLabel.Text = "Subtotal";
            // 
            // subTotalBox
            // 
            this.subTotalBox.Enabled = false;
            this.subTotalBox.Location = new System.Drawing.Point(158, 87);
            this.subTotalBox.Name = "subTotalBox";
            this.subTotalBox.Size = new System.Drawing.Size(100, 20);
            this.subTotalBox.TabIndex = 1;
            // 
            // taxBox
            // 
            this.taxBox.Enabled = false;
            this.taxBox.Location = new System.Drawing.Point(158, 114);
            this.taxBox.Name = "taxBox";
            this.taxBox.Size = new System.Drawing.Size(100, 20);
            this.taxBox.TabIndex = 2;
            // 
            // totalBox
            // 
            this.totalBox.Enabled = false;
            this.totalBox.Location = new System.Drawing.Point(158, 141);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(100, 20);
            this.totalBox.TabIndex = 3;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(60, 118);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(36, 16);
            this.taxLabel.TabIndex = 4;
            this.taxLabel.Text = "HST";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(60, 145);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(39, 16);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "Total";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sharp_Auto_Center.Properties.Resources.tesla_sLogo;
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tesla Model S";
            // 
            // purchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 183);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.taxBox);
            this.Controls.Add(this.subTotalBox);
            this.Controls.Add(this.subTotalLabel);
            this.Name = "purchaseForm";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.purchaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.TextBox subTotalBox;
        private System.Windows.Forms.TextBox taxBox;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
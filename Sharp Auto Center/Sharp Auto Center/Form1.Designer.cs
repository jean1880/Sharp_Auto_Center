namespace Sharp_Auto_Center
{
    partial class teslaSForm
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
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.designTab = new System.Windows.Forms.TabPage();
            this.roofGroup = new System.Windows.Forms.GroupBox();
            this.glassRoofButton = new System.Windows.Forms.RadioButton();
            this.solidRoofButton = new System.Windows.Forms.RadioButton();
            this.colourGroup = new System.Windows.Forms.GroupBox();
            this.metallicPaintButton = new System.Windows.Forms.RadioButton();
            this.solidPaintButton = new System.Windows.Forms.RadioButton();
            this.colourOptionBox = new System.Windows.Forms.ListBox();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.wheelGroup = new System.Windows.Forms.GroupBox();
            this.Standard19Button = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.interiorOptionBox = new System.Windows.Forms.GroupBox();
            this.fabricButton = new System.Windows.Forms.RadioButton();
            this.leatherSeatButton = new System.Windows.Forms.RadioButton();
            this.extraOptionsBox = new System.Windows.Forms.GroupBox();
            this.tabMenu.SuspendLayout();
            this.designTab.SuspendLayout();
            this.roofGroup.SuspendLayout();
            this.colourGroup.SuspendLayout();
            this.wheelGroup.SuspendLayout();
            this.interiorOptionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.designTab);
            this.tabMenu.Controls.Add(this.settingsTab);
            this.tabMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMenu.HotTrack = true;
            this.tabMenu.ItemSize = new System.Drawing.Size(58, 30);
            this.tabMenu.Location = new System.Drawing.Point(-3, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(320, 738);
            this.tabMenu.TabIndex = 0;
            // 
            // designTab
            // 
            this.designTab.AutoScroll = true;
            this.designTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.designTab.Controls.Add(this.extraOptionsBox);
            this.designTab.Controls.Add(this.interiorOptionBox);
            this.designTab.Controls.Add(this.wheelGroup);
            this.designTab.Controls.Add(this.roofGroup);
            this.designTab.Controls.Add(this.colourGroup);
            this.designTab.Controls.Add(this.colourOptionBox);
            this.designTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designTab.Location = new System.Drawing.Point(4, 34);
            this.designTab.Name = "designTab";
            this.designTab.Padding = new System.Windows.Forms.Padding(3);
            this.designTab.Size = new System.Drawing.Size(312, 700);
            this.designTab.TabIndex = 0;
            this.designTab.Text = "Design";
            // 
            // roofGroup
            // 
            this.roofGroup.Controls.Add(this.glassRoofButton);
            this.roofGroup.Controls.Add(this.solidRoofButton);
            this.roofGroup.Location = new System.Drawing.Point(11, 96);
            this.roofGroup.Name = "roofGroup";
            this.roofGroup.Size = new System.Drawing.Size(271, 92);
            this.roofGroup.TabIndex = 7;
            this.roofGroup.TabStop = false;
            this.roofGroup.Text = "Roof Options";
            // 
            // glassRoofButton
            // 
            this.glassRoofButton.AutoSize = true;
            this.glassRoofButton.Location = new System.Drawing.Point(7, 56);
            this.glassRoofButton.Name = "glassRoofButton";
            this.glassRoofButton.Size = new System.Drawing.Size(186, 24);
            this.glassRoofButton.TabIndex = 1;
            this.glassRoofButton.TabStop = true;
            this.glassRoofButton.Text = "Panaramic Glass Roof";
            this.glassRoofButton.UseVisualStyleBackColor = true;
            this.glassRoofButton.CheckedChanged += new System.EventHandler(this.roofButtons_CheckedChanged);
            // 
            // solidRoofButton
            // 
            this.solidRoofButton.AutoSize = true;
            this.solidRoofButton.Location = new System.Drawing.Point(7, 26);
            this.solidRoofButton.Name = "solidRoofButton";
            this.solidRoofButton.Size = new System.Drawing.Size(101, 24);
            this.solidRoofButton.TabIndex = 0;
            this.solidRoofButton.TabStop = true;
            this.solidRoofButton.Text = "Solid Roof";
            this.solidRoofButton.UseVisualStyleBackColor = true;
            this.solidRoofButton.CheckedChanged += new System.EventHandler(this.roofButtons_CheckedChanged);
            // 
            // colourGroup
            // 
            this.colourGroup.Controls.Add(this.metallicPaintButton);
            this.colourGroup.Controls.Add(this.solidPaintButton);
            this.colourGroup.Location = new System.Drawing.Point(11, 6);
            this.colourGroup.Name = "colourGroup";
            this.colourGroup.Size = new System.Drawing.Size(144, 84);
            this.colourGroup.TabIndex = 4;
            this.colourGroup.TabStop = false;
            this.colourGroup.Text = "Colour Set";
            // 
            // metallicPaintButton
            // 
            this.metallicPaintButton.AutoSize = true;
            this.metallicPaintButton.Location = new System.Drawing.Point(7, 54);
            this.metallicPaintButton.Name = "metallicPaintButton";
            this.metallicPaintButton.Size = new System.Drawing.Size(80, 24);
            this.metallicPaintButton.TabIndex = 1;
            this.metallicPaintButton.TabStop = true;
            this.metallicPaintButton.Text = "Metallic";
            this.metallicPaintButton.UseVisualStyleBackColor = true;
            this.metallicPaintButton.CheckedChanged += new System.EventHandler(this.PaintButtons_CheckedChanged);
            // 
            // solidPaintButton
            // 
            this.solidPaintButton.AutoSize = true;
            this.solidPaintButton.Location = new System.Drawing.Point(7, 24);
            this.solidPaintButton.Name = "solidPaintButton";
            this.solidPaintButton.Size = new System.Drawing.Size(100, 24);
            this.solidPaintButton.TabIndex = 0;
            this.solidPaintButton.TabStop = true;
            this.solidPaintButton.Text = "Solid Coat";
            this.solidPaintButton.UseVisualStyleBackColor = true;
            this.solidPaintButton.CheckedChanged += new System.EventHandler(this.PaintButtons_CheckedChanged);
            // 
            // colourOptionBox
            // 
            this.colourOptionBox.FormattingEnabled = true;
            this.colourOptionBox.ItemHeight = 20;
            this.colourOptionBox.Location = new System.Drawing.Point(162, 6);
            this.colourOptionBox.Name = "colourOptionBox";
            this.colourOptionBox.Size = new System.Drawing.Size(120, 84);
            this.colourOptionBox.TabIndex = 3;
            this.colourOptionBox.Visible = false;
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settingsTab.Location = new System.Drawing.Point(4, 34);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(303, 340);
            this.settingsTab.TabIndex = 1;
            this.settingsTab.Text = "Settings";
            // 
            // wheelGroup
            // 
            this.wheelGroup.Controls.Add(this.radioButton3);
            this.wheelGroup.Controls.Add(this.radioButton2);
            this.wheelGroup.Controls.Add(this.Standard19Button);
            this.wheelGroup.Location = new System.Drawing.Point(12, 194);
            this.wheelGroup.Name = "wheelGroup";
            this.wheelGroup.Size = new System.Drawing.Size(270, 100);
            this.wheelGroup.TabIndex = 8;
            this.wheelGroup.TabStop = false;
            this.wheelGroup.Text = "Wheel Options";
            // 
            // Standard19Button
            // 
            this.Standard19Button.AutoSize = true;
            this.Standard19Button.Location = new System.Drawing.Point(6, 25);
            this.Standard19Button.Name = "Standard19Button";
            this.Standard19Button.Size = new System.Drawing.Size(185, 24);
            this.Standard19Button.TabIndex = 0;
            this.Standard19Button.TabStop = true;
            this.Standard19Button.Text = "Stock 19\" Wheel Rims";
            this.Standard19Button.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(151, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "19\" Cyclone Rims";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 70);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(151, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "21\" Cyclone Rims";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // interiorOptionBox
            // 
            this.interiorOptionBox.Controls.Add(this.leatherSeatButton);
            this.interiorOptionBox.Controls.Add(this.fabricButton);
            this.interiorOptionBox.Location = new System.Drawing.Point(12, 300);
            this.interiorOptionBox.Name = "interiorOptionBox";
            this.interiorOptionBox.Size = new System.Drawing.Size(271, 89);
            this.interiorOptionBox.TabIndex = 9;
            this.interiorOptionBox.TabStop = false;
            this.interiorOptionBox.Text = "Interior Options";
            // 
            // fabricButton
            // 
            this.fabricButton.AutoSize = true;
            this.fabricButton.Location = new System.Drawing.Point(7, 26);
            this.fabricButton.Name = "fabricButton";
            this.fabricButton.Size = new System.Drawing.Size(117, 24);
            this.fabricButton.TabIndex = 0;
            this.fabricButton.TabStop = true;
            this.fabricButton.Text = "Fabric Seats";
            this.fabricButton.UseVisualStyleBackColor = true;
            // 
            // leatherSeatButton
            // 
            this.leatherSeatButton.AutoSize = true;
            this.leatherSeatButton.Location = new System.Drawing.Point(6, 56);
            this.leatherSeatButton.Name = "leatherSeatButton";
            this.leatherSeatButton.Size = new System.Drawing.Size(128, 24);
            this.leatherSeatButton.TabIndex = 1;
            this.leatherSeatButton.TabStop = true;
            this.leatherSeatButton.Text = "Leather Seats";
            this.leatherSeatButton.UseVisualStyleBackColor = true;
            // 
            // extraOptionsBox
            // 
            this.extraOptionsBox.Location = new System.Drawing.Point(12, 395);
            this.extraOptionsBox.Name = "extraOptionsBox";
            this.extraOptionsBox.Size = new System.Drawing.Size(271, 149);
            this.extraOptionsBox.TabIndex = 10;
            this.extraOptionsBox.TabStop = false;
            this.extraOptionsBox.Text = "Extras";
            // 
            // teslaSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(311, 733);
            this.Controls.Add(this.tabMenu);
            this.Name = "teslaSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.teslaSForm_Load);
            this.tabMenu.ResumeLayout(false);
            this.designTab.ResumeLayout(false);
            this.roofGroup.ResumeLayout(false);
            this.roofGroup.PerformLayout();
            this.colourGroup.ResumeLayout(false);
            this.colourGroup.PerformLayout();
            this.wheelGroup.ResumeLayout(false);
            this.wheelGroup.PerformLayout();
            this.interiorOptionBox.ResumeLayout(false);
            this.interiorOptionBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage designTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.GroupBox colourGroup;
        private System.Windows.Forms.RadioButton metallicPaintButton;
        private System.Windows.Forms.RadioButton solidPaintButton;
        private System.Windows.Forms.ListBox colourOptionBox;
        private System.Windows.Forms.GroupBox roofGroup;
        private System.Windows.Forms.RadioButton solidRoofButton;
        private System.Windows.Forms.RadioButton glassRoofButton;
        private System.Windows.Forms.GroupBox wheelGroup;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton Standard19Button;
        private System.Windows.Forms.GroupBox interiorOptionBox;
        private System.Windows.Forms.RadioButton leatherSeatButton;
        private System.Windows.Forms.RadioButton fabricButton;
        private System.Windows.Forms.GroupBox extraOptionsBox;
    }
}


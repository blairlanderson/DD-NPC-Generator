namespace NameGeneratorUI
{
    partial class NameGen_Splash
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
            this.lblHeader01 = new System.Windows.Forms.Label();
            this.lblHeader02 = new System.Windows.Forms.Label();
            this.cboRace = new System.Windows.Forms.ComboBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.grpFirstLastSelector = new System.Windows.Forms.GroupBox();
            this.radFirst = new System.Windows.Forms.RadioButton();
            this.radFirstLast = new System.Windows.Forms.RadioButton();
            this.radLast = new System.Windows.Forms.RadioButton();
            this.cboNumber = new System.Windows.Forms.ComboBox();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpFirstLastSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader01
            // 
            this.lblHeader01.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader01.AutoSize = true;
            this.lblHeader01.Font = new System.Drawing.Font("Trajan Pro", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader01.Location = new System.Drawing.Point(348, 16);
            this.lblHeader01.Name = "lblHeader01";
            this.lblHeader01.Size = new System.Drawing.Size(97, 41);
            this.lblHeader01.TabIndex = 0;
            this.lblHeader01.Text = "NPC";
            // 
            // lblHeader02
            // 
            this.lblHeader02.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader02.AutoSize = true;
            this.lblHeader02.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader02.Location = new System.Drawing.Point(312, 59);
            this.lblHeader02.Name = "lblHeader02";
            this.lblHeader02.Size = new System.Drawing.Size(171, 21);
            this.lblHeader02.TabIndex = 1;
            this.lblHeader02.Text = "Name Generator";
            // 
            // cboRace
            // 
            this.cboRace.FormattingEnabled = true;
            this.cboRace.Location = new System.Drawing.Point(183, 98);
            this.cboRace.Name = "cboRace";
            this.cboRace.Size = new System.Drawing.Size(200, 24);
            this.cboRace.TabIndex = 2;
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(183, 128);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(200, 24);
            this.cboGender.TabIndex = 3;
            // 
            // grpFirstLastSelector
            // 
            this.grpFirstLastSelector.Controls.Add(this.radLast);
            this.grpFirstLastSelector.Controls.Add(this.radFirstLast);
            this.grpFirstLastSelector.Controls.Add(this.radFirst);
            this.grpFirstLastSelector.Location = new System.Drawing.Point(183, 220);
            this.grpFirstLastSelector.Name = "grpFirstLastSelector";
            this.grpFirstLastSelector.Size = new System.Drawing.Size(200, 117);
            this.grpFirstLastSelector.TabIndex = 4;
            this.grpFirstLastSelector.TabStop = false;
            // 
            // radFirst
            // 
            this.radFirst.AutoSize = true;
            this.radFirst.Location = new System.Drawing.Point(6, 21);
            this.radFirst.Name = "radFirst";
            this.radFirst.Size = new System.Drawing.Size(130, 21);
            this.radFirst.TabIndex = 0;
            this.radFirst.TabStop = true;
            this.radFirst.Text = "First Name Only";
            this.radFirst.UseVisualStyleBackColor = true;
            // 
            // radFirstLast
            // 
            this.radFirstLast.AutoSize = true;
            this.radFirstLast.Location = new System.Drawing.Point(6, 48);
            this.radFirstLast.Name = "radFirstLast";
            this.radFirstLast.Size = new System.Drawing.Size(147, 21);
            this.radFirstLast.TabIndex = 1;
            this.radFirstLast.TabStop = true;
            this.radFirstLast.Text = "First + Last Names";
            this.radFirstLast.UseVisualStyleBackColor = true;
            // 
            // radLast
            // 
            this.radLast.AutoSize = true;
            this.radLast.Location = new System.Drawing.Point(6, 75);
            this.radLast.Name = "radLast";
            this.radLast.Size = new System.Drawing.Size(130, 21);
            this.radLast.TabIndex = 2;
            this.radLast.TabStop = true;
            this.radLast.Text = "Last Name Only";
            this.radLast.UseVisualStyleBackColor = true;
            // 
            // cboNumber
            // 
            this.cboNumber.FormattingEnabled = true;
            this.cboNumber.Location = new System.Drawing.Point(543, 98);
            this.cboNumber.Name = "cboNumber";
            this.cboNumber.Size = new System.Drawing.Size(121, 24);
            this.cboNumber.TabIndex = 5;
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(132, 101);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(45, 17);
            this.lblRace.TabIndex = 6;
            this.lblRace.Text = "Race:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(117, 131);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(411, 101);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(126, 17);
            this.lblNumber.TabIndex = 8;
            this.lblNumber.Text = "Number of Names:";
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 16;
            this.lstNames.Location = new System.Drawing.Point(414, 128);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(250, 372);
            this.lstNames.TabIndex = 9;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(120, 161);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(57, 17);
            this.lblRegion.TabIndex = 12;
            this.lblRegion.Text = "Region:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(183, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // NameGen_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 528);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.cboNumber);
            this.Controls.Add(this.grpFirstLastSelector);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.cboRace);
            this.Controls.Add(this.lblHeader02);
            this.Controls.Add(this.lblHeader01);
            this.Name = "NameGen_Splash";
            this.Text = "Name Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpFirstLastSelector.ResumeLayout(false);
            this.grpFirstLastSelector.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader01;
        private System.Windows.Forms.Label lblHeader02;
        private System.Windows.Forms.ComboBox cboRace;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.GroupBox grpFirstLastSelector;
        private System.Windows.Forms.RadioButton radLast;
        private System.Windows.Forms.RadioButton radFirstLast;
        private System.Windows.Forms.RadioButton radFirst;
        private System.Windows.Forms.ComboBox cboNumber;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}
namespace Text2Images
{
	partial class FormMain
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
			this.textBoxText = new System.Windows.Forms.TextBox();
			this.textBoxOutput = new System.Windows.Forms.TextBox();
			this.buttonFolderOutput = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxFonts = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownPaddingHorizontal = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.numericUpDownPaddingVertical = new System.Windows.Forms.NumericUpDown();
			this.buttonColorBack = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.buttonColorFore = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPaddingHorizontal)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPaddingVertical)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Text:";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 176);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Output:";
			// 
			// textBoxText
			// 
			this.textBoxText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxText.Location = new System.Drawing.Point(60, 6);
			this.textBoxText.Multiline = true;
			this.textBoxText.Name = "textBoxText";
			this.textBoxText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxText.Size = new System.Drawing.Size(536, 159);
			this.textBoxText.TabIndex = 2;
			this.textBoxText.Text = "Enter lines of text here; each is output to it\'s own file.";
			// 
			// textBoxOutput
			// 
			this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxOutput.Location = new System.Drawing.Point(60, 173);
			this.textBoxOutput.Name = "textBoxOutput";
			this.textBoxOutput.Size = new System.Drawing.Size(503, 20);
			this.textBoxOutput.TabIndex = 3;
			this.textBoxOutput.Text = "C:\\Temp\\Output";
			// 
			// buttonFolderOutput
			// 
			this.buttonFolderOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonFolderOutput.Location = new System.Drawing.Point(569, 171);
			this.buttonFolderOutput.Name = "buttonFolderOutput";
			this.buttonFolderOutput.Size = new System.Drawing.Size(27, 23);
			this.buttonFolderOutput.TabIndex = 4;
			this.buttonFolderOutput.Text = "...";
			this.buttonFolderOutput.UseVisualStyleBackColor = true;
			this.buttonFolderOutput.Click += new System.EventHandler(this.buttonFolderOutput_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(521, 245);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Convert";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Name:";
			// 
			// comboBoxFonts
			// 
			this.comboBoxFonts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxFonts.DropDownWidth = 200;
			this.comboBoxFonts.FormattingEnabled = true;
			this.comboBoxFonts.Location = new System.Drawing.Point(56, 14);
			this.comboBoxFonts.Name = "comboBoxFonts";
			this.comboBoxFonts.Size = new System.Drawing.Size(202, 21);
			this.comboBoxFonts.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Size:";
			// 
			// numericUpDownFontSize
			// 
			this.numericUpDownFontSize.Location = new System.Drawing.Point(56, 41);
			this.numericUpDownFontSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDownFontSize.Name = "numericUpDownFontSize";
			this.numericUpDownFontSize.Size = new System.Drawing.Size(47, 20);
			this.numericUpDownFontSize.TabIndex = 9;
			this.numericUpDownFontSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// numericUpDownPaddingHorizontal
			// 
			this.numericUpDownPaddingHorizontal.Location = new System.Drawing.Point(69, 14);
			this.numericUpDownPaddingHorizontal.Name = "numericUpDownPaddingHorizontal";
			this.numericUpDownPaddingHorizontal.Size = new System.Drawing.Size(47, 20);
			this.numericUpDownPaddingHorizontal.TabIndex = 11;
			this.numericUpDownPaddingHorizontal.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Horizontal:";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.comboBoxFonts);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.numericUpDownFontSize);
			this.groupBox1.Location = new System.Drawing.Point(15, 199);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(264, 69);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Font";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.numericUpDownPaddingVertical);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.numericUpDownPaddingHorizontal);
			this.groupBox2.Location = new System.Drawing.Point(285, 199);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(124, 69);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Padding";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 42);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Vertical:";
			// 
			// numericUpDownPaddingVertical
			// 
			this.numericUpDownPaddingVertical.Location = new System.Drawing.Point(69, 40);
			this.numericUpDownPaddingVertical.Name = "numericUpDownPaddingVertical";
			this.numericUpDownPaddingVertical.Size = new System.Drawing.Size(47, 20);
			this.numericUpDownPaddingVertical.TabIndex = 13;
			this.numericUpDownPaddingVertical.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// buttonColorBack
			// 
			this.buttonColorBack.BackColor = System.Drawing.Color.White;
			this.buttonColorBack.Location = new System.Drawing.Point(43, 39);
			this.buttonColorBack.Name = "buttonColorBack";
			this.buttonColorBack.Size = new System.Drawing.Size(23, 23);
			this.buttonColorBack.TabIndex = 14;
			this.buttonColorBack.UseVisualStyleBackColor = false;
			this.buttonColorBack.Click += new System.EventHandler(this.buttonColorBack_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.buttonColorFore);
			this.groupBox3.Controls.Add(this.buttonColorBack);
			this.groupBox3.Location = new System.Drawing.Point(415, 200);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(74, 68);
			this.groupBox3.TabIndex = 15;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Color";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 44);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "Back:";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Fore:";
			// 
			// buttonColorFore
			// 
			this.buttonColorFore.BackColor = System.Drawing.Color.Black;
			this.buttonColorFore.Location = new System.Drawing.Point(43, 10);
			this.buttonColorFore.Name = "buttonColorFore";
			this.buttonColorFore.Size = new System.Drawing.Size(23, 23);
			this.buttonColorFore.TabIndex = 15;
			this.buttonColorFore.UseVisualStyleBackColor = false;
			this.buttonColorFore.Click += new System.EventHandler(this.buttonColorFore_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(608, 280);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.buttonFolderOutput);
			this.Controls.Add(this.textBoxOutput);
			this.Controls.Add(this.textBoxText);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(460, 188);
			this.Name = "FormMain";
			this.Text = "Text 2 Images";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPaddingHorizontal)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPaddingVertical)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxText;
		private System.Windows.Forms.TextBox textBoxOutput;
		private System.Windows.Forms.Button buttonFolderOutput;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxFonts;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
		private System.Windows.Forms.NumericUpDown numericUpDownPaddingHorizontal;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numericUpDownPaddingVertical;
		private System.Windows.Forms.Button buttonColorBack;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button buttonColorFore;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}


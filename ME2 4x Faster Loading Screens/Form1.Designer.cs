namespace ME2_4x_Faster_Loading_Screens
{
    partial class Form1
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
            this.folderLocationText = new System.Windows.Forms.TextBox();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxLabel = new System.Windows.Forms.Label();
            this.fourTimesFasterRadioButton = new System.Windows.Forms.RadioButton();
            this.twoTimesFasterRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select your Mass Effect 2 install location:";
            // 
            // folderLocationText
            // 
            this.folderLocationText.Location = new System.Drawing.Point(16, 38);
            this.folderLocationText.Name = "folderLocationText";
            this.folderLocationText.ReadOnly = true;
            this.folderLocationText.Size = new System.Drawing.Size(359, 20);
            this.folderLocationText.TabIndex = 1;
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFolderButton.Location = new System.Drawing.Point(381, 27);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(113, 36);
            this.selectFolderButton.TabIndex = 2;
            this.selectFolderButton.Text = "Select Folder";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Enabled = false;
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(159, 87);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(216, 36);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(16, 172);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(471, 190);
            this.textBox1.TabIndex = 4;
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.AutoSize = true;
            this.textBoxLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLabel.Location = new System.Drawing.Point(16, 152);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(104, 17);
            this.textBoxLabel.TabIndex = 5;
            this.textBoxLabel.Text = "Files To Convert:";
            // 
            // fourTimesFasterRadioButton
            // 
            this.fourTimesFasterRadioButton.AutoSize = true;
            this.fourTimesFasterRadioButton.Checked = true;
            this.fourTimesFasterRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourTimesFasterRadioButton.Location = new System.Drawing.Point(3, 3);
            this.fourTimesFasterRadioButton.Name = "fourTimesFasterRadioButton";
            this.fourTimesFasterRadioButton.Size = new System.Drawing.Size(87, 25);
            this.fourTimesFasterRadioButton.TabIndex = 6;
            this.fourTimesFasterRadioButton.TabStop = true;
            this.fourTimesFasterRadioButton.Text = "4x faster";
            this.fourTimesFasterRadioButton.UseVisualStyleBackColor = true;
            // 
            // twoTimesFasterRadioButton
            // 
            this.twoTimesFasterRadioButton.AutoSize = true;
            this.twoTimesFasterRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoTimesFasterRadioButton.Location = new System.Drawing.Point(3, 34);
            this.twoTimesFasterRadioButton.Name = "twoTimesFasterRadioButton";
            this.twoTimesFasterRadioButton.Size = new System.Drawing.Size(90, 25);
            this.twoTimesFasterRadioButton.TabIndex = 7;
            this.twoTimesFasterRadioButton.Text = "2x Faster";
            this.twoTimesFasterRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fourTimesFasterRadioButton);
            this.panel1.Controls.Add(this.twoTimesFasterRadioButton);
            this.panel1.Location = new System.Drawing.Point(24, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 64);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 374);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.folderLocationText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ME2 4x Faster Loading Screens";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox folderLocationText;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label textBoxLabel;
        private System.Windows.Forms.RadioButton fourTimesFasterRadioButton;
        private System.Windows.Forms.RadioButton twoTimesFasterRadioButton;
        private System.Windows.Forms.Panel panel1;
    }
}


namespace WindowsFormsApplication2
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
            this.loadFileButton = new System.Windows.Forms.Button();
            this.nextInstructionButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.RunToEndButton = new System.Windows.Forms.Button();
            this.CCVal = new System.Windows.Forms.Label();
            this.PCVal = new System.Windows.Forms.Label();
            this.MARVal = new System.Windows.Forms.Label();
            this.IRVal = new System.Windows.Forms.Label();
            this.MDRVal = new System.Windows.Forms.Label();
            this.TempVal = new System.Windows.Forms.Label();
            this.BVal = new System.Windows.Forms.Label();
            this.AVal = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.Label();
            this.zero = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Alabel = new System.Windows.Forms.Label();
            this.accLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ErrMsg = new System.Windows.Forms.Label();
            this.CacheSize = new System.Windows.Forms.ComboBox();
            this.BlockSize = new System.Windows.Forms.ComboBox();
            this.Associativity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hitLabel = new System.Windows.Forms.Label();
            this.missLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadFileButton
            // 
            this.loadFileButton.Location = new System.Drawing.Point(220, 112);
            this.loadFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(116, 20);
            this.loadFileButton.TabIndex = 2;
            this.loadFileButton.Text = "Load File";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // nextInstructionButton
            // 
            this.nextInstructionButton.Location = new System.Drawing.Point(220, 164);
            this.nextInstructionButton.Margin = new System.Windows.Forms.Padding(2);
            this.nextInstructionButton.Name = "nextInstructionButton";
            this.nextInstructionButton.Size = new System.Drawing.Size(116, 20);
            this.nextInstructionButton.TabIndex = 3;
            this.nextInstructionButton.Text = "Next";
            this.nextInstructionButton.UseVisualStyleBackColor = true;
            this.nextInstructionButton.Click += new System.EventHandler(this.nextInstructionButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(220, 138);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(116, 20);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // RunToEndButton
            // 
            this.RunToEndButton.Location = new System.Drawing.Point(220, 190);
            this.RunToEndButton.Margin = new System.Windows.Forms.Padding(2);
            this.RunToEndButton.Name = "RunToEndButton";
            this.RunToEndButton.Size = new System.Drawing.Size(116, 20);
            this.RunToEndButton.TabIndex = 5;
            this.RunToEndButton.Text = "Run To End";
            this.RunToEndButton.UseVisualStyleBackColor = true;
            this.RunToEndButton.Click += new System.EventHandler(this.RunToEndButton_Click);
            // 
            // CCVal
            // 
            this.CCVal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CCVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CCVal.Location = new System.Drawing.Point(60, 327);
            this.CCVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CCVal.Name = "CCVal";
            this.CCVal.Size = new System.Drawing.Size(106, 19);
            this.CCVal.TabIndex = 57;
            this.CCVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PCVal
            // 
            this.PCVal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PCVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PCVal.Location = new System.Drawing.Point(60, 177);
            this.PCVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PCVal.Name = "PCVal";
            this.PCVal.Size = new System.Drawing.Size(106, 19);
            this.PCVal.TabIndex = 56;
            this.PCVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MARVal
            // 
            this.MARVal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MARVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MARVal.Location = new System.Drawing.Point(60, 207);
            this.MARVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MARVal.Name = "MARVal";
            this.MARVal.Size = new System.Drawing.Size(106, 19);
            this.MARVal.TabIndex = 55;
            this.MARVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IRVal
            // 
            this.IRVal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IRVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IRVal.Location = new System.Drawing.Point(60, 297);
            this.IRVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IRVal.Name = "IRVal";
            this.IRVal.Size = new System.Drawing.Size(106, 19);
            this.IRVal.TabIndex = 54;
            this.IRVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MDRVal
            // 
            this.MDRVal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MDRVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MDRVal.Location = new System.Drawing.Point(60, 237);
            this.MDRVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MDRVal.Name = "MDRVal";
            this.MDRVal.Size = new System.Drawing.Size(106, 19);
            this.MDRVal.TabIndex = 53;
            this.MDRVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TempVal
            // 
            this.TempVal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TempVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TempVal.Location = new System.Drawing.Point(60, 267);
            this.TempVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TempVal.Name = "TempVal";
            this.TempVal.Size = new System.Drawing.Size(106, 19);
            this.TempVal.TabIndex = 52;
            this.TempVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BVal
            // 
            this.BVal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BVal.Location = new System.Drawing.Point(60, 57);
            this.BVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BVal.Name = "BVal";
            this.BVal.Size = new System.Drawing.Size(106, 19);
            this.BVal.TabIndex = 51;
            this.BVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AVal
            // 
            this.AVal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AVal.Location = new System.Drawing.Point(60, 27);
            this.AVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AVal.Name = "AVal";
            this.AVal.Size = new System.Drawing.Size(106, 19);
            this.AVal.TabIndex = 50;
            this.AVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 330);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 13);
            this.label20.TabIndex = 49;
            this.label20.Text = "CC";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 300);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "IR";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 270);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 47;
            this.label17.Text = "Temp";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 240);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "MDR";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 210);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "MAR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 180);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "PC";
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.one.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.one.Location = new System.Drawing.Point(60, 147);
            this.one.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(106, 19);
            this.one.TabIndex = 43;
            this.one.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.zero.Location = new System.Drawing.Point(60, 117);
            this.zero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(106, 19);
            this.zero.TabIndex = 42;
            this.zero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "One";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Zero";
            // 
            // Alabel
            // 
            this.Alabel.AutoSize = true;
            this.Alabel.Location = new System.Drawing.Point(20, 30);
            this.Alabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Alabel.Name = "Alabel";
            this.Alabel.Size = new System.Drawing.Size(14, 13);
            this.Alabel.TabIndex = 38;
            this.Alabel.Text = "A";
            // 
            // accLabel
            // 
            this.accLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.accLabel.Location = new System.Drawing.Point(60, 87);
            this.accLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accLabel.Name = "accLabel";
            this.accLabel.Size = new System.Drawing.Size(106, 19);
            this.accLabel.TabIndex = 37;
            this.accLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "ACC";
            // 
            // ErrMsg
            // 
            this.ErrMsg.AutoSize = true;
            this.ErrMsg.Location = new System.Drawing.Point(20, 360);
            this.ErrMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(32, 13);
            this.ErrMsg.TabIndex = 58;
            this.ErrMsg.Text = "Error:";
            // 
            // CacheSize
            // 
            this.CacheSize.FormattingEnabled = true;
            this.CacheSize.Location = new System.Drawing.Point(220, 56);
            this.CacheSize.Name = "CacheSize";
            this.CacheSize.Size = new System.Drawing.Size(116, 21);
            this.CacheSize.TabIndex = 59;
            this.CacheSize.Text = "  Select Cache Size";
            this.CacheSize.SelectedIndexChanged += new System.EventHandler(this.CacheSize_SelectedIndexChanged);
            // 
            // BlockSize
            // 
            this.BlockSize.FormattingEnabled = true;
            this.BlockSize.Location = new System.Drawing.Point(220, 86);
            this.BlockSize.Name = "BlockSize";
            this.BlockSize.Size = new System.Drawing.Size(116, 21);
            this.BlockSize.TabIndex = 61;
            this.BlockSize.Text = "  Select Block Size";
            this.BlockSize.SelectedIndexChanged += new System.EventHandler(this.BlockSize_SelectedIndexChanged);
            // 
            // Associativity
            // 
            this.Associativity.FormattingEnabled = true;
            this.Associativity.Location = new System.Drawing.Point(220, 26);
            this.Associativity.Name = "Associativity";
            this.Associativity.Size = new System.Drawing.Size(116, 21);
            this.Associativity.TabIndex = 62;
            this.Associativity.Text = " Select Associativity";
            this.Associativity.SelectedIndexChanged += new System.EventHandler(this.Associativity_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Hit Counter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Miss Counter";
            // 
            // hitLabel
            // 
            this.hitLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hitLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hitLabel.Location = new System.Drawing.Point(294, 218);
            this.hitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hitLabel.Name = "hitLabel";
            this.hitLabel.Size = new System.Drawing.Size(42, 19);
            this.hitLabel.TabIndex = 67;
            this.hitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // missLabel
            // 
            this.missLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.missLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.missLabel.Location = new System.Drawing.Point(294, 246);
            this.missLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.missLabel.Name = "missLabel";
            this.missLabel.Size = new System.Drawing.Size(42, 19);
            this.missLabel.TabIndex = 68;
            this.missLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 382);
            this.Controls.Add(this.missLabel);
            this.Controls.Add(this.hitLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Associativity);
            this.Controls.Add(this.BlockSize);
            this.Controls.Add(this.CacheSize);
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.CCVal);
            this.Controls.Add(this.PCVal);
            this.Controls.Add(this.MARVal);
            this.Controls.Add(this.IRVal);
            this.Controls.Add(this.MDRVal);
            this.Controls.Add(this.TempVal);
            this.Controls.Add(this.BVal);
            this.Controls.Add(this.AVal);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.one);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Alabel);
            this.Controls.Add(this.accLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RunToEndButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.nextInstructionButton);
            this.Controls.Add(this.loadFileButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Gemini";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.Button nextInstructionButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button RunToEndButton;
        private System.Windows.Forms.Label CCVal;
        private System.Windows.Forms.Label PCVal;
        private System.Windows.Forms.Label MARVal;
        private System.Windows.Forms.Label IRVal;
        private System.Windows.Forms.Label MDRVal;
        private System.Windows.Forms.Label TempVal;
        private System.Windows.Forms.Label BVal;
        private System.Windows.Forms.Label AVal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label one;
        private System.Windows.Forms.Label zero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Alabel;
        private System.Windows.Forms.Label accLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ErrMsg;
        private System.Windows.Forms.ComboBox CacheSize;
        private System.Windows.Forms.ComboBox BlockSize;
        private System.Windows.Forms.ComboBox Associativity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hitLabel;
        private System.Windows.Forms.Label missLabel;
    }
}


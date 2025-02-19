﻿namespace Operations
{
    partial class DecodeCanBus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecodeCanBus));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBaudStd = new System.Windows.Forms.ComboBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.comboBaudFD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioIdleHigh = new System.Windows.Forms.RadioButton();
            this.radioIdleLow = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textSmplStd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textSmplFD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Standard:";
            // 
            // comboBaudStd
            // 
            this.comboBaudStd.FormattingEnabled = true;
            this.comboBaudStd.Items.AddRange(new object[] {
            "1 M",
            "800 k",
            "750 k",
            "500 k",
            "250 k",
            "125 k",
            "100 k",
            "83333",
            "50 k",
            "20 k",
            "10 k"});
            this.comboBaudStd.Location = new System.Drawing.Point(71, 82);
            this.comboBaudStd.Name = "comboBaudStd";
            this.comboBaudStd.Size = new System.Drawing.Size(67, 21);
            this.comboBaudStd.TabIndex = 1;
            // 
            // btnDecode
            // 
            this.btnDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDecode.ForeColor = System.Drawing.Color.Black;
            this.btnDecode.Location = new System.Drawing.Point(71, 188);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 100;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // comboBaudFD
            // 
            this.comboBaudFD.FormattingEnabled = true;
            this.comboBaudFD.Items.AddRange(new object[] {
            "5 M",
            "2 M",
            "1 M",
            "800 k",
            "750 k",
            "500 k"});
            this.comboBaudFD.Location = new System.Drawing.Point(71, 109);
            this.comboBaudFD.Name = "comboBaudFD";
            this.comboBaudFD.Size = new System.Drawing.Size(67, 21);
            this.comboBaudFD.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "CAN FD:";
            // 
            // radioIdleHigh
            // 
            this.radioIdleHigh.AutoSize = true;
            this.radioIdleHigh.Checked = true;
            this.radioIdleHigh.Location = new System.Drawing.Point(14, 140);
            this.radioIdleHigh.Name = "radioIdleHigh";
            this.radioIdleHigh.Size = new System.Drawing.Size(157, 17);
            this.radioIdleHigh.TabIndex = 20;
            this.radioIdleHigh.TabStop = true;
            this.radioIdleHigh.Text = "Bus Idle (Recessive) is High";
            this.radioIdleHigh.UseVisualStyleBackColor = true;
            // 
            // radioIdleLow
            // 
            this.radioIdleLow.AutoSize = true;
            this.radioIdleLow.Location = new System.Drawing.Point(14, 157);
            this.radioIdleLow.Name = "radioIdleLow";
            this.radioIdleLow.Size = new System.Drawing.Size(155, 17);
            this.radioIdleLow.TabIndex = 21;
            this.radioIdleLow.Text = "Bus Idle (Recessive) is Low";
            this.radioIdleLow.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Baudrate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Samplepoint:";
            // 
            // textSmplStd
            // 
            this.textSmplStd.Location = new System.Drawing.Point(155, 83);
            this.textSmplStd.Name = "textSmplStd";
            this.textSmplStd.Size = new System.Drawing.Size(52, 20);
            this.textSmplStd.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 109;
            this.label5.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 111;
            this.label6.Text = "%";
            // 
            // textSmplFD
            // 
            this.textSmplFD.Location = new System.Drawing.Point(155, 109);
            this.textSmplFD.Name = "textSmplFD";
            this.textSmplFD.Size = new System.Drawing.Size(52, 20);
            this.textSmplFD.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(11, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 13);
            this.label7.TabIndex = 112;
            this.label7.Text = "For CAN classic you can set a samplepoint of 50 %";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(11, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 13);
            this.label8.TabIndex = 113;
            this.label8.Text = "But for CAN FD with 2 baudrates it is fundamental";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(12, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 13);
            this.label9.TabIndex = 114;
            this.label9.Text = "that both samplepoints match the CAN network.";
            // 
            // linkHelp
            // 
            this.linkHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkHelp.AutoSize = true;
            this.linkHelp.LinkColor = System.Drawing.Color.Lime;
            this.linkHelp.Location = new System.Drawing.Point(156, 192);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(59, 13);
            this.linkHelp.TabIndex = 115;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "Show Help";
            this.linkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelp_LinkClicked);
            // 
            // DecodeCanBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(266, 223);
            this.Controls.Add(this.linkHelp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textSmplFD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textSmplStd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioIdleLow);
            this.Controls.Add(this.radioIdleHigh);
            this.Controls.Add(this.comboBaudFD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.comboBaudStd);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DecodeCanBus";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Decode CAN Bus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBaudStd;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.ComboBox comboBaudFD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioIdleHigh;
        private System.Windows.Forms.RadioButton radioIdleLow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSmplStd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textSmplFD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkHelp;

    }
}
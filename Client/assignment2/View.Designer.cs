namespace assignment2
{
    partial class View
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
            this.cText = new System.Windows.Forms.TextBox();
            this.sText = new System.Windows.Forms.TextBox();
            this.sResponse = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teardownBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.setupBtn = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.portNum = new System.Windows.Forms.TextBox();
            this.ipNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.headerChk = new System.Windows.Forms.CheckBox();
            this.reportChk = new System.Windows.Forms.CheckBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.vidName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cText
            // 
            this.cText.Location = new System.Drawing.Point(20, 10);
            this.cText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cText.Multiline = true;
            this.cText.Name = "cText";
            this.cText.ReadOnly = true;
            this.cText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cText.Size = new System.Drawing.Size(478, 140);
            this.cText.TabIndex = 0;
            // 
            // sText
            // 
            this.sText.Location = new System.Drawing.Point(20, 198);
            this.sText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sText.Multiline = true;
            this.sText.Name = "sText";
            this.sText.ReadOnly = true;
            this.sText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sText.Size = new System.Drawing.Size(478, 146);
            this.sText.TabIndex = 1;
            // 
            // sResponse
            // 
            this.sResponse.AutoSize = true;
            this.sResponse.Location = new System.Drawing.Point(17, 179);
            this.sResponse.Name = "sResponse";
            this.sResponse.Size = new System.Drawing.Size(125, 17);
            this.sResponse.TabIndex = 2;
            this.sResponse.Text = "Server Responses";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teardownBtn);
            this.groupBox1.Controls.Add(this.pauseBtn);
            this.groupBox1.Controls.Add(this.playBtn);
            this.groupBox1.Controls.Add(this.setupBtn);
            this.groupBox1.Controls.Add(this.imageBox);
            this.groupBox1.Location = new System.Drawing.Point(516, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(562, 385);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // teardownBtn
            // 
            this.teardownBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.teardownBtn.Location = new System.Drawing.Point(421, 320);
            this.teardownBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teardownBtn.Name = "teardownBtn";
            this.teardownBtn.Size = new System.Drawing.Size(133, 60);
            this.teardownBtn.TabIndex = 4;
            this.teardownBtn.Text = "Teardown";
            this.teardownBtn.UseVisualStyleBackColor = false;
            this.teardownBtn.Click += new System.EventHandler(this.teardownBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.pauseBtn.Location = new System.Drawing.Point(283, 320);
            this.pauseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(133, 60);
            this.pauseBtn.TabIndex = 3;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = false;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.playBtn.Location = new System.Drawing.Point(144, 320);
            this.playBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(133, 60);
            this.playBtn.TabIndex = 2;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // setupBtn
            // 
            this.setupBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.setupBtn.Location = new System.Drawing.Point(5, 320);
            this.setupBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setupBtn.Name = "setupBtn";
            this.setupBtn.Size = new System.Drawing.Size(133, 60);
            this.setupBtn.TabIndex = 1;
            this.setupBtn.Text = "Setup";
            this.setupBtn.UseVisualStyleBackColor = false;
            this.setupBtn.Click += new System.EventHandler(this.setupBtn_Click);
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(5, 12);
            this.imageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(551, 303);
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // portNum
            // 
            this.portNum.Location = new System.Drawing.Point(108, 347);
            this.portNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.portNum.Name = "portNum";
            this.portNum.Size = new System.Drawing.Size(89, 22);
            this.portNum.TabIndex = 4;
            this.portNum.Text = "3000";
            // 
            // ipNum
            // 
            this.ipNum.Location = new System.Drawing.Point(108, 373);
            this.ipNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ipNum.Name = "ipNum";
            this.ipNum.ReadOnly = true;
            this.ipNum.Size = new System.Drawing.Size(122, 22);
            this.ipNum.TabIndex = 5;
            this.ipNum.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "IP Address";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.connectBtn.Location = new System.Drawing.Point(244, 373);
            this.connectBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(118, 52);
            this.connectBtn.TabIndex = 8;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = false;
            // 
            // headerChk
            // 
            this.headerChk.AutoSize = true;
            this.headerChk.Location = new System.Drawing.Point(388, 154);
            this.headerChk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.headerChk.Name = "headerChk";
            this.headerChk.Size = new System.Drawing.Size(110, 21);
            this.headerChk.TabIndex = 9;
            this.headerChk.Text = "Print Header";
            this.headerChk.UseVisualStyleBackColor = true;
            // 
            // reportChk
            // 
            this.reportChk.AutoSize = true;
            this.reportChk.Location = new System.Drawing.Point(260, 154);
            this.reportChk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportChk.Name = "reportChk";
            this.reportChk.Size = new System.Drawing.Size(120, 21);
            this.reportChk.TabIndex = 10;
            this.reportChk.Text = "Packet Report";
            this.reportChk.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.exitBtn.Location = new System.Drawing.Point(375, 375);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(123, 50);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // vidName
            // 
            this.vidName.FormattingEnabled = true;
            this.vidName.Items.AddRange(new object[] {
            "video1.mjpeg",
            "video2.mjpeg"});
            this.vidName.Location = new System.Drawing.Point(108, 402);
            this.vidName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vidName.Name = "vidName";
            this.vidName.Size = new System.Drawing.Size(122, 24);
            this.vidName.TabIndex = 12;
            this.vidName.SelectedIndexChanged += new System.EventHandler(this.vidName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Video Name";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(244, 346);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 26);
            this.button2.TabIndex = 15;
            this.button2.Text = "Clear Respones";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 434);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vidName);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.reportChk);
            this.Controls.Add(this.headerChk);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipNum);
            this.Controls.Add(this.portNum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sResponse);
            this.Controls.Add(this.sText);
            this.Controls.Add(this.cText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "View";
            this.Text = "video player";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cText;
        private System.Windows.Forms.TextBox sText;
        private System.Windows.Forms.Label sResponse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button teardownBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button setupBtn;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.TextBox portNum;
        private System.Windows.Forms.TextBox ipNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.CheckBox headerChk;
        private System.Windows.Forms.CheckBox reportChk;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ComboBox vidName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}


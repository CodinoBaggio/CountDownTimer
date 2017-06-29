namespace CountDownTimer
{
    partial class OptionForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownCountDownSeconds = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownRunMinute = new System.Windows.Forms.NumericUpDown();
            this.buttonRun = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ImmediatelyRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownStartCountDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonTopLeft = new System.Windows.Forms.RadioButton();
            this.radioButtonTopRight = new System.Windows.Forms.RadioButton();
            this.radioButtonBottomLeft = new System.Windows.Forms.RadioButton();
            this.radioButtonBottomRight = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountDownSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRunMinute)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartCountDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "毎時";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "カウントダウンする秒数";
            // 
            // numericUpDownCountDownSeconds
            // 
            this.numericUpDownCountDownSeconds.Location = new System.Drawing.Point(14, 83);
            this.numericUpDownCountDownSeconds.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownCountDownSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCountDownSeconds.Name = "numericUpDownCountDownSeconds";
            this.numericUpDownCountDownSeconds.Size = new System.Drawing.Size(49, 19);
            this.numericUpDownCountDownSeconds.TabIndex = 6;
            this.numericUpDownCountDownSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownCountDownSeconds.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "分に起動";
            // 
            // numericUpDownRunMinute
            // 
            this.numericUpDownRunMinute.Location = new System.Drawing.Point(159, 24);
            this.numericUpDownRunMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownRunMinute.Name = "numericUpDownRunMinute";
            this.numericUpDownRunMinute.Size = new System.Drawing.Size(49, 19);
            this.numericUpDownRunMinute.TabIndex = 3;
            this.numericUpDownRunMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownRunMinute.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRun.Location = new System.Drawing.Point(223, 328);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 12;
            this.buttonRun.Text = "適用";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "秒";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImmediatelyRunToolStripMenuItem,
            this.toolStripSeparator1,
            this.OptionToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 76);
            // 
            // ImmediatelyRunToolStripMenuItem
            // 
            this.ImmediatelyRunToolStripMenuItem.Name = "ImmediatelyRunToolStripMenuItem";
            this.ImmediatelyRunToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ImmediatelyRunToolStripMenuItem.Text = "今すぐ実行";
            this.ImmediatelyRunToolStripMenuItem.Click += new System.EventHandler(this.ImmediatelyRunToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // OptionToolStripMenuItem
            // 
            this.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem";
            this.OptionToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.OptionToolStripMenuItem.Text = "設定";
            this.OptionToolStripMenuItem.Click += new System.EventHandler(this.OptionToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ExitToolStripMenuItem.Text = "終了";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "カウントダウンタイマー";
            this.notifyIcon1.Visible = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(304, 328);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSmall);
            this.groupBox1.Controls.Add(this.radioButtonLarge);
            this.groupBox1.Location = new System.Drawing.Point(14, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 61);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "タイマーフォームの大きさ";
            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.AutoSize = true;
            this.radioButtonSmall.Location = new System.Drawing.Point(20, 41);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(35, 16);
            this.radioButtonSmall.TabIndex = 1;
            this.radioButtonSmall.Text = "小";
            this.radioButtonSmall.UseVisualStyleBackColor = true;
            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.Checked = true;
            this.radioButtonLarge.Location = new System.Drawing.Point(20, 19);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(35, 16);
            this.radioButtonLarge.TabIndex = 0;
            this.radioButtonLarge.TabStop = true;
            this.radioButtonLarge.Text = "大";
            this.radioButtonLarge.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "秒";
            // 
            // numericUpDownStartCountDown
            // 
            this.numericUpDownStartCountDown.Location = new System.Drawing.Point(159, 83);
            this.numericUpDownStartCountDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownStartCountDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStartCountDown.Name = "numericUpDownStartCountDown";
            this.numericUpDownStartCountDown.Size = new System.Drawing.Size(49, 19);
            this.numericUpDownStartCountDown.TabIndex = 9;
            this.numericUpDownStartCountDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownStartCountDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "カウントダウンがスタートするまでの秒数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "識別名";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(14, 24);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(134, 19);
            this.textBoxID.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonBottomRight);
            this.groupBox2.Controls.Add(this.radioButtonBottomLeft);
            this.groupBox2.Controls.Add(this.radioButtonTopRight);
            this.groupBox2.Controls.Add(this.radioButtonTopLeft);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(170, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 181);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "タイマーフォームの表示位置";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(28, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 129);
            this.label8.TabIndex = 0;
            this.label8.Text = "スクリーン";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonTopLeft
            // 
            this.radioButtonTopLeft.AutoSize = true;
            this.radioButtonTopLeft.Location = new System.Drawing.Point(28, 29);
            this.radioButtonTopLeft.Name = "radioButtonTopLeft";
            this.radioButtonTopLeft.Size = new System.Drawing.Size(14, 13);
            this.radioButtonTopLeft.TabIndex = 1;
            this.radioButtonTopLeft.TabStop = true;
            this.radioButtonTopLeft.UseVisualStyleBackColor = true;
            // 
            // radioButtonTopRight
            // 
            this.radioButtonTopRight.AutoSize = true;
            this.radioButtonTopRight.Location = new System.Drawing.Point(167, 29);
            this.radioButtonTopRight.Name = "radioButtonTopRight";
            this.radioButtonTopRight.Size = new System.Drawing.Size(14, 13);
            this.radioButtonTopRight.TabIndex = 2;
            this.radioButtonTopRight.TabStop = true;
            this.radioButtonTopRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonBottomLeft
            // 
            this.radioButtonBottomLeft.AutoSize = true;
            this.radioButtonBottomLeft.Location = new System.Drawing.Point(28, 145);
            this.radioButtonBottomLeft.Name = "radioButtonBottomLeft";
            this.radioButtonBottomLeft.Size = new System.Drawing.Size(14, 13);
            this.radioButtonBottomLeft.TabIndex = 3;
            this.radioButtonBottomLeft.TabStop = true;
            this.radioButtonBottomLeft.UseVisualStyleBackColor = true;
            // 
            // radioButtonBottomRight
            // 
            this.radioButtonBottomRight.AutoSize = true;
            this.radioButtonBottomRight.Location = new System.Drawing.Point(167, 145);
            this.radioButtonBottomRight.Name = "radioButtonBottomRight";
            this.radioButtonBottomRight.Size = new System.Drawing.Size(14, 13);
            this.radioButtonBottomRight.TabIndex = 4;
            this.radioButtonBottomRight.TabStop = true;
            this.radioButtonBottomRight.UseVisualStyleBackColor = true;
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 363);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownStartCountDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.numericUpDownRunMinute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownCountDownSeconds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "OptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "タイマー設定";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionForm_FormClosing);
            this.Load += new System.EventHandler(this.OptionForm_Load);
            this.Shown += new System.EventHandler(this.OptionForm_Shown);
            this.SizeChanged += new System.EventHandler(this.OptionForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountDownSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRunMinute)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartCountDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownCountDownSeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownRunMinute;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ToolStripMenuItem ImmediatelyRunToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownStartCountDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonBottomRight;
        private System.Windows.Forms.RadioButton radioButtonBottomLeft;
        private System.Windows.Forms.RadioButton radioButtonTopRight;
        private System.Windows.Forms.RadioButton radioButtonTopLeft;
        private System.Windows.Forms.Label label8;
    }
}
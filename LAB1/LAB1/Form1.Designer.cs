namespace LAB1
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
            this.components = new System.ComponentModel.Container();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxPortSelect = new System.Windows.Forms.ComboBox();
            this.textBoxXAcc = new System.Windows.Forms.TextBox();
            this.textBoxYAcc = new System.Windows.Forms.TextBox();
            this.textBoxZAcc = new System.Windows.Forms.TextBox();
            this.textBoxXAvg = new System.Windows.Forms.TextBox();
            this.textBoxYAvg = new System.Windows.Forms.TextBox();
            this.textBoxZAvg = new System.Windows.Forms.TextBox();
            this.textBoxZMax = new System.Windows.Forms.TextBox();
            this.textBoxYMax = new System.Windows.Forms.TextBox();
            this.textBoxXMax = new System.Windows.Forms.TextBox();
            this.labelXAcc = new System.Windows.Forms.Label();
            this.labelYAcc = new System.Windows.Forms.Label();
            this.labelZAcc = new System.Windows.Forms.Label();
            this.labelZAvg = new System.Windows.Forms.Label();
            this.labelYAvg = new System.Windows.Forms.Label();
            this.labelXAvg = new System.Windows.Forms.Label();
            this.labelZMax = new System.Windows.Forms.Label();
            this.labelYMax = new System.Windows.Forms.Label();
            this.labelXMax = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBoxOrientation = new System.Windows.Forms.PictureBox();
            this.pictureBoxGameBackground = new System.Windows.Forms.PictureBox();
            this.textBoxAction = new System.Windows.Forms.TextBox();
            this.labelAction = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.progressBarTimeLeft = new System.Windows.Forms.ProgressBar();
            this.textBoxKilled = new System.Windows.Forms.TextBox();
            this.textBoxMissed = new System.Windows.Forms.TextBox();
            this.labelKilled = new System.Windows.Forms.Label();
            this.labelMissed = new System.Windows.Forms.Label();
            this.labelTimeLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrientation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(178, 36);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxPortSelect
            // 
            this.comboBoxPortSelect.FormattingEnabled = true;
            this.comboBoxPortSelect.Location = new System.Drawing.Point(38, 38);
            this.comboBoxPortSelect.Name = "comboBoxPortSelect";
            this.comboBoxPortSelect.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPortSelect.TabIndex = 1;
            this.comboBoxPortSelect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxPortSelect_MouseClick);
            // 
            // textBoxXAcc
            // 
            this.textBoxXAcc.Location = new System.Drawing.Point(153, 121);
            this.textBoxXAcc.Name = "textBoxXAcc";
            this.textBoxXAcc.Size = new System.Drawing.Size(100, 20);
            this.textBoxXAcc.TabIndex = 2;
            // 
            // textBoxYAcc
            // 
            this.textBoxYAcc.Location = new System.Drawing.Point(153, 157);
            this.textBoxYAcc.Name = "textBoxYAcc";
            this.textBoxYAcc.Size = new System.Drawing.Size(100, 20);
            this.textBoxYAcc.TabIndex = 3;
            // 
            // textBoxZAcc
            // 
            this.textBoxZAcc.Location = new System.Drawing.Point(153, 193);
            this.textBoxZAcc.Name = "textBoxZAcc";
            this.textBoxZAcc.Size = new System.Drawing.Size(100, 20);
            this.textBoxZAcc.TabIndex = 4;
            // 
            // textBoxXAvg
            // 
            this.textBoxXAvg.Location = new System.Drawing.Point(153, 252);
            this.textBoxXAvg.Name = "textBoxXAvg";
            this.textBoxXAvg.Size = new System.Drawing.Size(100, 20);
            this.textBoxXAvg.TabIndex = 5;
            // 
            // textBoxYAvg
            // 
            this.textBoxYAvg.Location = new System.Drawing.Point(153, 289);
            this.textBoxYAvg.Name = "textBoxYAvg";
            this.textBoxYAvg.Size = new System.Drawing.Size(100, 20);
            this.textBoxYAvg.TabIndex = 6;
            // 
            // textBoxZAvg
            // 
            this.textBoxZAvg.Location = new System.Drawing.Point(153, 326);
            this.textBoxZAvg.Name = "textBoxZAvg";
            this.textBoxZAvg.Size = new System.Drawing.Size(100, 20);
            this.textBoxZAvg.TabIndex = 7;
            // 
            // textBoxZMax
            // 
            this.textBoxZMax.Location = new System.Drawing.Point(153, 460);
            this.textBoxZMax.Name = "textBoxZMax";
            this.textBoxZMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxZMax.TabIndex = 10;
            // 
            // textBoxYMax
            // 
            this.textBoxYMax.Location = new System.Drawing.Point(153, 423);
            this.textBoxYMax.Name = "textBoxYMax";
            this.textBoxYMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxYMax.TabIndex = 9;
            // 
            // textBoxXMax
            // 
            this.textBoxXMax.Location = new System.Drawing.Point(153, 386);
            this.textBoxXMax.Name = "textBoxXMax";
            this.textBoxXMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxXMax.TabIndex = 8;
            // 
            // labelXAcc
            // 
            this.labelXAcc.AutoSize = true;
            this.labelXAcc.Location = new System.Drawing.Point(35, 124);
            this.labelXAcc.Name = "labelXAcc";
            this.labelXAcc.Size = new System.Drawing.Size(76, 13);
            this.labelXAcc.TabIndex = 11;
            this.labelXAcc.Text = "X Acceleration";
            // 
            // labelYAcc
            // 
            this.labelYAcc.AutoSize = true;
            this.labelYAcc.Location = new System.Drawing.Point(35, 160);
            this.labelYAcc.Name = "labelYAcc";
            this.labelYAcc.Size = new System.Drawing.Size(76, 13);
            this.labelYAcc.TabIndex = 12;
            this.labelYAcc.Text = "Y Acceleration";
            // 
            // labelZAcc
            // 
            this.labelZAcc.AutoSize = true;
            this.labelZAcc.Location = new System.Drawing.Point(35, 196);
            this.labelZAcc.Name = "labelZAcc";
            this.labelZAcc.Size = new System.Drawing.Size(76, 13);
            this.labelZAcc.TabIndex = 13;
            this.labelZAcc.Text = "Z Acceleration";
            // 
            // labelZAvg
            // 
            this.labelZAvg.AutoSize = true;
            this.labelZAvg.Location = new System.Drawing.Point(35, 327);
            this.labelZAvg.Name = "labelZAvg";
            this.labelZAvg.Size = new System.Drawing.Size(98, 13);
            this.labelZAvg.TabIndex = 16;
            this.labelZAvg.Text = "Z Acceleration Avg";
            // 
            // labelYAvg
            // 
            this.labelYAvg.AutoSize = true;
            this.labelYAvg.Location = new System.Drawing.Point(35, 291);
            this.labelYAvg.Name = "labelYAvg";
            this.labelYAvg.Size = new System.Drawing.Size(98, 13);
            this.labelYAvg.TabIndex = 15;
            this.labelYAvg.Text = "Y Acceleration Avg";
            // 
            // labelXAvg
            // 
            this.labelXAvg.AutoSize = true;
            this.labelXAvg.Location = new System.Drawing.Point(35, 255);
            this.labelXAvg.Name = "labelXAvg";
            this.labelXAvg.Size = new System.Drawing.Size(98, 13);
            this.labelXAvg.TabIndex = 14;
            this.labelXAvg.Text = "X Acceleration Avg";
            // 
            // labelZMax
            // 
            this.labelZMax.AutoSize = true;
            this.labelZMax.Location = new System.Drawing.Point(35, 463);
            this.labelZMax.Name = "labelZMax";
            this.labelZMax.Size = new System.Drawing.Size(99, 13);
            this.labelZMax.TabIndex = 19;
            this.labelZMax.Text = "Z Acceleration Max";
            // 
            // labelYMax
            // 
            this.labelYMax.AutoSize = true;
            this.labelYMax.Location = new System.Drawing.Point(35, 427);
            this.labelYMax.Name = "labelYMax";
            this.labelYMax.Size = new System.Drawing.Size(99, 13);
            this.labelYMax.TabIndex = 18;
            this.labelYMax.Text = "Y Acceleration Max";
            // 
            // labelXMax
            // 
            this.labelXMax.AutoSize = true;
            this.labelXMax.Location = new System.Drawing.Point(35, 391);
            this.labelXMax.Name = "labelXMax";
            this.labelXMax.Size = new System.Drawing.Size(99, 13);
            this.labelXMax.TabIndex = 17;
            this.labelXMax.Text = "X Acceleration Max";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // pictureBoxOrientation
            // 
            this.pictureBoxOrientation.Location = new System.Drawing.Point(277, 38);
            this.pictureBoxOrientation.Name = "pictureBoxOrientation";
            this.pictureBoxOrientation.Size = new System.Drawing.Size(159, 150);
            this.pictureBoxOrientation.TabIndex = 20;
            this.pictureBoxOrientation.TabStop = false;
            // 
            // pictureBoxGameBackground
            // 
            this.pictureBoxGameBackground.Location = new System.Drawing.Point(461, 36);
            this.pictureBoxGameBackground.Name = "pictureBoxGameBackground";
            this.pictureBoxGameBackground.Size = new System.Drawing.Size(407, 480);
            this.pictureBoxGameBackground.TabIndex = 21;
            this.pictureBoxGameBackground.TabStop = false;
            // 
            // textBoxAction
            // 
            this.textBoxAction.Location = new System.Drawing.Point(78, 82);
            this.textBoxAction.Name = "textBoxAction";
            this.textBoxAction.Size = new System.Drawing.Size(175, 20);
            this.textBoxAction.TabIndex = 22;
            // 
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.Location = new System.Drawing.Point(35, 85);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(37, 13);
            this.labelAction.TabIndex = 23;
            this.labelAction.Text = "Action";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(361, 255);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 24;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(361, 291);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(75, 23);
            this.buttonRestart.TabIndex = 25;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // progressBarTimeLeft
            // 
            this.progressBarTimeLeft.Location = new System.Drawing.Point(640, 486);
            this.progressBarTimeLeft.Name = "progressBarTimeLeft";
            this.progressBarTimeLeft.Size = new System.Drawing.Size(214, 23);
            this.progressBarTimeLeft.TabIndex = 26;
            // 
            // textBoxKilled
            // 
            this.textBoxKilled.Location = new System.Drawing.Point(513, 463);
            this.textBoxKilled.Name = "textBoxKilled";
            this.textBoxKilled.Size = new System.Drawing.Size(33, 20);
            this.textBoxKilled.TabIndex = 27;
            // 
            // textBoxMissed
            // 
            this.textBoxMissed.Location = new System.Drawing.Point(513, 489);
            this.textBoxMissed.Name = "textBoxMissed";
            this.textBoxMissed.Size = new System.Drawing.Size(33, 20);
            this.textBoxMissed.TabIndex = 28;
            // 
            // labelKilled
            // 
            this.labelKilled.AutoSize = true;
            this.labelKilled.Location = new System.Drawing.Point(471, 466);
            this.labelKilled.Name = "labelKilled";
            this.labelKilled.Size = new System.Drawing.Size(32, 13);
            this.labelKilled.TabIndex = 29;
            this.labelKilled.Text = "Killed";
            // 
            // labelMissed
            // 
            this.labelMissed.AutoSize = true;
            this.labelMissed.Location = new System.Drawing.Point(471, 492);
            this.labelMissed.Name = "labelMissed";
            this.labelMissed.Size = new System.Drawing.Size(40, 13);
            this.labelMissed.TabIndex = 30;
            this.labelMissed.Text = "Missed";
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.AutoSize = true;
            this.labelTimeLeft.Location = new System.Drawing.Point(583, 492);
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(51, 13);
            this.labelTimeLeft.TabIndex = 31;
            this.labelTimeLeft.Text = "Time Left";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 536);
            this.Controls.Add(this.labelTimeLeft);
            this.Controls.Add(this.labelMissed);
            this.Controls.Add(this.labelKilled);
            this.Controls.Add(this.textBoxMissed);
            this.Controls.Add(this.textBoxKilled);
            this.Controls.Add(this.progressBarTimeLeft);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelAction);
            this.Controls.Add(this.textBoxAction);
            this.Controls.Add(this.pictureBoxGameBackground);
            this.Controls.Add(this.pictureBoxOrientation);
            this.Controls.Add(this.labelZMax);
            this.Controls.Add(this.labelYMax);
            this.Controls.Add(this.labelXMax);
            this.Controls.Add(this.labelZAvg);
            this.Controls.Add(this.labelYAvg);
            this.Controls.Add(this.labelXAvg);
            this.Controls.Add(this.labelZAcc);
            this.Controls.Add(this.labelYAcc);
            this.Controls.Add(this.labelXAcc);
            this.Controls.Add(this.textBoxZMax);
            this.Controls.Add(this.textBoxYMax);
            this.Controls.Add(this.textBoxXMax);
            this.Controls.Add(this.textBoxZAvg);
            this.Controls.Add(this.textBoxYAvg);
            this.Controls.Add(this.textBoxXAvg);
            this.Controls.Add(this.textBoxZAcc);
            this.Controls.Add(this.textBoxYAcc);
            this.Controls.Add(this.textBoxXAcc);
            this.Controls.Add(this.comboBoxPortSelect);
            this.Controls.Add(this.buttonConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrientation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxPortSelect;
        private System.Windows.Forms.TextBox textBoxXAcc;
        private System.Windows.Forms.TextBox textBoxYAcc;
        private System.Windows.Forms.TextBox textBoxZAcc;
        private System.Windows.Forms.TextBox textBoxXAvg;
        private System.Windows.Forms.TextBox textBoxYAvg;
        private System.Windows.Forms.TextBox textBoxZAvg;
        private System.Windows.Forms.TextBox textBoxZMax;
        private System.Windows.Forms.TextBox textBoxYMax;
        private System.Windows.Forms.TextBox textBoxXMax;
        private System.Windows.Forms.Label labelXAcc;
        private System.Windows.Forms.Label labelYAcc;
        private System.Windows.Forms.Label labelZAcc;
        private System.Windows.Forms.Label labelZAvg;
        private System.Windows.Forms.Label labelYAvg;
        private System.Windows.Forms.Label labelXAvg;
        private System.Windows.Forms.Label labelZMax;
        private System.Windows.Forms.Label labelYMax;
        private System.Windows.Forms.Label labelXMax;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBoxOrientation;
        private System.Windows.Forms.PictureBox pictureBoxGameBackground;
        private System.Windows.Forms.TextBox textBoxAction;
        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.ProgressBar progressBarTimeLeft;
        private System.Windows.Forms.TextBox textBoxKilled;
        private System.Windows.Forms.TextBox textBoxMissed;
        private System.Windows.Forms.Label labelKilled;
        private System.Windows.Forms.Label labelMissed;
        private System.Windows.Forms.Label labelTimeLeft;
    }
}


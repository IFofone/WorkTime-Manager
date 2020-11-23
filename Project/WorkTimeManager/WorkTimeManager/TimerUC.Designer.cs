namespace WorkTimeManager
{
    partial class TimerUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.workTimeLbl = new System.Windows.Forms.Label();
            this.breakTimeLbl = new System.Windows.Forms.Label();
            this.hoursLbl = new System.Windows.Forms.Label();
            this.minutesLbl = new System.Windows.Forms.Label();
            this.secondsLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.endBtn = new System.Windows.Forms.Button();
            this.stateLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(47, 210);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(298, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // workTimeLbl
            // 
            this.workTimeLbl.AutoSize = true;
            this.workTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.workTimeLbl.Location = new System.Drawing.Point(139, 49);
            this.workTimeLbl.Name = "workTimeLbl";
            this.workTimeLbl.Size = new System.Drawing.Size(0, 20);
            this.workTimeLbl.TabIndex = 1;
            // 
            // breakTimeLbl
            // 
            this.breakTimeLbl.AutoSize = true;
            this.breakTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.breakTimeLbl.Location = new System.Drawing.Point(328, 49);
            this.breakTimeLbl.Name = "breakTimeLbl";
            this.breakTimeLbl.Size = new System.Drawing.Size(0, 20);
            this.breakTimeLbl.TabIndex = 2;
            // 
            // hoursLbl
            // 
            this.hoursLbl.AutoSize = true;
            this.hoursLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hoursLbl.Location = new System.Drawing.Point(46, 134);
            this.hoursLbl.Name = "hoursLbl";
            this.hoursLbl.Size = new System.Drawing.Size(87, 63);
            this.hoursLbl.TabIndex = 3;
            this.hoursLbl.Text = "00";
            // 
            // minutesLbl
            // 
            this.minutesLbl.AutoSize = true;
            this.minutesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutesLbl.Location = new System.Drawing.Point(154, 134);
            this.minutesLbl.Name = "minutesLbl";
            this.minutesLbl.Size = new System.Drawing.Size(87, 63);
            this.minutesLbl.TabIndex = 4;
            this.minutesLbl.Text = "00";
            // 
            // secondsLbl
            // 
            this.secondsLbl.AutoSize = true;
            this.secondsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondsLbl.Location = new System.Drawing.Point(259, 134);
            this.secondsLbl.Name = "secondsLbl";
            this.secondsLbl.Size = new System.Drawing.Size(87, 63);
            this.secondsLbl.TabIndex = 5;
            this.secondsLbl.Text = "00";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(47, 254);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(155, 254);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(128, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(235, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 46);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // endBtn
            // 
            this.endBtn.Location = new System.Drawing.Point(270, 254);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(75, 23);
            this.endBtn.TabIndex = 2;
            this.endBtn.Text = "End";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // stateLbl
            // 
            this.stateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stateLbl.Location = new System.Drawing.Point(53, 95);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(288, 21);
            this.stateLbl.TabIndex = 11;
            this.stateLbl.Text = "WORKTIME";
            this.stateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(53, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "WorkTime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(239, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "BreakTime";
            // 
            // TimerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stateLbl);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.secondsLbl);
            this.Controls.Add(this.minutesLbl);
            this.Controls.Add(this.hoursLbl);
            this.Controls.Add(this.breakTimeLbl);
            this.Controls.Add(this.workTimeLbl);
            this.Controls.Add(this.progressBar1);
            this.Name = "TimerUC";
            this.Size = new System.Drawing.Size(398, 326);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label workTimeLbl;
        private System.Windows.Forms.Label breakTimeLbl;
        private System.Windows.Forms.Label hoursLbl;
        private System.Windows.Forms.Label minutesLbl;
        private System.Windows.Forms.Label secondsLbl;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button endBtn;
        private System.Windows.Forms.Label stateLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

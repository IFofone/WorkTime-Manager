namespace WorkTimeManager
{
    partial class BaseForm
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
            this.remindersBtn = new System.Windows.Forms.Button();
            this.accountBtn = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.visualPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.TableLayoutPanel();
            this.timerBtn = new System.Windows.Forms.Button();
            this.logoPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // remindersBtn
            // 
            this.remindersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remindersBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.remindersBtn.Location = new System.Drawing.Point(3, 133);
            this.remindersBtn.Name = "remindersBtn";
            this.remindersBtn.Size = new System.Drawing.Size(209, 44);
            this.remindersBtn.TabIndex = 101;
            this.remindersBtn.Text = "Reminders";
            this.remindersBtn.UseVisualStyleBackColor = true;
            this.remindersBtn.Click += new System.EventHandler(this.RemindersBtn_Click);
            // 
            // accountBtn
            // 
            this.accountBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.accountBtn.Location = new System.Drawing.Point(3, 83);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(209, 44);
            this.accountBtn.TabIndex = 100;
            this.accountBtn.Text = "Account";
            this.accountBtn.UseVisualStyleBackColor = true;
            this.accountBtn.Click += new System.EventHandler(this.AccountBtn_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logoPanel.Controls.Add(this.titleLabel);
            this.logoPanel.Controls.Add(this.nameLabel);
            this.logoPanel.Location = new System.Drawing.Point(218, 0);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(673, 80);
            this.logoPanel.TabIndex = 5;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(39, 22);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(77, 33);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Home";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(568, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 26);
            this.nameLabel.TabIndex = 0;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logoLabel.ForeColor = System.Drawing.Color.White;
            this.logoLabel.Location = new System.Drawing.Point(3, 0);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(209, 80);
            this.logoLabel.TabIndex = 0;
            this.logoLabel.Text = "WorkTime Manager";
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoLabel.Click += new System.EventHandler(this.LogoLabel_Click);
            // 
            // visualPanel
            // 
            this.visualPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visualPanel.AutoSize = true;
            this.visualPanel.BackColor = System.Drawing.Color.White;
            this.visualPanel.Location = new System.Drawing.Point(218, 80);
            this.visualPanel.Margin = new System.Windows.Forms.Padding(0);
            this.visualPanel.Name = "visualPanel";
            this.visualPanel.Size = new System.Drawing.Size(673, 485);
            this.visualPanel.TabIndex = 6;
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftPanel.BackColor = System.Drawing.Color.Transparent;
            this.leftPanel.ColumnCount = 1;
            this.leftPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPanel.Controls.Add(this.timerBtn, 0, 3);
            this.leftPanel.Controls.Add(this.accountBtn, 0, 1);
            this.leftPanel.Controls.Add(this.remindersBtn, 0, 2);
            this.leftPanel.Controls.Add(this.logoLabel, 0, 0);
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.RowCount = 5;
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.leftPanel.Size = new System.Drawing.Size(215, 565);
            this.leftPanel.TabIndex = 9;
            // 
            // timerBtn
            // 
            this.timerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timerBtn.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.timerBtn.Location = new System.Drawing.Point(3, 183);
            this.timerBtn.Name = "timerBtn";
            this.timerBtn.Size = new System.Drawing.Size(209, 44);
            this.timerBtn.TabIndex = 102;
            this.timerBtn.Text = "Timer";
            this.timerBtn.UseVisualStyleBackColor = true;
            this.timerBtn.Click += new System.EventHandler(this.TimerBtn_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.visualPanel);
            this.Controls.Add(this.logoPanel);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "BaseForm";
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button accountBtn;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel visualPanel;
        private System.Windows.Forms.Button remindersBtn;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.TableLayoutPanel leftPanel;
        private System.Windows.Forms.Button timerBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}


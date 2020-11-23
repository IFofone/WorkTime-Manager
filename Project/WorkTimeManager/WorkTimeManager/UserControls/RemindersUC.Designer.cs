namespace WorkTimeManager
{
    partial class RemindersUc
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
            this.addReminderBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.currentFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.doneFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.removeBtn = new System.Windows.Forms.Button();
            this.remindersCLB = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // addReminderBtn
            // 
            this.addReminderBtn.Location = new System.Drawing.Point(31, 25);
            this.addReminderBtn.Name = "addReminderBtn";
            this.addReminderBtn.Size = new System.Drawing.Size(75, 23);
            this.addReminderBtn.TabIndex = 0;
            this.addReminderBtn.Text = "Add";
            this.addReminderBtn.UseVisualStyleBackColor = true;
            this.addReminderBtn.Click += new System.EventHandler(this.AddReminderBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(123, 25);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // currentFLP
            // 
            this.currentFLP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.currentFLP.AutoScroll = true;
            this.currentFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.currentFLP.Location = new System.Drawing.Point(31, 54);
            this.currentFLP.Name = "currentFLP";
            this.currentFLP.Size = new System.Drawing.Size(271, 368);
            this.currentFLP.TabIndex = 3;
            this.currentFLP.WrapContents = false;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(549, 25);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Clear History";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Visible = false;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // doneFLP
            // 
            this.doneFLP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.doneFLP.AutoScroll = true;
            this.doneFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.doneFLP.Location = new System.Drawing.Point(340, 54);
            this.doneFLP.Name = "doneFLP";
            this.doneFLP.Size = new System.Drawing.Size(284, 368);
            this.doneFLP.TabIndex = 5;
            this.doneFLP.WrapContents = false;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(227, 25);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Visible = false;
            this.removeBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // remindersCLB
            // 
            this.remindersCLB.CheckOnClick = true;
            this.remindersCLB.FormattingEnabled = true;
            this.remindersCLB.HorizontalScrollbar = true;
            this.remindersCLB.Location = new System.Drawing.Point(123, 45);
            this.remindersCLB.Name = "remindersCLB";
            this.remindersCLB.ScrollAlwaysVisible = true;
            this.remindersCLB.Size = new System.Drawing.Size(179, 184);
            this.remindersCLB.TabIndex = 4;
            this.remindersCLB.Visible = false;
            // 
            // RemindersUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.remindersCLB);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.doneFLP);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.currentFLP);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addReminderBtn);
            this.Name = "RemindersUc";
            this.Size = new System.Drawing.Size(655, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addReminderBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.FlowLayoutPanel currentFLP;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.FlowLayoutPanel doneFLP;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.CheckedListBox remindersCLB;
    }
}

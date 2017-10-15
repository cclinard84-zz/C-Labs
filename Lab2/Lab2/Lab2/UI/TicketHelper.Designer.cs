namespace Lab2
{
    partial class TicketHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketHelper));
            this.labelSpeed = new System.Windows.Forms.Label();
            this.checkBoxVisitor = new System.Windows.Forms.CheckBox();
            this.checkBoxFaculty = new System.Windows.Forms.CheckBox();
            this.checkBoxStudent = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.checkBoxSenior = new System.Windows.Forms.CheckBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelTicketAmount = new System.Windows.Forms.Label();
            this.labelTotalTicketAmount = new System.Windows.Forms.Label();
            this.buttonAppeal = new System.Windows.Forms.Button();
            this.maskedTextBoxSpeed = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxEvening = new System.Windows.Forms.CheckBox();
            this.buttonTicketHistory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumTickets = new System.Windows.Forms.Label();
            this.labelTotalTicketsByDate = new System.Windows.Forms.Label();
            this.labelTicketCountByDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(-3, 111);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(80, 25);
            this.labelSpeed.TabIndex = 1;
            this.labelSpeed.Text = "Speed:";
            // 
            // checkBoxVisitor
            // 
            this.checkBoxVisitor.AutoSize = true;
            this.checkBoxVisitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxVisitor.Location = new System.Drawing.Point(201, 175);
            this.checkBoxVisitor.Name = "checkBoxVisitor";
            this.checkBoxVisitor.Size = new System.Drawing.Size(104, 29);
            this.checkBoxVisitor.TabIndex = 2;
            this.checkBoxVisitor.Text = "Visitor";
            this.checkBoxVisitor.UseVisualStyleBackColor = true;
            this.checkBoxVisitor.CheckedChanged += new System.EventHandler(this.checkBoxVisitor_CheckedChanged);
            // 
            // checkBoxFaculty
            // 
            this.checkBoxFaculty.AutoSize = true;
            this.checkBoxFaculty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxFaculty.Location = new System.Drawing.Point(201, 210);
            this.checkBoxFaculty.Name = "checkBoxFaculty";
            this.checkBoxFaculty.Size = new System.Drawing.Size(189, 29);
            this.checkBoxFaculty.TabIndex = 3;
            this.checkBoxFaculty.Text = "Faculty or Staff";
            this.checkBoxFaculty.UseVisualStyleBackColor = true;
            this.checkBoxFaculty.CheckedChanged += new System.EventHandler(this.checkBoxFaculty_CheckedChanged);
            // 
            // checkBoxStudent
            // 
            this.checkBoxStudent.AutoSize = true;
            this.checkBoxStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxStudent.Location = new System.Drawing.Point(201, 245);
            this.checkBoxStudent.Name = "checkBoxStudent";
            this.checkBoxStudent.Size = new System.Drawing.Size(118, 29);
            this.checkBoxStudent.TabIndex = 4;
            this.checkBoxStudent.Text = "Student";
            this.checkBoxStudent.UseVisualStyleBackColor = true;
            this.checkBoxStudent.CheckedChanged += new System.EventHandler(this.checkBoxStudent_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(83, 57);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(299, 31);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 62);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(63, 25);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Date:";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // checkBoxSenior
            // 
            this.checkBoxSenior.AutoSize = true;
            this.checkBoxSenior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSenior.Location = new System.Drawing.Point(225, 280);
            this.checkBoxSenior.Name = "checkBoxSenior";
            this.checkBoxSenior.Size = new System.Drawing.Size(106, 29);
            this.checkBoxSenior.TabIndex = 9;
            this.checkBoxSenior.Text = "Senior";
            this.checkBoxSenior.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Location = new System.Drawing.Point(225, 340);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(119, 40);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculate.Location = new System.Drawing.Point(83, 340);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(119, 40);
            this.buttonCalculate.TabIndex = 11;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Location = new System.Drawing.Point(550, 447);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(119, 40);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelTicketAmount
            // 
            this.labelTicketAmount.AutoSize = true;
            this.labelTicketAmount.Location = new System.Drawing.Point(78, 403);
            this.labelTicketAmount.Name = "labelTicketAmount";
            this.labelTicketAmount.Size = new System.Drawing.Size(173, 25);
            this.labelTicketAmount.TabIndex = 13;
            this.labelTicketAmount.Text = "Ticket Amount: $";
            // 
            // labelTotalTicketAmount
            // 
            this.labelTotalTicketAmount.AutoSize = true;
            this.labelTotalTicketAmount.Location = new System.Drawing.Point(258, 402);
            this.labelTotalTicketAmount.Name = "labelTotalTicketAmount";
            this.labelTotalTicketAmount.Size = new System.Drawing.Size(0, 25);
            this.labelTotalTicketAmount.TabIndex = 14;
            // 
            // buttonAppeal
            // 
            this.buttonAppeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAppeal.Location = new System.Drawing.Point(83, 435);
            this.buttonAppeal.Name = "buttonAppeal";
            this.buttonAppeal.Size = new System.Drawing.Size(142, 82);
            this.buttonAppeal.TabIndex = 15;
            this.buttonAppeal.Text = "Appeal";
            this.buttonAppeal.UseVisualStyleBackColor = true;
            this.buttonAppeal.Click += new System.EventHandler(this.buttonAppeal_Click);
            // 
            // maskedTextBoxSpeed
            // 
            this.maskedTextBoxSpeed.Location = new System.Drawing.Point(83, 108);
            this.maskedTextBoxSpeed.Mask = "000";
            this.maskedTextBoxSpeed.Name = "maskedTextBoxSpeed";
            this.maskedTextBoxSpeed.Size = new System.Drawing.Size(43, 31);
            this.maskedTextBoxSpeed.TabIndex = 16;
            // 
            // checkBoxEvening
            // 
            this.checkBoxEvening.AutoSize = true;
            this.checkBoxEvening.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxEvening.Location = new System.Drawing.Point(201, 109);
            this.checkBoxEvening.Name = "checkBoxEvening";
            this.checkBoxEvening.Size = new System.Drawing.Size(122, 29);
            this.checkBoxEvening.TabIndex = 17;
            this.checkBoxEvening.Text = "Evening";
            this.checkBoxEvening.UseVisualStyleBackColor = true;
            // 
            // buttonTicketHistory
            // 
            this.buttonTicketHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTicketHistory.Location = new System.Drawing.Point(536, 33);
            this.buttonTicketHistory.Name = "buttonTicketHistory";
            this.buttonTicketHistory.Size = new System.Drawing.Size(142, 82);
            this.buttonTicketHistory.TabIndex = 18;
            this.buttonTicketHistory.Text = "Ticket History";
            this.buttonTicketHistory.UseVisualStyleBackColor = true;
            this.buttonTicketHistory.Click += new System.EventHandler(this.buttonTicketHistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Total Tickets:";
            // 
            // labelNumTickets
            // 
            this.labelNumTickets.AutoSize = true;
            this.labelNumTickets.Location = new System.Drawing.Point(599, 340);
            this.labelNumTickets.Name = "labelNumTickets";
            this.labelNumTickets.Size = new System.Drawing.Size(0, 25);
            this.labelNumTickets.TabIndex = 20;
            // 
            // labelTotalTicketsByDate
            // 
            this.labelTotalTicketsByDate.AutoSize = true;
            this.labelTotalTicketsByDate.Location = new System.Drawing.Point(376, 297);
            this.labelTotalTicketsByDate.Name = "labelTotalTicketsByDate";
            this.labelTotalTicketsByDate.Size = new System.Drawing.Size(223, 25);
            this.labelTotalTicketsByDate.TabIndex = 21;
            this.labelTotalTicketsByDate.Text = "Total Tickets By Date:";
            // 
            // labelTicketCountByDate
            // 
            this.labelTicketCountByDate.AutoSize = true;
            this.labelTicketCountByDate.Location = new System.Drawing.Point(599, 297);
            this.labelTicketCountByDate.Name = "labelTicketCountByDate";
            this.labelTicketCountByDate.Size = new System.Drawing.Size(0, 25);
            this.labelTicketCountByDate.TabIndex = 22;
            // 
            // TicketHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(703, 529);
            this.Controls.Add(this.labelTicketCountByDate);
            this.Controls.Add(this.labelTotalTicketsByDate);
            this.Controls.Add(this.labelNumTickets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTicketHistory);
            this.Controls.Add(this.checkBoxEvening);
            this.Controls.Add(this.maskedTextBoxSpeed);
            this.Controls.Add(this.buttonAppeal);
            this.Controls.Add(this.labelTotalTicketAmount);
            this.Controls.Add(this.labelTicketAmount);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.checkBoxSenior);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.checkBoxStudent);
            this.Controls.Add(this.checkBoxFaculty);
            this.Controls.Add(this.checkBoxVisitor);
            this.Controls.Add(this.labelSpeed);
            this.Name = "TicketHelper";
            this.Text = "Ticket Helper";
            this.Shown += new System.EventHandler(this.TicketHelper_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.CheckBox checkBoxVisitor;
        private System.Windows.Forms.CheckBox checkBoxFaculty;
        private System.Windows.Forms.CheckBox checkBoxStudent;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.CheckBox checkBoxSenior;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelTicketAmount;
        private System.Windows.Forms.Label labelTotalTicketAmount;
        private System.Windows.Forms.Button buttonAppeal;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSpeed;
        private System.Windows.Forms.CheckBox checkBoxEvening;
        private System.Windows.Forms.Button buttonTicketHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumTickets;
        private System.Windows.Forms.Label labelTotalTicketsByDate;
        private System.Windows.Forms.Label labelTicketCountByDate;
    }
}


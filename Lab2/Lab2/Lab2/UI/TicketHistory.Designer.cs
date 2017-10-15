namespace Lab2.UI
{
    partial class TicketHistory
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
            this.listViewTicketHistory = new System.Windows.Forms.ListView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewTicketHistory
            // 
            this.listViewTicketHistory.BackColor = System.Drawing.SystemColors.Control;
            this.listViewTicketHistory.Location = new System.Drawing.Point(12, 45);
            this.listViewTicketHistory.Name = "listViewTicketHistory";
            this.listViewTicketHistory.Size = new System.Drawing.Size(738, 383);
            this.listViewTicketHistory.TabIndex = 0;
            this.listViewTicketHistory.UseCompatibleStateImageBehavior = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 461);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(123, 57);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // TicketHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(762, 547);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listViewTicketHistory);
            this.Name = "TicketHistory";
            this.Text = "TicketHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewTicketHistory;
        private System.Windows.Forms.Button buttonBack;
    }
}
namespace coffeeApp.UI
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddFlavor = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a flavoring not on the list";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(329, 234);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(129, 61);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAddFlavor
            // 
            this.buttonAddFlavor.Location = new System.Drawing.Point(102, 234);
            this.buttonAddFlavor.Name = "buttonAddFlavor";
            this.buttonAddFlavor.Size = new System.Drawing.Size(125, 61);
            this.buttonAddFlavor.TabIndex = 2;
            this.buttonAddFlavor.Text = "Add Flavor";
            this.buttonAddFlavor.UseVisualStyleBackColor = true;
            this.buttonAddFlavor.Click += new System.EventHandler(this.button2_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(102, 144);
            this.maskedTextBox1.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(356, 31);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 331);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.buttonAddFlavor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "Add Coffee Flavor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddFlavor;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}
namespace coffeeApp
{
    partial class Beans
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCoffeeFlavorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coffeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.countToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxCoffeeFlavors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxAddFlavors = new System.Windows.Forms.GroupBox();
            this.listBoxSyrupFlavors = new System.Windows.Forms.ListBox();
            this.groupBoxSizes = new System.Windows.Forms.GroupBox();
            this.radioButtonExtraLarge = new System.Windows.Forms.RadioButton();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxOrderName = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxQuantity = new System.Windows.Forms.ComboBox();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.columnHeaderDrink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSyrupFlavor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.buttonCompleteOrder = new System.Windows.Forms.Button();
            this.buttonClearOrder = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBoxAddFlavors.SuspendLayout();
            this.groupBoxSizes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addCoffeeFlavorsToolStripMenuItem,
            this.coffeeListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1154, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.clearToolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(179, 38);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // clearToolStripMenuItem2
            // 
            this.clearToolStripMenuItem2.Name = "clearToolStripMenuItem2";
            this.clearToolStripMenuItem2.Size = new System.Drawing.Size(179, 38);
            this.clearToolStripMenuItem2.Text = "Clear";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // addCoffeeFlavorsToolStripMenuItem
            // 
            this.addCoffeeFlavorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.addCoffeeFlavorsToolStripMenuItem.Name = "addCoffeeFlavorsToolStripMenuItem";
            this.addCoffeeFlavorsToolStripMenuItem.Size = new System.Drawing.Size(179, 38);
            this.addCoffeeFlavorsToolStripMenuItem.Text = "Coffee Flavors";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(200, 38);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // coffeeListToolStripMenuItem
            // 
            this.coffeeListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem1,
            this.countToolStripMenuItem});
            this.coffeeListToolStripMenuItem.Name = "coffeeListToolStripMenuItem";
            this.coffeeListToolStripMenuItem.Size = new System.Drawing.Size(140, 36);
            this.coffeeListToolStripMenuItem.Text = "Coffee List";
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(179, 38);
            this.clearToolStripMenuItem1.Text = "Clear";
            // 
            // countToolStripMenuItem
            // 
            this.countToolStripMenuItem.Name = "countToolStripMenuItem";
            this.countToolStripMenuItem.Size = new System.Drawing.Size(179, 38);
            this.countToolStripMenuItem.Text = "Count";
            this.countToolStripMenuItem.Click += new System.EventHandler(this.countToolStripMenuItem_Click);
            // 
            // comboBoxCoffeeFlavors
            // 
            this.comboBoxCoffeeFlavors.FormattingEnabled = true;
            this.comboBoxCoffeeFlavors.Location = new System.Drawing.Point(21, 87);
            this.comboBoxCoffeeFlavors.Name = "comboBoxCoffeeFlavors";
            this.comboBoxCoffeeFlavors.Size = new System.Drawing.Size(189, 33);
            this.comboBoxCoffeeFlavors.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coffee Flavors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Syrup Flavors";
            // 
            // groupBoxAddFlavors
            // 
            this.groupBoxAddFlavors.Controls.Add(this.listBoxSyrupFlavors);
            this.groupBoxAddFlavors.Controls.Add(this.comboBoxCoffeeFlavors);
            this.groupBoxAddFlavors.Controls.Add(this.label2);
            this.groupBoxAddFlavors.Controls.Add(this.label1);
            this.groupBoxAddFlavors.Location = new System.Drawing.Point(21, 59);
            this.groupBoxAddFlavors.Name = "groupBoxAddFlavors";
            this.groupBoxAddFlavors.Size = new System.Drawing.Size(260, 300);
            this.groupBoxAddFlavors.TabIndex = 5;
            this.groupBoxAddFlavors.TabStop = false;
            this.groupBoxAddFlavors.Text = "Add Flavors";
            // 
            // listBoxSyrupFlavors
            // 
            this.listBoxSyrupFlavors.FormattingEnabled = true;
            this.listBoxSyrupFlavors.ItemHeight = 25;
            this.listBoxSyrupFlavors.Location = new System.Drawing.Point(21, 201);
            this.listBoxSyrupFlavors.Name = "listBoxSyrupFlavors";
            this.listBoxSyrupFlavors.Size = new System.Drawing.Size(189, 54);
            this.listBoxSyrupFlavors.TabIndex = 5;
            // 
            // groupBoxSizes
            // 
            this.groupBoxSizes.Controls.Add(this.radioButtonExtraLarge);
            this.groupBoxSizes.Controls.Add(this.radioButtonLarge);
            this.groupBoxSizes.Controls.Add(this.radioButtonMedium);
            this.groupBoxSizes.Controls.Add(this.radioButtonSmall);
            this.groupBoxSizes.Location = new System.Drawing.Point(21, 365);
            this.groupBoxSizes.Name = "groupBoxSizes";
            this.groupBoxSizes.Size = new System.Drawing.Size(262, 255);
            this.groupBoxSizes.TabIndex = 6;
            this.groupBoxSizes.TabStop = false;
            this.groupBoxSizes.Text = "Coffee Sizes";
            // 
            // radioButtonExtraLarge
            // 
            this.radioButtonExtraLarge.AutoSize = true;
            this.radioButtonExtraLarge.Location = new System.Drawing.Point(24, 201);
            this.radioButtonExtraLarge.Name = "radioButtonExtraLarge";
            this.radioButtonExtraLarge.Size = new System.Drawing.Size(227, 29);
            this.radioButtonExtraLarge.TabIndex = 3;
            this.radioButtonExtraLarge.TabStop = true;
            this.radioButtonExtraLarge.Text = "Extra Large - $3.00";
            this.radioButtonExtraLarge.UseVisualStyleBackColor = true;
            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.Location = new System.Drawing.Point(24, 147);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(171, 29);
            this.radioButtonLarge.TabIndex = 2;
            this.radioButtonLarge.TabStop = true;
            this.radioButtonLarge.Text = "Large - $2.50";
            this.radioButtonLarge.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(24, 97);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(192, 29);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Medium - $1.50";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.AutoSize = true;
            this.radioButtonSmall.Location = new System.Drawing.Point(24, 45);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(169, 29);
            this.radioButtonSmall.TabIndex = 0;
            this.radioButtonSmall.TabStop = true;
            this.radioButtonSmall.Text = "Small - $1.00";
            this.radioButtonSmall.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.maskedTextBoxOrderName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxQuantity);
            this.groupBox1.Location = new System.Drawing.Point(288, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 300);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Order Name";
            // 
            // maskedTextBoxOrderName
            // 
            this.maskedTextBoxOrderName.Location = new System.Drawing.Point(19, 201);
            this.maskedTextBoxOrderName.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.maskedTextBoxOrderName.Name = "maskedTextBoxOrderName";
            this.maskedTextBoxOrderName.Size = new System.Drawing.Size(221, 31);
            this.maskedTextBoxOrderName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quantity";
            // 
            // comboBoxQuantity
            // 
            this.comboBoxQuantity.FormattingEnabled = true;
            this.comboBoxQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxQuantity.Location = new System.Drawing.Point(19, 87);
            this.comboBoxQuantity.Name = "comboBoxQuantity";
            this.comboBoxQuantity.Size = new System.Drawing.Size(165, 33);
            this.comboBoxQuantity.TabIndex = 0;
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDrink,
            this.columnHeaderSyrupFlavor,
            this.columnHeaderQuantity,
            this.columnHeaderPrice});
            this.listViewOrder.Location = new System.Drawing.Point(587, 59);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(545, 380);
            this.listViewOrder.TabIndex = 8;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeaderDrink
            // 
            this.columnHeaderDrink.Text = "Drink";
            this.columnHeaderDrink.Width = 85;
            // 
            // columnHeaderSyrupFlavor
            // 
            this.columnHeaderSyrupFlavor.Text = "Syrup Flavor";
            this.columnHeaderSyrupFlavor.Width = 75;
            // 
            // columnHeaderQuantity
            // 
            this.columnHeaderQuantity.Text = "Quantity";
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.Width = 65;
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.Location = new System.Drawing.Point(353, 396);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(175, 56);
            this.buttonAddToOrder.TabIndex = 9;
            this.buttonAddToOrder.Text = "Add To Order";
            this.buttonAddToOrder.UseVisualStyleBackColor = true;
            this.buttonAddToOrder.Click += new System.EventHandler(this.buttonAddToOrder_Click);
            // 
            // buttonCompleteOrder
            // 
            this.buttonCompleteOrder.Location = new System.Drawing.Point(353, 472);
            this.buttonCompleteOrder.Name = "buttonCompleteOrder";
            this.buttonCompleteOrder.Size = new System.Drawing.Size(175, 56);
            this.buttonCompleteOrder.TabIndex = 10;
            this.buttonCompleteOrder.Text = "Complete Order";
            this.buttonCompleteOrder.UseVisualStyleBackColor = true;
            this.buttonCompleteOrder.Click += new System.EventHandler(this.buttonCompleteOrder_Click);
            // 
            // buttonClearOrder
            // 
            this.buttonClearOrder.Location = new System.Drawing.Point(353, 552);
            this.buttonClearOrder.Name = "buttonClearOrder";
            this.buttonClearOrder.Size = new System.Drawing.Size(175, 56);
            this.buttonClearOrder.TabIndex = 11;
            this.buttonClearOrder.Text = "Clear Order";
            this.buttonClearOrder.UseVisualStyleBackColor = true;
            this.buttonClearOrder.Click += new System.EventHandler(this.buttonClearOrder_Click);
            // 
            // Beans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 619);
            this.Controls.Add(this.buttonClearOrder);
            this.Controls.Add(this.buttonCompleteOrder);
            this.Controls.Add(this.buttonAddToOrder);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSizes);
            this.Controls.Add(this.groupBoxAddFlavors);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Beans";
            this.Text = " ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxAddFlavors.ResumeLayout(false);
            this.groupBoxAddFlavors.PerformLayout();
            this.groupBoxSizes.ResumeLayout(false);
            this.groupBoxSizes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCoffeeFlavorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coffeeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem countToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxCoffeeFlavors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxAddFlavors;
        private System.Windows.Forms.ListBox listBoxSyrupFlavors;
        private System.Windows.Forms.GroupBox groupBoxSizes;
        private System.Windows.Forms.RadioButton radioButtonExtraLarge;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOrderName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxQuantity;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.Button buttonCompleteOrder;
        private System.Windows.Forms.Button buttonClearOrder;
        private System.Windows.Forms.ColumnHeader columnHeaderDrink;
        private System.Windows.Forms.ColumnHeader columnHeaderSyrupFlavor;
        private System.Windows.Forms.ColumnHeader columnHeaderQuantity;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
    }
}


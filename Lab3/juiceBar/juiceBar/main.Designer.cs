namespace juiceBar
{
    partial class main
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
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesNewRomanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helveticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comicSansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxDrinkPicker = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxQuantity = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxCoolDownRemedy = new System.Windows.Forms.CheckBox();
            this.checkBoxEnergyBoost = new System.Windows.Forms.CheckBox();
            this.checkBoxVitaminPack = new System.Windows.Forms.CheckBox();
            this.groupBoxSizes = new System.Windows.Forms.GroupBox();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.tabControlDrinkType = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioButtonVegetable = new System.Windows.Forms.RadioButton();
            this.radioButtonFruit = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButtonWheatberry = new System.Windows.Forms.RadioButton();
            this.radioButtonBanana = new System.Windows.Forms.RadioButton();
            this.radioButtonStrawberry = new System.Windows.Forms.RadioButton();
            this.radioButtonPomegranate = new System.Windows.Forms.RadioButton();
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.buttonOrderComplete = new System.Windows.Forms.Button();
            this.buttonSummaryReport = new System.Windows.Forms.Button();
            this.groupBoxOrderDetails = new System.Windows.Forms.GroupBox();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.listViewOrderDetails = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.groupBoxDrinkPicker.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxSizes.SuspendLayout();
            this.tabControlDrinkType.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxOrderDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(215, 38);
            this.summaryToolStripMenuItem.Text = "Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(215, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToOrderToolStripMenuItem,
            this.completeOrderToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(67, 38);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToOrderToolStripMenuItem
            // 
            this.addToOrderToolStripMenuItem.Name = "addToOrderToolStripMenuItem";
            this.addToOrderToolStripMenuItem.Size = new System.Drawing.Size(286, 38);
            this.addToOrderToolStripMenuItem.Text = "Add To Order";
            this.addToOrderToolStripMenuItem.Click += new System.EventHandler(this.addToOrderToolStripMenuItem_Click);
            // 
            // completeOrderToolStripMenuItem
            // 
            this.completeOrderToolStripMenuItem.Name = "completeOrderToolStripMenuItem";
            this.completeOrderToolStripMenuItem.Size = new System.Drawing.Size(286, 38);
            this.completeOrderToolStripMenuItem.Text = "Complete Order";
            this.completeOrderToolStripMenuItem.Click += new System.EventHandler(this.completeOrderToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timesNewRomanToolStripMenuItem,
            this.helveticaToolStripMenuItem,
            this.comicSansToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(286, 38);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // timesNewRomanToolStripMenuItem
            // 
            this.timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            this.timesNewRomanToolStripMenuItem.Size = new System.Drawing.Size(313, 38);
            this.timesNewRomanToolStripMenuItem.Text = "Times New Roman";
            this.timesNewRomanToolStripMenuItem.Click += new System.EventHandler(this.timesNewRomanToolStripMenuItem_Click);
            // 
            // helveticaToolStripMenuItem
            // 
            this.helveticaToolStripMenuItem.Name = "helveticaToolStripMenuItem";
            this.helveticaToolStripMenuItem.Size = new System.Drawing.Size(313, 38);
            this.helveticaToolStripMenuItem.Text = "Helvetica";
            this.helveticaToolStripMenuItem.Click += new System.EventHandler(this.helveticaToolStripMenuItem_Click);
            // 
            // comicSansToolStripMenuItem
            // 
            this.comicSansToolStripMenuItem.Name = "comicSansToolStripMenuItem";
            this.comicSansToolStripMenuItem.Size = new System.Drawing.Size(313, 38);
            this.comicSansToolStripMenuItem.Text = "Comic Sans";
            this.comicSansToolStripMenuItem.Click += new System.EventHandler(this.comicSansToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueToolStripMenuItem,
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(286, 38);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.blueToolStripMenuItem.Text = "White";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.redToolStripMenuItem.Text = "Blue";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.greenToolStripMenuItem.Text = "Pink";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(179, 38);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBoxDrinkPicker
            // 
            this.groupBoxDrinkPicker.Controls.Add(this.maskedTextBoxQuantity);
            this.groupBoxDrinkPicker.Controls.Add(this.groupBox1);
            this.groupBoxDrinkPicker.Controls.Add(this.groupBoxSizes);
            this.groupBoxDrinkPicker.Controls.Add(this.labelQuantity);
            this.groupBoxDrinkPicker.Controls.Add(this.tabControlDrinkType);
            this.groupBoxDrinkPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDrinkPicker.Location = new System.Drawing.Point(12, 43);
            this.groupBoxDrinkPicker.Name = "groupBoxDrinkPicker";
            this.groupBoxDrinkPicker.Size = new System.Drawing.Size(542, 476);
            this.groupBoxDrinkPicker.TabIndex = 2;
            this.groupBoxDrinkPicker.TabStop = false;
            this.groupBoxDrinkPicker.Text = "Drink Picker";
            // 
            // maskedTextBoxQuantity
            // 
            this.maskedTextBoxQuantity.Location = new System.Drawing.Point(472, 411);
            this.maskedTextBoxQuantity.Mask = "000";
            this.maskedTextBoxQuantity.Name = "maskedTextBoxQuantity";
            this.maskedTextBoxQuantity.Size = new System.Drawing.Size(48, 38);
            this.maskedTextBoxQuantity.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxCoolDownRemedy);
            this.groupBox1.Controls.Add(this.checkBoxEnergyBoost);
            this.groupBox1.Controls.Add(this.checkBoxVitaminPack);
            this.groupBox1.Location = new System.Drawing.Point(352, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 327);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplements - $2.50";
            // 
            // checkBoxCoolDownRemedy
            // 
            this.checkBoxCoolDownRemedy.AutoSize = true;
            this.checkBoxCoolDownRemedy.Location = new System.Drawing.Point(32, 234);
            this.checkBoxCoolDownRemedy.Name = "checkBoxCoolDownRemedy";
            this.checkBoxCoolDownRemedy.Size = new System.Drawing.Size(287, 35);
            this.checkBoxCoolDownRemedy.TabIndex = 2;
            this.checkBoxCoolDownRemedy.Text = "Cool Down Remedy";
            this.checkBoxCoolDownRemedy.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnergyBoost
            // 
            this.checkBoxEnergyBoost.AutoSize = true;
            this.checkBoxEnergyBoost.Location = new System.Drawing.Point(32, 161);
            this.checkBoxEnergyBoost.Name = "checkBoxEnergyBoost";
            this.checkBoxEnergyBoost.Size = new System.Drawing.Size(209, 35);
            this.checkBoxEnergyBoost.TabIndex = 1;
            this.checkBoxEnergyBoost.Text = "Energy Boost";
            this.checkBoxEnergyBoost.UseVisualStyleBackColor = true;
            // 
            // checkBoxVitaminPack
            // 
            this.checkBoxVitaminPack.AutoSize = true;
            this.checkBoxVitaminPack.Location = new System.Drawing.Point(32, 89);
            this.checkBoxVitaminPack.Name = "checkBoxVitaminPack";
            this.checkBoxVitaminPack.Size = new System.Drawing.Size(204, 35);
            this.checkBoxVitaminPack.TabIndex = 0;
            this.checkBoxVitaminPack.Text = "Vitamin Pack";
            this.checkBoxVitaminPack.UseVisualStyleBackColor = true;
            // 
            // groupBoxSizes
            // 
            this.groupBoxSizes.Controls.Add(this.radioButtonSmall);
            this.groupBoxSizes.Controls.Add(this.radioButtonMedium);
            this.groupBoxSizes.Controls.Add(this.radioButtonLarge);
            this.groupBoxSizes.Location = new System.Drawing.Point(178, 61);
            this.groupBoxSizes.Name = "groupBoxSizes";
            this.groupBoxSizes.Size = new System.Drawing.Size(168, 327);
            this.groupBoxSizes.TabIndex = 3;
            this.groupBoxSizes.TabStop = false;
            this.groupBoxSizes.Text = "Sizes";
            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.AutoSize = true;
            this.radioButtonSmall.Location = new System.Drawing.Point(10, 84);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(203, 35);
            this.radioButtonSmall.TabIndex = 1;
            this.radioButtonSmall.TabStop = true;
            this.radioButtonSmall.Text = "Small - $3.00";
            this.radioButtonSmall.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(10, 156);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(231, 35);
            this.radioButtonMedium.TabIndex = 2;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Medium - $3.50";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.Location = new System.Drawing.Point(10, 229);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(205, 35);
            this.radioButtonLarge.TabIndex = 3;
            this.radioButtonLarge.TabStop = true;
            this.radioButtonLarge.Text = "Large - $4.00";
            this.radioButtonLarge.UseVisualStyleBackColor = true;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(346, 414);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(116, 31);
            this.labelQuantity.TabIndex = 10;
            this.labelQuantity.Text = "Quantity";
            // 
            // tabControlDrinkType
            // 
            this.tabControlDrinkType.Controls.Add(this.tabPage1);
            this.tabControlDrinkType.Controls.Add(this.tabPage2);
            this.tabControlDrinkType.Location = new System.Drawing.Point(22, 51);
            this.tabControlDrinkType.Name = "tabControlDrinkType";
            this.tabControlDrinkType.SelectedIndex = 0;
            this.tabControlDrinkType.Size = new System.Drawing.Size(148, 337);
            this.tabControlDrinkType.TabIndex = 0;
            this.tabControlDrinkType.SelectedIndexChanged += new System.EventHandler(this.tabControlDrinkType_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radioButtonVegetable);
            this.tabPage1.Controls.Add(this.radioButtonFruit);
            this.tabPage1.Location = new System.Drawing.Point(8, 45);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(132, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Juice";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButtonVegetable
            // 
            this.radioButtonVegetable.AutoSize = true;
            this.radioButtonVegetable.Location = new System.Drawing.Point(28, 121);
            this.radioButtonVegetable.Name = "radioButtonVegetable";
            this.radioButtonVegetable.Size = new System.Drawing.Size(167, 35);
            this.radioButtonVegetable.TabIndex = 1;
            this.radioButtonVegetable.TabStop = true;
            this.radioButtonVegetable.Text = "Vegetable";
            this.radioButtonVegetable.UseVisualStyleBackColor = true;
            // 
            // radioButtonFruit
            // 
            this.radioButtonFruit.AutoSize = true;
            this.radioButtonFruit.Location = new System.Drawing.Point(28, 49);
            this.radioButtonFruit.Name = "radioButtonFruit";
            this.radioButtonFruit.Size = new System.Drawing.Size(100, 35);
            this.radioButtonFruit.TabIndex = 0;
            this.radioButtonFruit.TabStop = true;
            this.radioButtonFruit.Text = "Fruit";
            this.radioButtonFruit.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioButtonWheatberry);
            this.tabPage2.Controls.Add(this.radioButtonBanana);
            this.tabPage2.Controls.Add(this.radioButtonStrawberry);
            this.tabPage2.Controls.Add(this.radioButtonPomegranate);
            this.tabPage2.Location = new System.Drawing.Point(8, 45);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(132, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Smoothie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioButtonWheatberry
            // 
            this.radioButtonWheatberry.AutoSize = true;
            this.radioButtonWheatberry.Location = new System.Drawing.Point(26, 265);
            this.radioButtonWheatberry.Name = "radioButtonWheatberry";
            this.radioButtonWheatberry.Size = new System.Drawing.Size(195, 35);
            this.radioButtonWheatberry.TabIndex = 3;
            this.radioButtonWheatberry.TabStop = true;
            this.radioButtonWheatberry.Text = "Wheat Berry";
            this.radioButtonWheatberry.UseVisualStyleBackColor = true;
            // 
            // radioButtonBanana
            // 
            this.radioButtonBanana.AutoSize = true;
            this.radioButtonBanana.Location = new System.Drawing.Point(26, 189);
            this.radioButtonBanana.Name = "radioButtonBanana";
            this.radioButtonBanana.Size = new System.Drawing.Size(138, 35);
            this.radioButtonBanana.TabIndex = 2;
            this.radioButtonBanana.TabStop = true;
            this.radioButtonBanana.Text = "Banana";
            this.radioButtonBanana.UseVisualStyleBackColor = true;
            // 
            // radioButtonStrawberry
            // 
            this.radioButtonStrawberry.AutoSize = true;
            this.radioButtonStrawberry.Location = new System.Drawing.Point(26, 116);
            this.radioButtonStrawberry.Name = "radioButtonStrawberry";
            this.radioButtonStrawberry.Size = new System.Drawing.Size(177, 35);
            this.radioButtonStrawberry.TabIndex = 1;
            this.radioButtonStrawberry.TabStop = true;
            this.radioButtonStrawberry.Text = "Strawberry";
            this.radioButtonStrawberry.UseVisualStyleBackColor = true;
            // 
            // radioButtonPomegranate
            // 
            this.radioButtonPomegranate.AutoSize = true;
            this.radioButtonPomegranate.Location = new System.Drawing.Point(26, 48);
            this.radioButtonPomegranate.Name = "radioButtonPomegranate";
            this.radioButtonPomegranate.Size = new System.Drawing.Size(207, 35);
            this.radioButtonPomegranate.TabIndex = 0;
            this.radioButtonPomegranate.TabStop = true;
            this.radioButtonPomegranate.Text = "Pomegranate";
            this.radioButtonPomegranate.UseVisualStyleBackColor = true;
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToOrder.Location = new System.Drawing.Point(374, 525);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(180, 66);
            this.buttonAddToOrder.TabIndex = 3;
            this.buttonAddToOrder.Text = "Add to Order";
            this.buttonAddToOrder.UseVisualStyleBackColor = true;
            this.buttonAddToOrder.Click += new System.EventHandler(this.buttonAddToOrder_Click);
            // 
            // buttonOrderComplete
            // 
            this.buttonOrderComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderComplete.Location = new System.Drawing.Point(674, 525);
            this.buttonOrderComplete.Name = "buttonOrderComplete";
            this.buttonOrderComplete.Size = new System.Drawing.Size(218, 66);
            this.buttonOrderComplete.TabIndex = 4;
            this.buttonOrderComplete.Text = "Order Complete ";
            this.buttonOrderComplete.UseVisualStyleBackColor = true;
            this.buttonOrderComplete.Click += new System.EventHandler(this.buttonOrderComplete_Click);
            // 
            // buttonSummaryReport
            // 
            this.buttonSummaryReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSummaryReport.Location = new System.Drawing.Point(34, 525);
            this.buttonSummaryReport.Name = "buttonSummaryReport";
            this.buttonSummaryReport.Size = new System.Drawing.Size(226, 66);
            this.buttonSummaryReport.TabIndex = 5;
            this.buttonSummaryReport.Text = "Summary Report";
            this.buttonSummaryReport.UseVisualStyleBackColor = true;
            this.buttonSummaryReport.Click += new System.EventHandler(this.buttonSummaryReport_Click);
            // 
            // groupBoxOrderDetails
            // 
            this.groupBoxOrderDetails.Controls.Add(this.labelTotalCost);
            this.groupBoxOrderDetails.Controls.Add(this.labelTotal);
            this.groupBoxOrderDetails.Controls.Add(this.listViewOrderDetails);
            this.groupBoxOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOrderDetails.Location = new System.Drawing.Point(560, 43);
            this.groupBoxOrderDetails.Name = "groupBoxOrderDetails";
            this.groupBoxOrderDetails.Size = new System.Drawing.Size(352, 476);
            this.groupBoxOrderDetails.TabIndex = 6;
            this.groupBoxOrderDetails.TabStop = false;
            this.groupBoxOrderDetails.Text = "Order Details";
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Location = new System.Drawing.Point(256, 421);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(86, 31);
            this.labelTotalCost.TabIndex = 2;
            this.labelTotalCost.Text = "label1";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(146, 421);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(105, 31);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Total: $";
            // 
            // listViewOrderDetails
            // 
            this.listViewOrderDetails.Location = new System.Drawing.Point(16, 51);
            this.listViewOrderDetails.Name = "listViewOrderDetails";
            this.listViewOrderDetails.Size = new System.Drawing.Size(314, 337);
            this.listViewOrderDetails.TabIndex = 0;
            this.listViewOrderDetails.UseCompatibleStateImageBehavior = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 598);
            this.Controls.Add(this.groupBoxOrderDetails);
            this.Controls.Add(this.buttonSummaryReport);
            this.Controls.Add(this.buttonOrderComplete);
            this.Controls.Add(this.buttonAddToOrder);
            this.Controls.Add(this.groupBoxDrinkPicker);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "Drink Order Application";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxDrinkPicker.ResumeLayout(false);
            this.groupBoxDrinkPicker.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSizes.ResumeLayout(false);
            this.groupBoxSizes.PerformLayout();
            this.tabControlDrinkType.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxOrderDetails.ResumeLayout(false);
            this.groupBoxOrderDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxDrinkPicker;
        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.TabControl tabControlDrinkType;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton radioButtonVegetable;
        private System.Windows.Forms.RadioButton radioButtonFruit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton radioButtonWheatberry;
        private System.Windows.Forms.RadioButton radioButtonBanana;
        private System.Windows.Forms.RadioButton radioButtonStrawberry;
        private System.Windows.Forms.RadioButton radioButtonPomegranate;
        private System.Windows.Forms.Button buttonOrderComplete;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helveticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comicSansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button buttonSummaryReport;
        private System.Windows.Forms.GroupBox groupBoxOrderDetails;
        private System.Windows.Forms.ListView listViewOrderDetails;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxSizes;
        private System.Windows.Forms.CheckBox checkBoxCoolDownRemedy;
        private System.Windows.Forms.CheckBox checkBoxEnergyBoost;
        private System.Windows.Forms.CheckBox checkBoxVitaminPack;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxQuantity;
        private System.Windows.Forms.Label labelTotalCost;
    }
}


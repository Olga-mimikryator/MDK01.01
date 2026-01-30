namespace LR3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderButton = new System.Windows.Forms.Button();
            this.quantityFoodNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.foodByTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.foodTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.myOrderRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.foodPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.expirationDateLabel = new System.Windows.Forms.Label();
            this.manufacturerFoodLabel = new System.Windows.Forms.Label();
            this.supplierFoodLabel = new System.Windows.Forms.Label();
            this.priceFoodLabel = new System.Windows.Forms.Label();
            this.foodNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityFoodNumericUpDown)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.orderButton);
            this.panel1.Controls.Add(this.quantityFoodNumericUpDown);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.foodByTypeComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.foodTypeComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 111);
            this.panel1.TabIndex = 0;
            // 
            // orderButton
            // 
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderButton.Location = new System.Drawing.Point(543, 55);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(113, 33);
            this.orderButton.TabIndex = 5;
            this.orderButton.Text = "Заказать";
            this.orderButton.UseVisualStyleBackColor = true;
            // 
            // quantityFoodNumericUpDown
            // 
            this.quantityFoodNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityFoodNumericUpDown.Location = new System.Drawing.Point(470, 57);
            this.quantityFoodNumericUpDown.Name = "quantityFoodNumericUpDown";
            this.quantityFoodNumericUpDown.Size = new System.Drawing.Size(48, 29);
            this.quantityFoodNumericUpDown.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(242, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Продукты";
            // 
            // foodByTypeComboBox
            // 
            this.foodByTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foodByTypeComboBox.FormattingEnabled = true;
            this.foodByTypeComboBox.Location = new System.Drawing.Point(246, 55);
            this.foodByTypeComboBox.Name = "foodByTypeComboBox";
            this.foodByTypeComboBox.Size = new System.Drawing.Size(208, 33);
            this.foodByTypeComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Группа продуктов";
            // 
            // foodTypeComboBox
            // 
            this.foodTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foodTypeComboBox.FormattingEnabled = true;
            this.foodTypeComboBox.Location = new System.Drawing.Point(19, 55);
            this.foodTypeComboBox.Name = "foodTypeComboBox";
            this.foodTypeComboBox.Size = new System.Drawing.Size(208, 33);
            this.foodTypeComboBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Мой заказ:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.myOrderRichTextBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 346);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(668, 218);
            this.panel3.TabIndex = 3;
            // 
            // myOrderRichTextBox
            // 
            this.myOrderRichTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.myOrderRichTextBox.Location = new System.Drawing.Point(0, 30);
            this.myOrderRichTextBox.Name = "myOrderRichTextBox";
            this.myOrderRichTextBox.Size = new System.Drawing.Size(668, 188);
            this.myOrderRichTextBox.TabIndex = 4;
            this.myOrderRichTextBox.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.expirationDateLabel);
            this.panel2.Controls.Add(this.manufacturerFoodLabel);
            this.panel2.Controls.Add(this.supplierFoodLabel);
            this.panel2.Controls.Add(this.priceFoodLabel);
            this.panel2.Controls.Add(this.foodNameLabel);
            this.panel2.Controls.Add(this.foodPhotoPictureBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 235);
            this.panel2.TabIndex = 4;
            // 
            // foodPhotoPictureBox
            // 
            this.foodPhotoPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.foodPhotoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.foodPhotoPictureBox.Name = "foodPhotoPictureBox";
            this.foodPhotoPictureBox.Size = new System.Drawing.Size(235, 235);
            this.foodPhotoPictureBox.TabIndex = 0;
            this.foodPhotoPictureBox.TabStop = false;
            // 
            // expirationDateLabel
            // 
            this.expirationDateLabel.AutoSize = true;
            this.expirationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expirationDateLabel.Location = new System.Drawing.Point(262, 169);
            this.expirationDateLabel.Name = "expirationDateLabel";
            this.expirationDateLabel.Size = new System.Drawing.Size(60, 24);
            this.expirationDateLabel.TabIndex = 9;
            this.expirationDateLabel.Text = "label3";
            // 
            // manufacturerFoodLabel
            // 
            this.manufacturerFoodLabel.AutoSize = true;
            this.manufacturerFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturerFoodLabel.Location = new System.Drawing.Point(262, 136);
            this.manufacturerFoodLabel.Name = "manufacturerFoodLabel";
            this.manufacturerFoodLabel.Size = new System.Drawing.Size(60, 24);
            this.manufacturerFoodLabel.TabIndex = 8;
            this.manufacturerFoodLabel.Text = "label3";
            // 
            // supplierFoodLabel
            // 
            this.supplierFoodLabel.AutoSize = true;
            this.supplierFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplierFoodLabel.Location = new System.Drawing.Point(262, 101);
            this.supplierFoodLabel.Name = "supplierFoodLabel";
            this.supplierFoodLabel.Size = new System.Drawing.Size(60, 24);
            this.supplierFoodLabel.TabIndex = 7;
            this.supplierFoodLabel.Text = "label3";
            // 
            // priceFoodLabel
            // 
            this.priceFoodLabel.AutoSize = true;
            this.priceFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceFoodLabel.Location = new System.Drawing.Point(262, 66);
            this.priceFoodLabel.Name = "priceFoodLabel";
            this.priceFoodLabel.Size = new System.Drawing.Size(60, 24);
            this.priceFoodLabel.TabIndex = 6;
            this.priceFoodLabel.Text = "label3";
            // 
            // foodNameLabel
            // 
            this.foodNameLabel.AutoSize = true;
            this.foodNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foodNameLabel.Location = new System.Drawing.Point(262, 31);
            this.foodNameLabel.Name = "foodNameLabel";
            this.foodNameLabel.Size = new System.Drawing.Size(60, 24);
            this.foodNameLabel.TabIndex = 5;
            this.foodNameLabel.Text = "label3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Заказ продуктов";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityFoodNumericUpDown)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox foodTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox foodByTypeComboBox;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.NumericUpDown quantityFoodNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox myOrderRichTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label expirationDateLabel;
        private System.Windows.Forms.Label manufacturerFoodLabel;
        private System.Windows.Forms.Label supplierFoodLabel;
        private System.Windows.Forms.Label priceFoodLabel;
        private System.Windows.Forms.Label foodNameLabel;
        private System.Windows.Forms.PictureBox foodPhotoPictureBox;
    }
}


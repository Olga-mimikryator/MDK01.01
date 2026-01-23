namespace WinFormConstructElements
{
    partial class ManyForm
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
            this.StudentList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numberLabel = new System.Windows.Forms.Label();
            this.argBallLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.StudentPhoto = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentList
            // 
            this.StudentList.Dock = System.Windows.Forms.DockStyle.Left;
            this.StudentList.FormattingEnabled = true;
            this.StudentList.Location = new System.Drawing.Point(0, 0);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(250, 450);
            this.StudentList.TabIndex = 2;
            this.StudentList.SelectedIndexChanged += new System.EventHandler(this.StudentList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numberLabel);
            this.panel1.Controls.Add(this.argBallLabel);
            this.panel1.Controls.Add(this.ageLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.StudentPhoto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 450);
            this.panel1.TabIndex = 3;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(235, 128);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(60, 24);
            this.numberLabel.TabIndex = 6;
            this.numberLabel.Text = "label3";
            // 
            // argBallLabel
            // 
            this.argBallLabel.AutoSize = true;
            this.argBallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.argBallLabel.Location = new System.Drawing.Point(235, 176);
            this.argBallLabel.Name = "argBallLabel";
            this.argBallLabel.Size = new System.Drawing.Size(60, 24);
            this.argBallLabel.TabIndex = 5;
            this.argBallLabel.Text = "label4";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.Location = new System.Drawing.Point(235, 83);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(60, 24);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "label2";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(235, 39);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(60, 24);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "label1";
            // 
            // StudentPhoto
            // 
            this.StudentPhoto.Location = new System.Drawing.Point(25, 12);
            this.StudentPhoto.Name = "StudentPhoto";
            this.StudentPhoto.Size = new System.Drawing.Size(172, 224);
            this.StudentPhoto.TabIndex = 2;
            this.StudentPhoto.TabStop = false;
            // 
            // ManyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StudentList);
            this.Name = "ManyForm";
            this.Text = "Информация о студентах";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox StudentList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox StudentPhoto;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label argBallLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}


namespace Calculator
{
    partial class Form1
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
            this.PlusButton = new System.Windows.Forms.Button();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.MinusButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.FullClearButton = new System.Windows.Forms.Button();
            this.pointButton = new System.Windows.Forms.Button();
            this.powButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlusButton
            // 
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusButton.Location = new System.Drawing.Point(309, 221);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(75, 75);
            this.PlusButton.TabIndex = 0;
            this.PlusButton.Tag = "1";
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // mainTextBox
            // 
            this.mainTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.mainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTextBox.Location = new System.Drawing.Point(26, 12);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ReadOnly = true;
            this.mainTextBox.Size = new System.Drawing.Size(550, 34);
            this.mainTextBox.TabIndex = 1;
            // 
            // MinusButton
            // 
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusButton.Location = new System.Drawing.Point(309, 302);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(75, 75);
            this.MinusButton.TabIndex = 1;
            this.MinusButton.Tag = "2";
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SixButton.Location = new System.Drawing.Point(189, 221);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(75, 75);
            this.SixButton.TabIndex = 3;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.DigitClick);
            // 
            // FiveButton
            // 
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiveButton.Location = new System.Drawing.Point(108, 221);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(75, 75);
            this.FiveButton.TabIndex = 4;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.DigitClick);
            // 
            // FourButton
            // 
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FourButton.Location = new System.Drawing.Point(27, 221);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(75, 75);
            this.FourButton.TabIndex = 5;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.DigitClick);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThreeButton.Location = new System.Drawing.Point(189, 302);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(75, 75);
            this.ThreeButton.TabIndex = 6;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.DigitClick);
            // 
            // TwoButton
            // 
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TwoButton.Location = new System.Drawing.Point(108, 302);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(75, 75);
            this.TwoButton.TabIndex = 7;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.DigitClick);
            // 
            // OneButton
            // 
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OneButton.Location = new System.Drawing.Point(27, 302);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(75, 75);
            this.OneButton.TabIndex = 8;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.DigitClick);
            // 
            // NineButton
            // 
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NineButton.Location = new System.Drawing.Point(189, 140);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(75, 75);
            this.NineButton.TabIndex = 9;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.DigitClick);
            // 
            // EightButton
            // 
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EightButton.Location = new System.Drawing.Point(108, 140);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(75, 75);
            this.EightButton.TabIndex = 10;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.DigitClick);
            // 
            // SevenButton
            // 
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SevenButton.Location = new System.Drawing.Point(27, 140);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(75, 75);
            this.SevenButton.TabIndex = 11;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.DigitClick);
            // 
            // divisionButton
            // 
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divisionButton.Location = new System.Drawing.Point(390, 302);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(75, 75);
            this.divisionButton.TabIndex = 12;
            this.divisionButton.Tag = "4";
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplyButton.Location = new System.Drawing.Point(390, 221);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 75);
            this.multiplyButton.TabIndex = 13;
            this.multiplyButton.Tag = "3";
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqualButton.Location = new System.Drawing.Point(501, 221);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(75, 156);
            this.EqualButton.TabIndex = 14;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZeroButton.Location = new System.Drawing.Point(27, 59);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(114, 75);
            this.ZeroButton.TabIndex = 15;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.DigitClick);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(501, 59);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 75);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "<<<";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // FullClearButton
            // 
            this.FullClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullClearButton.Location = new System.Drawing.Point(309, 59);
            this.FullClearButton.Name = "FullClearButton";
            this.FullClearButton.Size = new System.Drawing.Size(156, 75);
            this.FullClearButton.TabIndex = 17;
            this.FullClearButton.Text = "Clear";
            this.FullClearButton.UseVisualStyleBackColor = true;
            this.FullClearButton.Click += new System.EventHandler(this.FullClearButton_Click);
            // 
            // pointButton
            // 
            this.pointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointButton.Location = new System.Drawing.Point(147, 59);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(117, 75);
            this.pointButton.TabIndex = 18;
            this.pointButton.Text = ",";
            this.pointButton.UseVisualStyleBackColor = true;
            this.pointButton.Click += new System.EventHandler(this.pointButton_Click);
            // 
            // powButton
            // 
            this.powButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.powButton.Location = new System.Drawing.Point(309, 140);
            this.powButton.Name = "powButton";
            this.powButton.Size = new System.Drawing.Size(75, 75);
            this.powButton.TabIndex = 19;
            this.powButton.Tag = "5";
            this.powButton.Text = "^";
            this.powButton.UseVisualStyleBackColor = true;
            this.powButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 392);
            this.Controls.Add(this.powButton);
            this.Controls.Add(this.pointButton);
            this.Controls.Add(this.FullClearButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.PlusButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button FullClearButton;
        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.Button powButton;
    }
}


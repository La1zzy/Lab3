namespace Lab3._1
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
            this.components = new System.ComponentModel.Container();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LastName = new System.Windows.Forms.TextBox();
            this.BirthYear = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MonthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Day = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MonthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(372, 204);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 20);
            this.FirstName.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(372, 230);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 20);
            this.LastName.TabIndex = 2;
            // 
            // BirthYear
            // 
            this.BirthYear.Location = new System.Drawing.Point(372, 256);
            this.BirthYear.Name = "BirthYear";
            this.BirthYear.Size = new System.Drawing.Size(100, 20);
            this.BirthYear.TabIndex = 3;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(372, 282);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 20);
            this.Email.TabIndex = 4;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(568, 267);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(250, 205);
            this.OutputTextBox.TabIndex = 5;
            this.OutputTextBox.Text = "";
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(373, 449);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 6;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(354, 406);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(65, 17);
            this.MaleRadioButton.TabIndex = 7;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Чоловік";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(416, 406);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(56, 17);
            this.FemaleRadioButton.TabIndex = 8;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Жінка";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MonthNumericUpDown
            // 
            this.MonthNumericUpDown.Location = new System.Drawing.Point(422, 358);
            this.MonthNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.MonthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MonthNumericUpDown.Name = "MonthNumericUpDown";
            this.MonthNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.MonthNumericUpDown.TabIndex = 9;
            this.MonthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DayNumericUpDown
            // 
            this.DayNumericUpDown.Location = new System.Drawing.Point(422, 327);
            this.DayNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.DayNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DayNumericUpDown.Name = "DayNumericUpDown";
            this.DayNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.DayNumericUpDown.TabIndex = 10;
            this.DayNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Location = new System.Drawing.Point(369, 334);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(34, 13);
            this.Day.TabIndex = 11;
            this.Day.Text = "День";
            // 
            // Month
            // 
            this.Month.AutoSize = true;
            this.Month.Location = new System.Drawing.Point(369, 360);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(42, 13);
            this.Month.TabIndex = 12;
            this.Month.Text = "Місяць";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ім\'я";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Фамілія";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Рік народження";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Пошта";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 529);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.DayNumericUpDown);
            this.Controls.Add(this.MonthNumericUpDown);
            this.Controls.Add(this.FemaleRadioButton);
            this.Controls.Add(this.MaleRadioButton);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.BirthYear);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MonthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox BirthYear;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.NumericUpDown MonthNumericUpDown;
        private System.Windows.Forms.NumericUpDown DayNumericUpDown;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Label Month;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


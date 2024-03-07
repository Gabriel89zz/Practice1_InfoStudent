namespace Practice1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            txtLastName = new TextBox();
            label2 = new Label();
            txtMotherLastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            label5 = new Label();
            txtCarrer = new TextBox();
            label6 = new Label();
            dtBirthDate = new DateTimePicker();
            label7 = new Label();
            nudAverage = new NumericUpDown();
            button1 = new Button();
            lblInfoStudent = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAverage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 36);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(45, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(162, 29);
            txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(307, 60);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(126, 29);
            txtLastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(307, 36);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 2;
            label2.Text = "Last Name:";
            // 
            // txtMotherLastName
            // 
            txtMotherLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMotherLastName.Location = new Point(545, 60);
            txtMotherLastName.Name = "txtMotherLastName";
            txtMotherLastName.Size = new Size(126, 29);
            txtMotherLastName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(543, 36);
            label3.Name = "label3";
            label3.Size = new Size(149, 21);
            label3.TabIndex = 4;
            label3.Text = "Mothers Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(45, 140);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 6;
            label4.Text = "Birth Date:";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(307, 164);
            txtId.Name = "txtId";
            txtId.Size = new Size(126, 29);
            txtId.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(307, 140);
            label5.Name = "label5";
            label5.Size = new Size(26, 21);
            label5.TabIndex = 8;
            label5.Text = "Id:";
            // 
            // txtCarrer
            // 
            txtCarrer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCarrer.Location = new Point(543, 164);
            txtCarrer.Name = "txtCarrer";
            txtCarrer.Size = new Size(126, 29);
            txtCarrer.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(543, 140);
            label6.Name = "label6";
            label6.Size = new Size(57, 21);
            label6.TabIndex = 10;
            label6.Text = "Carrer:";
            // 
            // dtBirthDate
            // 
            dtBirthDate.Format = DateTimePickerFormat.Short;
            dtBirthDate.Location = new Point(45, 166);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(82, 23);
            dtBirthDate.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(45, 246);
            label7.Name = "label7";
            label7.Size = new Size(70, 21);
            label7.TabIndex = 13;
            label7.Text = "Average:";
            // 
            // nudAverage
            // 
            nudAverage.Location = new Point(45, 270);
            nudAverage.Name = "nudAverage";
            nudAverage.Size = new Size(120, 23);
            nudAverage.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(232, 258);
            button1.Name = "button1";
            button1.Size = new Size(101, 42);
            button1.TabIndex = 15;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblInfoStudent
            // 
            lblInfoStudent.AutoSize = true;
            lblInfoStudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoStudent.Location = new Point(45, 345);
            lblInfoStudent.Name = "lblInfoStudent";
            lblInfoStudent.Size = new Size(0, 21);
            lblInfoStudent.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 508);
            Controls.Add(lblInfoStudent);
            Controls.Add(button1);
            Controls.Add(nudAverage);
            Controls.Add(label7);
            Controls.Add(dtBirthDate);
            Controls.Add(txtCarrer);
            Controls.Add(label6);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtMotherLastName);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudAverage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtMotherLastName;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private Label label5;
        private TextBox txtCarrer;
        private Label label6;
        private DateTimePicker dtBirthDate;
        private Label label7;
        private NumericUpDown nudAverage;
        private Button button1;
        private Label lblInfoStudent;
    }
}
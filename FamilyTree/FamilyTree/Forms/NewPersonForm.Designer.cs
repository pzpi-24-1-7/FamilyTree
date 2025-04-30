namespace FamilyTree.Forms
{
    partial class NewPersonForm
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
            label2 = new Label();
            FNBox = new TextBox();
            label3 = new Label();
            LNBox = new TextBox();
            label4 = new Label();
            MNBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            AdressBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            OKButton = new Button();
            button2 = new Button();
            dateTimePicker = new DateTimePicker();
            SexCBox = new ComboBox();
            FatherCBox = new ComboBox();
            MotherCBox = new ComboBox();
            label1 = new Label();
            POBBox = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 33);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 3;
            label2.Text = "First name";
            // 
            // FNBox
            // 
            FNBox.Location = new Point(154, 30);
            FNBox.Name = "FNBox";
            FNBox.Size = new Size(532, 27);
            FNBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 66);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 5;
            label3.Text = "Last name";
            // 
            // LNBox
            // 
            LNBox.Location = new Point(154, 63);
            LNBox.Name = "LNBox";
            LNBox.Size = new Size(532, 27);
            LNBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 99);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 7;
            label4.Text = "Middle name";
            // 
            // MNBox
            // 
            MNBox.Location = new Point(154, 96);
            MNBox.Name = "MNBox";
            MNBox.Size = new Size(532, 27);
            MNBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 132);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 9;
            label5.Text = "Sex";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 163);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 11;
            label6.Text = "Address";
            // 
            // AdressBox
            // 
            AdressBox.Location = new Point(154, 163);
            AdressBox.Name = "AdressBox";
            AdressBox.Size = new Size(532, 27);
            AdressBox.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(331, 132);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 13;
            label7.Text = "DOB";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(95, 233);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 15;
            label8.Text = "Father";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(401, 233);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 17;
            label9.Text = "Mother";
            // 
            // OKButton
            // 
            OKButton.DialogResult = DialogResult.OK;
            OKButton.Location = new Point(224, 281);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(100, 40);
            OKButton.TabIndex = 18;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(401, 281);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 19;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(377, 129);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(309, 27);
            dateTimePicker.TabIndex = 20;
            // 
            // SexCBox
            // 
            SexCBox.FormattingEnabled = true;
            SexCBox.Location = new Point(154, 129);
            SexCBox.Name = "SexCBox";
            SexCBox.Size = new Size(143, 28);
            SexCBox.TabIndex = 21;
            // 
            // FatherCBox
            // 
            FatherCBox.FormattingEnabled = true;
            FatherCBox.Location = new Point(154, 229);
            FatherCBox.Name = "FatherCBox";
            FatherCBox.Size = new Size(220, 28);
            FatherCBox.TabIndex = 22;
            // 
            // MotherCBox
            // 
            MotherCBox.FormattingEnabled = true;
            MotherCBox.Location = new Point(464, 229);
            MotherCBox.Name = "MotherCBox";
            MotherCBox.Size = new Size(220, 28);
            MotherCBox.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 199);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 25;
            label1.Text = "POB";
            // 
            // POBBox
            // 
            POBBox.Location = new Point(154, 196);
            POBBox.Name = "POBBox";
            POBBox.Size = new Size(532, 27);
            POBBox.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(71, 33);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 3;
            label10.Text = "First name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(72, 66);
            label11.Name = "label11";
            label11.Size = new Size(76, 20);
            label11.TabIndex = 5;
            label11.Text = "Last name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(51, 99);
            label12.Name = "label12";
            label12.Size = new Size(97, 20);
            label12.TabIndex = 7;
            label12.Text = "Middle name";
            // 
            // NewPersonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 333);
            Controls.Add(label1);
            Controls.Add(POBBox);
            Controls.Add(MotherCBox);
            Controls.Add(FatherCBox);
            Controls.Add(SexCBox);
            Controls.Add(dateTimePicker);
            Controls.Add(button2);
            Controls.Add(OKButton);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(AdressBox);
            Controls.Add(label5);
            Controls.Add(label12);
            Controls.Add(label4);
            Controls.Add(MNBox);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(LNBox);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(FNBox);
            MaximumSize = new Size(750, 380);
            MinimumSize = new Size(750, 380);
            Name = "NewPersonForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox FNBox;
        private Label label3;
        private TextBox LNBox;
        private Label label4;
        private TextBox MNBox;
        private Label label5;
        private Label label6;
        private TextBox AdressBox;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button OKButton;
        private Button button2;
        private DateTimePicker dateTimePicker;
        private ComboBox SexCBox;
        private ComboBox FatherCBox;
        private ComboBox MotherCBox;
        private Label label1;
        private TextBox POBBox;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}
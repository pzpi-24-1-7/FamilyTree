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
            AddressBox = new TextBox();
            label7 = new Label();
            OKButton = new Button();
            CancelButton1 = new Button();
            dateTimePicker = new DateTimePicker();
            SexCBox = new ComboBox();
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
            //FNBox.Validated += FNBox_Validated;
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
            //LNBox.Validated += LNBox_Validated;
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
            //MNBox.Validated += MNBox_Validated;
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
            // AddressBox
            // 
            AddressBox.Location = new Point(154, 163);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(532, 27);
            AddressBox.TabIndex = 10;
            //AddressBox.Validated += AddressBox_Validated;
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
            // CancelButton1
            // 
            CancelButton1.DialogResult = DialogResult.Cancel;
            CancelButton1.Location = new Point(401, 281);
            CancelButton1.Name = "CancelButton1";
            CancelButton1.Size = new Size(100, 40);
            CancelButton1.TabIndex = 19;
            CancelButton1.Text = "Cancel";
            CancelButton1.UseVisualStyleBackColor = true;
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
            //POBBox.Validated += POBBox_Validated;
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
            Controls.Add(SexCBox);
            Controls.Add(dateTimePicker);
            Controls.Add(CancelButton1);
            Controls.Add(OKButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(AddressBox);
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
            Text = "Add new person";
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
        private TextBox AddressBox;
        private Label label7;
        private Button OKButton;
        private Button CancelButton1;
        private DateTimePicker dateTimePicker;
        private ComboBox SexCBox;
        private Label label1;
        private TextBox POBBox;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}
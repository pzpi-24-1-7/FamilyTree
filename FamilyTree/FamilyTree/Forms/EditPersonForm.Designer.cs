namespace FamilyTree.Forms
{
    partial class EditPersonForm
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
            label1 = new Label();
            POBBox = new TextBox();
            SexCBox = new ComboBox();
            dateTimePicker = new DateTimePicker();
            button2 = new Button();
            OKButton = new Button();
            label7 = new Label();
            label6 = new Label();
            AddressBox = new TextBox();
            label5 = new Label();
            label12 = new Label();
            MNBox = new TextBox();
            label11 = new Label();
            LNBox = new TextBox();
            label10 = new Label();
            FNBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 199);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 45;
            label1.Text = "POB";
            // 
            // POBBox
            // 
            POBBox.Location = new Point(145, 196);
            POBBox.Name = "POBBox";
            POBBox.Size = new Size(532, 27);
            POBBox.TabIndex = 44;
            POBBox.Validated += POBBox_Validating;
            // 
            // SexCBox
            // 
            SexCBox.FormattingEnabled = true;
            SexCBox.Location = new Point(145, 129);
            SexCBox.Name = "SexCBox";
            SexCBox.Size = new Size(143, 28);
            SexCBox.TabIndex = 41;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(368, 129);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(309, 27);
            dateTimePicker.TabIndex = 40;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(392, 281);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 39;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            OKButton.DialogResult = DialogResult.OK;
            OKButton.Location = new Point(215, 281);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(100, 40);
            OKButton.TabIndex = 38;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            OKButton.DialogResult = DialogResult.None;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(322, 132);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 35;
            label7.Text = "DOB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 163);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 34;
            label6.Text = "Address";
            // 
            // AddressBox
            // 
            AddressBox.Location = new Point(145, 163);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(532, 27);
            AddressBox.TabIndex = 33;
            AddressBox.Validated += AddressBox_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 132);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 32;
            label5.Text = "Sex";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(42, 99);
            label12.Name = "label12";
            label12.Size = new Size(97, 20);
            label12.TabIndex = 31;
            label12.Text = "Middle name";
            // 
            // MNBox
            // 
            MNBox.Location = new Point(145, 96);
            MNBox.Name = "MNBox";
            MNBox.Size = new Size(532, 27);
            MNBox.TabIndex = 30;
            MNBox.Validated += MNBox_Validating;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(63, 66);
            label11.Name = "label11";
            label11.Size = new Size(76, 20);
            label11.TabIndex = 29;
            label11.Text = "Last name";
            // 
            // LNBox
            // 
            LNBox.Location = new Point(145, 63);
            LNBox.Name = "LNBox";
            LNBox.Size = new Size(532, 27);
            LNBox.TabIndex = 28;
            LNBox.Validated += LNBox_Validating;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(62, 33);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 27;
            label10.Text = "First name";
            // 
            // FNBox
            // 
            FNBox.Location = new Point(145, 30);
            FNBox.Name = "FNBox";
            FNBox.Size = new Size(532, 27);
            FNBox.TabIndex = 26;
            FNBox.Validated += FNBox_Validating;
            // 
            // EditPersonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 333);
            Controls.Add(label1);
            Controls.Add(POBBox);
            Controls.Add(SexCBox);
            Controls.Add(dateTimePicker);
            Controls.Add(button2);
            Controls.Add(OKButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(AddressBox);
            Controls.Add(label5);
            Controls.Add(label12);
            Controls.Add(MNBox);
            Controls.Add(label11);
            Controls.Add(LNBox);
            Controls.Add(label10);
            Controls.Add(FNBox);
            MaximumSize = new Size(750, 380);
            MinimumSize = new Size(750, 380);
            Name = "EditPersonForm";
            Text = "Edit person";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox POBBox;
        private ComboBox SexCBox;
        private DateTimePicker dateTimePicker;
        private Button button2;
        private Button OKButton;
        private Label label7;
        private Label label6;
        private TextBox AddressBox;
        private Label label5;
        private Label label12;
        private TextBox MNBox;
        private Label label11;
        private TextBox LNBox;
        private Label label10;
        private TextBox FNBox;
    }
}
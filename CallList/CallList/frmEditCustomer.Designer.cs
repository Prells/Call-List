namespace CallList
{
    partial class frmEditCustomer
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
            btnSubmit = new Button();
            btnCancel = new Button();
            lblName = new Label();
            lblNumber = new Label();
            txtName = new TextBox();
            txtNumber = new TextBox();
            lblItemHeld = new Label();
            txtItemHeld = new TextBox();
            lblDateCalled = new Label();
            txtDateCalled = new TextBox();
            lblDatePickedUp = new Label();
            txtDatePickedUp = new TextBox();
            richTextBox1 = new RichTextBox();
            lblNotes = new Label();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(158, 298);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(283, 298);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(102, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(53, 43);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(88, 15);
            lblNumber.TabIndex = 3;
            lblNumber.Text = "Phone Number";
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 4;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(158, 40);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 5;
            // 
            // lblItemHeld
            // 
            lblItemHeld.AutoSize = true;
            lblItemHeld.Location = new Point(82, 81);
            lblItemHeld.Name = "lblItemHeld";
            lblItemHeld.Size = new Size(59, 15);
            lblItemHeld.TabIndex = 6;
            lblItemHeld.Text = "Item Held";
            // 
            // txtItemHeld
            // 
            txtItemHeld.Location = new Point(158, 78);
            txtItemHeld.Name = "txtItemHeld";
            txtItemHeld.Size = new Size(100, 23);
            txtItemHeld.TabIndex = 7;
            // 
            // lblDateCalled
            // 
            lblDateCalled.AutoSize = true;
            lblDateCalled.Location = new Point(74, 119);
            lblDateCalled.Name = "lblDateCalled";
            lblDateCalled.Size = new Size(67, 15);
            lblDateCalled.TabIndex = 8;
            lblDateCalled.Text = "Date Called";
            // 
            // txtDateCalled
            // 
            txtDateCalled.Location = new Point(158, 116);
            txtDateCalled.Name = "txtDateCalled";
            txtDateCalled.Size = new Size(100, 23);
            txtDateCalled.TabIndex = 9;
            // 
            // lblDatePickedUp
            // 
            lblDatePickedUp.AutoSize = true;
            lblDatePickedUp.Location = new Point(54, 157);
            lblDatePickedUp.Name = "lblDatePickedUp";
            lblDatePickedUp.Size = new Size(87, 15);
            lblDatePickedUp.TabIndex = 10;
            lblDatePickedUp.Text = "Date Picked Up";
            // 
            // txtDatePickedUp
            // 
            txtDatePickedUp.Location = new Point(158, 154);
            txtDatePickedUp.Name = "txtDatePickedUp";
            txtDatePickedUp.Size = new Size(100, 23);
            txtDatePickedUp.TabIndex = 11;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(158, 183);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(200, 99);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(103, 186);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(38, 15);
            lblNotes.TabIndex = 13;
            lblNotes.Text = "Notes";
            // 
            // frmEditCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 333);
            Controls.Add(lblNotes);
            Controls.Add(richTextBox1);
            Controls.Add(txtDatePickedUp);
            Controls.Add(lblDatePickedUp);
            Controls.Add(txtDateCalled);
            Controls.Add(lblDateCalled);
            Controls.Add(txtItemHeld);
            Controls.Add(lblItemHeld);
            Controls.Add(txtNumber);
            Controls.Add(txtName);
            Controls.Add(lblNumber);
            Controls.Add(lblName);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Name = "frmEditCustomer";
            Text = "frmEditCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Button btnCancel;
        private Label lblName;
        private Label lblNumber;
        private TextBox txtName;
        private TextBox txtNumber;
        private Label lblItemHeld;
        private TextBox txtItemHeld;
        private Label lblDateCalled;
        private TextBox txtDateCalled;
        private Label lblDatePickedUp;
        private TextBox txtDatePickedUp;
        private RichTextBox richTextBox1;
        private Label lblNotes;
    }
}
namespace CallList
{
    partial class frmAddCustomer
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
            lblName = new Label();
            txtName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblSets = new Label();
            lblNotes = new Label();
            richNotes = new RichTextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            lstSets = new ListBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(101, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(126, 23);
            txtName.TabIndex = 1;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(12, 40);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(91, 15);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone Number:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(101, 37);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(126, 23);
            txtPhone.TabIndex = 3;
            // 
            // lblSets
            // 
            lblSets.AutoSize = true;
            lblSets.Location = new Point(16, 79);
            lblSets.Name = "lblSets";
            lblSets.Size = new Size(31, 15);
            lblSets.TabIndex = 5;
            lblSets.Text = "Sets:";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(6, 194);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(41, 15);
            lblNotes.TabIndex = 6;
            lblNotes.Text = "Notes:";
            // 
            // richNotes
            // 
            richNotes.Location = new Point(101, 194);
            richNotes.Name = "richNotes";
            richNotes.Size = new Size(245, 96);
            richNotes.TabIndex = 8;
            richNotes.Text = "";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(101, 321);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(210, 321);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lstSets
            // 
            lstSets.FormattingEnabled = true;
            lstSets.ItemHeight = 15;
            lstSets.Location = new Point(101, 79);
            lstSets.Name = "lstSets";
            lstSets.SelectionMode = SelectionMode.MultiSimple;
            lstSets.Size = new Size(120, 94);
            lstSets.TabIndex = 11;
            // 
            // frmAddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 500);
            Controls.Add(lstSets);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(richNotes);
            Controls.Add(lblNotes);
            Controls.Add(lblSets);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "frmAddCustomer";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblSets;
        private Label lblNotes;
        private RichTextBox richNotes;
        private Button btnSubmit;
        private Button btnCancel;
        private ListBox lstSets;
    }
}

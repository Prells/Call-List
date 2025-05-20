namespace CallList
{
    partial class frmCreateList
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
            lblListName = new Label();
            txtListName = new TextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblListName
            // 
            lblListName.AutoSize = true;
            lblListName.Location = new Point(64, 55);
            lblListName.Name = "lblListName";
            lblListName.Size = new Size(42, 15);
            lblListName.TabIndex = 0;
            lblListName.Text = "Name:";
            // 
            // txtListName
            // 
            txtListName.Location = new Point(112, 52);
            txtListName.Name = "txtListName";
            txtListName.Size = new Size(116, 23);
            txtListName.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(64, 93);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(166, 93);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCreateList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 154);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txtListName);
            Controls.Add(lblListName);
            Name = "frmCreateList";
            Text = "frmCreateList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListName;
        private TextBox txtListName;
        private Button btnSubmit;
        private Button btnCancel;
    }
}
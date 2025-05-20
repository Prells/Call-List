namespace CallList
{
    partial class frmViewLists
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
            btnCreateNewList = new Button();
            lstPokemon = new ListBox();
            btnClose = new Button();
            btnOpen = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // btnCreateNewList
            // 
            btnCreateNewList.Location = new Point(12, 164);
            btnCreateNewList.Name = "btnCreateNewList";
            btnCreateNewList.Size = new Size(111, 23);
            btnCreateNewList.TabIndex = 0;
            btnCreateNewList.Text = "Create New List";
            btnCreateNewList.UseVisualStyleBackColor = true;
            btnCreateNewList.Click += btnCreateNewList_Click;
            // 
            // lstPokemon
            // 
            lstPokemon.FormattingEnabled = true;
            lstPokemon.ItemHeight = 15;
            lstPokemon.Location = new Point(12, 12);
            lstPokemon.Name = "lstPokemon";
            lstPokemon.Size = new Size(239, 139);
            lstPokemon.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(291, 164);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(129, 164);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(210, 164);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmViewLists
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 205);
            Controls.Add(btnDelete);
            Controls.Add(btnOpen);
            Controls.Add(btnClose);
            Controls.Add(lstPokemon);
            Controls.Add(btnCreateNewList);
            Name = "frmViewLists";
            Text = "frmViewLists";
            Load += frmViewLists_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateNewList;
        private ListBox lstPokemon;
        private Button btnClose;
        private Button btnOpen;
        private Button btnDelete;
    }
}
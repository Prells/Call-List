using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallList
{
    public partial class frmCreateList : Form
    {
        public frmCreateList()
        {
            InitializeComponent();            
        }

        public CallList GetCallList()
        {
            this.Text = "Create List";
            this.ShowDialog();
            return customerList;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private CallList customerList;
        private string name;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(IsValidData())
            {                
                name = txtListName.Text;
                customerList = new CallList(name);
            }
            this.Close();
        }

        public string GetName()
        {
            return name;
        }
        

        private bool IsValidData()
        {
            bool isValid = true;

            string errorMessage = "";
            errorMessage += Validator.IsPresent(txtListName.Text, "List Name");

            if (errorMessage != "")
            {
                isValid = false;
                MessageBox.Show(errorMessage, "Enter a List Name");
            }
            return isValid;
        }

    }
}

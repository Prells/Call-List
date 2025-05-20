namespace CallList
{
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();           
        }

        public frmAddCustomer(List<CallList> lists)
        {
            InitializeComponent();
            this.Text = "Add Customer";
            foreach (CallList list in lists)
            {
                lstSets.Items.Add(list.SetName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Customer? c = null;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(lstSets.SelectedItems.Count == 0) {
                MessageBox.Show("Must select at least 1 set");
                return;
            }
            if(txtName.Text.Length == 0)
            {
                MessageBox.Show("Enter a name");
                return;
            }
            if(txtPhone.Text.Length == 0)
            {
                MessageBox.Show("Enter a phone number");
                return;
            }
            
            List<String> selectedSets = new List<String>();
            for(int i = 0; i < lstSets.SelectedItems.Count; i++)
            {
                selectedSets.Add(lstSets.SelectedItems[i].ToString());
            }
            c = new()
            {
                name = txtName.Text,
                phoneNumber = txtPhone.Text,
                sets = selectedSets,
                itemHeld = "",
                datePickedUp = "",
                dateCalled = "",
                itemPickedUp = "",
                notes = richNotes.Text,
                
            };
            this.Close();
        }

        public Customer GetCustomer() {            
            this.ShowDialog();
            return c;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallList
{
    public partial class frmViewLists : Form
    {
        public frmViewLists()
        {
            InitializeComponent();
            this.Text = "Call Lists";
        }

        private List<CallList> lists = null!;

        private void frmViewLists_Load(object sender, EventArgs e)
        {
            lists = CustomerDB.LoadLists();
            FillList();
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer addCustomer = new(lists);
            Customer c = addCustomer.GetCustomer();
            if(c == null)
            {
                return;
            }           
            foreach(string s in c.sets)
            {
                for(int i = 0; i < lists.Count; i++)
                {
                   if(s.Equals(lists[i].SetName))
                   {
                     lists[i].GetList.Add(c);
                   }
                }
            }
        }        

        private void btnCreateNewList_Click(object sender, EventArgs e)
        {
            frmCreateList frmCreateList = new frmCreateList();
            CallList list = frmCreateList.GetCallList();
            if (list != null)
            {
                lists.Add(list);
                FillList();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CustomerDB.SaveLists(lists);
            this.Close();
        }

        private void FillList()
        {
            lstPokemon.Items.Clear();
            foreach (CallList list in lists)
            {
                lstPokemon.Items.Add(list.SetName);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (lstPokemon.SelectedItems.Count == 0 || lstPokemon.SelectedItems.Count > 1)
            {
                MessageBox.Show("Select only one list");                
                return;
            }
            string name = lstPokemon.SelectedItem.ToString();
            if (name == null)
            {
                MessageBox.Show("No list selected");
                return;
            }
            foreach (CallList list in lists)
            {
                if (list.SetName == name)
                {   
                    lists.Remove(list);
                    frmCustomerLists frmCustomerLists = new frmCustomerLists(list);
                    CallList newList = frmCustomerLists.GetCallList();                    
                    lists.Add(newList);
                    break;
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstPokemon.SelectedIndex;
            List<CallList> callList = new List<CallList>();
            if(i == -1)
            {
                MessageBox.Show("Please select an item to delete.", "No item selected");
            }
            else
            {                
                string itemName = lists[i].SetName;
                var selectedList = lists.Where(k => k.SetName.Equals(itemName)).First();
                string message = $"Are you sure you want to delete {selectedList.SetName}?";
                DialogResult result = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    lists.Remove(selectedList);                    
                    CustomerDB.SaveLists(lists);
                    FillList();
                }

            }
        }
    }
}

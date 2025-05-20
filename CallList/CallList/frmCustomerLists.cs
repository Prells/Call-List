using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallList
{
    public partial class frmCustomerLists : Form
    {
        private CallList callList;

        public frmCustomerLists(CallList list)
        {
            InitializeComponent();
            callList = list;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            List<Customer> customers = list.GetList;
            this.Text = list.SetName;
            dgvList.Columns.Add("custName", "Name");
            dgvList.Columns.Add("custNumber", "Phone Number");
            dgvList.Columns.Add("custItemHeld", "Item Held");
            dgvList.Columns.Add("custdateCalled", "Date Called");
            dgvList.Columns.Add("custDatePickedUp", "Date Picked Up");
            dgvList.Columns.Add("custNotes", "Notes");

            foreach (Customer customer in customers)
            {
                dgvList.Rows.Add(customer.name, customer.phoneNumber, customer.itemHeld, customer.dateCalled, customer.datePickedUp, customer.notes);
            }

            this.ShowDialog();
        }

        public bool Changed()
        {
            return isEditted;
        }

        private bool isEditted = false;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Customer> customers = [];           
            
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                Customer c = new Customer();
                int count = 0;
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if(cell.Value != null)
                    {
                        switch(count) 
                        {
                            case 0: 
                                c.name = cell.Value.ToString();
                                count++;
                                break;
                            case 1:
                                c.phoneNumber = cell.Value.ToString();
                                count++;
                                break;
                            case 2:
                                c.itemHeld = cell.Value.ToString();
                                count++;
                                break;
                            case 3:
                                c.dateCalled = cell.Value.ToString();
                                count++;
                                break;
                            case 4:
                                c.datePickedUp = cell.Value.ToString();
                                count++;
                                break;
                            case 5:
                                c.notes = cell.Value.ToString();
                                count++;
                                break;
                        }
                    }
                }
                customers.Add(c);
            }
            //save new list of customers
            callList.GetList.Clear();
            callList.GetList = customers;              
            
        }

        public CallList GetCallList()
        {
            return callList;
        }
    }
}

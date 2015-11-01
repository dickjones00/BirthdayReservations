using DataLayer.Model;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervacije.Forms
{
    public partial class frmCustomer : Form
    {
        private CustomerRepository CustomerDB = new CustomerRepository();
        private Customer customer = new Customer();
        private Boolean izmjena = false;

        public frmCustomer(Customer Customer)
        {
            InitializeComponent();
            customer = Customer;
            if (customer != null)
                izmjena = true;
            GetCustomerInfo();
        }

        private void GetCustomerInfo()
        {
            if (izmjena)
            {
                txtIme.Text = customer.Name;
                txtAge.Text = customer.Age.ToString();
                dtpBirthday.Value = customer.BirthdayDate;
                txtContactPerson.Text = customer.ContactPerson;
                txtContactNumber.Text = customer.PhoneNumber;
                txtNote.Text = customer.Note;
            }
            else
            {
                txtIme.Text = "";
                txtAge.Text = "";
                dtpBirthday.Text = "";
                txtContactPerson.Text = "";
                txtContactNumber.Text = "";
                txtNote.Text = "";
            }
        }

        private void btnCancelCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            using (CustomerRepository context = new CustomerRepository())
            {

                var result = context.Context.Customer.SingleOrDefault(b => b.Id == customer.Id);
                if (result != null)
                {
                    result.Name = txtIme.Text;
                    result.Age = int.Parse(txtAge.Text);
                    result.BirthdayDate = dtpBirthday.Value;
                    result.ContactPerson = txtContactPerson.Text;
                    result.PhoneNumber = txtContactNumber.Text;
                    result.Note = txtNote.Text;
                    context.Context.SaveChanges();
                }                
            }
            this.Close();
        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            customer.Age = DateTime.Now.Year - dtpBirthday.Value.Year;
            txtAge.Text = customer.Age.ToString();
        }
    }
}

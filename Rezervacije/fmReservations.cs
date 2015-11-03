using System;
using System.Windows.Forms;
using System.Threading;
using DataLayer.Model;
using DataLayer.Repository;
using System.Threading.Tasks;
using Rezervacije.Forms;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;

namespace Rezervacije
{
    public partial class fmReservations : Form
    {
        public string rowId = "";
        public string rowName = "";
        public string rowWeight = "";
        public string rowPrice = "";
        public bool accontation = false;

        private CakeRepository CakeDB = new CakeRepository();
        private CustomerRepository CustomerDB = new CustomerRepository();
        private OrderRepository OrderDB = new OrderRepository();

        private Customer customer = new Customer();
        private Order order = new Order();

        private Guid rowClicked;
        public fmReservations()
        {
            InitializeComponent();
        }

        private async void fmReservations_Load(object sender, EventArgs e)
        {
            prgLoadTables.Visible = true;
            label9.Visible = true;
            cboPackage.SelectedIndex = 0;
            dtpResDate.Text = DateTime.Today.ToLongDateString();
            var culture = Thread.CurrentThread.CurrentCulture;
            var day = culture.DateTimeFormat.GetDayName(dtpResDate.Value.DayOfWeek);
            lblDateDay.Text = UppercaseFirst(day);

            await RefreshTables();
            label9.Visible = false;
            prgLoadTables.Visible = false;
            FillNameComboBox();

        }

        private void FillNameComboBox()
        {
            //cboName.DataSource = null;
            
            cboName.DataSource = customerBindingSource.DataSource;
            
            cboName.Update();
            cboName.Refresh();
        }

        private async Task RefreshTables()
        {
            var cakeSelect = CakeSelect();
            var customerSelect = CustomerSelect();
            var orderSelect = OrderSelect();
            try
            {
                await Task.WhenAll(cakeSelect, customerSelect, orderSelect);
            }
            catch
            {

            }
        }

        private async Task CakeSelect()
        {
            try
            {
                var cakes = await CakeDB.GetList();
                cakesBindingSource.DataSource = cakes;

                grpAddCake.Visible = false;
                grpDeleteCake.Visible = false;
                grdCakes.DataSource = cakes;
                grdCakes.Update();
                grdCakes.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task CustomerSelect()
        {
            try
            {
                CustomerRepository CustomerDB = new CustomerRepository();
                var customers = await CustomerDB.GetList();
                customerBindingSource.DataSource = customers;

                grpAddCake.Visible = false;
                grpDeleteCake.Visible = false;
                grdCustomer.DataSource = customers;
                grdCustomer.Update();
                grdCustomer.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task OrderSelect()
        {
            try
            {
                var orders = await OrderDB.GetList();
                orderBindingSource.DataSource = orders;

                grpAddCake.Visible = false;
                grpDeleteCake.Visible = false;
                grdOrder.DataSource = orders;
                grdOrder.Update();
                grdOrder.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        private void cboResTimeFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int addedTime = Convert.ToInt32(cboResTimeFrom.Text) + 2;
            cboResTimeTo.Text = addedTime.ToString();
        }

        private void dtpResDate_ValueChanged(object sender, EventArgs e)
        {
            var culture = Thread.CurrentThread.CurrentCulture;
            var day = culture.DateTimeFormat.GetDayName(dtpResDate.Value.DayOfWeek);
            lblDateDay.Text = UppercaseFirst(day);
        }

        private void txtCakeWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private async void btnAddCake_Click(object sender, EventArgs e)
        {
            if (btnAddCake.Text == "Dodaj tortu")
            {
                try
                {
                    
                    string name = txtCakeName.Text;
                    int weight = Convert.ToInt32(txtCakeWeight.Text);
                    decimal price = decimal.Parse(txtCakePrice.Text);

                    var cake = new Cake();
                    cake.Name = txtCakeName.Text;
                    cake.Weight = Convert.ToInt32(txtCakeWeight.Text);
                    cake.Price = decimal.Parse(txtCakePrice.Text);

                    await CakeDB.Insert(cake);
                    CakeDB.Context.SaveChanges();

                    await CakeSelect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (btnAddCake.Text == "Prihvati izmjene")
            {
                try
                {
                    var cake = await CakeDB.Find(Guid.Parse(rowId));
                    
                    cake.Name = txtCakeName.Text;
                    cake.Weight = Convert.ToInt32(txtCakeWeight.Text);
                    cake.Price = decimal.Parse(txtCakePrice.Text);

                    await CakeDB.Update(cake);
                    CakeDB.Context.SaveChanges();

                    await CakeSelect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnShowAddGroup_Click(object sender, EventArgs e)
        {
            btnAddCake.Text = "Dodaj tortu";
            txtCakeName.Text = "";
            txtCakeWeight.Text = "";
            txtCakePrice.Text = "";
            grpDeleteCake.Visible = false;
            grpAddCake.Visible = true;
        }

        private void btnShowDeleteConfirm_Click(object sender, EventArgs e)
        {
            grpAddCake.Visible = false;
            grpDeleteCake.Visible = true;
            label5.Text = "Sigurno želite obrisati odabranu tortu? (ID:" + rowId + ")";
        }

        private void btnCancelAddCake_Click(object sender, EventArgs e)
        {
            grpAddCake.Visible = false;
        }

        private void btnCancelDeleteCake_Click(object sender, EventArgs e)
        {
            grpDeleteCake.Visible = false;
        }

        private async void btnConfirmDeleteCake_Click(object sender, EventArgs e)
        {
            try
            {
                var cake = await CakeDB.Find(Guid.Parse(rowId));
                await CakeDB.Delete(cake);
                CakeDB.Context.SaveChanges();

                await RefreshTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void novaRezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            tabTabs.SelectedIndex = 0;
        }

        private void otvoriRezervacijuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            tabTabs.SelectedIndex = 1;
        }

        private void btnEditCake_Click(object sender, EventArgs e)
        {
            btnAddCake.Text = "Prihvati izmjene";
            grpAddCake.Visible = true;
            grpDeleteCake.Visible = false;
            txtCakeName.Text = rowName;
            txtCakeWeight.Text = rowWeight;
            txtCakePrice.Text = rowPrice;
        }

        private void grdCakes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = this.grdCakes.Rows[e.RowIndex];
            rowId = row.Cells[0].Value.ToString();
            rowName = row.Cells[1].Value.ToString();
            rowWeight = row.Cells[2].Value.ToString();
            rowPrice = row.Cells[3].Value.ToString();
        }

        private void grdCakes_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            grpAddCake.Visible = false;
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                await RefreshTables();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSaveReservation_Click(object sender, EventArgs e)
        {
            try
            {
                var cake = await CakeDB.Find(Guid.Parse(rowId));
                FillCustomerObject();

                if (CheckIfNameAndBirthdayExist(customer.Name, customer.BirthdayDate))
                {
                    var result = MessageBox.Show("Postoji već osoba s tim imenom i datumom rođenja!\nŽelite li svejedno unijeti podatke u bazu?", "Upozorenje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        await CustomerDB.Insert(customer);
                        CustomerDB.Context.SaveChanges();
                        FillOrderObject(cake);

                        await OrderDB.Insert(order);
                        OrderDB.Context.SaveChanges();

                        await RefreshTables();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    await CustomerDB.Insert(customer);
                    CustomerDB.Context.SaveChanges();
                    FillOrderObject(cake);

                    await OrderDB.Insert(order);
                    OrderDB.Context.SaveChanges();

                    await OrderSelect();
                    await CustomerSelect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.InnerException);
            }
        }

        private void FillOrderObject(Cake cake)
        {
            order.CakeName = cake.Name;
            order.CustomerName = customer.Name;
            order.CustomerId = customer.Id;
            order.CakeId = cake.Id;
            order.Accontation = accontation;
            order.Note = txtNote.Text;
            order.OrderDate = DateTime.Parse(dtpResDate.Text);
            order.Package = cboPackage.Text;
            order.TimeSpanFrom = Convert.ToInt32(cboResTimeFrom.Text);
            order.TimeSpanTo = Convert.ToInt32(cboResTimeTo.Text);
        }

        private void FillCustomerObject()
        {
            customer = new Customer();
            customer.Name = cboName.Text;
            customer.Age = DateTime.Now.Year - dtpBirthdayDate.Value.Year;
            customer.BirthdayDate = DateTime.Parse(dtpBirthdayDate.Text);
            customer.ContactPerson = txtContactPerson.Text;
            customer.PhoneNumber = txtPhone.Text;
            customer.Note = txtNote.Text;
        }

        private bool CheckIfNameAndBirthdayExist(string name, DateTime birthday)
        {
            using (var context = new CustomerRepository())
            {
                bool birthdayExists = context.Context.Customer.Any(contact => contact.Name.Equals(cboName.DisplayMember) && contact.BirthdayDate.Equals(dtpBirthdayDate.Value.Date));
                if (birthdayExists)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
        }

        private bool CheckIfCustomerIdExist(Guid guid)
        {
            using (var context = new CustomerRepository())
            {
                bool idExists = context.Context.Customer.Any(contact => contact.Id.Equals(guid));
                if (idExists)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAccontation.Checked)
                accontation = true;
            else
                accontation = false;
        }

        private async void grdCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid id = GetGuidFromCustomer();
            GetCustomerByGuid(id);
            frmCustomer cust = new frmCustomer(customer);
            cust.ShowDialog();
            await CustomerSelect();
        }

        private void GetCustomerByGuid(Guid id)
        {
            using (var context = new CustomerRepository())
            {

                var user = context.Context.Customer.Find(id);
                customer = user;
            }
        }

        private void GetOrderByGuid(Guid orderGuid)
        {
            using (var context = new OrderRepository())
            {

                var foundOrder = context.Context.Order.Find(orderGuid);
                order = foundOrder;
            }
        }

        private void grdCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid id = GetGuidFromCustomer();

            var obj = customerBindingSource.List.OfType<Customer>().ToList().Find(f => f.Id == id); //search object in this case by Id
            //var pos = customerBindingSource.IndexOf(obj);
            //customerBindingSource.Position = pos;
        }

        private Guid GetGuidFromCustomer()
        {
            int rowindex = grdCustomer.CurrentRow.Index;
            int cell = GetColumnIndexByName(grdCustomer, "Id");

            Guid id = new Guid(grdCustomer.Rows[rowindex].Cells[cell].Value.ToString());
            return id;
        }

        private int GetColumnIndexByName(DataGridView grid, string name)
        {
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                if (grid.Columns[i].HeaderText.ToLower().Trim() == name.ToLower().Trim())
                {
                    return i;
                }
            }

            return -1;
        }

        private void cboName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var guidCustomer = new Guid(cboName.SelectedValue.ToString());
                    if (CheckIfCustomerIdExist(guidCustomer))
                    {
                        GetCustomerByGuid(guidCustomer);

                        txtContactPerson.Text = customer.ContactPerson;
                        txtPhone.Text = customer.PhoneNumber;
                        dtpBirthdayDate.Value = customer.BirthdayDate;
                    }
                }
                catch
                {
                    return;
                }
            }
        }

        private async void grdOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid id = GetGuidFromSelectedRow(grdOrder, "Id slavljenika");

            List<Order> orders = await OrderDB.GetList();
            orderBindingSource.DataSource = grdOrder.DataSource;
            List<Order> filteredByCustomerId = new List<Order>(orders.Where(p => p.CustomerId.Equals(id)).ToList());

            grdFilteredOrders.DataSource = filteredByCustomerId;
            grdFilteredOrders.Update();
            grdFilteredOrders.Refresh();
        }

        private Guid GetGuidFromSelectedRow(DataGridView grid, string nameOfIdColumn)
        {
            int rowindex = grid.CurrentRow.Index;
            int cell = GetColumnIndexByName(grid, nameOfIdColumn);
            Guid id = new Guid(grid.Rows[rowindex].Cells[cell].Value.ToString());
            return id;
        }

        private void cboName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboName.SelectedValue != null)
            {
                var guidCustomer = new Guid(cboName.SelectedValue.ToString());
                if (CheckIfCustomerIdExist(guidCustomer))
                {
                    GetCustomerByGuid(guidCustomer);

                    txtContactPerson.Text = customer.ContactPerson;
                    txtPhone.Text = customer.PhoneNumber;
                    dtpBirthdayDate.Value = customer.BirthdayDate;
                }
            }
        }
        private void grdOrder_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            ShowContextMenuOnGrid(sender, e, grdOrder);
        }

        private void grdCustomer_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            ShowContextMenuOnGrid(sender, e, grdCustomer);
        }

        private void ShowContextMenuOnGrid(object sender, DataGridViewCellMouseEventArgs e, DataGridView grid)
        {
            // Ignore if a column or row header is clicked
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];

                    // Here you can do whatever you want with the cell
                    grid.CurrentCell = clickedCell;  // Select the clicked cell, for instance
                    grid.CurrentRow.Selected = true;

                    // Get mouse position relative to the vehicles grid
                    var relativeMousePosition = grdOrder.PointToClient(Cursor.Position);

                    // Show the context menu
                    this.mnuGridOrders.Show(grdOrder, relativeMousePosition);
                }
            }
        }

        private async void smiDelete_Click(object sender, EventArgs e)
        {
            DeleteFromGridById();
            await RefreshTables();
            FillNameComboBox();
        }

        private void DeleteFromGridById()
        {
            Order orderToRemove;
            Customer customerToRemove;
            if (grdOrder.Focused)
            {
                orderToRemove = OrderDB.Context.Order.SingleOrDefault(x => x.Id == rowClicked); //returns a single item.

                if (orderToRemove != null)
                {
                    OrderDB.Context.Order.Remove(orderToRemove);
                    OrderDB.Context.SaveChanges();
                }
            }
            else if (grdCustomer.Focused)
            {
                customerToRemove = CustomerDB.Context.Customer.SingleOrDefault(x => x.Id == rowClicked); //returns a single item.

                if (customerToRemove != null)
                {
                    CustomerDB.Context.Customer.Remove(customerToRemove);
                    CustomerDB.Context.SaveChanges();
                }
            }
        }

        private void grdOrder_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowClicked = GetGuidFromSelectedRow(grdOrder, "Id narudžbe");
        }

        private void grdCustomer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowClicked = GetGuidFromSelectedRow(grdCustomer, "Id");
        }
    }
}

namespace Rezervacije
{
    partial class fmReservations
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
            CakeDB.Dispose();
            CustomerDB.Dispose();
            OrderDB.Dispose();

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmReservations));
            this.lblResDate = new System.Windows.Forms.Label();
            this.dtpResDate = new System.Windows.Forms.DateTimePicker();
            this.lblChildName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novaRezervacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otvoriRezervacijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeZaOvajTjedanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tjedanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mjesecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabTabs = new System.Windows.Forms.TabControl();
            this.tabNewReservation = new System.Windows.Forms.TabPage();
            this.dtpBirthdayDate = new System.Windows.Forms.DateTimePicker();
            this.grdOrder = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CakeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSpanFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSpanToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accontationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdCustomer = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboPackage = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkAccontation = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaveReservation = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEditCake = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowDeleteConfirm = new System.Windows.Forms.Button();
            this.btnShowAddGroup = new System.Windows.Forms.Button();
            this.grdCakes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cakesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboResTimeTo = new System.Windows.Forms.ComboBox();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.cboResTimeFrom = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.lblDo = new System.Windows.Forms.Label();
            this.lblOd = new System.Windows.Forms.Label();
            this.lblDateDay = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblResTime = new System.Windows.Forms.Label();
            this.lblCake = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblContactPerson = new System.Windows.Forms.Label();
            this.grpDeleteCake = new System.Windows.Forms.GroupBox();
            this.btnCancelDeleteCake = new System.Windows.Forms.Button();
            this.btnConfirmDeleteCake = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpAddCake = new System.Windows.Forms.GroupBox();
            this.btnCancelAddCake = new System.Windows.Forms.Button();
            this.btnAddCake = new System.Windows.Forms.Button();
            this.txtCakePrice = new System.Windows.Forms.TextBox();
            this.txtCakeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCakeWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabReservations = new System.Windows.Forms.TabPage();
            this.grdFilteredOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prgLoadTables = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabTabs.SuspendLayout();
            this.tabNewReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCakes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakesBindingSource)).BeginInit();
            this.grpDeleteCake.SuspendLayout();
            this.grpAddCake.SuspendLayout();
            this.tabReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFilteredOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResDate
            // 
            this.lblResDate.AutoSize = true;
            this.lblResDate.Location = new System.Drawing.Point(6, 12);
            this.lblResDate.Name = "lblResDate";
            this.lblResDate.Size = new System.Drawing.Size(92, 13);
            this.lblResDate.TabIndex = 0;
            this.lblResDate.Text = "Datum rezervacije";
            // 
            // dtpResDate
            // 
            this.dtpResDate.Location = new System.Drawing.Point(104, 9);
            this.dtpResDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpResDate.MinDate = new System.DateTime(2015, 7, 2, 0, 0, 0, 0);
            this.dtpResDate.Name = "dtpResDate";
            this.dtpResDate.Size = new System.Drawing.Size(147, 20);
            this.dtpResDate.TabIndex = 0;
            this.dtpResDate.Value = new System.DateTime(2015, 7, 2, 0, 0, 0, 0);
            this.dtpResDate.ValueChanged += new System.EventHandler(this.dtpResDate_ValueChanged);
            // 
            // lblChildName
            // 
            this.lblChildName.AutoSize = true;
            this.lblChildName.Location = new System.Drawing.Point(6, 41);
            this.lblChildName.Name = "lblChildName";
            this.lblChildName.Size = new System.Drawing.Size(76, 13);
            this.lblChildName.TabIndex = 0;
            this.lblChildName.Text = "Ime slavljenika";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaRezervacijaToolStripMenuItem,
            this.otvoriRezervacijuToolStripMenuItem,
            this.rezervacijeZaOvajTjedanToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.toolStripMenuItem1.Text = "Rezervacije";
            // 
            // novaRezervacijaToolStripMenuItem
            // 
            this.novaRezervacijaToolStripMenuItem.Name = "novaRezervacijaToolStripMenuItem";
            this.novaRezervacijaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.novaRezervacijaToolStripMenuItem.Text = "Nova";
            this.novaRezervacijaToolStripMenuItem.Click += new System.EventHandler(this.novaRezervacijaToolStripMenuItem_Click);
            // 
            // otvoriRezervacijuToolStripMenuItem
            // 
            this.otvoriRezervacijuToolStripMenuItem.Name = "otvoriRezervacijuToolStripMenuItem";
            this.otvoriRezervacijuToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.otvoriRezervacijuToolStripMenuItem.Text = "Pregled";
            this.otvoriRezervacijuToolStripMenuItem.Click += new System.EventHandler(this.otvoriRezervacijuToolStripMenuItem_Click);
            // 
            // rezervacijeZaOvajTjedanToolStripMenuItem
            // 
            this.rezervacijeZaOvajTjedanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danasToolStripMenuItem,
            this.tjedanToolStripMenuItem,
            this.mjesecToolStripMenuItem});
            this.rezervacijeZaOvajTjedanToolStripMenuItem.Name = "rezervacijeZaOvajTjedanToolStripMenuItem";
            this.rezervacijeZaOvajTjedanToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.rezervacijeZaOvajTjedanToolStripMenuItem.Text = "Rezervacije za razdoblje";
            // 
            // danasToolStripMenuItem
            // 
            this.danasToolStripMenuItem.Name = "danasToolStripMenuItem";
            this.danasToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.danasToolStripMenuItem.Text = "Danas";
            // 
            // tjedanToolStripMenuItem
            // 
            this.tjedanToolStripMenuItem.Name = "tjedanToolStripMenuItem";
            this.tjedanToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.tjedanToolStripMenuItem.Text = "Tjedan (pon-ned)";
            // 
            // mjesecToolStripMenuItem
            // 
            this.mjesecToolStripMenuItem.Name = "mjesecToolStripMenuItem";
            this.mjesecToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.mjesecToolStripMenuItem.Text = "Mjesec";
            // 
            // tabTabs
            // 
            this.tabTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTabs.Controls.Add(this.tabNewReservation);
            this.tabTabs.Controls.Add(this.tabReservations);
            this.tabTabs.Location = new System.Drawing.Point(1, 51);
            this.tabTabs.Name = "tabTabs";
            this.tabTabs.SelectedIndex = 0;
            this.tabTabs.Size = new System.Drawing.Size(1025, 511);
            this.tabTabs.TabIndex = 3;
            this.tabTabs.Tag = "";
            // 
            // tabNewReservation
            // 
            this.tabNewReservation.Controls.Add(this.dtpBirthdayDate);
            this.tabNewReservation.Controls.Add(this.grdOrder);
            this.tabNewReservation.Controls.Add(this.grdCustomer);
            this.tabNewReservation.Controls.Add(this.cboPackage);
            this.tabNewReservation.Controls.Add(this.label8);
            this.tabNewReservation.Controls.Add(this.chkAccontation);
            this.tabNewReservation.Controls.Add(this.label7);
            this.tabNewReservation.Controls.Add(this.btnSaveReservation);
            this.tabNewReservation.Controls.Add(this.label6);
            this.tabNewReservation.Controls.Add(this.btnRefresh);
            this.tabNewReservation.Controls.Add(this.btnEditCake);
            this.tabNewReservation.Controls.Add(this.txtNote);
            this.tabNewReservation.Controls.Add(this.label4);
            this.tabNewReservation.Controls.Add(this.btnShowDeleteConfirm);
            this.tabNewReservation.Controls.Add(this.btnShowAddGroup);
            this.tabNewReservation.Controls.Add(this.grdCakes);
            this.tabNewReservation.Controls.Add(this.cboResTimeTo);
            this.tabNewReservation.Controls.Add(this.cboName);
            this.tabNewReservation.Controls.Add(this.cboResTimeFrom);
            this.tabNewReservation.Controls.Add(this.txtPhone);
            this.tabNewReservation.Controls.Add(this.txtContactPerson);
            this.tabNewReservation.Controls.Add(this.lblResDate);
            this.tabNewReservation.Controls.Add(this.lblDo);
            this.tabNewReservation.Controls.Add(this.lblOd);
            this.tabNewReservation.Controls.Add(this.lblDateDay);
            this.tabNewReservation.Controls.Add(this.lblDay);
            this.tabNewReservation.Controls.Add(this.lblResTime);
            this.tabNewReservation.Controls.Add(this.lblCake);
            this.tabNewReservation.Controls.Add(this.lblPhone);
            this.tabNewReservation.Controls.Add(this.lblContactPerson);
            this.tabNewReservation.Controls.Add(this.lblChildName);
            this.tabNewReservation.Controls.Add(this.dtpResDate);
            this.tabNewReservation.Controls.Add(this.grpDeleteCake);
            this.tabNewReservation.Controls.Add(this.grpAddCake);
            this.tabNewReservation.Location = new System.Drawing.Point(4, 22);
            this.tabNewReservation.Name = "tabNewReservation";
            this.tabNewReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewReservation.Size = new System.Drawing.Size(1017, 485);
            this.tabNewReservation.TabIndex = 0;
            this.tabNewReservation.Text = "Nova rezervacija";
            this.tabNewReservation.UseVisualStyleBackColor = true;
            // 
            // dtpBirthdayDate
            // 
            this.dtpBirthdayDate.Location = new System.Drawing.Point(104, 67);
            this.dtpBirthdayDate.MaxDate = new System.DateTime(2015, 7, 2, 0, 0, 0, 0);
            this.dtpBirthdayDate.MinDate = new System.DateTime(1950, 2, 1, 0, 0, 0, 0);
            this.dtpBirthdayDate.Name = "dtpBirthdayDate";
            this.dtpBirthdayDate.Size = new System.Drawing.Size(147, 20);
            this.dtpBirthdayDate.TabIndex = 110;
            this.dtpBirthdayDate.Value = new System.DateTime(2014, 12, 13, 14, 18, 3, 0);
            // 
            // grdOrder
            // 
            this.grdOrder.AllowUserToAddRows = false;
            this.grdOrder.AllowUserToDeleteRows = false;
            this.grdOrder.AllowUserToResizeColumns = false;
            this.grdOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdOrder.AutoGenerateColumns = false;
            this.grdOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.CakeName,
            this.CustomerName,
            this.orderDateDataGridViewTextBoxColumn,
            this.timeSpanFromDataGridViewTextBoxColumn,
            this.timeSpanToDataGridViewTextBoxColumn,
            this.packageDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.cakeDataGridViewTextBoxColumn,
            this.CustomerId,
            this.dataGridViewTextBoxColumn3,
            this.accontationDataGridViewCheckBoxColumn});
            this.grdOrder.DataSource = this.orderBindingSource;
            this.grdOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdOrder.EnableHeadersVisualStyles = false;
            this.grdOrder.GridColor = System.Drawing.Color.Blue;
            this.grdOrder.Location = new System.Drawing.Point(620, 260);
            this.grdOrder.MultiSelect = false;
            this.grdOrder.Name = "grdOrder";
            this.grdOrder.ReadOnly = true;
            this.grdOrder.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grdOrder.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOrder.ShowEditingIcon = false;
            this.grdOrder.Size = new System.Drawing.Size(391, 222);
            this.grdOrder.TabIndex = 109;
            this.grdOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrder_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.FillWeight = 80F;
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id narudžbe";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 80;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Width = 80;
            // 
            // CakeName
            // 
            this.CakeName.DataPropertyName = "CakeName";
            this.CakeName.HeaderText = "Ime torte";
            this.CakeName.Name = "CakeName";
            this.CakeName.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Ime slavljenika";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.FillWeight = 120F;
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Datum Narudžbe";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 110;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDateDataGridViewTextBoxColumn.Width = 110;
            // 
            // timeSpanFromDataGridViewTextBoxColumn
            // 
            this.timeSpanFromDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.timeSpanFromDataGridViewTextBoxColumn.DataPropertyName = "TimeSpanFrom";
            this.timeSpanFromDataGridViewTextBoxColumn.FillWeight = 60F;
            this.timeSpanFromDataGridViewTextBoxColumn.HeaderText = "Od (h)";
            this.timeSpanFromDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.timeSpanFromDataGridViewTextBoxColumn.Name = "timeSpanFromDataGridViewTextBoxColumn";
            this.timeSpanFromDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeSpanFromDataGridViewTextBoxColumn.Width = 60;
            // 
            // timeSpanToDataGridViewTextBoxColumn
            // 
            this.timeSpanToDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.timeSpanToDataGridViewTextBoxColumn.DataPropertyName = "TimeSpanTo";
            this.timeSpanToDataGridViewTextBoxColumn.FillWeight = 50F;
            this.timeSpanToDataGridViewTextBoxColumn.HeaderText = "Do (h)";
            this.timeSpanToDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.timeSpanToDataGridViewTextBoxColumn.Name = "timeSpanToDataGridViewTextBoxColumn";
            this.timeSpanToDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeSpanToDataGridViewTextBoxColumn.Width = 60;
            // 
            // packageDataGridViewTextBoxColumn
            // 
            this.packageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.packageDataGridViewTextBoxColumn.DataPropertyName = "Package";
            this.packageDataGridViewTextBoxColumn.FillWeight = 150F;
            this.packageDataGridViewTextBoxColumn.HeaderText = "Paket";
            this.packageDataGridViewTextBoxColumn.MinimumWidth = 130;
            this.packageDataGridViewTextBoxColumn.Name = "packageDataGridViewTextBoxColumn";
            this.packageDataGridViewTextBoxColumn.ReadOnly = true;
            this.packageDataGridViewTextBoxColumn.Width = 130;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.FillWeight = 200F;
            this.noteDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.noteDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cakeDataGridViewTextBoxColumn
            // 
            this.cakeDataGridViewTextBoxColumn.DataPropertyName = "Cake";
            this.cakeDataGridViewTextBoxColumn.HeaderText = "Cake";
            this.cakeDataGridViewTextBoxColumn.Name = "cakeDataGridViewTextBoxColumn";
            this.cakeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cakeDataGridViewTextBoxColumn.Visible = false;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "CustomerId";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Customer";
            this.dataGridViewTextBoxColumn3.HeaderText = "Customer";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // accontationDataGridViewCheckBoxColumn
            // 
            this.accontationDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.accontationDataGridViewCheckBoxColumn.DataPropertyName = "Accontation";
            this.accontationDataGridViewCheckBoxColumn.FillWeight = 60F;
            this.accontationDataGridViewCheckBoxColumn.HeaderText = "Akontacija";
            this.accontationDataGridViewCheckBoxColumn.MinimumWidth = 60;
            this.accontationDataGridViewCheckBoxColumn.Name = "accontationDataGridViewCheckBoxColumn";
            this.accontationDataGridViewCheckBoxColumn.ReadOnly = true;
            this.accontationDataGridViewCheckBoxColumn.Width = 60;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(DataLayer.Model.Order);
            // 
            // grdCustomer
            // 
            this.grdCustomer.AllowUserToAddRows = false;
            this.grdCustomer.AllowUserToDeleteRows = false;
            this.grdCustomer.AllowUserToResizeColumns = false;
            this.grdCustomer.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCustomer.AutoGenerateColumns = false;
            this.grdCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.ageDataGridViewTextBoxColumn,
            this.birthdayDateDataGridViewTextBoxColumn,
            this.contactPersonDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.Note,
            this.idDataGridViewTextBoxColumn});
            this.grdCustomer.DataSource = this.customerBindingSource;
            this.grdCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdCustomer.EnableHeadersVisualStyles = false;
            this.grdCustomer.GridColor = System.Drawing.Color.Blue;
            this.grdCustomer.Location = new System.Drawing.Point(620, 9);
            this.grdCustomer.MultiSelect = false;
            this.grdCustomer.Name = "grdCustomer";
            this.grdCustomer.ReadOnly = true;
            this.grdCustomer.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grdCustomer.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCustomer.ShowEditingIcon = false;
            this.grdCustomer.Size = new System.Drawing.Size(391, 245);
            this.grdCustomer.TabIndex = 108;
            this.grdCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomer_CellContentClick);
            this.grdCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomer_CellDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.FillWeight = 150F;
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Ime slavljenika";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 150;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.FillWeight = 70F;
            this.ageDataGridViewTextBoxColumn.HeaderText = "Dob";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Width = 70;
            // 
            // birthdayDateDataGridViewTextBoxColumn
            // 
            this.birthdayDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.birthdayDateDataGridViewTextBoxColumn.DataPropertyName = "BirthdayDate";
            this.birthdayDateDataGridViewTextBoxColumn.FillWeight = 120F;
            this.birthdayDateDataGridViewTextBoxColumn.HeaderText = "Datum rođendana";
            this.birthdayDateDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.birthdayDateDataGridViewTextBoxColumn.Name = "birthdayDateDataGridViewTextBoxColumn";
            this.birthdayDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthdayDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // contactPersonDataGridViewTextBoxColumn
            // 
            this.contactPersonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.contactPersonDataGridViewTextBoxColumn.DataPropertyName = "ContactPerson";
            this.contactPersonDataGridViewTextBoxColumn.FillWeight = 200F;
            this.contactPersonDataGridViewTextBoxColumn.HeaderText = "Kontakt osoba";
            this.contactPersonDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.contactPersonDataGridViewTextBoxColumn.Name = "contactPersonDataGridViewTextBoxColumn";
            this.contactPersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactPersonDataGridViewTextBoxColumn.Width = 200;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.FillWeight = 120F;
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Napomena";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(DataLayer.Model.Customer);
            // 
            // cboPackage
            // 
            this.cboPackage.FormattingEnabled = true;
            this.cboPackage.Items.AddRange(new object[] {
            "Twister Small (10)",
            "Twister Medium (15)",
            "Twister Large (20)",
            "Twister Maxi(25+)"});
            this.cboPackage.Location = new System.Drawing.Point(322, 38);
            this.cboPackage.Name = "cboPackage";
            this.cboPackage.Size = new System.Drawing.Size(202, 21);
            this.cboPackage.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 107;
            this.label8.Text = "Paket";
            // 
            // chkAccontation
            // 
            this.chkAccontation.AutoSize = true;
            this.chkAccontation.Location = new System.Drawing.Point(599, 44);
            this.chkAccontation.Name = "chkAccontation";
            this.chkAccontation.Size = new System.Drawing.Size(15, 14);
            this.chkAccontation.TabIndex = 106;
            this.chkAccontation.UseVisualStyleBackColor = true;
            this.chkAccontation.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(534, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 105;
            this.label7.Text = "Akontacija";
            // 
            // btnSaveReservation
            // 
            this.btnSaveReservation.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSaveReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnSaveReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveReservation.Location = new System.Drawing.Point(530, 67);
            this.btnSaveReservation.Name = "btnSaveReservation";
            this.btnSaveReservation.Size = new System.Drawing.Size(84, 72);
            this.btnSaveReservation.TabIndex = 10;
            this.btnSaveReservation.Text = "Spremi rezervaciju";
            this.btnSaveReservation.UseVisualStyleBackColor = false;
            this.btnSaveReservation.Click += new System.EventHandler(this.btnSaveReservation_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 103;
            this.label6.Text = "Napomena";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(10, 256);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 23);
            this.btnRefresh.TabIndex = 102;
            this.btnRefresh.Text = "Osvježi";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEditCake
            // 
            this.btnEditCake.BackColor = System.Drawing.Color.Yellow;
            this.btnEditCake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCake.Location = new System.Drawing.Point(10, 198);
            this.btnEditCake.Name = "btnEditCake";
            this.btnEditCake.Size = new System.Drawing.Size(88, 23);
            this.btnEditCake.TabIndex = 101;
            this.btnEditCake.Text = "Izmjeni";
            this.btnEditCake.UseVisualStyleBackColor = false;
            this.btnEditCake.Click += new System.EventHandler(this.btnEditCake_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(322, 67);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(202, 72);
            this.txtNote.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Datum rođendana";
            // 
            // btnShowDeleteConfirm
            // 
            this.btnShowDeleteConfirm.BackColor = System.Drawing.Color.LightCoral;
            this.btnShowDeleteConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDeleteConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowDeleteConfirm.Location = new System.Drawing.Point(10, 227);
            this.btnShowDeleteConfirm.Name = "btnShowDeleteConfirm";
            this.btnShowDeleteConfirm.Size = new System.Drawing.Size(88, 23);
            this.btnShowDeleteConfirm.TabIndex = 100;
            this.btnShowDeleteConfirm.Text = "Obriši";
            this.btnShowDeleteConfirm.UseVisualStyleBackColor = false;
            this.btnShowDeleteConfirm.Click += new System.EventHandler(this.btnShowDeleteConfirm_Click);
            // 
            // btnShowAddGroup
            // 
            this.btnShowAddGroup.BackColor = System.Drawing.Color.YellowGreen;
            this.btnShowAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAddGroup.Location = new System.Drawing.Point(10, 169);
            this.btnShowAddGroup.Name = "btnShowAddGroup";
            this.btnShowAddGroup.Size = new System.Drawing.Size(88, 23);
            this.btnShowAddGroup.TabIndex = 90;
            this.btnShowAddGroup.Text = "Dodaj";
            this.btnShowAddGroup.UseVisualStyleBackColor = false;
            this.btnShowAddGroup.Click += new System.EventHandler(this.btnShowAddGroup_Click);
            // 
            // grdCakes
            // 
            this.grdCakes.AllowUserToAddRows = false;
            this.grdCakes.AllowUserToDeleteRows = false;
            this.grdCakes.AllowUserToResizeColumns = false;
            this.grdCakes.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdCakes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdCakes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdCakes.AutoGenerateColumns = false;
            this.grdCakes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCakes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn});
            this.grdCakes.DataSource = this.cakesBindingSource;
            this.grdCakes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdCakes.EnableHeadersVisualStyles = false;
            this.grdCakes.GridColor = System.Drawing.Color.Blue;
            this.grdCakes.Location = new System.Drawing.Point(104, 152);
            this.grdCakes.MultiSelect = false;
            this.grdCakes.Name = "grdCakes";
            this.grdCakes.ReadOnly = true;
            this.grdCakes.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grdCakes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grdCakes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCakes.ShowEditingIcon = false;
            this.grdCakes.Size = new System.Drawing.Size(510, 221);
            this.grdCakes.TabIndex = 80;
            this.grdCakes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCakes_RowEnter);
            this.grdCakes.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCakes_RowLeave);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.FillWeight = 50F;
            this.idDataGridViewTextBoxColumn1.Frozen = true;
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 50;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn1
            // 
            this.weightDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.weightDataGridViewTextBoxColumn1.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn1.FillWeight = 90F;
            this.weightDataGridViewTextBoxColumn1.HeaderText = "Težina (g)";
            this.weightDataGridViewTextBoxColumn1.MinimumWidth = 90;
            this.weightDataGridViewTextBoxColumn1.Name = "weightDataGridViewTextBoxColumn1";
            this.weightDataGridViewTextBoxColumn1.ReadOnly = true;
            this.weightDataGridViewTextBoxColumn1.Width = 90;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.FillWeight = 90F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Cijena (kn)";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 90;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 90;
            // 
            // cakesBindingSource
            // 
            this.cakesBindingSource.DataSource = typeof(DataLayer.Model.Cake);
            // 
            // cboResTimeTo
            // 
            this.cboResTimeTo.FormattingEnabled = true;
            this.cboResTimeTo.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.cboResTimeTo.Location = new System.Drawing.Point(565, 9);
            this.cboResTimeTo.Name = "cboResTimeTo";
            this.cboResTimeTo.Size = new System.Drawing.Size(49, 21);
            this.cboResTimeTo.TabIndex = 2;
            this.cboResTimeTo.Text = "11";
            // 
            // cboName
            // 
            this.cboName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "Name", true));
            this.cboName.DataSource = this.customerBindingSource;
            this.cboName.DisplayMember = "Name";
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(104, 38);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(147, 21);
            this.cboName.TabIndex = 1;
            this.cboName.ValueMember = "Id";
            this.cboName.SelectedValueChanged += new System.EventHandler(this.cboName_SelectedValueChanged);
            this.cboName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboName_KeyUp);
            // 
            // cboResTimeFrom
            // 
            this.cboResTimeFrom.FormattingEnabled = true;
            this.cboResTimeFrom.Items.AddRange(new object[] {
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.cboResTimeFrom.Location = new System.Drawing.Point(483, 9);
            this.cboResTimeFrom.Name = "cboResTimeFrom";
            this.cboResTimeFrom.Size = new System.Drawing.Size(49, 21);
            this.cboResTimeFrom.TabIndex = 1;
            this.cboResTimeFrom.Text = "09";
            this.cboResTimeFrom.SelectedIndexChanged += new System.EventHandler(this.cboResTimeFrom_SelectedIndexChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(104, 119);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(147, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Location = new System.Drawing.Point(104, 93);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(147, 20);
            this.txtContactPerson.TabIndex = 5;
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Location = new System.Drawing.Point(538, 12);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(19, 13);
            this.lblDo.TabIndex = 0;
            this.lblDo.Text = "do";
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Location = new System.Drawing.Point(458, 12);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(19, 13);
            this.lblOd.TabIndex = 0;
            this.lblOd.Text = "od";
            // 
            // lblDateDay
            // 
            this.lblDateDay.AutoSize = true;
            this.lblDateDay.Location = new System.Drawing.Point(288, 12);
            this.lblDateDay.Name = "lblDateDay";
            this.lblDateDay.Size = new System.Drawing.Size(27, 13);
            this.lblDateDay.TabIndex = 0;
            this.lblDateDay.Text = "Dan";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(257, 12);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(30, 13);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "Dan:";
            // 
            // lblResTime
            // 
            this.lblResTime.AutoSize = true;
            this.lblResTime.Location = new System.Drawing.Point(362, 12);
            this.lblResTime.Name = "lblResTime";
            this.lblResTime.Size = new System.Drawing.Size(95, 13);
            this.lblResTime.TabIndex = 0;
            this.lblResTime.Text = "Vrijeme rezervacije";
            // 
            // lblCake
            // 
            this.lblCake.AutoSize = true;
            this.lblCake.Location = new System.Drawing.Point(7, 153);
            this.lblCake.Name = "lblCake";
            this.lblCake.Size = new System.Drawing.Size(32, 13);
            this.lblCake.TabIndex = 0;
            this.lblCake.Text = "Torta";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 122);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(64, 13);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Kontakt broj";
            // 
            // lblContactPerson
            // 
            this.lblContactPerson.AutoSize = true;
            this.lblContactPerson.Location = new System.Drawing.Point(6, 96);
            this.lblContactPerson.Name = "lblContactPerson";
            this.lblContactPerson.Size = new System.Drawing.Size(76, 13);
            this.lblContactPerson.TabIndex = 0;
            this.lblContactPerson.Text = "Kontakt osoba";
            // 
            // grpDeleteCake
            // 
            this.grpDeleteCake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpDeleteCake.BackColor = System.Drawing.Color.White;
            this.grpDeleteCake.Controls.Add(this.btnCancelDeleteCake);
            this.grpDeleteCake.Controls.Add(this.btnConfirmDeleteCake);
            this.grpDeleteCake.Controls.Add(this.label5);
            this.grpDeleteCake.Location = new System.Drawing.Point(104, 379);
            this.grpDeleteCake.Name = "grpDeleteCake";
            this.grpDeleteCake.Size = new System.Drawing.Size(510, 100);
            this.grpDeleteCake.TabIndex = 15;
            this.grpDeleteCake.TabStop = false;
            this.grpDeleteCake.Visible = false;
            // 
            // btnCancelDeleteCake
            // 
            this.btnCancelDeleteCake.Location = new System.Drawing.Point(129, 32);
            this.btnCancelDeleteCake.Name = "btnCancelDeleteCake";
            this.btnCancelDeleteCake.Size = new System.Drawing.Size(117, 23);
            this.btnCancelDeleteCake.TabIndex = 20;
            this.btnCancelDeleteCake.Text = "Odustani";
            this.btnCancelDeleteCake.UseVisualStyleBackColor = true;
            this.btnCancelDeleteCake.Click += new System.EventHandler(this.btnCancelDeleteCake_Click);
            // 
            // btnConfirmDeleteCake
            // 
            this.btnConfirmDeleteCake.Location = new System.Drawing.Point(6, 32);
            this.btnConfirmDeleteCake.Name = "btnConfirmDeleteCake";
            this.btnConfirmDeleteCake.Size = new System.Drawing.Size(117, 23);
            this.btnConfirmDeleteCake.TabIndex = 10;
            this.btnConfirmDeleteCake.Text = "Da";
            this.btnConfirmDeleteCake.UseVisualStyleBackColor = true;
            this.btnConfirmDeleteCake.Click += new System.EventHandler(this.btnConfirmDeleteCake_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sigurno želite obrisati odabranu tortu?";
            // 
            // grpAddCake
            // 
            this.grpAddCake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpAddCake.BackColor = System.Drawing.Color.White;
            this.grpAddCake.Controls.Add(this.btnCancelAddCake);
            this.grpAddCake.Controls.Add(this.btnAddCake);
            this.grpAddCake.Controls.Add(this.txtCakePrice);
            this.grpAddCake.Controls.Add(this.txtCakeName);
            this.grpAddCake.Controls.Add(this.label3);
            this.grpAddCake.Controls.Add(this.label1);
            this.grpAddCake.Controls.Add(this.txtCakeWeight);
            this.grpAddCake.Controls.Add(this.label2);
            this.grpAddCake.Location = new System.Drawing.Point(104, 379);
            this.grpAddCake.Name = "grpAddCake";
            this.grpAddCake.Size = new System.Drawing.Size(510, 100);
            this.grpAddCake.TabIndex = 14;
            this.grpAddCake.TabStop = false;
            this.grpAddCake.Visible = false;
            // 
            // btnCancelAddCake
            // 
            this.btnCancelAddCake.Location = new System.Drawing.Point(129, 71);
            this.btnCancelAddCake.Name = "btnCancelAddCake";
            this.btnCancelAddCake.Size = new System.Drawing.Size(117, 23);
            this.btnCancelAddCake.TabIndex = 50;
            this.btnCancelAddCake.Text = "Odustani";
            this.btnCancelAddCake.UseVisualStyleBackColor = true;
            this.btnCancelAddCake.Click += new System.EventHandler(this.btnCancelAddCake_Click);
            // 
            // btnAddCake
            // 
            this.btnAddCake.Location = new System.Drawing.Point(6, 71);
            this.btnAddCake.Name = "btnAddCake";
            this.btnAddCake.Size = new System.Drawing.Size(117, 23);
            this.btnAddCake.TabIndex = 40;
            this.btnAddCake.Text = "Dodaj tortu";
            this.btnAddCake.UseVisualStyleBackColor = true;
            this.btnAddCake.Click += new System.EventHandler(this.btnAddCake_Click);
            // 
            // txtCakePrice
            // 
            this.txtCakePrice.Location = new System.Drawing.Point(197, 38);
            this.txtCakePrice.MaxLength = 6;
            this.txtCakePrice.Name = "txtCakePrice";
            this.txtCakePrice.Size = new System.Drawing.Size(49, 20);
            this.txtCakePrice.TabIndex = 30;
            // 
            // txtCakeName
            // 
            this.txtCakeName.Location = new System.Drawing.Point(70, 13);
            this.txtCakeName.MaxLength = 50;
            this.txtCakeName.Name = "txtCakeName";
            this.txtCakeName.Size = new System.Drawing.Size(176, 20);
            this.txtCakeName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cijena (kn)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naziv torte";
            // 
            // txtCakeWeight
            // 
            this.txtCakeWeight.Location = new System.Drawing.Point(70, 38);
            this.txtCakeWeight.MaxLength = 4;
            this.txtCakeWeight.Name = "txtCakeWeight";
            this.txtCakeWeight.Size = new System.Drawing.Size(59, 20);
            this.txtCakeWeight.TabIndex = 20;
            this.txtCakeWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCakeWeight_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Težina (g)";
            // 
            // tabReservations
            // 
            this.tabReservations.Controls.Add(this.grdFilteredOrders);
            this.tabReservations.Location = new System.Drawing.Point(4, 22);
            this.tabReservations.Name = "tabReservations";
            this.tabReservations.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservations.Size = new System.Drawing.Size(1017, 485);
            this.tabReservations.TabIndex = 1;
            this.tabReservations.Text = "Pregled";
            this.tabReservations.UseVisualStyleBackColor = true;
            // 
            // grdFilteredOrders
            // 
            this.grdFilteredOrders.AllowUserToAddRows = false;
            this.grdFilteredOrders.AllowUserToDeleteRows = false;
            this.grdFilteredOrders.AllowUserToResizeColumns = false;
            this.grdFilteredOrders.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdFilteredOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grdFilteredOrders.AutoGenerateColumns = false;
            this.grdFilteredOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFilteredOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn1,
            this.OrderDate,
            this.dataGridViewTextBoxColumn7,
            this.Package,
            this.dataGridViewTextBoxColumn2});
            this.grdFilteredOrders.DataSource = this.orderBindingSource;
            this.grdFilteredOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFilteredOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdFilteredOrders.EnableHeadersVisualStyles = false;
            this.grdFilteredOrders.GridColor = System.Drawing.Color.Blue;
            this.grdFilteredOrders.Location = new System.Drawing.Point(3, 3);
            this.grdFilteredOrders.MultiSelect = false;
            this.grdFilteredOrders.Name = "grdFilteredOrders";
            this.grdFilteredOrders.ReadOnly = true;
            this.grdFilteredOrders.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grdFilteredOrders.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grdFilteredOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFilteredOrders.ShowEditingIcon = false;
            this.grdFilteredOrders.Size = new System.Drawing.Size(1011, 479);
            this.grdFilteredOrders.TabIndex = 109;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn8.HeaderText = "Id narudžbe";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ime slavljenika";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "Datum narudžbe";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn7.HeaderText = "Napomena";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Package
            // 
            this.Package.DataPropertyName = "Package";
            this.Package.HeaderText = "Paket";
            this.Package.Name = "Package";
            this.Package.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CakeName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime torte";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // prgLoadTables
            // 
            this.prgLoadTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgLoadTables.Location = new System.Drawing.Point(123, 28);
            this.prgLoadTables.Name = "prgLoadTables";
            this.prgLoadTables.Size = new System.Drawing.Size(903, 17);
            this.prgLoadTables.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgLoadTables.TabIndex = 4;
            this.prgLoadTables.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 110;
            this.label9.Text = "Učitavanje podataka...";
            this.label9.Visible = false;
            // 
            // fmReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 562);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.prgLoadTables);
            this.Controls.Add(this.tabTabs);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "fmReservations";
            this.Text = "Rezervacije rođendana";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmReservations_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabTabs.ResumeLayout(false);
            this.tabNewReservation.ResumeLayout(false);
            this.tabNewReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCakes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakesBindingSource)).EndInit();
            this.grpDeleteCake.ResumeLayout(false);
            this.grpDeleteCake.PerformLayout();
            this.grpAddCake.ResumeLayout(false);
            this.grpAddCake.PerformLayout();
            this.tabReservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFilteredOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResDate;
        private System.Windows.Forms.DateTimePicker dtpResDate;
        private System.Windows.Forms.Label lblChildName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novaRezervacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otvoriRezervacijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeZaOvajTjedanToolStripMenuItem;
        private System.Windows.Forms.TabControl tabTabs;
        private System.Windows.Forms.TabPage tabNewReservation;
        private System.Windows.Forms.TabPage tabReservations;
        private System.Windows.Forms.ComboBox cboResTimeTo;
        private System.Windows.Forms.ComboBox cboResTimeFrom;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.Label lblResTime;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblContactPerson;
        private System.Windows.Forms.Label lblDateDay;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblCake;
        private System.Windows.Forms.DataGridView grdCakes;
        private System.Windows.Forms.BindingSource cakesBindingSource;
        private System.Windows.Forms.TextBox txtCakePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCakeWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCakeName;
        private System.Windows.Forms.Button btnAddCake;
        private System.Windows.Forms.GroupBox grpAddCake;
        private System.Windows.Forms.Button btnCancelAddCake;
        private System.Windows.Forms.Button btnShowDeleteConfirm;
        private System.Windows.Forms.Button btnShowAddGroup;
        private System.Windows.Forms.GroupBox grpDeleteCake;
        private System.Windows.Forms.Button btnCancelDeleteCake;
        private System.Windows.Forms.Button btnConfirmDeleteCake;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem danasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tjedanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mjesecToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditCake;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSaveReservation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboPackage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkAccontation;
        private System.Windows.Forms.DataGridView grdOrder;
        private System.Windows.Forms.DataGridView grdCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.ProgressBar prgLoadTables;
        private System.Windows.Forms.DataGridViewTextBoxColumn cakeGuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerGuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cakeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpBirthdayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.DataGridView grdFilteredOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Package;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CakeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSpanFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSpanToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn accontationDataGridViewCheckBoxColumn;
    }
}


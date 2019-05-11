namespace BankManagement
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.bank_lists = new System.Windows.Forms.ListView();
            this.bank_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bank_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bank_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bank_id_textbox = new System.Windows.Forms.TextBox();
            this.bank_name_textbox = new System.Windows.Forms.TextBox();
            this.bank_email_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bank_update_button = new System.Windows.Forms.Button();
            this.bank_new_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bank_new_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.add_new_banks = new System.Windows.Forms.Button();
            this.bank_remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.customer_lists = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cus_id_textbox = new System.Windows.Forms.TextBox();
            this.cus_name_text = new System.Windows.Forms.TextBox();
            this.update_cus_button = new System.Windows.Forms.Button();
            this.cus_new_names_textbox = new System.Windows.Forms.TextBox();
            this.cus_add_new = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cus_city_textbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cus_location_textbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cus_new_city = new System.Windows.Forms.TextBox();
            this.cus_new_location = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.loan_lists = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loan_cus_id_textbox = new System.Windows.Forms.TextBox();
            this.loan_amount_textbox = new System.Windows.Forms.TextBox();
            this.loan_bank_id_textbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.removeLoan = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.connect_string_textbox = new System.Windows.Forms.TextBox();
            this.connect_database_button = new System.Windows.Forms.Button();
            this.connection_group = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.connection_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Banks";
            // 
            // bank_lists
            // 
            this.bank_lists.AllowColumnReorder = true;
            this.bank_lists.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bank_id,
            this.bank_name,
            this.bank_email});
            this.bank_lists.FullRowSelect = true;
            this.bank_lists.GridLines = true;
            this.bank_lists.HideSelection = false;
            this.bank_lists.Location = new System.Drawing.Point(22, 34);
            this.bank_lists.MultiSelect = false;
            this.bank_lists.Name = "bank_lists";
            this.bank_lists.Size = new System.Drawing.Size(388, 148);
            this.bank_lists.TabIndex = 4;
            this.bank_lists.UseCompatibleStateImageBehavior = false;
            this.bank_lists.View = System.Windows.Forms.View.Details;
            this.bank_lists.SelectedIndexChanged += new System.EventHandler(this.bank_lists_SelectedIndexChanged);
            // 
            // bank_id
            // 
            this.bank_id.Text = "Bank Id";
            this.bank_id.Width = 100;
            // 
            // bank_name
            // 
            this.bank_name.Tag = "1";
            this.bank_name.Text = "Bank Name";
            this.bank_name.Width = 100;
            // 
            // bank_email
            // 
            this.bank_email.Text = "Bank Email";
            this.bank_email.Width = 150;
            // 
            // bank_id_textbox
            // 
            this.bank_id_textbox.Enabled = false;
            this.bank_id_textbox.Location = new System.Drawing.Point(72, 198);
            this.bank_id_textbox.Name = "bank_id_textbox";
            this.bank_id_textbox.Size = new System.Drawing.Size(137, 20);
            this.bank_id_textbox.TabIndex = 6;
            // 
            // bank_name_textbox
            // 
            this.bank_name_textbox.Enabled = false;
            this.bank_name_textbox.Location = new System.Drawing.Point(72, 224);
            this.bank_name_textbox.Name = "bank_name_textbox";
            this.bank_name_textbox.Size = new System.Drawing.Size(137, 20);
            this.bank_name_textbox.TabIndex = 7;
            // 
            // bank_email_textbox
            // 
            this.bank_email_textbox.Enabled = false;
            this.bank_email_textbox.Location = new System.Drawing.Point(72, 250);
            this.bank_email_textbox.Name = "bank_email_textbox";
            this.bank_email_textbox.Size = new System.Drawing.Size(137, 20);
            this.bank_email_textbox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bank Id";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bank Name";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Bank Email";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // bank_update_button
            // 
            this.bank_update_button.Location = new System.Drawing.Point(101, 276);
            this.bank_update_button.Name = "bank_update_button";
            this.bank_update_button.Size = new System.Drawing.Size(75, 23);
            this.bank_update_button.TabIndex = 9;
            this.bank_update_button.Text = "Update";
            this.bank_update_button.UseVisualStyleBackColor = true;
            this.bank_update_button.Click += new System.EventHandler(this.bank_update_button_Click);
            // 
            // bank_new_name
            // 
            this.bank_new_name.Location = new System.Drawing.Point(292, 224);
            this.bank_new_name.Name = "bank_new_name";
            this.bank_new_name.Size = new System.Drawing.Size(118, 20);
            this.bank_new_name.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bank Name";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // bank_new_email
            // 
            this.bank_new_email.Location = new System.Drawing.Point(292, 250);
            this.bank_new_email.Name = "bank_new_email";
            this.bank_new_email.Size = new System.Drawing.Size(118, 20);
            this.bank_new_email.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Bank Email";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // add_new_banks
            // 
            this.add_new_banks.Location = new System.Drawing.Point(308, 276);
            this.add_new_banks.Name = "add_new_banks";
            this.add_new_banks.Size = new System.Drawing.Size(75, 23);
            this.add_new_banks.TabIndex = 12;
            this.add_new_banks.Text = "Add New Bank";
            this.add_new_banks.UseVisualStyleBackColor = true;
            this.add_new_banks.Click += new System.EventHandler(this.add_new_banks_Click);
            // 
            // bank_remove
            // 
            this.bank_remove.Location = new System.Drawing.Point(335, 5);
            this.bank_remove.Name = "bank_remove";
            this.bank_remove.Size = new System.Drawing.Size(75, 23);
            this.bank_remove.TabIndex = 13;
            this.bank_remove.Text = "Remove";
            this.bank_remove.UseVisualStyleBackColor = true;
            this.bank_remove.Click += new System.EventHandler(this.bank_remove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Customer Name";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(726, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Customer Name";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(456, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Customers";
            // 
            // customer_lists
            // 
            this.customer_lists.AllowColumnReorder = true;
            this.customer_lists.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.customer_lists.FullRowSelect = true;
            this.customer_lists.GridLines = true;
            this.customer_lists.HideSelection = false;
            this.customer_lists.Location = new System.Drawing.Point(459, 34);
            this.customer_lists.MultiSelect = false;
            this.customer_lists.Name = "customer_lists";
            this.customer_lists.Size = new System.Drawing.Size(332, 148);
            this.customer_lists.TabIndex = 4;
            this.customer_lists.UseCompatibleStateImageBehavior = false;
            this.customer_lists.View = System.Windows.Forms.View.Details;
            this.customer_lists.SelectedIndexChanged += new System.EventHandler(this.customer_lists_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Customer Id";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "1";
            this.columnHeader2.Text = "Customer Name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "City";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Location";
            // 
            // cus_id_textbox
            // 
            this.cus_id_textbox.Enabled = false;
            this.cus_id_textbox.Location = new System.Drawing.Point(553, 198);
            this.cus_id_textbox.Name = "cus_id_textbox";
            this.cus_id_textbox.Size = new System.Drawing.Size(137, 20);
            this.cus_id_textbox.TabIndex = 6;
            // 
            // cus_name_text
            // 
            this.cus_name_text.Enabled = false;
            this.cus_name_text.Location = new System.Drawing.Point(553, 224);
            this.cus_name_text.Name = "cus_name_text";
            this.cus_name_text.Size = new System.Drawing.Size(137, 20);
            this.cus_name_text.TabIndex = 7;
            // 
            // update_cus_button
            // 
            this.update_cus_button.Location = new System.Drawing.Point(569, 304);
            this.update_cus_button.Name = "update_cus_button";
            this.update_cus_button.Size = new System.Drawing.Size(75, 23);
            this.update_cus_button.TabIndex = 9;
            this.update_cus_button.Text = "Update";
            this.update_cus_button.UseVisualStyleBackColor = true;
            this.update_cus_button.Click += new System.EventHandler(this.update_cus_button_Click);
            // 
            // cus_new_names_textbox
            // 
            this.cus_new_names_textbox.Location = new System.Drawing.Point(806, 201);
            this.cus_new_names_textbox.Name = "cus_new_names_textbox";
            this.cus_new_names_textbox.Size = new System.Drawing.Size(137, 20);
            this.cus_new_names_textbox.TabIndex = 10;
            // 
            // cus_add_new
            // 
            this.cus_add_new.Location = new System.Drawing.Point(840, 290);
            this.cus_add_new.Name = "cus_add_new";
            this.cus_add_new.Size = new System.Drawing.Size(75, 23);
            this.cus_add_new.TabIndex = 12;
            this.cus_add_new.Text = "Add New Bank";
            this.cus_add_new.UseVisualStyleBackColor = true;
            this.cus_add_new.Click += new System.EventHandler(this.cus_add_new_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(588, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(456, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Customer City";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // cus_city_textbox
            // 
            this.cus_city_textbox.Enabled = false;
            this.cus_city_textbox.Location = new System.Drawing.Point(553, 252);
            this.cus_city_textbox.Name = "cus_city_textbox";
            this.cus_city_textbox.Size = new System.Drawing.Size(137, 20);
            this.cus_city_textbox.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(452, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Customer Location";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // cus_location_textbox
            // 
            this.cus_location_textbox.Enabled = false;
            this.cus_location_textbox.Location = new System.Drawing.Point(553, 278);
            this.cus_location_textbox.Name = "cus_location_textbox";
            this.cus_location_textbox.Size = new System.Drawing.Size(137, 20);
            this.cus_location_textbox.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(711, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Customer City";
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(707, 256);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Customer Location";
            this.label14.Click += new System.EventHandler(this.label1_Click);
            // 
            // cus_new_city
            // 
            this.cus_new_city.Location = new System.Drawing.Point(808, 227);
            this.cus_new_city.Name = "cus_new_city";
            this.cus_new_city.Size = new System.Drawing.Size(137, 20);
            this.cus_new_city.TabIndex = 7;
            // 
            // cus_new_location
            // 
            this.cus_new_location.Location = new System.Drawing.Point(808, 253);
            this.cus_new_location.Name = "cus_new_location";
            this.cus_new_location.Size = new System.Drawing.Size(137, 20);
            this.cus_new_location.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(837, 426);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Customer Id";
            this.label18.Click += new System.EventHandler(this.label1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(837, 397);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Bank Id";
            this.label19.Click += new System.EventHandler(this.label1_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(837, 456);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Amount";
            this.label21.Click += new System.EventHandler(this.label1_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(46, 345);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Loans";
            // 
            // loan_lists
            // 
            this.loan_lists.AllowColumnReorder = true;
            this.loan_lists.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.loan_lists.FullRowSelect = true;
            this.loan_lists.GridLines = true;
            this.loan_lists.HideSelection = false;
            this.loan_lists.Location = new System.Drawing.Point(36, 374);
            this.loan_lists.MultiSelect = false;
            this.loan_lists.Name = "loan_lists";
            this.loan_lists.Size = new System.Drawing.Size(766, 148);
            this.loan_lists.TabIndex = 4;
            this.loan_lists.UseCompatibleStateImageBehavior = false;
            this.loan_lists.View = System.Windows.Forms.View.Details;
            this.loan_lists.SelectedIndexChanged += new System.EventHandler(this.loan_lists_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Loan Number";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Bank Id";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Tag = "1";
            this.columnHeader6.Text = "Bank Name";
            this.columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Customer Id";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Customer Name";
            this.columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Amount";
            this.columnHeader9.Width = 100;
            // 
            // loan_cus_id_textbox
            // 
            this.loan_cus_id_textbox.Location = new System.Drawing.Point(906, 423);
            this.loan_cus_id_textbox.Name = "loan_cus_id_textbox";
            this.loan_cus_id_textbox.Size = new System.Drawing.Size(71, 20);
            this.loan_cus_id_textbox.TabIndex = 7;
            // 
            // loan_amount_textbox
            // 
            this.loan_amount_textbox.Location = new System.Drawing.Point(906, 453);
            this.loan_amount_textbox.Name = "loan_amount_textbox";
            this.loan_amount_textbox.Size = new System.Drawing.Size(71, 20);
            this.loan_amount_textbox.TabIndex = 7;
            // 
            // loan_bank_id_textbox
            // 
            this.loan_bank_id_textbox.Location = new System.Drawing.Point(906, 394);
            this.loan_bank_id_textbox.Name = "loan_bank_id_textbox";
            this.loan_bank_id_textbox.Size = new System.Drawing.Size(71, 20);
            this.loan_bank_id_textbox.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(906, 490);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add New Bank";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // removeLoan
            // 
            this.removeLoan.Location = new System.Drawing.Point(727, 528);
            this.removeLoan.Name = "removeLoan";
            this.removeLoan.Size = new System.Drawing.Size(75, 23);
            this.removeLoan.TabIndex = 13;
            this.removeLoan.Text = "Remove";
            this.removeLoan.UseVisualStyleBackColor = true;
            this.removeLoan.Click += new System.EventHandler(this.removeLoan_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(883, 355);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Add New Loan";
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(827, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Add Customer";
            this.label16.Click += new System.EventHandler(this.label1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(305, 205);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Add Bank";
            this.label17.Click += new System.EventHandler(this.label1_Click);
            // 
            // connect_string_textbox
            // 
            this.connect_string_textbox.Location = new System.Drawing.Point(12, 43);
            this.connect_string_textbox.Name = "connect_string_textbox";
            this.connect_string_textbox.Size = new System.Drawing.Size(579, 20);
            this.connect_string_textbox.TabIndex = 14;
            this.connect_string_textbox.Text = "server=.; Initial Catalog=bankManagement;Integrated Security=SSPI";
            // 
            // connect_database_button
            // 
            this.connect_database_button.Location = new System.Drawing.Point(618, 43);
            this.connect_database_button.Name = "connect_database_button";
            this.connect_database_button.Size = new System.Drawing.Size(75, 23);
            this.connect_database_button.TabIndex = 9;
            this.connect_database_button.Text = "Connect";
            this.connect_database_button.UseVisualStyleBackColor = true;
            this.connect_database_button.Click += new System.EventHandler(this.connect_database_button_Click);
            // 
            // connection_group
            // 
            this.connection_group.Controls.Add(this.connect_string_textbox);
            this.connection_group.Controls.Add(this.connect_database_button);
            this.connection_group.Location = new System.Drawing.Point(72, 565);
            this.connection_group.Name = "connection_group";
            this.connection_group.Size = new System.Drawing.Size(746, 100);
            this.connection_group.TabIndex = 15;
            this.connection_group.TabStop = false;
            this.connection_group.Text = "Connection Settings";
            this.connection_group.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(830, 78);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(213, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(860, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(932, 104);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(830, 120);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(213, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Value = 3;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 716);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.connection_group);
            this.Controls.Add(this.removeLoan);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bank_remove);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cus_add_new);
            this.Controls.Add(this.add_new_banks);
            this.Controls.Add(this.bank_new_email);
            this.Controls.Add(this.loan_bank_id_textbox);
            this.Controls.Add(this.cus_new_names_textbox);
            this.Controls.Add(this.bank_new_name);
            this.Controls.Add(this.update_cus_button);
            this.Controls.Add(this.bank_update_button);
            this.Controls.Add(this.bank_email_textbox);
            this.Controls.Add(this.loan_amount_textbox);
            this.Controls.Add(this.cus_new_location);
            this.Controls.Add(this.cus_location_textbox);
            this.Controls.Add(this.loan_cus_id_textbox);
            this.Controls.Add(this.cus_new_city);
            this.Controls.Add(this.cus_city_textbox);
            this.Controls.Add(this.cus_name_text);
            this.Controls.Add(this.bank_name_textbox);
            this.Controls.Add(this.cus_id_textbox);
            this.Controls.Add(this.bank_id_textbox);
            this.Controls.Add(this.loan_lists);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.customer_lists);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bank_lists);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Bank Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.connection_group.ResumeLayout(false);
            this.connection_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView bank_lists;
        private System.Windows.Forms.ColumnHeader bank_id;
        private System.Windows.Forms.ColumnHeader bank_email;
        private System.Windows.Forms.TextBox bank_id_textbox;
        private System.Windows.Forms.TextBox bank_name_textbox;
        private System.Windows.Forms.TextBox bank_email_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ColumnHeader bank_name;
        private System.Windows.Forms.Button bank_update_button;
        private System.Windows.Forms.TextBox bank_new_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bank_new_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button add_new_banks;
        private System.Windows.Forms.Button bank_remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView customer_lists;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox cus_id_textbox;
        private System.Windows.Forms.TextBox cus_name_text;
        private System.Windows.Forms.Button update_cus_button;
        private System.Windows.Forms.TextBox cus_new_names_textbox;
        private System.Windows.Forms.Button cus_add_new;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cus_city_textbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cus_location_textbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cus_new_city;
        private System.Windows.Forms.TextBox cus_new_location;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ListView loan_lists;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox loan_cus_id_textbox;
        private System.Windows.Forms.TextBox loan_amount_textbox;
        private System.Windows.Forms.TextBox loan_bank_id_textbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button removeLoan;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox connect_string_textbox;
        private System.Windows.Forms.Button connect_database_button;
        private System.Windows.Forms.GroupBox connection_group;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}


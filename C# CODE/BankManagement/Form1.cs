using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.CoreAudioApi;
using NAudio.Wave;

namespace BankManagement
{
    public partial class Form1 : Form
    {
        public MMDeviceEnumerator enumerator;
        public Form1()
        {
            InitializeComponent();


       enumerator = new MMDeviceEnumerator();

            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            comboBox1.Items.AddRange(devices.ToArray());
            comboBox1.SelectedIndex = 1;
        }
        private BufferedWaveProvider bwp;

        WaveIn wi;
        WaveOut wo;




        SqlConnection conn;
    
        string getData(string table_name,string wherecond,string fieldname)
        {
            SqlCommand command = new SqlCommand("Select * from "+ table_name + " where "+ wherecond + ";", conn);
            conn.Close();
            conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return (String.Format("{0}", reader[fieldname]));
                }
                conn.Close();
                return "";
            }
            conn.Close();
        }
        void bank_list()
        {
            try
            {
                bank_lists.Items.Clear();
                SqlCommand query_bank = new SqlCommand("SELECT * FROM banks", conn);
                SqlDataAdapter da = new SqlDataAdapter(query_bank);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow banks in dt.Rows)
                {
                    string[] list_banks = { banks["bank_id"].ToString(), banks["bank_name"].ToString(), banks["bank_email"].ToString() };
                    var listViewItem = new ListViewItem(list_banks);
                    bank_lists.Items.Add(listViewItem);
                }

                conn.Close();
            }
            catch
            { }

        }
        void customer_list()
        {
            customer_lists.Items.Clear();
            SqlCommand query_customer = new SqlCommand("SELECT * FROM customers", conn);
            SqlDataAdapter da = new SqlDataAdapter(query_customer);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow customers in dt.Rows)
            {
                string[] list_customers = { customers["cus_id"].ToString(), customers["cus_name"].ToString(), getData("cus_location", "cus_id='"+customers["cus_id"]+"'", "cus_city"), getData("cus_location", "cus_id='" + customers["cus_id"] + "'", "cus_location") };
                var listViewItem = new ListViewItem(list_customers);
                customer_lists.Items.Add(listViewItem);
       
            }

            conn.Close();
        }

        void loan_list()
        {
            loan_lists.Items.Clear();
            SqlCommand query_customer = new SqlCommand("SELECT * FROM loans", conn);
            SqlDataAdapter da = new SqlDataAdapter(query_customer);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow loans_datas in dt.Rows)
            {
                string[] list_customers = {
                     loans_datas["loan_num"].ToString(),
                    loans_datas["bank_id"].ToString(),
                    getData("banks", "bank_id='"+loans_datas["bank_id"]+"'", "bank_name"),
                     loans_datas["cus_id"].ToString(),
                     getData("customers", "cus_id='"+loans_datas["cus_id"]+"'", "cus_name"),
                     loans_datas["amount"].ToString()

                };
                var listViewItem = new ListViewItem(list_customers);
                loan_lists.Items.Add(listViewItem);

            }

            conn.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            wi = new WaveIn();

            wi.DataAvailable += new EventHandler<WaveInEventArgs>(wi_DataAvailable);

            bwp = new BufferedWaveProvider(wi.WaveFormat);
            bwp.DiscardOnBufferOverflow = true;

           
            wi.StartRecording();

            try
            {
                conn = new SqlConnection(@"server=.; Initial Catalog=bankManagement;Integrated Security=SSPI");
                bank_list();
                customer_list();
                loan_list();
            }
            catch
            {

                try
                {
                    conn = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=bankManagement;Integrated Security=SSPI");
                    bank_list();
                    customer_list();
                    loan_list();
                }
                catch (Exception ex2)
                {
                    connection_group.Visible = true;
                    MessageBox.Show("Failed Database Connected (bankManagement)\n" + ex2.ToString());
                }


            }
           

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bank_update_button_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "update banks set bank_name='" + bank_name_textbox.Text + "',bank_email='" + bank_email_textbox.Text + "' where bank_id=" + bank_id_textbox.Text + "";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Bank has been updated Successfully");
                bank_id_textbox.Text = "";
                bank_name_textbox.Text = "";
                bank_email_textbox.Text = "";
                bank_name_textbox.Enabled = false;
                bank_email_textbox.Enabled = false;
                bank_list();
            }
            catch{}
            conn.Close();
        }

        private void bank_lists_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string bank_id = bank_lists.SelectedItems[0].SubItems[0].Text;
                string bank_name = bank_lists.SelectedItems[0].SubItems[1].Text;
                string bank_email = bank_lists.SelectedItems[0].SubItems[2].Text;
                bank_id_textbox.Text = bank_id.ToString();
                bank_name_textbox.Text = bank_name;
                bank_email_textbox.Text = bank_email;
                bank_name_textbox.Enabled = true;
                bank_email_textbox.Enabled = true;
            }
            catch { }
           
        }

        private void add_new_bank(object sender, EventArgs e)
        {

        }

        private void add_new_banks_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "insert into banks(bank_name,bank_email) values ('" + bank_new_name.Text + "','" + bank_new_email.Text + "')";
                cmd.ExecuteNonQuery(); 
                conn.Close();
                MessageBox.Show("Bank has been Added Successfully");
                bank_list();
            }
            catch { }
        }

        private void bank_remove_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "delete from banks where bank_id='" + bank_id_textbox.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Bank has been Removed Successfully");
            bank_list();
            }
            catch { }
        }

        private void update_cus_button_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                conn.Close();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "update customers set cus_name='" + cus_name_text.Text + "' where cus_id=" + cus_id_textbox.Text + "";
                cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "update cus_location set cus_city='" + cus_city_textbox.Text + "', cus_location='" + cus_location_textbox.Text + "' where cus_id=" + cus_id_textbox.Text + "";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Customer has been updated Successfully");
                cus_id_textbox.Text = "";
                cus_name_text.Text = "";
                cus_city_textbox.Text = "";
                cus_location_textbox.Text = "";
                bank_name_textbox.Enabled = false;
                bank_email_textbox.Enabled = false;
                customer_list();
            }
            catch { }
            conn.Close();
        }

        private void customer_lists_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string cus_id = customer_lists.SelectedItems[0].SubItems[0].Text;
                string cus_name = customer_lists.SelectedItems[0].SubItems[1].Text;
                cus_id_textbox.Text = cus_id.ToString();
                cus_name_text.Text = cus_name;
                cus_city_textbox.Text = getData("cus_location", "cus_id='" + cus_id_textbox.Text + "'", "cus_city");
                cus_location_textbox.Text = getData("cus_location", "cus_id='" + cus_id_textbox.Text + "'", "cus_location");
                cus_name_text.Enabled = true;
                cus_city_textbox.Enabled = true;
                cus_location_textbox.Enabled = true;
            }
            catch { }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                SqlCommand cmd = new SqlCommand();
            conn.Close();
            conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "delete from customers where cus_id='" + cus_id_textbox.Text + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from cus_location where cus_id='" + cus_id_textbox.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Customer has been Removed Successfully");
                customer_list();
           /* }
            catch { }*/
        }

        private void cus_add_new_Click(object sender, EventArgs e)
        {
           
            try{
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "insert into customers(cus_name) values ('" + cus_new_names_textbox.Text + "')SELECT SCOPE_IDENTITY()";
               
                string cus_primarykey = cmd.ExecuteScalar().ToString();
                conn.Close();
                conn.Open();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "insert into cus_location(cus_id,cus_city,cus_location) values ('" + cus_primarykey +  "','" + cus_new_city.Text + "'" + ",'" + cus_new_location.Text + "')";
                cmd2.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Customer has been Added Successfully");
                customer_list();
            conn.Close();
            }
            catch { }
        }

        private void loan_lists_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "insert into loans(bank_id,cus_id,amount) values ('" + loan_bank_id_textbox.Text + "','" + loan_cus_id_textbox.Text + "','" + loan_amount_textbox.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Loan has been Added Successfully");
                loan_list();
            }
            catch { }
        }

        private void removeLoan_Click(object sender, EventArgs e)
        {
            try
            {
           
                SqlCommand cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "delete from loans where loan_num='" + loan_lists.SelectedItems[0].SubItems[0].Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Loan has been Removed Successfully");
                loan_list();
            }
            catch { }
        }

        private void connect_database_button_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connect_string_textbox.Text);
                bank_list();
                customer_list();
                loan_list();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Failed Database Connected (bankManagement)\n" + ex2.ToString());
            }
        }
        public int isMessageAvaible = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem != null)
            {
            
                var device = (MMDevice)comboBox1.SelectedItem;

               int val = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
                int newval = val * 5;
                progressBar1.Value = newval > 99 ? 100 : newval;
                label20.Text = newval.ToString();

                if(val >= trackBar1.Value && isMessageAvaible == 0)
                {
                    isMessageAvaible = 1;
                    DialogResult dialogResult = new DialogResult();
                    dialogResult = MessageBox.Show("Hello, Welcome, I can hear you !!", "Hello", MessageBoxButtons.OK);
                    if (dialogResult == DialogResult.OK)
                    {
                        isMessageAvaible = 0;
                    }
                    
                    
                    



                }

            }
        }

   
        void wi_DataAvailable(object sender, WaveInEventArgs e)
        {
            bwp.AddSamples(e.Buffer, 0, e.BytesRecorded);

        }
    }
}

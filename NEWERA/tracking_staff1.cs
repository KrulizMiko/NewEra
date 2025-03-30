using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEWERA
{
    public partial class tracking_staff1 : Form
    {
        public void checkclient()
        {
            Application.Run(new WORKadmins());
        }
        public void minus()
        {
            Application.Run(new DELETED_staff());
        }
        public void plusik()
        {
            Application.Run(new PLUSstaff());
        }
        public tracking_staff1()
        {
            InitializeComponent();
        }
        public void vha()
        {
            Application.Run(new tracking_client1());
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread tha = new Thread(vha); tha.Start();  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tracking_staff1_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=auf_good.db;");
                SQLiteConnection DB = new SQLiteConnection(connection);
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter("SELECT * FROM employees", DB);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                DB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ооооой, ошибочка" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=auf_good.db;");
            SQLiteConnection DB = new SQLiteConnection(connection);
            SQLiteDataAdapter data = new SQLiteDataAdapter("SELECT * FROM employees", DB);

            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Thread thread = new Thread(plusik);
            thread.Start(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Thread s = new Thread(minus);
            s.Start();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           this.Close();
            Thread thread = new Thread(checkclient); thread.Start(); 
        }
    }
}

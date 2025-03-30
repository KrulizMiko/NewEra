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
    public partial class tracking_client1 : Form
    {
        public tracking_client1()
        {
            InitializeComponent();         
        }
        public void Work1()
        {
            Application.Run(new PLUSclient());
        }
        public void DELETED()
        {
            Application.Run(new delete_client());
        }
        public void Auto()
        {
            Application.Run(new authorization());
        }
        public void staffi ()
        {
            Application.Run(new tracking_staff1());
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void staff()
        {
           //кнопка для персонала

        }
        private void tracking_client1_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView6();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы вышли из аккаунта!!");
            this.Close();
            Thread tha = new Thread(Auto);
            tha.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread tha = new Thread(staffi); tha.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Thread tha = new Thread(DELETED);
            tha.Start();
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataIntoDataGridView6();
        }

        private void LoadDataIntoDataGridView6()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=auf_good.db;");
                SQLiteConnection DB = new SQLiteConnection(connection);
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter("SELECT * FROM clients", DB);
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

        private void button4_Click(object sender, EventArgs e)
        {
            Thread tha = new Thread(Work1);
            tha.Start();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=auf_good.db;");
            SQLiteConnection DB = new SQLiteConnection(connection);
            SQLiteDataAdapter data = new SQLiteDataAdapter("SELECT * FROM clients", DB);

            DataTable dt = new DataTable(); 
            data.Fill(dt);  
            dataGridView1.DataSource = dt;  
        }
    }
}

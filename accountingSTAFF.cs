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
    public partial class accountingSTAFF : Form
    {
        public accountingSTAFF()
        {
            InitializeComponent();
        }
        public void Uchott()
        {
         Application.Run(new WORKadmins());
        }
        public void Backi()
        {
            Application.Run(new WORKadmins()); 
        }

       

        private void LoadDataIntoDataGridView4()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=auf_good.db;");
                SQLiteConnection DB = new SQLiteConnection(connection);
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter("SELECT * FROM attendance_STAFF", DB);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(Uchott);
            thread.Start(); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(Backi);
            thread.Start(); 
        }

        private void accountingSTAFF_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView4();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

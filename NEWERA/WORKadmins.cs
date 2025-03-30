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
    public partial class WORKadmins : Form
    {
        public WORKadmins()
        {
            InitializeComponent();
        }
        public void backt()
        {
            Application.Run(new tracking_staff1());
        }
        public void Uchet()
        {
            Application.Run(new accountingSTAFF());
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataIntoDataGridView2();
        }

        private void LoadDataIntoDataGridView2()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=auf_good.db;");
                SQLiteConnection DB = new SQLiteConnection(connection);
                DB.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter("SELECT * FROM work_empi", DB);
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
            Thread tha = new Thread(Uchet);
            tha.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(backt);
            thread.Start();
        }

        private void WORKadmins_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView2();
        }



        private void button9_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=auf_good.db;");
            SQLiteConnection DB = new SQLiteConnection(connection);
            SQLiteDataAdapter data = new SQLiteDataAdapter("SELECT * FROM work_empi", DB);

            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        //запросы sql

        #region Непопулярный статус
        private void button4_Click(object sender, EventArgs e)
        {
            //непопулярный статус в клубе

            SQLiteConnection conn = new SQLiteConnection("Data Source=auf_good.db");
            SQLiteConnection DB = new SQLiteConnection(conn);

            string query = "SELECT status, count(*) as '*' FROM clients GROUP BY status ORDER BY '*' asc LIMIT 2;";
            DB.Open();
            try
            {
                SQLiteDataAdapter sda = new SQLiteDataAdapter(query, DB);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                MessageBox.Show($"Результат в Таблице! {dt}");
            }
            catch (Exception ex)
            { //обработчик ошибок запроса и коннекта в базу данных
                MessageBox.Show("Произшла ошибка в запросе " + ex.Message);
            }
            finally
            { //конец
                DB.Close();
            }
        }
        #endregion

        #region Кто больше всех потратил
        private void button3_Click(object sender, EventArgs e)
        {
            //кто больше потратил ( запрос sql)

            SQLiteConnection conn = new SQLiteConnection("Data Source=auf_good.db");
            SQLiteConnection DB = new SQLiteConnection(conn);

            string query = "SELECT id_client, SUM(SUMa) as SUMa FROM work_empi GROUP BY id_client ORDER BY SUMa desc LIMIT 2;";

            DB.Open();
            try
            {
                SQLiteDataAdapter sda = new SQLiteDataAdapter(query, DB);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                MessageBox.Show($"Результат в Таблице! Кто больше всех потатрил {dt}");
            }
            catch (Exception ex)
            { //обработчик ошибок запроса и коннекта в базу данных
                MessageBox.Show("Произшла ошибка в запросе " + ex.Message);
            }
            finally
            { //конец
                DB.Close();
            }
        }
        #endregion

        #region Непопулярный пакет
        private void button5_Click(object sender, EventArgs e)
        {
            // непопулярный пакет в клубе 

            SQLiteConnection conn = new SQLiteConnection("Data Source=auf_good.db");
            SQLiteConnection DB = new SQLiteConnection(conn);

            string query = "SELECT pack, count(*) as '*' FROM work_empi GROUP BY pack ORDER BY '*' asc LIMIT 2;";
            DB.Open();
            try
            {
                SQLiteDataAdapter sda = new SQLiteDataAdapter(query, DB);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                MessageBox.Show($"Результат в Таблице! {dt}");
            }
            catch (Exception ex)
            { //обработчик ошибок запроса и коннекта в базу данных
                MessageBox.Show("Произшла ошибка в запросе " + ex.Message);
            }
            finally
            { //конец
                DB.Close();
            }
        }
        #endregion

        #region Подорожание услуг на 5%
        private void button8_Click(object sender, EventArgs e)
        {
            // Подорожание услуг на 5% (table price)


            SQLiteConnection conn = new SQLiteConnection("Data Source=auf_good.db");
            SQLiteConnection DB = new SQLiteConnection(conn);



            string query = "UPDATE Cop SET [1_hour] = [1_hour] * 1.05;" +
                "UPDATE Cop SET [3_hours] = [3_hours] * 1.05;" +
                "UPDATE Cop SET [5_hours] = [5_hours] * 1.05 ;" +
                "UPDATE Cop SET daily = daily * 1.05;" +
                "SELECT * from Cop; ";

            DB.Open();
            try
            {
                SQLiteDataAdapter sda = new SQLiteDataAdapter(query, DB);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                MessageBox.Show($"Результат в Таблице! {dt}");
            }
            catch (Exception ex)
            { //обработчик ошибок запроса и коннекта в базу данных
                MessageBox.Show("Произшла ошибка в запросе " + ex.Message);
            }
            finally
            { //конец
                DB.Close();
            }
        }
        #endregion

        #region Сеанс за день
        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=auf_good.db");
            SQLiteConnection DB = new SQLiteConnection(conn);

            string query = "SELECT * FROM work_empi WHERE Dates = ('2024-05-03');";
            DB.Open();
            try
            {
                SQLiteDataAdapter sda = new SQLiteDataAdapter(query, DB);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                MessageBox.Show($"Результат в Таблице! {dt}");
            }
            catch (Exception ex)
            { //обработчик ошибок запроса и коннекта в базу данных
                MessageBox.Show("Произшла ошибка в запросе " + ex.Message);
            }
            finally
            { //конец
                DB.Close();
            }

        }
        #endregion

    }
}

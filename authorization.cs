using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;

namespace NEWERA
{
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
        }
        public void clients()
        {
            Application.Run(new client1());
        }
        public void adminka()
        {
            Application.Run(new tracking_client1());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string surname = Surname.Text;
            string neme = Name.Text;
            try
            {
                if (surname.Trim() == "" && neme.Trim() == "")
                {
                    MessageBox.Show("Ваши поля пусты!", "Заполните поля!");
                }
                else if (surname.Trim() == "")
                {
                    MessageBox.Show("Первое поле заполни бля");
                }
                else if (neme.Trim() == "")
                {
                    MessageBox.Show("Второе поле заполни бля");
                }//проверки на дурака
                else
                {
                    SQLiteConnection DB = new SQLiteConnection("Data Source=auf_good.db;");
                    string Clients = "SELECT count(*) from clients where nickname = @Nike and password = @Pass;";
                    string Employees = "SELECT count(*) from employees where Surname = @Nike and Name = @Pass;";
                    DB.Open();
                    SQLiteCommand onecmd = new SQLiteCommand(Clients, DB);
                    onecmd.Parameters.AddWithValue("@Nike", surname);
                    onecmd.Parameters.AddWithValue("@Pass", neme);
                    onecmd.ExecuteNonQuery();

                    SQLiteCommand twocmd = new SQLiteCommand(Employees, DB);
                    twocmd.Parameters.AddWithValue("@Nike", surname);
                    twocmd.Parameters.AddWithValue("@Pass", neme);
                    twocmd.ExecuteNonQuery();

                    long onecount = (long)onecmd.ExecuteScalar(); //проверка на наличие строки в таблице клиентов   
                    long twocount = (long)twocmd.ExecuteScalar(); //проверка на наличие строки в таблице сотрудников 
                    if (onecount > 0)
                    {
                        MessageBox.Show("Привет киберспортсмен!");
                        this.Close();
                        Thread thread = new Thread(clients);
                        thread.Start();
                    }
                    else if (twocount > 0)//для админов
                    {
                        MessageBox.Show("Доброго времени суток,сотрудник! Переношу вас в администрацию:");
                        this.Close();
                        Thread thread = new Thread(adminka);
                        thread.Start();
                    }
                    else
                    {
                        MessageBox.Show("Ваши данные не верны!", "error");
                    }
                    DB.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("Произошла ошибка авторизации!\n" + ex); }

        }
    }
    }


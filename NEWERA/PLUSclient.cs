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
    public partial class PLUSclient : Form
    {
        public PLUSclient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //БАЗА ДАННЫХ В DB BROWSER FOR SQLITE
            string connection = "Data Source=auf_good.db;";
            SQLiteConnection DB = new SQLiteConnection(connection);
            DB.Open();
            var Nam = Name.Text;
            var surnam = Surname.Text;
            var Aga = Age.Text;
            var stat = status.Text;  //переменные данные об клиенте (данные из полей)
            var nick = nickname.Text;
            var pass = password.Text;    //Значение переменных

            SQLiteCommand command = new SQLiteCommand("INSERT INTO clients(Surname, Name, Age, status, nickname, password) " +
                "VALUES (@Surname, @Name, @Age, @status, @nickname, @password) ", DB);
            command.Parameters.AddWithValue("@Surname", Surname.Text);
            command.Parameters.AddWithValue("@Name", Name.Text);      
            command.Parameters.AddWithValue("@Age", Age.Text);
            command.Parameters.AddWithValue("@status", status.Text);         //Заполняет поля: из поля tMail.Text в таблицу Usersa в колонку Mail
            command.Parameters.AddWithValue("@nickname", nickname.Text);
            command.Parameters.AddWithValue("@password", password.Text);
            command.ExecuteNonQuery();
            //регистрация данных клиента
            DB.Close();
            //БАЗА ДАННЫХ В DB BROWSER FOR SQLITE


            MessageBox.Show("Вы успешно добавили клиента!");
            this.Close();
        }

        private void nickname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

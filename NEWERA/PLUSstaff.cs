using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NEWERA
{
    public partial class PLUSstaff : Form
    {
        public PLUSstaff()
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
            var Aga = Vurname2.Text;
            var stat = num.Text;  //переменные данные об клиенте (данные из полей)
                //Значение переменных

            SQLiteCommand command = new SQLiteCommand("INSERT INTO employees(Surname, Name, Vurname2, number_passport, Token) " +
                "VALUES (@Surname, @Name, @Vurname2, @number_passport, @Token)", DB);
            command.Parameters.AddWithValue("@Surname", Surname.Text);
            command.Parameters.AddWithValue("@Name", Name.Text);
            command.Parameters.AddWithValue("@Vurname2", Vurname2.Text);
            command.Parameters.AddWithValue("@number_passport", num.Text);         //Заполняет поля: из поля tMail.Text в таблицу Usersa в колонку Mail
            command.Parameters.AddWithValue("@Token", tok.Text);
            command.ExecuteNonQuery();

            //регистрация данных клиента
            DB.Close();
            //БАЗА ДАННЫХ В DB BROWSER FOR SQLITE


            MessageBox.Show("Вы успешно добавили сотрудника!");
            this.Close();
        }
    }
}

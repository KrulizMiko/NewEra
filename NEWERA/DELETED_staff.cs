using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEWERA
{
    public partial class DELETED_staff : Form
    {
        public DELETED_staff()
        {
            InitializeComponent();
        }

        

        private void id_client_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=auf_good.db;");
            SQLiteConnection DB = new SQLiteConnection(connection);
            DB.Open();
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM employees where [id_ staff] = @id_staff", DB);
            cmd.Parameters.AddWithValue("@id_staff", poka.Text);
            int provka = cmd.ExecuteNonQuery();
            if (provka > 0)
            {
                MessageBox.Show($"Вы успешно удалили сотрудника под номером {poka.Text}");
                this.Close();
            }
            else
            {
                MessageBox.Show($"Сотрудник под номером {poka.Text} не найден");
            }
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEWERA
{
    public partial class client3 : Form
    {
        public client3()
        {
            InitializeComponent();
        }

        public void price()
        {
            Application.Run(new client2());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(price);
            thread.Start();
        }
    }
}

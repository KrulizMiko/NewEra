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
    public partial class client1 : Form
    {
        public client1()
        {
            InitializeComponent();
            
        }
         public void Bench()
        {
            Application.Run(new client3());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(Bench);
            thread.Start(); 
        }
    }
}

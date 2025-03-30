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
    public partial class client2 : Form
    {
        public client2()
        {
            InitializeComponent();
        }
        public void price()
        {
            Application.Run(new client3()); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen redPen = new Pen(Color.Red, 2);
            int x1= 100, y1 = 10;
            g.DrawLine(redPen, x1, y1, x1, y1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(price);
            th.Start();
        }
    }
}

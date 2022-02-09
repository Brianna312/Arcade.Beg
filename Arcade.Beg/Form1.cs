using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace Arcade.Beg
{
      
        private void button1_Click(object sender, EventArgs e)
        {
            //initial superficial changes
            button1.BackColor = Color.DarkBlue;
            Thread.Sleep(1000);
            Refresh();
            label1.Text = "Adventure starts in...";
            label1.Location = new Point(50, 50);
            button1.ForeColor = Color.CornflowerBlue;
            button1.BackColor = Color.CornflowerBlue;
            button1.Location = new Point(-999, -999);
         

            //countdown and duck           
            label2.Location = new Point(280, 200);
            label2.ForeColor = Color.Navy;
            label2.BackColor = Color.Transparent;
            Thread.Sleep(1000);
            Refresh();
            label2.Text = "2";
            Thread.Sleep(1000);
            Refresh();
            label2.Text = "1";
            Thread.Sleep(1000);
            Refresh();
            label2.Text = "GO!";
            Thread.Sleep(1000);
            Refresh();
            label2.Location = new Point(((int)ClientSize.Width / 2 )- 48, 200);
            Thread.Sleep(1000);
            Refresh();
            label2.Location = new Point(999, 999);           
            label1.Location = new Point(999, 999);
            pictureBox1.Location = new Point(12, -35);
            Thread.Sleep(1000);
            Refresh();
        }
        
    }
}

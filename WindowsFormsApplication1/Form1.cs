using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        void createbutton(string n, int a, int b1, int c, int d)
        {
            Button b = new Button();
            b.Name = n;
            b.Size = new Size(a, b1);
            b.Location = new Point(c, d);
            
            this.Controls.Add(b);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           




        }

        void drawscreen()
        {

            int t = cbbkichthuoc.SelectedIndex;
            int n=0;
            switch(t)
            {
                case 0:
                    n = 3;
                    break;
                case 1:
                    n = 4;
                    break;
                case 2:
                    n = 5;
                    break;
                case 3:
                    n = 6;
                    break;
                case 4:
                    n = 7;
                    break;
                case 5:
                    n = 8;
                    break;
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    string name = "bt" + i.ToString() + j.ToString();
                    createbutton(name, 40, 40, i * 40+2, j * 40+40);
                }
            }
            this.Size = new Size(n * 40 + 2, n * 40 + 40);
        }


      
        private void cbbkichthuoc_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (Control item  in this.Controls)
             {
                if (item is Button)
                    this.Controls.Remove(item);
            }
           // this.Controls.Clear();
            drawscreen();
           
        }
    }
}

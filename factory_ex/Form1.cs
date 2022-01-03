using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factory_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            creator[] a = new creator[2];
            a[0] = new Concretecreator_one();
            a[1] = new Concretecreator_tow();
            foreach(creator a1 in a)
            {
                product p = a1.Items();
                string b = p.GetType().Name;
                list.Items.Add("builder is:" + b);
            }
        }
    }
}

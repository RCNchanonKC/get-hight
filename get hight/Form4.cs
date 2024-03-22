using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace get_hight
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            label4.Text = marijuana.GetProperties();
            label5.Text = marijuana.GetSource();
            label6.Text = marijuana.GetPrice();
        }

        Marijuana marijuana = new Marijuana();
        private void SaveCSV_Click(object sender, EventArgs e)
        {
            CSV csv = new CSV();
            csv.SavetoFile(marijuana);
        }


        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label5.Text = kratom.GetProperties();
            label6.Text = kratom.GetSource();
            label7.Text = kratom.GetPrice();
        }

        
        KratomLeaves kratom = new KratomLeaves();
        private void SaveCSV_Click(object sender, EventArgs e)
        {
            CSV csv = new CSV();
            csv.SavetoFile(kratom);
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

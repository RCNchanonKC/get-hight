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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SpringOnioneing.Text = SpringOnion.GetProperties();
            labelsource.Text = SpringOnion.GetSource();
            label6.Text = SpringOnion.GetPrice();
        }
        private SpringOnion SpringOnion = new SpringOnion();


        private void SaveCSV_Click(object sender, EventArgs e)
        {
            CSV csv = new CSV();
            csv.SavetoFile(SpringOnion);
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}

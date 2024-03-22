using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace get_hight
{
    public class CSV
    {
        private string path = @"C:\Users\wavez\Documents\get hight\Data.csv";

        public bool SavetoFile(Herb herb)
        {

            string contents = herb.GetProperties() + "," + herb.GetSource() + "," + herb.GetPrice() + "\n";
            try
            {
                File.WriteAllText(path, contents);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}

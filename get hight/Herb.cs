using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace get_hight
{
    public class Herb
    {
        protected string properties;
        protected string source;
        protected string price;

        public virtual string GetProperties()
        {
            return properties;
        }
        public virtual string GetSource()
        {
            return source;
        }
        public virtual string GetPrice()
        {
            return price;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.DL
{
    class ItemsDL
    {
        public bool CheckList(List<string> Orders)
        {
            bool flag = false;
            foreach (String i in Orders)
            {
                if (i == null)
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Nikitin.ClassHelper
{
    public static class Calc
    {
        public static double Debt(DateTime dateStart, double price)
        {
            int dayCount = (DateTime.Now - dateStart).Days;
            double debt = (dayCount - 30) * 0.01 * price;
            if (debt > 0)
            {
                return debt;
            }
            else
            {
                return 0;
            }
        }
    }
}

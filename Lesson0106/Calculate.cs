using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Lesson0106
{
    public class Calculate
    {
        public static double calculate(string expression)
        {
            double exp;
            if (expression.Contains("^") == true)
            {
                String[] value = expression.Split(new char[] { '^' }, StringSplitOptions.RemoveEmptyEntries);

                DataTable table = new DataTable();
                table.Columns.Add("expression", typeof(string), value[0]);
                DataRow row = table.NewRow();
                table.Rows.Add(row);
                double val1 = double.Parse((string)row["expression"]);

                DataTable table1 = new DataTable();
                table1.Columns.Add("expression", typeof(string), value[1]);
                DataRow row1 = table1.NewRow();
                table1.Rows.Add(row1);
                double val2 = double.Parse((string)row1["expression"]);


                exp =  Math.Pow(val1, val2);

            }
            else
            {
                DataTable table = new DataTable();
                table.Columns.Add("expression", typeof(string), expression);
                DataRow row = table.NewRow();
                table.Rows.Add(row);
                exp = double.Parse((string)row["expression"]);

            }


            
           
            return exp;
            
        }

    }
}

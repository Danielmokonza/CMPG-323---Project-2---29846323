using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    class UserInfo
    {
        public void Connect()
        {
            SqlCommand comm;
            DataSet ds;
            SqlDataAdapter adap;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Simphiwe\source\repos\WindowsFormsApp1\WindowsFormsApp1\Inventory.mdf;Integrated Security=True");
         }

    }
}

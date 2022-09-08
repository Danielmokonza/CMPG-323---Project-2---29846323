using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {
        UserInfo userClass = new UserInfo();
        public SqlCommand comm;
        public DataSet ds;
        public SqlDataAdapter adap;

        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Simphiwe\source\repos\WindowsFormsApp1\WindowsFormsApp1\Inventory.mdf;Integrated Security=True");
        public Admin()
        {
            InitializeComponent();
            
        
    }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand command;
            string sql;
            SqlDataAdapter adapter = new SqlDataAdapter();

            sql = @"Select * FROM Items";
            command = new SqlCommand(sql, con);

            DataSet ds = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(ds, "Items");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Items";



            con.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand command;
            string sql;
            SqlDataAdapter adapter = new SqlDataAdapter();

            sql = @"SELECT * from DVDs WHERE Age LIKE '%" + txtBoxSearch.Text + "%'"; ;
            command = new SqlCommand(sql, con);

            DataSet ds = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(ds, "Items");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Items";
        }
    }
}

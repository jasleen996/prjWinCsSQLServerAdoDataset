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

namespace prjWinCsSQLServerAdoDataset
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            DataSet mySet = new DataSet();

            // create a connection to the database dbbusiness and open it
            SqlConnection myCon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBBusiness_7478;Integrated Security=True");
            myCon.Open();
           
            // create a command to the connection to request the table companies
            SqlCommand myCmd = new SqlCommand("SELECT * FROM Companies", myCon);

            // create a dataAdapter with the command, and fill (or insert) the dataset with the result of the command as a new datatable
            SqlDataAdapter myAdp = new SqlDataAdapter(myCmd);
            myAdp.Fill(mySet, "Companies");

            // create a command to the connection to request the table employees
            SqlCommand myCmd2 = new SqlCommand("SELECT * FROM Employees", myCon);

            // create a dataAdapter with the command, and fill (or insert) the dataset with the result of the command as a new datatable
            SqlDataAdapter myAdp2 = new SqlDataAdapter(myCmd2);
            myAdp2.Fill(mySet, "Employees");



            gridResults.DataSource = mySet.Tables["Companies"];
        }
    }
}

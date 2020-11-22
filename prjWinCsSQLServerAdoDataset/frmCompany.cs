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
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
        }
        // Global variables for form
        DataSet mySet;
        SqlConnection myCon;
        private void frmCompany_Load(object sender, EventArgs e)
        {
            mySet = new DataSet();

            myCon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBBusiness_7478;Integrated Security=True");
            myCon.Open();

            // create a command to the connection to request the table companies
            SqlCommand myCmd = new SqlCommand("SELECT * FROM Companies", myCon);

            // create a dataAdapter with the command, and fill (or insert) the dataset with the result of the command as a new datatable
            SqlDataAdapter myAdp = new SqlDataAdapter(myCmd);
            myAdp.Fill(mySet, "Companies");

            // display the first datarow (index 0) of the table Companies in the textboxes
            txtName.Text = mySet.Tables["Companies"].Rows[0]["CompanyName"].ToString();
            txtLocation .Text = mySet.Tables["Companies"].Rows[0]["Location"].ToString();
            txtType.Text = mySet.Tables["Companies"].Rows[0]["Type"].ToString();
            txtBudget.Text = mySet.Tables["Companies"].Rows[0]["Budget"].ToString();
            txtWebsite .Text = mySet.Tables["Companies"].Rows[0]["Website"].ToString();

        }
    }
}

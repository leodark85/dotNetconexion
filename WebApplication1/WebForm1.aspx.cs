using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            //Aqui me atore por que en el ejemplo que estaba siguiento era algo asi 
            //si usas sqlexpress
            SqlConnection con = new SqlConnection(@"data source=.\SQLEXPRESS; database=Company; integrated security= SSPI");
             //si no usas sqlexpress
            // SqlConnection con = new SqlConnection(@"data source=.; database=Company; integrated security= SSPI");

            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Company;User ID=CompanyClient;Password=septiembre");

            SqlCommand cmd = new SqlCommand("select * from tblEmployee",con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            con.Close();
        }
    }
}
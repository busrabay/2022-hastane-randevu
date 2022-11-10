using Siniflarim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Veritabanii;

namespace _2022_hantane_randevu
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            Useroperation api = new Useroperation();

            var user = new User();

            Response.Redirect("giris.aspx");

                
        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}
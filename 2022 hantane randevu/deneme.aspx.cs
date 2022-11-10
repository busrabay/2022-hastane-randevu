using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Veritabanii;
using Siniflarim;

namespace _2022_hantane_randevu
{
    public partial class deneme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Useroperation api = new Useroperation();
            var user = new User {
                usersId = 1,
                Name = txtName.Text,
                Age = txtAge.Text,

                email = emailtxt.Text,
                sifre =  Int32.Parse(sifretxt.Text),
                Tc= Int32.Parse( tctxt.Text),
            };
            
        }
    }
}
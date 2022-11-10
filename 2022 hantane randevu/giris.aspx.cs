using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace _2022_hantane_randevu
{
    public partial class giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void drp_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)MSSQLLocalDB;Initial Catalog=veritabani.randevu;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter adptr = new SqlDataAdapter("SELECET * FROM sehir",conn);
            DataTable tbl = new DataTable();
            adptr.Fill(tbl);
            drp_il.DataSource = tbl;
            drp_il.DataTextField = "sehir seçiniz";
            drp_il.DataValueField = "sehirId";
            drp_il.DataBind();
        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)MSSQLLocalDB;Initial Catalog=veritabani.randevu;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter adptr = new SqlDataAdapter("SELECET * FROM Hastaneadi", conn);
            DataTable tbl = new DataTable();
            adptr.Fill(tbl);
            drp_il.DataSource = tbl;
            drp_il.DataTextField = "hastane seçiniz";
            drp_il.DataValueField = "hastaneId";
            drp_il.DataBind();
        }

        protected void drp_poliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)MSSQLLocalDB;Initial Catalog=veritabani.randevu;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter adptr = new SqlDataAdapter("SELECET * FROM poliklinik", conn);
            DataTable tbl = new DataTable();
            adptr.Fill(tbl);
            drp_il.DataSource = tbl;
            drp_il.DataTextField = "poliklinik seçiniz";
            drp_il.DataValueField = "poliklinikId";
            drp_il.DataBind();
        }

        protected void drp_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)MSSQLLocalDB;Initial Catalog=veritabani.randevu;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter adptr = new SqlDataAdapter("SELECET * FROM doktor", conn);
            DataTable tbl = new DataTable();
            adptr.Fill(tbl);
            drp_il.DataSource = tbl;
            drp_il.DataTextField = "doktor seçiniz";
            drp_il.DataValueField = "doktorId";
            drp_il.DataBind();
        }

        protected void drp_tarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)MSSQLLocalDB;Initial Catalog=veritabani.randevu;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter adptr = new SqlDataAdapter("SELECET * FROM Randevu", conn);
            DataTable tbl = new DataTable();
            adptr.Fill(tbl);
            drp_il.DataSource = tbl;
            drp_il.DataTextField = "tarih seçiniz";
            drp_il.DataValueField = "randevuId";
            drp_il.DataBind();
        }

        protected void btn_randevu_Click(object sender, EventArgs e)
        {

        }
    }
}
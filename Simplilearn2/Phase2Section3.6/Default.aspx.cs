using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase2Section3._6
{
    public partial class _Default : Page
    {  
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCategory.Items.Add(new ListItem("", "0"));
                ddlCategory.Items.Add(new ListItem("Cat1", "1"));
                ddlCategory.Items.Add(new ListItem("Cat2", "2"));
                ddlCategory.Items.Add(new ListItem("Cat3", "3"));
                int counter = (int)Application["HitCounter"];
                counter++;
                Application["HitCounter"] = counter;
                int sessCounter = (int)Session["HitCounter"];
                sessCounter++;
                Session["HitCounter"] = sessCounter;
                lblHitCounterA.Text = counter.ToString();
                lblHitCounterS.Text = sessCounter.ToString();
                fname.Text = "John";
                //Calculate Random Number and place in hidValidationToken
                //Also store in Session Variable
            }
            else
            {

                if (FileUpload1.HasFile)
                {
                    FileUpload1.SaveAs(@"D:\Temp\Simplilearn\" + FileUpload1.FileName);
                }
            }

            if (Application["HitCounter"] != null && ((int)Application["HitCounter"]) % 2 == 0)
                Trace.Warn("Application Hit Counter is Even");
            else
                Trace.Warn("Application Hit Counter is Odd");

        }

        protected void ibGoogleMapsAddress_Click(object sender, ImageClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://map.google.com");
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlSubCat.Items.Clear();

            switch (ddlCategory.SelectedValue)
            {
                case "1":
                    ddlSubCat.Items.Add("SubCat1-1");
                    ddlSubCat.Items.Add("SubCat1-2");
                    ddlSubCat.Items.Add("SubCat1-3");
                    break;
                case "2":
                    ddlSubCat.Items.Add("SubCat2-1");
                    ddlSubCat.Items.Add("SubCat2-2");
                    ddlSubCat.Items.Add("SubCat2-3");
                    break;
                case "3":
                    ddlSubCat.Items.Add("SubCat3-1");
                    ddlSubCat.Items.Add("SubCat3-2");
                    ddlSubCat.Items.Add("SubCat3-3");
                    break;
            }

        }

        protected void ddlSubCat_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }

}
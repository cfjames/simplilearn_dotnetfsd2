using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase2Section3._5
{
    public partial class _Default : Page
    {
        string log = "";

        protected void Page_PreInit(object sender, EventArgs e)
        {
            log += "Page_PreInit()<br/>";
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            log += "Page_Init()<br/>";
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            log += "Page_InitComplete()<br/>";
        }


        protected override void OnPreLoad(EventArgs e)
        {
            log += "OnPreLoad()<br/>";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            log += "Page_Load()<br/>";
            lblName.Text = log;
        }

        protected override void OnPreRender(EventArgs e)
        {
            log += "OnPreRender()<br/>";
        }

        protected override void OnSaveStateComplete(EventArgs e)
        {
            log += "OnSaveStateComplete()<br/>";
            lblName.Text = log;
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //nothing will be displayed once page unloads
        }
    }
}
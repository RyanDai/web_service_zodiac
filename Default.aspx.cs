using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
            /*if (!IsPostBack)
            {
                string time = sc1.getTime();
                TimeLabel.Text = time;
            }*/
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient sc1 = new ServiceReference1.ServiceClient();
            string zodiac = ZodiacBox.Text;
            string result = sc1.getDate(zodiac);
            DateBox.Text = result;
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient sc1 = new ServiceReference1.ServiceClient();
            string month = MonBox.Text;
            string day = DayBox.Text;
            string result = sc1.getName(month, day);
            NameBox.Text = result;


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient sc1 = new ServiceReference1.ServiceClient();
            string area = DropDownList1.Text;
            string code = sc1.getPostCode(area);
            CodeLabel.Text = code;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //storing whatever is put into the text box
            string var = TextBox1.Text;

            //sorting the stirng array the user puts into the text box
            sr1.Service1Client sort = new sr1.Service1Client();
            string sorted = sort.sort(var);
            Label1.Text = sorted;
        }

    }
}

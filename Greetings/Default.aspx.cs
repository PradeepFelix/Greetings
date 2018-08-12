using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Greetings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GreetingMessage();

        }

        private void GreetingMessage()
        {
            var message = "Good Morning";
            var dateTimeHour = DateTime.Now.Hour;

            if (dateTimeHour > 15 && dateTimeHour < 21)
            {
                message = "Good Evening";
            }else if(dateTimeHour> 20)
            {
                message = "Good Night";
            }else if(dateTimeHour > 11 && dateTimeHour < 16)
            {
                message = "Good Afternoon";
            }

            Response.Write(message);
           

        }
    }
}
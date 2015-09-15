using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Converter_Temperatura.service
{
    public partial class converter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double celsius = float.Parse(Request.QueryString[0]);
            double index = 0;

            if(celsius != null)
            {
                index = ConverterService.GetIndex(celsius);
            }
        }
    }
}
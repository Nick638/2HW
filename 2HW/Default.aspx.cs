using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2HW {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e)
        {
            int N = 15, sum = 0;
            for (int start = 1; start <= N; start++)
            {
                if (start % 2 == 0 || start % 3 == 0)
                {
                    sum += start; //sum = sum +start

                }
            }
            Response.Write(sum);
        }
    }
}
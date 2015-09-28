using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NumericSequenceCalc.Domain;

namespace NumericSequenceCalc
{
    public partial class NumericSequenceCalc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SequenceCalculator sc = new SequenceCalculator();
            int number = 0;
            pnlOutput.Visible = true;
            if (int.TryParse(txtNumber.Text, out number))
            {
                lblS311.Text = sc.S311(number);
                lblS312.Text = sc.S312(number);
                lblS313.Text = sc.S313(number);
                lblS314.Text = sc.S314(number);
                lblS315.Text = sc.S315(number);
            }
        }
    }
}
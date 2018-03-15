using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quotation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal discountAmount = (Convert.ToDecimal(txtPrice.Text) * Convert.ToDecimal(txtDiscount.Text)/100);
            lblDiscountAmount.Text = discountAmount.ToString("c");
            lblTotalPrice.Text = (Convert.ToDecimal(txtPrice.Text) - Convert.ToDecimal(discountAmount)).ToString("c");
        }
    }
}
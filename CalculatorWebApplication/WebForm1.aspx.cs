﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalculatorWebApplication.CalculatorService;
namespace CalculatorWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // this is from the CalculatorService file Reference.cs
            CalculatorWebServiceSoapClient client = new CalculatorWebServiceSoapClient();
            int result =  client.AddTwoNumbers( 
                Convert.ToInt32(txtFirstNumber.Text),
                Convert.ToInt32(txtSecondNumber.Text)  
               );
            lblResult.Text = result.ToString();
        }
    }
}
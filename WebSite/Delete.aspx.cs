using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

public partial class Delete : System.Web.UI.Page
{
    //var to store rhe primary key value to be deleted
    Int32 CustomerNo;

    //event handler for load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get teh number of the customer to be deleted from the session object
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
    }
    void DeleteCustomer()
    {
        //function to delete the selected record
        clsCustomerCollection CustomerLog = new clsCustomerCollection();
        //find the record to delete
        CustomerLog.ThisCustomer.Find(CustomerNo);
        //delete the record
        CustomerLog.Delete();
    }
    //event handler for the yes button
    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteCustomer();
        //redirect back to the main page
        Response.Redirect("DefaultCustomer.aspx");
    }
}
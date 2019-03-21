using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

public partial class DefaultCustomer : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)

    {

        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    {
        //create an instance of Customer collection
        Class_Library.clsCustomerCollection CustomerLog = new Class_Library.clsCustomerCollection();
        //set the data source to the list of customers in the collection
        lstCustomers.DataSource = CustomerLog.CustomerList;
        //set the name of the primary key
        lstCustomers.DataValueField = "CustomerNo";
        //set the data fiel to display
        lstCustomers.DataTextField = "HouseNo";
        //bind the data to the list
        lstCustomers.DataBind();
    }
    //event handler for add
    protected void btnAddCar_Click(object sender, EventArgs e)
    {
        //store -1 into rhw awaaion object to indicate this is a new record
        Session["CustomerNo"] = -1;
        //redirect the data entry page
        Response.Redirect("ACustomer.aspx");

    }

    //event handler for delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerNo;
        //if a record has been selected from the list 
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to  delete
            CustomerNo = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in session object
            Session["CustomerNo"] = CustomerNo;
            //redirect to the delete page
            Response.Redirect("Delete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select record to delete from the list";
        }
    }

    //event handler for the update button

    protected void btnUpdateCustomerDetails_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerNo;
        //if a record has been selected from the list 
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to  delete
            CustomerNo = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in session object
            Session["CustomerNo"] = CustomerNo;
            //redirect to the edit page
            Response.Redirect("ACustomer.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select record to delete from the list";
        }
    }
}



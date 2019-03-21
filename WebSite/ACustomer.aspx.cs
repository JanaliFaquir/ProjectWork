using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;
public partial class ACustomer : System.Web.UI.Page
{
    //variable ot store the primary key with page level scope
    Int32 CustomerNo;
    //event handlerfor the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of customers to be processed
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
        if (IsPostBack == false)
        {
            //populate the list of Towns
            DisplayCustomers();
            //if this is not a new record
            if (CustomerNo !=-1)
            {
                //display the current data for the record
                DisplayCustomers();
            }
        }
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtHouseNo_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    //function for adding new record
    void Add()
    {
        //create an instance of the customer log
        clsCustomerCollection CustomerLog = new clsCustomerCollection();
        //validate the data on the web form 
        string Error = CustomerLog.ThisCustomer.Valid(txtFirstName.Text, txtSurname.Text,txtEmail.Text, txtStreet.Text, txtPostCode.Text, txtHouseNo.Text, txtPhoneNo.Text, txtDateSold.Text);
        //if the data is OK then add it to the object
        if(Error =="")
        {
            //get the data entered by the user
            CustomerLog.ThisCustomer.FirstName = txtFirstName.Text;
            CustomerLog.ThisCustomer.Surname = txtSurname.Text;
            CustomerLog.ThisCustomer.Email = txtEmail.Text;
            CustomerLog.ThisCustomer.Street = txtStreet.Text;
            CustomerLog.ThisCustomer.PostCode = txtPostCode.Text;
            CustomerLog.ThisCustomer.Town = ddlTown.Text;
            CustomerLog.ThisCustomer.HouseNo = txtHouseNo.Text;
            CustomerLog.ThisCustomer.PhoneNo = txtPhoneNo.Text;
            CustomerLog.ThisCustomer.DateSold = Convert.ToDateTime(txtDateSold.Text);
            CustomerLog.ThisCustomer.Active = chkActive.Checked;
            //add the record 
            CustomerLog.Add();
            //all done so redirect to main page
            Response.Redirect("DefaultCustomer.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data you entered" + Error;
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //add the new record
        Add();
        //all done so redirect to main page
        Response.Redirect("DefaultCustomer.aspx");
    }
    //function for adding new record
    void Update()
    {
        //create an instance of the customer log
        clsCustomerCollection CustomerLog = new clsCustomerCollection();
        //validate the data on the web form 
        string Error = CustomerLog.ThisCustomer.Valid(txtFirstName.Text, txtSurname.Text, txtEmail.Text, txtStreet.Text, txtPostCode.Text, txtHouseNo.Text, txtPhoneNo.Text, txtDateSold.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            CustomerLog.ThisCustomer.Find(CustomerNo);
            //get the data entered by the user
            CustomerLog.ThisCustomer.FirstName = txtFirstName.Text;
            CustomerLog.ThisCustomer.Surname = txtSurname.Text;
            CustomerLog.ThisCustomer.Email = txtEmail.Text;
            CustomerLog.ThisCustomer.Street = txtStreet.Text;
            CustomerLog.ThisCustomer.PostCode = txtPostCode.Text;
            CustomerLog.ThisCustomer.Town = ddlTown.Text;
            CustomerLog.ThisCustomer.HouseNo = txtHouseNo.Text;
            CustomerLog.ThisCustomer.PhoneNo = txtPhoneNo.Text;
            CustomerLog.ThisCustomer.DateSold = Convert.ToDateTime(txtDateSold.Text);
            CustomerLog.ThisCustomer.Active = chkActive.Checked;
            //update the record 
            CustomerLog.Update();
            //all done so redirect to main page
            Response.Redirect("DefaultCustomer.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data you entered" + Error;
        }
    }


    protected void btnOK_Click1(object sender, EventArgs e)
    {
        if (CustomerNo == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
    }
    void DisplayCustomers()
    {
        //create an instance of Customer collection
        Class_Library.clsCustomerCollection CustomerLog = new Class_Library.clsCustomerCollection();
        //Find the records to update
        CustomerLog.ThisCustomer.Find(CustomerNo);
        //display the data for this record
        txtFirstName.Text = CustomerLog.ThisCustomer.FirstName;
        txtSurname.Text = CustomerLog.ThisCustomer.Surname;
        txtEmail.Text = CustomerLog.ThisCustomer.Email;
        txtStreet.Text = CustomerLog.ThisCustomer.Street;
        txtPostCode.Text = CustomerLog.ThisCustomer.PostCode;
        ddlTown.Text = CustomerLog.ThisCustomer.Town;
        txtHouseNo.Text = CustomerLog.ThisCustomer.HouseNo;
        txtDateSold.Text = CustomerLog.ThisCustomer.ToString();
        chkActive.Checked = CustomerLog.ThisCustomer.Active;
    }
}
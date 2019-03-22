using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DefaultManufacturer : System.Web.UI.Page
{
    Int32 ManufacturerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of manufacturer to proceed 
        ManufacturerID = Convert.ToInt32(Session["ManufacturerID"]);
        if (IsPostBack == false)
        {
           
            if (ManufacturerID != -1)
            {

                //display the current data for the record 
                DisplayManufacturers();

            }
        }
    }

    void DisplayManufacturers()
    {
        // create an instance of collection 
        Class_Library.clsManufacturerCollection ManufacturerLog = new Class_Library.clsManufacturerCollection();
        //set the data source to the list of addresses in the collection 
        lstManufacturers.DataSource = ManufacturerLog.ManufacturerList;
        //set the name of the primary ey 
        lstManufacturers.DataValueField = "ManufacturerID";
        //set the data filed to display 
        lstManufacturers.DataTextField = "CarModel";
        //bind the data to the list 
        lstManufacturers.DataBind();

    }

    //event ahandler add 
    protected void btnAddManufacturer_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to idivate this is a new record 
        Session["ManufacturerID"] = -1;
        //reirect to the data entry page 
        Response.Redirect("AnManufacturer.aspx");
    }

    //event handler delete 
    protected void btnDeleteManufacturer_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted 
        Int32 ManufacturerID;
        //if a record has been selectd from the list 
        if (lstManufacturers.SelectedIndex != -1)
        {
            //get the primary key value f the record to delte 
            ManufacturerID = Convert.ToInt32(lstManufacturers.SelectedValue);
            //store the data in the session object 
            Session["ManufacturerID"] = ManufacturerID;
            //redirect to the delte page 
            Response.Redirect("DeleteManufacturer.aspx");

        }
        else //if no record has been selected 
        {
            //display an error 
            lblError.Text = "Please select a record to delete from the list";
        }

        
    }

    //event handler update 
    protected void btnUpdateManufacturerDetails_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited 
        Int32 ManufacturerID;
        // if a recordhas been selected from the list 
        if (lstManufacturers.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            ManufacturerID = Convert.ToInt32(lstManufacturers.SelectedIndex);
            //store the data i the session object 
            Session["ManufacturerID"] = ManufacturerID;
            //redirect to the edit page 
            Response.Redirect("AnManufacturer.aspx");
        }
        else //if no record has been selected 
        {
            //display an error 
            lblError.Text = "Please select a record to delete from the list";
        }

        
    }

    protected void btnAddManufacturer_Click1(object sender, EventArgs e)
    {
        Response.Redirect("AnManufacturer.aspx");

    }
}

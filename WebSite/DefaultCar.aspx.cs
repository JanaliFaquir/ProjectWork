using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DefaultCar : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be edited
    Int32 CarID;

    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        CarID = Convert.ToInt32(Session["CarID"]);
        if (IsPostBack == false)
        {
            //populate the list of colours
            DisplayCars();
        }
    }

    void DisplayCars()
    {
        //create an instance of the Car Collection
        Class_Library.clsCarCollection CarLog = new Class_Library.clsCarCollection();
        //set the data source to the list of cars in the colllection
        lstCars.DataSource = CarLog.CarList;
        //set the name of the primary key
        lstCars.DataValueField = "CarID";
        //set the data field to display
        lstCars.DataTextField = "Model";
        //bind the data to the list
        lstCars.DataBind();
    }

    protected void btnAddCar_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CarID"] = -1;
        //redirect to the data entry page
        Response.Redirect("ACar.aspx?CarID=-1");
    }

    //event handler for the delete button
    protected void btnDeleteCar_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CarID;
        //if a record has been selected from the list
        if(lstCars.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CarID = Convert.ToInt32(lstCars.SelectedValue);
            //store the data in the session object
            Session["CarID"] = CarID;
            //redirect to the delete page
            Response.Redirect("DeleteCar.aspx");
        }
        else //if no record has been deleted
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }

    }

    //event handler for the update button
    protected void btnUpdateCarDetails_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CarID;
        //if a record has been selected from the list
        if (lstCars.SelectedIndex !=-1)
        {
            //get the primary key value of the record to edit
            CarID = Convert.ToInt32(lstCars.SelectedIndex);
            //store the data in the session object
            Session["CarID"] = CarID;
            //redirect to the update page
            Response.Redirect("ACar.aspx?CarID=" + CarID);
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "please select a record to delete from the list";
        }
        //this line of code re-directs to the  main page
        Response.Redirect("ACar.aspx");
    }
}
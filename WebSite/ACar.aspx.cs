using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

public partial class ACar : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be edited
    Int32 CarID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //copy the data from the query string to the text box cardid
        CarID = Convert.ToInt32(Request.QueryString["CarID"]);
        if (IsPostBack != true)
        {
            //if this is not a new record
            DisplayColours();
            //if the carid is not -1 then display the data from the record
            if (CarID != -1)
            {
                //display the existing data
                DisplayCar(CarID);
            }
        }
    }

    ////event handler for the ok button
    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (CarID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //updaate the record
            Update();
        }
            //all done so redirect back to the main page
            Response.Redirect("DefaultCar.aspx");
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the car log
        Class_Library.clsCarCollection CarLog = new Class_Library.clsCarCollection();
        //validate the date on the web form
        String Error = CarLog.ThisCar.Valid(txtCarName.Text, txtModel.Text, txtBodyType.Text, txtYearMade.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            CarLog.ThisCar.CarName = txtCarName.Text;
            CarLog.ThisCar.Model = txtModel.Text;
            CarLog.ThisCar.BodyType = txtBodyType.Text;
            CarLog.ThisCar.Price = Convert.ToDecimal(txtPrice.Text);
            CarLog.ThisCar.Stock = Convert.ToInt32(txtStock.Text);
            CarLog.ThisCar.YearMade = Convert.ToDateTime(txtYearMade.Text);
            CarLog.ThisCar.Fuel = chkDiesel.Checked = true;
            CarLog.ThisCar.Fuel = chkPetrol.Checked = false;
            CarLog.ThisCar.ColourNo = Convert.ToInt32(ddlColourNo.SelectedValue);
            //add the record
            CarLog.Add();
            //all  done to redirect back to the main page
            Response.Redirect("DefaultCar.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "there were problems with the data entered" + Error;
        }
    }

    void Update()
    {
        //create an instance of the car log
        Class_Library.clsCarCollection CarLog = new Class_Library.clsCarCollection();
        //validate the date on the web form
        String Error = CarLog.ThisCar.Valid(txtCarName.Text, txtModel.Text, txtBodyType.Text, txtYearMade.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            CarLog.ThisCar.Find(CarID);
            //get the data entered by the user
            CarLog.ThisCar.CarName = txtCarName.Text;
            CarLog.ThisCar.Model = txtModel.Text;
            CarLog.ThisCar.BodyType = txtBodyType.Text;
            CarLog.ThisCar.Price = Convert.ToDecimal(txtPrice.Text);
            CarLog.ThisCar.Stock = Convert.ToInt32(txtStock.Text);
            CarLog.ThisCar.YearMade = Convert.ToDateTime(txtYearMade.Text);
            CarLog.ThisCar.Fuel = chkDiesel.Checked = true;
            CarLog.ThisCar.Fuel = chkPetrol.Checked = false;
            CarLog.ThisCar.ColourNo = Convert.ToInt32(ddlColourNo.SelectedValue);
            //update the record
            CarLog.Update();
            //all  done to redirect back to the main page
            Response.Redirect("DefaultCar.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "there were problems with the data entered" + Error;
        }
    }

    void DisplayCar(Int32 CarID)
    {
        //create an instance of the car log
        clsCarCollection CarLog = new clsCarCollection();
        //find the record to update
        CarLog.ThisCar.Find(CarID);
        //display the car name
        txtCarName.Text = CarLog.ThisCar.CarName;
        //display the model
        txtModel.Text = CarLog.ThisCar.Model;
        //display the body type
        txtBodyType.Text = CarLog.ThisCar.BodyType;
        //display the price
        txtPrice.Text = Convert.ToString(CarLog.ThisCar.Price);
        //display the stock
        txtStock.Text = Convert.ToString(CarLog.ThisCar.Stock);
        //display the year made
        txtYearMade.Text = CarLog.ThisCar.YearMade.ToString("dd/MM/yyyy");
        //display the check boxes
        chkDiesel.Checked = CarLog.ThisCar.Fuel = true;
        chkPetrol.Checked = CarLog.ThisCar.Fuel = false;
        //display the drop down list
        ddlColourNo.SelectedValue = Convert.ToString(CarLog.ThisCar.ColourNo);
    }

    //function for populating the colour drop down list
    void DisplayColours()
    {
        //create an instance of the Colour Collection
        Class_Library.clsColourCollection Colours = new Class_Library.clsColourCollection();
        //set the data source to the list of colours in the collection
        ddlColourNo.DataSource = Colours.AllColours;
        //set the name of the primary key
        ddlColourNo.DataValueField = "ColourNo";
        //set the data field to display
        ddlColourNo.DataTextField = "ColourName";
        //bind the data to the list
        ddlColourNo.DataBind();
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("DefaultCar.aspx");
    }
}
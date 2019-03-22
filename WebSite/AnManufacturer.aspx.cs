using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library; 


public partial class AnManufacturer : System.Web.UI.Page
{
    Int32 ManufacturerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        {
            DisplayBatchProduction();
        }
        // if this is not a new record 
    }

    // event handler ok button 
    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (ManufacturerID == -1)
        {

            //add new record
            Add();
        }
      else
        {
            Update();
        }
        //all done so redirect back to the main papge 
        Response.Redirect("DefaultManufacturer.aspx");
    }

    void Add()
    {
        //create an instance of the manufacturer book 
        Class_Library.clsManufacturerCollection ManufacturerLog = new Class_Library.clsManufacturerCollection();
        //validate the dat aon the web form 
        String Error = ManufacturerLog.ThisManufacturer.Valid(txtCarModel.Text, txtChairMan.Text, txtEmail.Text, txtYearMade.Text);
        //if the data is ok then add it ot th eobjet 
        if (Error == "")
        {
            //get the data entered by  the user 
            ManufacturerLog.ThisManufacturer.CarModel = txtCarModel.Text;
            ManufacturerLog.ThisManufacturer.ChairMan = txtChairMan.Text;
            ManufacturerLog.ThisManufacturer.Email = txtEmail.Text;
            ManufacturerLog.ThisManufacturer.PhoneNo = Convert.ToInt32(txtPhoneNo.Text);
            ManufacturerLog.ThisManufacturer.YearMade = Convert.ToDateTime(txtYearMade.Text);
            ManufacturerLog.ThisManufacturer.Available = ChkAvailable.Checked;
            ManufacturerLog.ThisManufacturer.BatchProductionNo = Convert.ToInt32(ddlBatchProduction.SelectedValue);
            //add the record 
            ManufacturerLog.Add();
            // all done 
            Response.Redirect("DefaultManufacturer.aspx");
        }
        else
        {
            //report error 
            lblError.Text = "There were problems with the data entered " + Error; 
        }
    }

    void Update()
    {
        //create an instance of the manufacturer log 
        Class_Library.clsManufacturerCollection ManufacturerLog = new Class_Library.clsManufacturerCollection();
        //validate the data on the web form 
        String Error = ManufacturerLog.ThisManufacturer.Valid(txtCarModel.Text, txtChairMan.Text, txtEmail.Text, txtYearMade.Text);
        // if the data us ok then add it to the object 
        if (Error == "")
        {
            ManufacturerLog.ThisManufacturer.Find(ManufacturerID);
            //get the data entered by  the user 
            ManufacturerLog.ThisManufacturer.CarModel = txtCarModel.Text;
            ManufacturerLog.ThisManufacturer.ChairMan = txtChairMan.Text;
            ManufacturerLog.ThisManufacturer.Email = txtEmail.Text;
            ManufacturerLog.ThisManufacturer.PhoneNo = Convert.ToInt32(txtPhoneNo.Text);
            ManufacturerLog.ThisManufacturer.YearMade = Convert.ToDateTime(txtYearMade.Text);
            ManufacturerLog.ThisManufacturer.Available = ChkAvailable.Checked;
            ManufacturerLog.ThisManufacturer.BatchProductionNo = Convert.ToInt32(ddlBatchProduction.SelectedValue);
            //update the record 
            ManufacturerLog.Update();
            // all done 
            Response.Redirect("DefaultManufacturer.aspx");
        }
        else
        {
            //report error 
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void DisplayManufacturer()
    {
        //create an instance of manufacturer log 
        clsManufacturerCollection ManufacturerLog = new clsManufacturerCollection();
        //find the record to update 
        ManufacturerLog.ThisManufacturer.Find(ManufacturerID);
        // display the data for the record 
        txtCarModel.Text = ManufacturerLog.ThisManufacturer.CarModel;
        txtChairMan.Text = ManufacturerLog.ThisManufacturer.ChairMan;
        txtEmail.Text = ManufacturerLog.ThisManufacturer.Email;
        txtPhoneNo.Text = ManufacturerLog.ThisManufacturer.PhoneNo.ToString();
        txtChairMan.Text = ManufacturerLog.ThisManufacturer.YearMade.ToString();
        ChkAvailable.Checked = ManufacturerLog.ThisManufacturer.Available = true ;
        ddlBatchProduction.SelectedValue = ManufacturerLog.ThisManufacturer.BatchProductionNo.ToString();

    }

    void DisplayBatchProduction()
    {
        //cretae an intance of the batch production collection 
        Class_Library.clsBatchProductionCollection BatchProduction = new Class_Library.clsBatchProductionCollection();
        //set teh data 
        ddlBatchProduction.DataSource = BatchProduction.AllBatchProductions;
        //SET THE NAME 
        ddlBatchProduction.DataValueField = "BatchProductionNo";
        //set the data field to display 
        ddlBatchProduction.DataTextField = "BatchProduction";
        //bind the data to the list 
        ddlBatchProduction.DataBind();
    }
   
}
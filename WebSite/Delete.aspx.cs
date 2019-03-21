using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;

public partial class Delete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 CarID;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        CarID = Convert.ToInt32(Session["CarID"]);

    }

    void DeleteCar()
    {
    //function to delete the selected record

        //create a new instance of the car
        clsCarCollection CarLog = new clsCarCollection();
        //find the record to delete
        CarLog.ThisCar.Find(CarID);
        //delete the record
        CarLog.Delete();
    }


    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteCar();
        //redirect back to the main page
        Response.Redirect("DefaultCar.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to tthe main page 
        Response.Redirect("DefaultCar.aspx");
    }
}
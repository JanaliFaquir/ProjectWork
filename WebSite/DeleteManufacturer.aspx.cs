using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library; 

public partial class DeleteManufacturer : System.Web.UI.Page
{

    Int32 ManufacturerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the manufacturer to be deleted from the session object 
        ManufacturerID = Convert.ToInt32(Session["ManufacturerID"]);

    }

    void DeleteManufacturer()
    {
        //function to delte the selected record 
        //creat enew instane of manufacturer log 
        clsManufacturerCollection ManufacturerLog = new clsManufacturerCollection();
        //find the record to delete 
        ManufacturerLog.ThisManufacturer.Find(ManufacturerID);
        //delete the record 
        ManufacturerLog.DeleteManufacturer(); 

        }

    //event hnadler for he yes button
    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record 
        DeleteManufacturer();
        ///redirect back to tthe main page 
        Response.Redirect("DefaultManufacturer.aspx"); 
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        
        ///redirect back to tthe main page 
        Response.Redirect("DefaultManufacturer.aspx");
    }

}
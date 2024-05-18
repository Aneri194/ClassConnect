using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Display notifications when the page is first loaded
            ShowNotifications();
        }

    }
    protected void ShowNotifications()
    {
        try
        {
            string connectionString = "<YourConnectionString>"; // Replace with your actual connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Query to select notifications from the database
                string query = "SELECT name, title, date FROM Notifications";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                GridView2.DataSource = reader;
                GridView2.DataBind();
                reader.Close();
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions
            lblnew.Text = "Error loading notifications: " + ex.Message;
        }
    }
    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Read")
        {
            // Handle the read command, for example, redirect to a page to view the full notification details
            string title = e.CommandArgument.ToString();
            Response.Redirect("NotificationDetails.aspx?title=" + title);
        }

    }

}
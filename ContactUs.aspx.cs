using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ContactUs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionStringName"].ConnectionString;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO ContactUs (Name, Email, Subject, Message, SubmissionDate) VALUES (@Name, @Email, @Subject, @Message, GETDATE())";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@Subject", txtSubject.Text);
                command.Parameters.AddWithValue("@Message", txtMessage.Text);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MVC_API.DataBaseAccessLayer
{
    public class DataBase
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);

        public String GetLink(String component, String category)
        {
            SqlCommand command= new SqlCommand("GetLinkByComponentAndCat",con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@component", component);
            command.Parameters.AddWithValue("@category", category);
            SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
            con.Open();
            String link = (String)command.ExecuteScalar();
            //SqlDataReader dr = command.ExecuteReader();
            //if (dr.Read())
            //{
              //  string simpleValue = dr.GetString(0);
                //return simpleValue;
            //}
            //else
            //{
            //  dr.Read();
            //string simpleValue = dr.GetString(0);
            //return simpleValue;
            //}
            return link;                   
        }
        public Boolean AddComponent(String NewComponent)
        {
            SqlCommand command = new SqlCommand("AddNewComponent", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Component", NewComponent);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;

            }
            else
            {
                return false;

            }
        }

        public Boolean AddCategoryToComponent(String Component,String Category, String link)
        {
            SqlCommand command = new SqlCommand("AddNewCategoryToComponent", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Component", Component);
            command.Parameters.AddWithValue("@category", Category);
            command.Parameters.AddWithValue("@link", link);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;

            }
            else
            {
                return false;

            }
        }

    }
}
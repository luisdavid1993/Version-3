using System;
using System.Data;

namespace streamingcpanel.DataAccess
{
	
	public class DATools
	{
		public DATools()
		{
		}

		public static double getRecurrenteForUser( string userID )
		{
            double recurrente = 0;
            try
			{
			string query1 = "";
			query1 = query1 + " SELECT SUM(dinero) FROM G_Services ";
			query1 = query1 + " WHERE FK_User =  " + userID;

            streamingcpanel.DataAccess.ClassSQL mySQL = new streamingcpanel.DataAccess.ClassSQL();
            DataTable myTable1 = mySQL.GetAllDataFromQuery(query1, "G_Services").Tables[0];
            mySQL.cerrar();


            recurrente = double.Parse( myTable1.Rows[0][0].ToString() );
            return recurrente;
            }
            catch 
            {

                return recurrente;
            
            }

		}
	}
}

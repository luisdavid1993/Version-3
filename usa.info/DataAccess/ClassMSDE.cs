using System;
using System.Data;
using System.Data.SqlClient;





namespace streamingcpanel.DataAccess
{
	public class ClassSQL
	{
		public ClassSQL()
		{
		}

		private  string _ConnectionString = streamingcpanel.Constantes.CNN_STRING;

		private  DataSet ds = new DataSet();
		private  SqlDataAdapter dest = new SqlDataAdapter();

		public  void cerrar()
		{
			ds.Dispose();
			dest.Dispose();
		}
		public  void USER_RunDirectQuery( string sql)
		{
			try
			{
				SqlConnection myconn = new SqlConnection( _ConnectionString );
				SqlCommand myCommand = new SqlCommand(sql, myconn);
				myCommand.Connection.Open();
				myCommand.ExecuteNonQuery();
				myconn.Close();
			}
			catch( Exception e )
			{
				throw( e );
			}
		}				


		public  DataSet GetAllDataFromQuery(string query, string table)
		{
			
			try
			{	
				ds = new DataSet();
				SqlConnection conn;
				SqlCommandBuilder custCB;
				conn = new SqlConnection(_ConnectionString);
				dest = new SqlDataAdapter();
				dest.SelectCommand = new SqlCommand(query, conn);
				custCB = new SqlCommandBuilder(dest);
				dest.Fill(ds, table );
				return ds;

			}
			catch( Exception ex )
			{
				throw( ex );
			}
		}


//		public static void inserNewUserAccount( UserAccountEntity myAcc)
//		{
//			try
//			{
//
//				string insertQuery = "INSERT INTO " + enumTableUserAccounts.G_USER_ACCOUNTS.ToString() + 
//				" ( " +
//				enumTableUserAccounts.FK_User.ToString() + 
//				"," + enumTableUserAccounts.FK_Account_Type +
//				"," + enumTableUserAccounts.LimitCnn +
//				"," + enumTableUserAccounts.Name +
//				"," + enumTableUserAccounts.Price +
//				"," + enumTableUserAccounts.Type +
//				" ) VALUES ( " +
//				myAcc.User_FK_User.ToString() +
//				"," + myAcc.User_FK_Account_Type +
//				"," + myAcc.User_LimitCnn +
//				",'" + myAcc.User_Name + "'" +
//				"," + myAcc.User_Price +
//				"," + myAcc.User_Type +
//				") ";
//
//				USER_RunDirectQuery( insertQuery );
//			}
//			catch( Exception ex)
//			{
//				throw( ex );
//			}
//			
//
//
//		}
		

		#region Cities
//		public static DataTable GetDataTableCities( )
//		{
//			try
//			{
//				DataTable myTable = new DataTable();
//				myTable.Columns.Add( "ID");
//				myTable.Columns.Add( "NAME");
//				myTable.Columns.Add( "CODE");
//				
//				string query = "SELECT * FROM C_Cities ORDER BY Name ASC";
//				ds = GetAllDataFromQuery( query,"C_Cities" );
//				foreach( DataRow myR in ds.Tables[0].Rows )
//				{
//					DataRow myRow = myTable.NewRow();
//					myRow["ID"]= myR["PK_ID"].ToString().Trim();
//					myRow["NAME"]= myR["Name"].ToString().Trim();
//					myRow["CODE"]= myR["Code"].ToString().Trim();
//					myTable.Rows.Add( myRow );
//
//				}
//				return myTable;
//
//			}
//			catch
//			{
//				return null;
//			}			
//		}
//
//		public static string GetCodeCiti( decimal id, out string city )
//		{
//			string code = "";
//			city="";
//			try
//			{
//
//				string query = "SELECT * FROM C_Cities WHERE PK_ID = " + id;
//				ds = GetAllDataFromQuery( query,"C_Cities" );
//				if ( ds.Tables[0].Rows.Count > 0 )
//				{
//					code= ds.Tables[0].Rows[0]["Code"].ToString().Trim();
//					city= ds.Tables[0].Rows[0]["Name"].ToString().Trim();
//				}
//				return code;
//
//			}
//			catch
//			{
//				return null;
//			}			
//		}
//
//		public static void newCity(decimal id, string name,string code,  bool edit)
//		{
//			
//			try
//			{
//				string insertQuery = "";
//				if ( edit )
//				{
//					insertQuery = "UPDATE C_Cities" +  
//						" SET Name"  + "='" + name.Trim() + "'," +
//						" Code" + "='" + code.Trim() + "'" +
//						" WHERE " + enumTableIPTVChannelsAddress.PK_ID + "=" + id;
//				}
//				else
//				{
//					insertQuery = "INSERT INTO C_Cities" + 
//						" ( Name, Code ) VALUES ( '" +
//						name.Trim() + "'" +
//						",'" + code.Trim() + "'" +
//						") ";
//				}
//
//				ClassSQL.USER_RunDirectQuery( insertQuery );
//			}
//			catch( Exception ex)
//			{
//				throw( ex );
//			}
//			
//
//
//		}

		#endregion

		


		
		
	}
}

using System;
using System.Data;
using System.Data.SqlClient;

using streamingcpanel.Objects;



namespace streamingcpanel.DataAccess
{
	/// <summary>
	/// Summary description for DACountries.
	/// </summary>
	public class DACountries
	{
		private  DataSet ds = new DataSet();
		private  SqlDataAdapter dest = new SqlDataAdapter();

        private string _ConnectionString = streamingcpanel.Constantes.CNN_STRING;

        public DACountries()
		{
		}

		public  void cerrar()
		{
			ds.Dispose();
			dest.Dispose();
		}
		public   DataSet GetAllEnabledPaises()
		{
			try
			{
				string query = "SELECT * FROM F_Paises ";
				query = query + " WHERE State = 1 " ;
				query = query + " ORDER BY Name ASC ";
				ds = GetAllData( query );
				return ds;
			}
			catch( Exception e )
			{
				throw( e );
			}			
		}
		public   DataSet GetAllData( string query )
		{
			try
			{	
				DataSet ds = new DataSet();
				SqlConnection conn;
				SqlCommandBuilder custCB;
				conn = new SqlConnection(_ConnectionString);
				dest.SelectCommand = new SqlCommand(query, conn);
				custCB = new SqlCommandBuilder(dest);
				dest.Fill(ds,"F_Paises");
				return ds;

			}
			catch( Exception ex )
			{
				throw( ex );
			}	
		}
        public  string getIDByCode(string countryCode)
        {
            try
            {
                string name = "";

                string query = "SELECT * FROM F_Paises ";
                query = query + " WHERE country_code = '" + countryCode + "'";

                ds = GetAllData(query);
                if (ds.Tables[0].Rows.Count > 0)
                    name = ds.Tables[0].Rows[0]["PK_ID"].ToString();
                //cerrar();
                return name;


            }
            catch
            {
                return "";
            }
        }
		public  string getNameByCode( string countryCode)
		{
			try
			{
				string name = "";
				
				string query = "SELECT * FROM F_Paises ";
				query = query + " WHERE country_code = '"+ countryCode + "'" ;

				ds = GetAllData( query );
				if ( ds.Tables[0].Rows.Count>0 )
					name = ds.Tables[0].Rows[0]["Name"].ToString();
                //cerrar();
				return name ;
				
				
			}
			catch
			{
				return "";
			}
		}
		public  string getName( string id)
		{
			try
			{
				string name = "?";
				DataRow dr;
				string query = "SELECT Name FROM F_Paises WHERE PK_ID =" + id.ToString();
				ds = GetAllData( query );
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dr = ds.Tables[0].Rows[0];
                    name = dr["Name"].ToString();
                }
                //cerrar();
				return name ;
				
				
			}
			catch
			{
				return "";
			}
		}



		
		public  DataTable getUSAStates()
		{
			DataTable myTable = new DataTable();	
			DataRow myRow;

			myTable.Columns.Add("ID" );
			myTable.Columns.Add("SHORTNAME" ); 
			myTable.Columns.Add("NAME" );  
						
			myRow = myTable.NewRow();
			myRow["ID"] = "0";
			myRow["SHORTNAME"] = "dd";
			myRow["NAME"] = "Choose a State";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "1";
			myRow["SHORTNAME"] = "AL";
			myRow["NAME"] = "Alabama";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "2";
			myRow["SHORTNAME"] = "AK";
			myRow["NAME"] = "Alaska";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "3";
			myRow["SHORTNAME"] = "AZ";
			myRow["NAME"] = "Arizona";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "4";
			myRow["SHORTNAME"] = "AR";
			myRow["NAME"] = "Arkansa";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "5";
			myRow["SHORTNAME"] = "CA";
			myRow["NAME"] = "California";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "6";
			myRow["SHORTNAME"] = "CO";
			myRow["NAME"] = "Colorado";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "7";
			myRow["SHORTNAME"] = "CT";
			myRow["NAME"] = "Connecticut";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "8";
			myRow["SHORTNAME"] = "DC";
			myRow["NAME"] = "D.C.";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "9";
			myRow["SHORTNAME"] = "DE";
			myRow["NAME"] = "Delaware";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "10";
			myRow["SHORTNAME"] = "FL";
			myRow["NAME"] = "Florida";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "11";
			myRow["SHORTNAME"] = "GA";
			myRow["NAME"] = "Georgia";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "12";
			myRow["SHORTNAME"] = "HI";
			myRow["NAME"] = "Hawaii";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "13";
			myRow["SHORTNAME"] = "ID";
			myRow["NAME"] = "Idaho";
			myTable.Rows.Add( myRow );
			
			myRow = myTable.NewRow();
			myRow["ID"] = "14";
			myRow["SHORTNAME"] = "IL";
			myRow["NAME"] = "Illinois";
			myTable.Rows.Add( myRow );
			
			myRow = myTable.NewRow();
			myRow["ID"] = "15";
			myRow["SHORTNAME"] = "IN";
			myRow["NAME"] = "Indiana";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "16";
			myRow["SHORTNAME"] = "IA";
			myRow["NAME"] = "Iowa";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "17";
			myRow["SHORTNAME"] = "KS";
			myRow["NAME"] = "Kansas";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "18";
			myRow["SHORTNAME"] = "KY";
			myRow["NAME"] = "Kentucky";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "19";
			myRow["SHORTNAME"] = "LA";
			myRow["NAME"] = "Louisiana";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "20";
			myRow["SHORTNAME"] = "MD";
			myRow["NAME"] = "Maryland";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "21";
			myRow["SHORTNAME"] = "MA";
			myRow["NAME"] = "Massachusetts";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "22";
			myRow["SHORTNAME"] = "ME";
			myRow["NAME"] = "Maine";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "23";
			myRow["SHORTNAME"] = "MI";
			myRow["NAME"] = "Michigan";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "24";
			myRow["SHORTNAME"] = "MN";
			myRow["NAME"] = "Minnesota";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "25";
			myRow["SHORTNAME"] = "MS";
			myRow["NAME"] = "Mississippi";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "26";
			myRow["SHORTNAME"] = "MO";
			myRow["NAME"] = "Missouri";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "27";
			myRow["SHORTNAME"] = "MT";
			myRow["NAME"] = "Montana";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "28";
			myRow["SHORTNAME"] = "NE";
			myRow["NAME"] = "Nebraska";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "29";
			myRow["SHORTNAME"] = "NV";
			myRow["NAME"] = "Nevada";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "30";
			myRow["SHORTNAME"] = "NH";
			myRow["NAME"] = "New Hampshire";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "31";
			myRow["SHORTNAME"] = "NJ";
			myRow["NAME"] = "New Jersey";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "32";
			myRow["SHORTNAME"] = "NM";
			myRow["NAME"] = "New Mexico";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "33";
			myRow["SHORTNAME"] = "NY";
			myRow["NAME"] = "New York";
			myTable.Rows.Add( myRow );
						
			myRow = myTable.NewRow();
			myRow["ID"] = "34";
			myRow["SHORTNAME"] = "NC";
			myRow["NAME"] = "North Carolina";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "35";
			myRow["SHORTNAME"] = "ND";
			myRow["NAME"] = "North Dakota";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "36";
			myRow["SHORTNAME"] = "OH";
			myRow["NAME"] = "Ohio";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "37";
			myRow["SHORTNAME"] = "OK";
			myRow["NAME"] = "Oklahoma";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "38";
			myRow["SHORTNAME"] = "OR";
			myRow["NAME"] = "Oregon";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "39";
			myRow["SHORTNAME"] = "PA";
			myRow["NAME"] = "Pennsylvania";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "40";
			myRow["SHORTNAME"] = "RI";
			myRow["NAME"] = "Rhode Island";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "41";
			myRow["SHORTNAME"] = "SC";
			myRow["NAME"] = "South Carolina";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "42";
			myRow["SHORTNAME"] = "SD";
			myRow["NAME"] = "South Dakota";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "43";
			myRow["SHORTNAME"] = "TN";
			myRow["NAME"] = "Tennessee";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "44";
			myRow["SHORTNAME"] = "TX";
			myRow["NAME"] = "Texas";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "45";
			myRow["SHORTNAME"] = "UT";
			myRow["NAME"] = "Utah";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "46";
			myRow["SHORTNAME"] = "VT";
			myRow["NAME"] = "Vermont";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "47";
			myRow["SHORTNAME"] = "VA";
			myRow["NAME"] = "Virginia";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "48";
			myRow["SHORTNAME"] = "WA";
			myRow["NAME"] = "Washington";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "49";
			myRow["SHORTNAME"] = "WV";
			myRow["NAME"] = "West Virginia";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "50";
			myRow["SHORTNAME"] = "WI";
			myRow["NAME"] = "Wisconsin";
			myTable.Rows.Add( myRow );
			
			myRow = myTable.NewRow();
			myRow["ID"] = "51";
			myRow["SHORTNAME"] = "WY";
			myRow["NAME"] = "Wyoming";
			myTable.Rows.Add( myRow );

			return myTable;

			

		}


		public  DataTable getTimeZones()
		{
			DataTable myTable = new DataTable();	
			DataRow myRow;

			myTable.Columns.Add("ID" );
			myTable.Columns.Add("SHORTNAME" ); 
			myTable.Columns.Add("NAME" );  
						
			myRow = myTable.NewRow();
			myRow["ID"] = "0";
			myRow["SHORTNAME"] = "Choose a TimeZone";
			myRow["NAME"] = "Choose a TimeZone";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "1";
			myRow["SHORTNAME"] = "GMT -12";
			myRow["NAME"] = "(GMT-12:00) International Date Line West";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "2";
			myRow["SHORTNAME"] = "GMT -11";
			myRow["NAME"] = "(GMT-11:00) Midway Island, Samoa ";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "3";
			myRow["SHORTNAME"] = "GMT -10";
			myRow["NAME"] = "(GMT-10:00) Hawaii ";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "4";
			myRow["SHORTNAME"] = "GMT -9";
			myRow["NAME"] = "(GMT-9:00) Alaska ";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "5";
			myRow["SHORTNAME"] = "GMT -8";
			myRow["NAME"] = "(GMT-8:00) Pacific Time (USA & Canada); Tijuana ";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "6";
			myRow["SHORTNAME"] = "GMT -7";
			myRow["NAME"] = "(GMT-7:00) Mountain Time (USA & Canada) Arizona; Chihuahua; La Paz; Mazatlan ";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "7";
			myRow["SHORTNAME"] = "GMT -6";
			myRow["NAME"] = "(GMT-6:00) Central Time (US & Canada); Guadalajara;Mexico City;Monterrey ";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "8";
			myRow["SHORTNAME"] = "GMT -5";
			myRow["NAME"] = "(GMT-5:00) Eastern Time (US & Canada); Bogota; ";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "9";
			myRow["SHORTNAME"] = "GMT -4";
			myRow["NAME"] = "(GMT-4:00) Atlantic Time (Canada); Caracas, La Paz; Santiago  ";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "10";
			myRow["SHORTNAME"] = "GMT -3";
			myRow["NAME"] = "(GMT-3:00) Brasilia, Buenos Aires ";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "11";
			myRow["SHORTNAME"] = "GMT -2";
			myRow["NAME"] = "(GMT-2:00) Mid-Atlantic ";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "12";
			myRow["SHORTNAME"] = "GMT -1";
			myRow["NAME"] = "(GMT-1:00) Azores,  Cape Verde Is. ";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "13";
			myRow["SHORTNAME"] = "GMT";
			myRow["NAME"] = "(GMT) Greenwich Mean Time: Dublin, Lisbon, London, Casablanca ";
			myTable.Rows.Add( myRow );
			
			myRow = myTable.NewRow();
			myRow["ID"] = "14";
			myRow["SHORTNAME"] = "GMT +1";
			myRow["NAME"] = "(GMT+1:00) Amsterdam, Berlin, Bern, Rome, Vienna, Madrid, Paris; West Central Africa ";
			myTable.Rows.Add( myRow );
			
			myRow = myTable.NewRow();
			myRow["ID"] = "15";
			myRow["SHORTNAME"] = "GMT +2";
			myRow["NAME"] = "(GMT+2:00) Istanbul; Bucharest; Cairo; Sofia ";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "16";
			myRow["SHORTNAME"] = "GMT +3";
			myRow["NAME"] = "(GMT+3:00) Baghdad; Kuwait; Moscow";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "17";
			myRow["SHORTNAME"] = "GMT +4";
			myRow["NAME"] = "(GMT+4:00) Baku, Yerevan";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "18";
			myRow["SHORTNAME"] = "GMT +5";
			myRow["NAME"] = "(GMT+5:00) Islamabad, Karachi, Taskent";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "19";
			myRow["SHORTNAME"] = "GMT +6";
			myRow["NAME"] = "(GMT+6:00) Almaty, Astana";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "20";
			myRow["SHORTNAME"] = "GMT +7";
			myRow["NAME"] = "(GMT+7:00) Bangkok, Hanoi, Jakarta";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "21";
			myRow["SHORTNAME"] = "GMT +8";
			myRow["NAME"] = "(GMT+8:00) Beijing, Hong Kong, Singapore";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "22";
			myRow["SHORTNAME"] = "GMT +9";
			myRow["NAME"] = "(GMT+9:00) Osaka, Sapporo, Tokyo";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "23";
			myRow["SHORTNAME"] = "GMT +10";
			myRow["NAME"] = "(GMT+10:00) Canberra, Melbourne, Sydney";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "24";
			myRow["SHORTNAME"] = "GMT +11";
			myRow["NAME"] = "(GMT+11:00) Magadan, New Caledonia";
			myTable.Rows.Add( myRow );

			myRow = myTable.NewRow();
			myRow["ID"] = "25";
			myRow["SHORTNAME"] = "GMT +12";
			myRow["NAME"] = "(GMT+12:00) Fiji, Kamchatka, Marshall Is.";
			myTable.Rows.Add( myRow );

			return myTable;

			

		}

	}
}

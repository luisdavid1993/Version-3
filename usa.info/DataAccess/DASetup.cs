using System;
using System.Data;
using System.Data.SqlClient;

using streamingcpanel.Objects;


namespace streamingcpanel.DataAccess
{
	public enum setting_keys
	{
		emailNotifications,
        Licencia,
        LicenciaCheck,
        LicenciaReverso
		
	}

	public class DBSetup
	{
		

		private enum DBF_Setting
		{
			G_Setting,
			PK_ID,
            FK_User,
			Name, //50
			SettingValue //Memo
		}

		private  string _ConnectionString = streamingcpanel.Constantes.CNN_STRING;

		private  DataSet ds = new DataSet();
		private  SqlDataAdapter dest = new SqlDataAdapter();


		public DBSetup()
		{
		}

		public void cerrar()
		{
			ds.Dispose();
			dest.Dispose();
		}

		public  DataSet GetAllData( string query )
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
				dest.Fill(ds,DBF_Setting.G_Setting.ToString());
				return ds;

			}
			catch( Exception e )
			{
				throw( e );
			}			
		}

		public  string getSetting( string name, string defaultValue)
		{
			string settingValue = defaultValue;
			try
			{
				string query = "SELECT * FROM " + DBF_Setting.G_Setting.ToString() + 
					" WHERE " + DBF_Setting.Name.ToString() + "= '" + name + "'";
				ds= GetAllData( query);
				if ( ds.Tables[0].Rows.Count > 0 )
				{
					settingValue = ds.Tables[0].Rows[0][DBF_Setting.SettingValue.ToString()].ToString();
				}
				cerrar();
				return settingValue;
				
			}
			catch( Exception ex)
			{
				return settingValue;
			}
			

		}

		public  void saveSetting( string name, string valueSetting )
		{
			string query = "SELECT * FROM " + DBF_Setting.G_Setting.ToString() + 
				" WHERE " + DBF_Setting.Name.ToString() + "= '" + name + "'";
			ds= GetAllData( query);

			DataRow myRow = null;
			bool bNew = false;
			if ( ds.Tables[0].Rows.Count > 0 )
			{
				myRow = ds.Tables[0].Rows[0];
				bNew = false;
			}
			else
			{
				myRow = ds.Tables[0].NewRow();
				bNew = true;
			}

            myRow[DBF_Setting.Name.ToString()] = name.Trim() + "";
            myRow[DBF_Setting.SettingValue.ToString()] = valueSetting.Trim() + "";
            myRow[DBF_Setting.FK_User.ToString()] = 0;
			
			if ( bNew )
				ds.Tables[0].Rows.Add( myRow );
			
			dest.Update( ds,ds.Tables[0].TableName.ToString());
			
		}

        public void saveSetting(string name, string valueSetting, string userID)
        {
            string query = "SELECT * FROM " + DBF_Setting.G_Setting.ToString() +
                " WHERE " + DBF_Setting.Name.ToString() + "= '" + name + "' AND Fk_User = " + userID;
            ds = GetAllData(query);

            DataRow myRow = null;
            bool bNew = false;
            if (ds.Tables[0].Rows.Count > 0)
            {
                myRow = ds.Tables[0].Rows[0];
                bNew = false;
            }
            else
            {
                myRow = ds.Tables[0].NewRow();
                bNew = true;
            }

            myRow[DBF_Setting.Name.ToString()] = name.Trim() + "";
            myRow[DBF_Setting.SettingValue.ToString()] = valueSetting.Trim() + "";
            myRow[DBF_Setting.FK_User.ToString()] = userID;

            if (bNew)
                ds.Tables[0].Rows.Add(myRow);

            dest.Update(ds, ds.Tables[0].TableName.ToString());
            
        }

        public string getSetting(string name, string defaultValue, string userID)
        {
            string settingValue = defaultValue;
            try
            {
                string query = "SELECT * FROM " + DBF_Setting.G_Setting.ToString() +
                    " WHERE " + DBF_Setting.Name.ToString() + "= '" + name + "' AND Fk_User = " + userID;
                ds = GetAllData(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    settingValue = ds.Tables[0].Rows[0][DBF_Setting.SettingValue.ToString()].ToString().Trim() + "";
                }
                
                return settingValue;

            }
            catch
            {
                return settingValue;
            }


        }
	}
}

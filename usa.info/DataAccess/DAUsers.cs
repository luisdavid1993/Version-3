using System;
using System.Data;
using System.Data.SqlClient;

 

namespace streamingcpanel.DataAccess
{
	
	public class DAUsers
	{
		private  DataSet ds = new DataSet();
		private  SqlDataAdapter dest = new SqlDataAdapter();
		
		private  string _ConnectionString = streamingcpanel.Constantes.CNN_STRING;

		public DAUsers()
		{}

		public  void cerrar()
		{
			ds.Dispose();
			dest.Dispose();
		}

		#region save

        public  void SaveUserPersonalData(UserData myUser, string userID)
        {
            try
            {
                string query = "SELECT * FROM " + enumTableUser.G_Users.ToString() + " Where " + enumTableUser.PK_ID.ToString() + " = " + userID;
                ds = _GetAllUser(query);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    ds.Tables[0].Rows[0][enumTableUser.UserPass.ToString()] = myUser.User_UserPassword.Trim();

                    ds.Tables[0].Rows[0][enumTableUser.UserName.ToString()] = myUser.User_name.Trim();
                    ds.Tables[0].Rows[0][enumTableUser.UserMail.ToString()] = myUser.User_USerEmail.Trim();

                    ds.Tables[0].Rows[0][enumTableUser.UserWebPage.ToString()] = myUser.User_USerWebPage.Trim();
                    ds.Tables[0].Rows[0][enumTableUser.UserMail.ToString()] = myUser.User_USerEmail.Trim();
                    ds.Tables[0].Rows[0][enumTableUser.UserPhone.ToString()] = myUser.User_UserPhone.Trim();

                    ds.Tables[0].Rows[0][enumTableUser.UserCompany.ToString()] = myUser.User_UserCompany.Trim();
                    ds.Tables[0].Rows[0][enumTableUser.Address.ToString()] = myUser.User_USerAddress.Trim();

                    ds.Tables[0].Rows[0][enumTableUser.City.ToString()] = myUser.User_USerCity.Trim();
                    ds.Tables[0].Rows[0][enumTableUser.FK_UserCountry.ToString()] = myUser.User_FK_UserCountry;
                    ds.Tables[0].Rows[0][enumTableUser.ZipCode.ToString()] = myUser.User_UserZipCode.Trim();
       
                    dest.Update(ds, ds.Tables[0].TableName.ToString());
                }

                //cerrar();

            }
            catch (Exception e)
            {
                throw (e);
            }
        }

		public  UserData SaveUser( UserData myUser, bool isNew)
		{
			try
			{
                //streamingcpanel.Objects.ClassEmailSended.usuarios_EmailGeneral(myUser.User_name, "Usuarios", "", "");

				string query =  "SELECT * FROM " + enumTableUser.G_Users.ToString();

				ds = _GetAllUser( query );

				DataRow dr;
				DataRow[] drid = ds.Tables[0].Select( enumTableUser.UserLogin.ToString() + " = '" + myUser.User_USerLogin + "'");
				if ( isNew )
				{
					if ( drid.Length >0 ) 
					{
						throw( new Exception( "User Login found" ) );
					}
					dr= ds.Tables[0].NewRow();
				}
				else
				{
					drid = ds.Tables[0].Select( enumTableUser.PK_ID.ToString() + " = " + myUser.User_ID + "");
					if ( drid.Length == 0 ) 
					{
						throw( new Exception( "User Not found" ) );
					}
					dr= drid[0];
					
				}
				
				dr[enumTableUser.UserLogin.ToString()] = myUser.User_USerLogin.Trim();
				dr[enumTableUser.UserPass.ToString()] = myUser.User_UserPassword.Trim();

                if (isNew)
                {
                    dr[enumTableUser.F_Alta.ToString()] = System.DateTime.Now;
                    dr[enumTableUser.UserPath.ToString()] = myUser.User_path.Trim();
                }
				
				dr[enumTableUser.FK_resellerID.ToString()] = myUser.User_resellerID;
				dr[enumTableUser.F_Expired.ToString()] = myUser.User_F_Expired;
				dr[enumTableUser.F_NextPayment.ToString()] = myUser.User_F_NextPayment;
				
				dr[enumTableUser.UserCompany.ToString()] = myUser.User_UserCompany.Trim();
				dr[enumTableUser.UserMail.ToString()] = myUser.User_USerEmail.Trim();
				dr[enumTableUser.UserWebPage.ToString()] = myUser.User_USerWebPage.Trim();
				dr[enumTableUser.UserName.ToString()] = myUser.User_name.Trim();
				
				dr[enumTableUser.UserPhone.ToString()] = myUser.User_UserPhone.Trim();
				dr[enumTableUser.FK_UserCountry.ToString()] = myUser.User_FK_UserCountry;
				dr[enumTableUser.FK_USAState.ToString()] = myUser.UserFK_USAState.ToString().Trim();
				dr[enumTableUser.Address.ToString()] = myUser.User_USerAddress.Trim();
				dr[enumTableUser.City.ToString()] = myUser.User_USerCity.Trim();
				dr[enumTableUser.ZipCode.ToString()] = myUser.User_UserZipCode.Trim();
				
				dr[enumTableUser.UserType.ToString()] = myUser.User_UserType;
				dr[enumTableUser.UserState.ToString()] = myUser.User_UserState;
                dr[enumTableUser.CRM.ToString()] = myUser.User_CRM;
				dr[enumTableUser.PaymentType.ToString()] = myUser.User_EsGratis;
				dr[enumTableUser.Description.ToString()] = myUser.User_Description;
				dr[enumTableUser.LocalTime.ToString()] = myUser.User_LocalTime;


                dr[enumTableUser.alerta.ToString()] = myUser.User_Alert;

				if ( isNew )
					ds.Tables[0].Rows.Add( dr );

				dest.Update( ds,ds.Tables[0].TableName.ToString());
				
				if ( isNew )
				{
					dest.Fill(ds,enumTableUser.G_Users.ToString());
					//					streamingcpanel.WMS.CreateOnDemandPoint newOnD = new streamingcpanel.WMS.CreateOnDemandPoint();
					//					newOnD.CreateNewOnDemandPoint(myUser.User_USerLogin.Trim(),myUser.User_path.Trim());
					DataRow[] dridFoundNew = ds.Tables[0].Select( enumTableUser.UserLogin.ToString() + " = '" + myUser.User_USerLogin.Trim() + "'");
					myUser.User_ID = decimal.Parse( dridFoundNew[dridFoundNew.Length-1][enumTableUser.PK_ID.ToString()].ToString() );				
				}
                //cerrar();
				return myUser;
				
			}
			catch( Exception e )
			{
				throw( e );
			}
		}

  

		#endregion

		#region getData terminado el cerrar
        public  bool checkIfUserEnabled(string id)
        {
            string name = "";
            bool isEnabled = false;
            try
            {
                string query = "SELECT * FROM " + enumTableUser.G_Users.ToString() + " Where " + enumTableUser.PK_ID.ToString() + " = " + id;
                ds = _GetAllUser(query);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    name = ds.Tables[0].Rows[0][enumTableUser.UserState.ToString()].ToString().Trim() + "";
                    if (name.Equals("1"))
                        isEnabled = true;
                }

                //cerrar();
                return isEnabled;

            }
            catch
            {
                return false;

            }

        }
		public string checkEmailToRequestClave( string login , out string clave , out string id )
		{
			string email = "";
			clave = "";
			id = "";
			try
			{
				string query = "SELECT * FROM " + enumTableUser.G_Users.ToString() +
					" WHERE " + enumTableUser.UserLogin.ToString() + " ='" + login + "'" ;

				ds = _GetAllUser( query );
				if ( ds.Tables[0].Rows.Count > 0 )
				{
					id = ds.Tables[0].Rows[0][enumTableUser.PK_ID.ToString()].ToString();
					email = ds.Tables[0].Rows[0][enumTableUser.UserMail.ToString()].ToString();			
					clave = ds.Tables[0].Rows[0][enumTableUser.UserPass.ToString()].ToString();			
				}
                //cerrar();
				return email;

			}
			catch( Exception e )
			{
				throw( e );
			}		


		}

        public string GetUserAlerta(string id)
        {
            string name = "";
            try
            {
                string query = "SELECT * FROM " + enumTableUser.G_Users.ToString() + " Where " + enumTableUser.PK_ID.ToString() + " = " + id;
                ds = _GetAllUser(query);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    name = ds.Tables[0].Rows[0][enumTableUser.alerta.ToString()].ToString().Trim() + "";
                }

                //cerrar();	
                return name;

            }
            catch
            {
                return "";

            }

        }

        public  string GetUserName( decimal id)
		{
			string name = "";
			try
			{
				string query = "SELECT * FROM " + enumTableUser.G_Users.ToString() + " Where " + enumTableUser.PK_ID.ToString() + " = " + id; 
				ds = _GetAllUser( query );
				
				
				if ( ds.Tables[0].Rows.Count > 0 )
				{
					name = ds.Tables[0].Rows[0][enumTableUser.UserName.ToString()].ToString().Trim() + "";
				}
				
                //cerrar();	
				return name;

			}
			catch
			{
				return "";
				
			}
			
		}

		public  string GetUserLogin( decimal id)
		{
			string name = "";
			try
			{
				string query = "SELECT * FROM " + enumTableUser.G_Users.ToString() + " Where " + enumTableUser.PK_ID.ToString() + " = " + id; 
				ds = _GetAllUser( query );
				
				
				if ( ds.Tables[0].Rows.Count > 0 )
				{
					name = ds.Tables[0].Rows[0][enumTableUser.UserLogin.ToString()].ToString().Trim() + "";
				}
				
                //cerrar();	
				return name;

			}
			catch
			{
				return "";
				
			}
			
		}

		public  string getUserPassword( string user, out string userName, out string to)
		{

			try
			{
				userName ="";
				string pass = "";
				to = "";
				string query = "SELECT * FROM " + enumTableUser.G_Users.ToString() + " WHERE UserLogin = '" + user + "'"; 
				ds = _GetAllUser( query );

				if ( ds.Tables[0].Rows.Count > 0 )
				{
					pass = ds.Tables[0].Rows[0][enumTableUser.UserPass.ToString()].ToString().Trim() + "";
					userName = ds.Tables[0].Rows[0][enumTableUser.UserName.ToString()].ToString().Trim() + "";
					to = ds.Tables[0].Rows[0][enumTableUser.UserMail.ToString()].ToString().Trim() + "";
					
				}
				else
					throw( new Exception( "Login incorred: " + user ) );
				
                //cerrar();
				return pass;

			}
			catch( Exception e )
			{
				throw( e );
			}
			
			
		}
				
		
		public  UserData ValidUser( string user, string password)
		{
			UserData myUser = new UserData();

			try
			{
				string query = "SELECT * FROM " + enumTableUser.G_Users.ToString() + " WHERE UserLogin = '" + user + "' AND UserPass = '" + password + "'"; 
				ds = _GetAllUser( query );

				if ( ds.Tables[0].Rows.Count > 0 )
				{
					myUser = _loadUserData( ds.Tables[0].Rows[0] );
					myUser.User_loginTime = System.DateTime.Now.ToString();
				}
				else
					throw( new Exception( "Invalid user: " + user ) );
				
				//if ( DateTime.Parse( myUser.User_F_Expired ) < System.DateTime.Now )
				//	throw( new Exception( "Account Expired" ) );

				if ( myUser.User_UserState != 1 )
					throw( new Exception( "Account Disable" ) );

                //cerrar();
				return myUser;

			}
			catch( Exception e )
			{
				throw( e );
			}
			
			
		}
		
		public  UserData _loadUserData( DataRow userRow)
		{

			UserData myUser = new UserData();
			myUser.User_ID			= decimal.Parse( userRow[enumTableUser.PK_ID.ToString()].ToString());
			myUser.User_resellerID		= decimal.Parse( userRow[enumTableUser.FK_resellerID.ToString()].ToString() ) ;
			myUser.User_USerLogin = userRow[enumTableUser.UserLogin.ToString()].ToString().Trim() + "";
			
            myUser.User_path = userRow[enumTableUser.UserPath.ToString()].ToString().Trim() + "";
            
			myUser.User_name = userRow[enumTableUser.UserName.ToString()].ToString().Trim() + "";
			myUser.User_USerEmail = userRow[enumTableUser.UserMail.ToString()].ToString().Trim() + "";
			myUser.User_USerWebPage = userRow[enumTableUser.UserWebPage.ToString()].ToString().Trim() + "";
			myUser.User_UserPassword = userRow[enumTableUser.UserPass.ToString()].ToString().Trim() + "";
			myUser.User_UserType = int.Parse( userRow[enumTableUser.UserType.ToString()].ToString() );
			myUser.User_EsGratis = int.Parse( userRow[enumTableUser.PaymentType.ToString()].ToString() );
			myUser.User_F_NextPayment = userRow[enumTableUser.F_NextPayment.ToString()].ToString() ;
			myUser.User_F_Expired = userRow[enumTableUser.F_Expired.ToString()].ToString() ;
            myUser.User_F_Alta = userRow[enumTableUser.F_Alta.ToString()].ToString();
			myUser.User_UserCompany = userRow[enumTableUser.UserCompany.ToString()].ToString().Trim() ;
			myUser.User_UserPhone = userRow[enumTableUser.UserPhone.ToString()].ToString().Trim() ;
			myUser.User_LocalTime	= int.Parse( userRow[enumTableUser.LocalTime.ToString()].ToString() );
			myUser.User_Description	=  userRow[enumTableUser.Description.ToString()].ToString() ;

			myUser.User_USerAddress	=  userRow[enumTableUser.Address.ToString()].ToString() + "" ;
			myUser.User_USerCity	=  userRow[enumTableUser.City.ToString()].ToString() + "" ;
			myUser.User_UserZipCode	=  userRow[enumTableUser.ZipCode.ToString()].ToString() + "" ;

            
            myUser.User_Alert = userRow[enumTableUser.alerta.ToString()].ToString() + "";

			
			myUser.User_CRM	=  userRow[enumTableUser.CRM.ToString()].ToString() + "" ;

			if ( userRow[enumTableUser.UserState.ToString()] != System.DBNull.Value )
				myUser.User_UserState	= Decimal.Parse( userRow[enumTableUser.UserState.ToString()].ToString() ) ;
			else
				myUser.User_UserState	= 1;
			

			if ( userRow[enumTableUser.FK_USAState.ToString()] != System.DBNull.Value )
				myUser.UserFK_USAState	= Decimal.Parse( userRow[enumTableUser.FK_USAState.ToString()].ToString() ) ;
			else
				myUser.UserFK_USAState	=0;

			if ( userRow[enumTableUser.FK_UserCountry.ToString()] != System.DBNull.Value )
				myUser.User_FK_UserCountry	=  Decimal.Parse( userRow[enumTableUser.FK_UserCountry.ToString()].ToString() ) ;
			else
				myUser.User_FK_UserCountry	= 0;

			if ( userRow[enumTableUser.LocalTime.ToString()] != System.DBNull.Value )
				myUser.User_LocalTime	=  int.Parse( userRow[enumTableUser.LocalTime.ToString()].ToString() ) ;
			else
				myUser.User_LocalTime	=0;
			
          

			return myUser;


		}

		#endregion
		
		#region getAllUser
		public  DataSet GetAllUser(string query)
		{
			
			try
			{
				return _GetAllUser( query );
			}
			catch( Exception e )
			{
				throw( e );
			}
						
		}

		private  DataSet _GetAllUser( string query )
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
				dest.Fill(ds,enumTableUser.G_Users.ToString());
				
				return ds;

			}
			catch( Exception e )
			{
				throw( e );
			}
			
			
		}

		#endregion

		public  UserData GetOneUser( decimal id)
		{
			UserData myUser = new UserData();
			try
			{
				string query = "SELECT * FROM " + enumTableUser.G_Users.ToString() + " Where " + enumTableUser.PK_ID.ToString() + " = " + id; 
				ds = _GetAllUser( query );
				
				
				if ( ds.Tables[0].Rows.Count > 0 )
				{
					myUser = _loadUserData( ds.Tables[0].Rows[0] );
				}
				else
				{
					throw( new Exception( "User Not found" ) );
				}
				cerrar();
				return myUser;

			}
			catch( Exception e )
			{
				throw( e );
			}
			
		}

		public  UserData getFirtAdminUser()
		{
			UserData myUser = new UserData();

			try
			{
				string query = "SELECT * FROM G_Users WHERE UserType = 0 AND UserState = 1"; 
				ds = _GetAllUser( query );

				if ( ds.Tables[0].Rows.Count > 0 )
				{
					myUser = _loadUserData( ds.Tables[0].Rows[0] );
				}
				else
					throw( new Exception( "Invalid user" ) );
				
				cerrar();
				return myUser;

			}
			catch( Exception e )
			{
				throw( e );
			}
			
			
		}
				
	}
}





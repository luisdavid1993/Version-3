using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

 


namespace streamingcpanel.DataAccess
{

    public class NotaEntity
    {
        public NotaEntity()
        {
        }
        private string _Titulo = "";
        private string _MostrarInicio = "";
        private string _Tipo = "";
        private string _UserID = "";
        private string _AdminID = "";
        private string _id = "";
        private string _Nota = "";
        private string _Fecha = "";

        public string User_Titulo { get { return _Titulo; } set { _Titulo = value; } }
        public string User_MostrarInicio { get { return _MostrarInicio; } set { _MostrarInicio = value; } }
        public string User_Tipo { get { return _Tipo; } set { _Tipo = value; } }
        public string User_UserID { get { return _UserID; } set { _UserID = value; } }
        public string User_AdminID { get { return _AdminID; } set { _AdminID = value; } }
        public string User_id { get { return _id; } set { _id = value; } }
        public string User_Nota { get { return _Nota; } set { _Nota = value; } }
        public string User_Fecha { get { return _Fecha; } set { _Fecha = value; } }




    }

    public class DANotas
	{
		private  string _ConnectionString = streamingcpanel.Constantes.CNN_STRING;

		private  DataSet ds = new DataSet();
		private  SqlDataAdapter dest = new SqlDataAdapter();
		
		public DANotas()
		{
		}

		public  void cerrar()
		{
			ds.Dispose();
			dest.Dispose();
		}
		#region GetAllData
		public  DataSet GetAllData( )
		{
			try
			{
				string query ="";
				query = query + "SELECT TOP 500 * FROM G_Notas ";
				query = query + " ORDER BY PK_ID DESC";

				//string query = "SELECT * FROM " + enumTableSupport.G_Notas.ToString() + " ORDER BY PK_ID DESC";
				ds = _GetAllData( query );
				return ds;

			}
			catch( Exception e )
			{
				throw( e );
			}			
		}
		public  DataSet GetAllData( string userID )
		{
			try
			{
				string query ="";
				query = query + "SELECT TOP 500 * FROM G_Notas ";
				query = query + " WHERE FK_User =  "  + userID;
				query = query + " ORDER BY PK_ID DESC";
				//string query = "SELECT * FROM " + enumTableSupport.G_Notas.ToString() + " WHERE " + enumTableSupport.FK_User.ToString() + "=" + userID + " ORDER BY PK_ID DESC";
				ds = _GetAllData( query );
				return ds;

			}
			catch( Exception e )
			{
				throw( e );
			}			
		}
		public  DataSet _GetAllData( string query )
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
				dest.Fill(ds,enumTableNota.G_Notas.ToString());
				return ds;

			}
			catch( Exception e )
			{
				throw( e );
			}			
		}

		#endregion

		public  void SalvarNota( bool isNew, string NotaID, NotaEntity myNota)
		{
			try
			{
                string query = "SELECT * FROM G_Notas Where PK_ID = " + NotaID;
                ds = _GetAllData(query);

                DataRow dr;
                if (isNew)
                {
                    dr = ds.Tables[0].NewRow();                    
                }
                else
                {
                    dr = ds.Tables[0].Rows[0];

                }
              				
				dr[enumTableNota.FK_User.ToString()] = myNota.User_UserID;
				dr[enumTableNota.FK_Techician.ToString()] = myNota.User_AdminID;
				dr[enumTableNota.tipo.ToString()] = myNota.User_Tipo;
				dr[enumTableNota.Title.ToString()] = myNota.User_Titulo;
				dr[enumTableNota.description.ToString()] = myNota.User_Nota;
				dr[enumTableNota.Date.ToString()] = myNota.User_Fecha;
                dr["estado"] = myNota.User_MostrarInicio;

                if (isNew)  ds.Tables[0].Rows.Add( dr );

				dest.Update( ds,ds.Tables[0].TableName.ToString());
				cerrar();
				return ;
				
			}
			catch( Exception e )
			{
				throw( e );
			}
		

		}

        public NotaEntity traerNotaCompleta (string ItemID)
        {

            NotaEntity myNota = new NotaEntity();
            try
            {
                string query = "SELECT * FROM G_Notas Where PK_ID = " + ItemID;
                ds = _GetAllData(query);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    myNota.User_id = ds.Tables[0].Rows[0][enumTableNota.FK_User.ToString()].ToString().Trim() + "";
                    myNota.User_AdminID = ds.Tables[0].Rows[0][enumTableNota.FK_Techician.ToString()].ToString().Trim() + "";
                    myNota.User_Tipo = ds.Tables[0].Rows[0][enumTableNota.tipo.ToString()].ToString().Trim() + "";
                    myNota.User_Titulo = ds.Tables[0].Rows[0][enumTableNota.Title.ToString()].ToString().Trim() + "";
                    myNota.User_Nota = ds.Tables[0].Rows[0][enumTableNota.description.ToString()].ToString().Trim() + "";
                    myNota.User_Fecha = ds.Tables[0].Rows[0][enumTableNota.Date.ToString()].ToString().Trim() + "";
                    myNota.User_MostrarInicio = ds.Tables[0].Rows[0]["estado"].ToString().Trim() + "";

                    if (myNota.User_Fecha.Equals("")) myNota.User_Fecha = DateTime.Now.ToShortDateString();
                }

                //cerrar();	
                return myNota;

            }
            catch
            {
                return myNota;

            }




        }

        public List<string> traerNotasPorUsuario(decimal userId)
        {

			List<string> names = null;
            try
            {
                string query = "SELECT * FROM G_Notas Where FK_User = " + userId;
                ds = _GetAllData(query);


                if (ds.Tables[0].Rows.Count > 0)
                {
					names = new List<string>();
					for (int i =0; i< ds.Tables[0].Rows.Count;i++) {
						names.Add(ds.Tables[0].Rows[i][enumTableNota.description.ToString()].ToString().Trim() + "");
					}
                }
                return names;

            }
            catch
            {
				return null;

            }




        }

    }
}

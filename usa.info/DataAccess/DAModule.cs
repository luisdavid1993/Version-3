using streamingcpanel.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace usa.info.DataAccess
{
    public class DAModuleEntity {
      public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool MostrarSiempre { get; set; }
        public string Iframe { get; set; }
        public string Imagen { get; set; }
    }
    public class DAModule
    {
   

       private string _ConnectionString = streamingcpanel.Constantes.CNN_STRING;
        private DataSet ds = new DataSet();
        private SqlDataAdapter dest = new SqlDataAdapter();
    
        public DataSet _GetAllData(string query)
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
                dest.Fill(ds, enumTableModulos.G_Modulos.ToString());
                return ds;

            }
            catch (Exception e)
            {
                throw (e);
            }
        }
        public void cerrar()
        {
            ds.Dispose();
            dest.Dispose();
        }
        public List<DAModuleEntity> traerModulosPorUsuarioyDefecto(decimal UserId)
        {
            List<DAModuleEntity> myModule = null;
            try
            {
                string query = "SELECT * FROM [G_Modules] Where [MostrarSiempre] = 1 OR [User] = " + UserId;
                ds = _GetAllData(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    myModule = new List<DAModuleEntity>();
                   
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        DAModuleEntity module = new DAModuleEntity();
                        module.Nombre = ds.Tables[0].Rows[i][enumTableModulos.Nombre.ToString()].ToString().Trim() + "";
                        module.Descripcion = ds.Tables[0].Rows[i][enumTableModulos.Descripcion.ToString()].ToString().Trim() + "";
                        if (!string.IsNullOrWhiteSpace(ds.Tables[0].Rows[i][enumTableModulos.MostrarSiempre.ToString()].ToString())) {
                            module.MostrarSiempre = Convert.ToBoolean(ds.Tables[0].Rows[i][enumTableModulos.MostrarSiempre.ToString()].ToString());
                        }
                       module.Iframe = ds.Tables[0].Rows[i][enumTableModulos.Iframe.ToString()].ToString().Trim() + "";
                       module.Imagen = ds.Tables[0].Rows[i][enumTableModulos.Imagen.ToString()].ToString().Trim() + "";
                        myModule.Add(module);
                    }
                    
                }
                return myModule;
            }
            catch
            {
                return null;
            }

        }
    }
}
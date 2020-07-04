using System;
using System.Data;
using System.Configuration;

namespace streamingcpanel.Objects
{
    public enum enumServiceType
    {
        storage = 3,
        Mobil = 4,
        PlayList = 32,
        AutoDJ = 33,
        AutoDJTV = 43,
        AAC = 35,
        TV=31,
        Radio=30,
        Estadisticas=44,
        HDWPlayer=45,
        JWPlayer = 46,
        WebTV=14
    }
	public class GetSetConfigWeb
	{
		public GetSetConfigWeb()
		{}

		public static string GetSetting( string confygKey)
		{
            try
            {

                //return ConfigurationSettings.AppSettings[confygKey];
                string data = "";
                data = ConfigurationManager.ConnectionStrings[confygKey].ConnectionString;
                return data;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
		}
        //public static bool GetServiceTipo(string userID, enumServiceType serviceNumber)
        //{
        //    try
        //    {
        //        //storage = 3
        //        //Mobil = 4
        //        //PlayList = 32
        //        //AutoDJ = 33
        //        //AAC = 35

        //        bool have = false;
        //        string tipo = "3";
        //        //if (serviceNumber == enumServiceType.AAC) tipo = "35";
        //        //if (serviceNumber == enumServiceType.AutoDJ) tipo = "33";
        //        //if (serviceNumber == enumServiceType.AutoDJTV) tipo = "43";
        //        //if (serviceNumber == enumServiceType.Mobil) tipo = "4";
        //        //if (serviceNumber == enumServiceType.PlayList) tipo = "32";
        //        //if (serviceNumber == enumServiceType.storage) tipo = "3";
        //        //if (serviceNumber == enumServiceType.TV) tipo = "31";
        //        //if (serviceNumber == enumServiceType.Radio) tipo = "30";
        //        //if (serviceNumber == enumServiceType.Estadisticas) tipo = "44";
        //        //if (serviceNumber == enumServiceType.HDWPlayer) tipo = "45";
        //        //if (serviceNumber == enumServiceType.JWPlayer) tipo = "46";
        //        tipo = ((int)serviceNumber).ToString();

        //        streamingcpanel.DataAccess.DAServices myDBServices = new streamingcpanel.DataAccess.DAServices();
        //        DataTable myTable = myDBServices.GetServicesForUser(userID).Tables[0];
        //        myDBServices.cerrar();
        //        foreach (DataRow myRow in myTable.Rows)
        //        {
        //            string tipoDB = myRow["Tipo"].ToString();
        //            if (tipoDB.Equals( tipo ))
        //                have = true;
        //        }

        //        return have;

        //    }
        //    catch 
        //    {
        //        return false;
        //    }

        //}

	}
}

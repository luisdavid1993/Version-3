using System;


namespace streamingcpanel.Objects
{
	
	public enum enumUserType
	{
		Admin =0,
		Reseller=1,
		Standar=2,
        Delegado=3,
        Mercadeo = 4
    }
    public enum enumTipoHeader
    {
        Normal = 1,
        ok = 2,
        Error = 3,
    }

	//		public static string getUserTypeStringByID( string typeID )
	//		{
	//
	//			string userType = "Unknown";
	//			if ( typeID == ((int)enumUserType.Admin).ToString() )
	//				userType = "Admin";
	//			if ( typeID == ((int)enumUserType.Reseller).ToString() )
	//				userType = "Reseller";
	//			if ( typeID == ((int)enumUserType.Standar).ToString() )
	//				userType = "Standar User";
	//			if ( typeID == ((int)enumUserType.Distribuitor).ToString() )
	//				userType = "Distribuitor";
	//			if ( typeID == ((int)enumUserType.Manufacturer).ToString() )
	//				userType = "Manufacturer";
	//			if ( typeID == ((int)enumUserType.Support).ToString() )
	//				userType = "Support";
	//
	//			return userType;
	//
	//		}


//	public enum enumServiceType
//	{
//		OnDemand =0,
//		LivePlayList=1,
//		Encoder=2,
//		TimeTable=3,
//		Storage=4,
//		IPTV=5,
//		Payment=6,
//		LimitResellerUsers=7,
//		LimitStremingCnn=8,
//		LimitStremingBandWicth=9,
//		FlashEncoder=10,
//		iphoneEncoder=11
//	}

//	public enum EditMode
//	{
//		New =0,
//		Edit=1,
//		Delete=2,
//	}
//	public enum TaskState
//	{
//		Open =0,
//		Working=1,
//		Closed=2,
//	}
//	public enum enumChannelType
//	{
//		Tv =0,
//		Video=1,	
//		Radio=2,
//		Noticia=3
//	}
//	public enum enumIPTVMenusType
//	{
//		Static =0,
//		Dinamic=1,		
//	}

}

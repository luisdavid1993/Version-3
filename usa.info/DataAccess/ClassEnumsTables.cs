using System;

namespace streamingcpanel.DataAccess
{

	public enum enumTableUser
	{
		G_Users=0,
		PK_ID,
		FK_resellerID,
		UserLogin,
		UserName,
		UserPass,
		UserMail,
		UserWebPage,
		Address, //250
		City, //80
		ZipCode, //10
		FK_USAState,
		UserType,
		UserState,
		CRM,
		PaymentType,
		F_NextPayment,
		F_Alta,
		F_Expired,
		UserPath,
		FK_UserCountry,
		UserPhone,
		UserCompany,
        //MBLimit,
        //MaxCnn,
		LocalTime,
		Description,
		Notes,
        alerta
	}

	public enum enumTableAccountTypes
	{
		G_ACCOUNT_TYPES =0,
		PK_ID,
		Name,
		LimitMB,
		LimitCnn,
		Description,
		Price,
		Type
	}
	public enum enumTableServidores
	{
		G_Servidores =0,
		PK_ID,
		Name,
		IpAddress,
		url,
		Estado,
        logspath,
        ServiceURL,
        AdminUser,
        AdminPassword,
		Tipo
	}
	
	public enum enumTableLiveEncoder
	{
		G_LIVE_ENCODER =0,
		PK_ID,
		FK_USER,
		FK_Server,
		Estado,
		Name,
        stream,
		Type,
		EncoderAddress,
        scPort,
        scID,
        scPass
		
	}
	
    //public enum enumTableUserAccounts
    //{
    //    G_USER_ACCOUNTS=0,
    //    PK_ID,
    //    FK_Account_Type,
    //    FK_User,
    //    Name,
    //    LimitMB,
    //    LimitCnn,
    //    Price,
    //    Type
    //}

	public enum enumTableBitacora
	{
		G_BITACORA=0,
		PK_ID,
		FK_Reseller,
		FK_User,
		FK_PlayList,
		host,
		Date,
		Description
	}

	public enum enumTableASX
	{
		G_ASX=0,
		PK_ID,
		FK_User,
		Name,
		ServerPath,
		url,
		urlBase,
		sFile,
		DateCreated
	}
	public enum enumTableFilesFolders
	{
		G_FILES_FOLDERS=0,
		PK_ID,
		FK_User,
		Name
	}

	
	public enum enumPayPalData
	{
		G_PAYPAL_DATA=0,
		PK_ID,
		FK_User,
		description,
		Date,
		Name,
		Status,
		Amount
	}


	public enum enumTableNota
	{
		G_Notas=0,
		PK_ID,
		FK_User,
		FK_Techician,
		tipo,
		Name,
		Title,
		description,
		Date,
		TotalTime
	}

	public enum enumTableModulos
	{
		G_Modulos = 0,
		Nombre,
		Descripcion,
		MostrarSiempre,
		Iframe,
		Imagen
	}

	#region delete
	//	public enum enumChannelsCategoriesData
	//	{
	//		G_CHANNELS_CATEGORIES=0,
	//		PK_ID,
	//		FK_ResellerID,
	//		Name,
	//	}
	//	public enum enumTablePlayerData
	//	{
	//		G_PLAYER_DATA = 0,
	//		PK_ID,
	//		FK_User,
	//		HTMLRightContent,
	//		HTMLBottom,
	//		ASXFileToStart
	//	}
	//	public enum enumTableTikects
	//	{
	//		G_TIKECTS=0,
	//		PK_ID,
	//		FK_User,
	//		Name,
	//		whereis,
	//		title,
	//		description,
	//		Date,
	//		state,
	//		Response
	//	}
	//	public enum enumTableSystemConfy
	//	{
	//		G_SYSTEM_CONFY=0,
	//		PK_ID,
	//		FK_User,
	//		Name,
	//		Value
	//	}
	//	public enum enumTableAutoUpDateChannels
	//	{
	//		G_AUTOOPDATE_CHANNELS = 0,
	//		PK_ID,
	//		FK_resellerID,
	//		urlBase,
	//		urlStreaming,
	//		Enable
	//	}
	//	public enum enumTableUserIPTV
	//	{
	//		G_Users_IPTV=0,
	//		PK_ID,
	//		FK_resellerID,
	//		FK_IPTVMenu,
	//		FK_Distribuitor,
	//		UserLogin,
	//		UserName,
	//		UserPass,
	//		UserMail,
	//		F_Alta,
	//		F_Expired,
	//		UserPath,
	//		FK_UserCountry,
	//		UserPhone,
	//		UserCompany,
	//		LocalTime,
	//		MacAddess,
	//		SerialNumber,
	//		Description
	//	}
	//	public enum enumTableIPTVMenus
	//	{
	//		G_IPTV_MENUS=0,
	//		PK_ID,
	//		FK_resellerID,
	//		Name,
	//		url,
	//		Type
	//	}
	//	public enum enumTableResellerIPTVConfy
	//	{
	//		G_RESELLER_IPTV_CONFY=0,
	//		PK_ID,
	//		FK_resellerID,
	//		HTMLExpired,
	//		HTMLHelp,
	//		HTMLChannelError,
	//		URLUserNotFounded,
	//		FK_IPTVDefaultMenu
	//	}
	//	public enum enumTableIPTVChannelsAddress
	//	{
	//		G_IPTV_CHANNELS=0,
	//		PK_ID,
	//		FK_resellerID,
	//		FK_CategorieID,
	//		Name,
	//		NameShort,
	//		Description,
	//		url,
	//		Type,
	//		urlPicture,
	//		toOrder,
	//		isEnable
	//	}
	//	
	//	public enum enumTableFilesUpload
	//	{
	//		G_FILES_UPLOAD =0,
	//		PK_ID,
	//		FK_USER,
	//		FK_Folder,
	//		LocalPath,
	//		ServerPath,
	//		OnDemandName,
	//		Description,
	//		DateUpload,
	//		FileLenght,
	//		FileTime,
	//		FileBitRate,
	//		FileTitle,
	//		FileAuthor,
	//		FileCopyRight,
	//		FileDescription,
	//		ImageURL,
	//		IsPublic
	//	}

	//	public enum enumTablePlayList
	//	{
	//		G_PLAY_LIST =0,
	//		PK_ID,
	//		FK_USER,
	//		Name,
	//		OnDemandName,
	//		Description,
	//		DateCreated,
	//		FileLenght,
	//		FileTime
	//	}
	//	public enum enumTablePlayListFiles
	//	{
	//		G_PLAY_LIST_FILES =0,
	//		PK_ID,
	//		FK_PLAYLIST,
	//		Name,
	//		ServerPath,
	//		FileLenght,
	//		FileTime
	//	}


	//	public enum enumTableTimeTables
	//	{
	//		G_TIMETABLES=0,
	//		PK_ID,
	//		FK_User,
	//		Day,
	//		HourIni,
	//		HourFin,
	//		Name,
	//		FileTime
	//	}
	//	public enum enumTableTimeTablesPlayList
	//	{
	//		G_TIMETABLES_PLAYLISTS=0,
	//		PK_ID,
	//		FK_TimeTable,
	//		FK_PlayList,
	//		Name,
	//		ServerPath,
	//		FileTime,
	//		toOrder
	//	}


	#endregion



}

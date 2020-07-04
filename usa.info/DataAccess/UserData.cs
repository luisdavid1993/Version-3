using System;

namespace streamingcpanel.DataAccess
{
	
	public class UserData
	{
		public UserData()
		{
			_USerLogin="";
			_UserPassword="";
            _Autorizacion = "";

			_name="";
			_USerEmail="";
			UserPhone="";
			_USerWebPage="";
			UserCompany="";
			_USerAddress="";
			_USerCity ="";
			FK_UserCountry=0;
			FK_USAState=0;
			_UserZipCode="";

			_UserType =(int) streamingcpanel.Objects.enumUserType.Standar;
			_PaymentType = 0;
			_F_Expired = System.DateTime.Now.AddDays( 15 ).ToShortDateString();
			_F_NextPayment = System.DateTime.Now.AddDays( 30 ).ToShortDateString();
			_Description="";
			_LocalTime = 9;

            //_HaveIPTV = false;
            //_HaveFlash = false;
            //_HaveIphone = false;
			
		}

        //private string _FlashName = "";
		private string _Alert = "";
		private string _CRM = "";
        //private bool _HaveFlash;
        //private bool _HaveIphone;

		//Login Data
        private string _USerLogin, _UserPassword, _Autorizacion;
		//Personal Data
		private string	_USerAddress,_USerCity,_UserZipCode;
		private decimal FK_UserCountry,FK_USAState;

		private string	_loginTime;
		private string _name,_path, _Description;
		private string  _F_Alta,_F_Expired,_F_NextPayment;
		private string _USerEmail,UserPhone,UserCompany,_USerWebPage;
		
		private decimal _UserType; //0 = Admin, 1=Reseller, 2 = User
		private decimal _UserState; // 1=Enable, 2 = Disable
		private decimal _PaymentType; //0 = Montly, 1=Quartely, 2 = Semi-Anually, 3=Anually
		
		private decimal _id, _resellerID; 
		
        //private decimal MBLimit,MBUsed,MaxCnn;
		private int _LocalTime;

        public string User_Autorizacion { get { return _Autorizacion; } set { _Autorizacion = value; } }

		public string User_CRM	{ 	get {return _CRM; } set {_CRM = value;	}}
        
        public string User_Alert { get { return _Alert; } set { _Alert = value; } }

        //public bool User_HaveIPTV		{		get {return _HaveIPTV; }			set {_HaveIPTV = value;	}		}
        //public bool User_HaveFlash		{		get {return _HaveFlash; }			set {_HaveFlash = value;	} }
        //public bool User_HaveIphone		{		get {return _HaveIphone; }			set {_HaveIphone = value;	}}

		public decimal User_UserState
		{
			get {return _UserState; }
			set {_UserState = value;	}
		}

        //public int User_limitStremingBand
        //{
        //    get {return _limitStremingBand; }
        //    set {_limitStremingBand = value;	}
        //}
        //public int User_limitStremingCnn
        //{
        //    get {return _limitStremingCnn; }
        //    set {_limitStremingCnn = value;	}
        //}
        //public int User_limitResellersUser
        //{
        //    get {return _limitResellersUser; }
        //    set {_limitResellersUser = value;	}
        //}

		public string User_UserZipCode
		{
			get {return _UserZipCode; }
			set {_UserZipCode = value;	}
		}
		public string User_USerCity
		{
			get {return _USerCity; }
			set {_USerCity = value;	}
		}
		public string User_USerAddress
		{
			get {return _USerAddress; }
			set {_USerAddress = value;	}
		}

		public string User_F_NextPayment
		{
			get {return _F_NextPayment; }
			set {_F_NextPayment = value;	}
		}

		public decimal User_EsGratis
		{
			get {return _PaymentType; }
			set {_PaymentType = value;	}
		}

        //public int User_limitIPTVUsers
        //{
        //    get {return _limitIPTVUsers; }
        //    set {_limitIPTVUsers = value;	}
        //}
        //public int User_limitPlayList
        //{
        //    get {return _limitPlayList; }
        //    set {_limitPlayList = value;	}
        //}
        //public int User_limitTimeTable
        //{
        //    get {return _limitTimeTable; }
        //    set {_limitTimeTable = value;	}
        //}
        //public int User_limitEncoders
        //{
        //    get {return _limitEncoders; }
        //    set {_limitEncoders = value;	}
        //}

		public string User_loginTime
		{
			get {return _loginTime; }
			set {_loginTime = value;	}
		}

		
		public decimal User_resellerID
		{
			get {return _resellerID; }
			set {_resellerID = value;	}
		}
		public int User_LocalTime
		{
			get {return _LocalTime; }
			set {_LocalTime = value;	}
		}
        //public decimal User_MaxCnn
        //{
        //    get {return MaxCnn; }
        //    set {MaxCnn = value;	}
        //}
		
        //public decimal User_MBLimit
        //{
        //    get {return MBLimit; }
        //    set {MBLimit = value;	}
        //}
        //public decimal User_MBUsed
        //{
        //    get {return MBUsed; }
        //    set {MBUsed = value;	}
        //}
		public decimal User_UserType
		{
			get {return _UserType; }
			set {_UserType = value;	}
		}
		public decimal User_FK_UserCountry
		{
			get {return FK_UserCountry; }
			set {FK_UserCountry = value;	}
		}
		public decimal UserFK_USAState
		{
			get {return FK_USAState; }
			set {FK_USAState = value;	}
		}
		public decimal User_ID
		{
			get {return _id; }
			set {_id = value;	}
		}
		
		public string User_UserPhone
		{
			get {return UserPhone; }
			set {UserPhone = value;	}
		}
		public string User_UserCompany
		{
			get {return UserCompany; }
			set {UserCompany = value;	}
		}
		public string User_USerEmail
		{
			get {return _USerEmail; }
			set {_USerEmail = value;	}
		}
		public string User_USerWebPage
		{
			get {return _USerWebPage; }
			set {_USerWebPage = value;	}
		}
		

		public string User_USerLogin
		{
			get {return _USerLogin; }
			set {_USerLogin = value;	}
		}
		public string User_UserPassword
		{
			get {return _UserPassword; }
			set {_UserPassword = value;	}
		}

		
		public string User_F_Expired
		{
			get {return _F_Expired; }
			set {_F_Expired = value;	}
		}
		public string User_F_Alta
		{
			get {return _F_Alta; }
			set {_F_Alta = value;	}
		}
		public string User_Description
		{
			get {return _Description; }
			set {_Description = value;	}
		}
		
		public string User_name
		{
			get 
			{
				return _name; 
			}
			set 
			{
				_name = value;
			}
		}
		public string User_path
		{
			get 
			{
				return _path; 
			}
			set 
			{
				_path = value;
			}
		}



	}



}

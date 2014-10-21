/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Collections;

namespace bingo.DO
{
   [Serializable ]
   public class ClientLoginDO
    {

        /// <summary>
        /// Summary description for ClientLoginDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string CLIENTLOGINID_FIELD ="ClientLoginID";
		public const string USERNAME_FIELD ="Username";
		public const string PASSWORD_FIELD ="Password";
		public const string CLIENTNAME_FIELD ="ClientName";
		public const string EMAIL_FIELD ="Email";
		public const string PHONE_FIELD ="Phone";
		public const string MOBILE_FIELD ="Mobile";
		public const string ADDRESS_FIELD ="Address";
		public const string DETAILINFO_FIELD ="DetailInfo";

		#endregion
		
		#region Private Variables
					private Int32 _ClientLoginID;
		private String _Username;
		private String _Password;
		private String _ClientName;
		private String _Email;
		private String _Phone;
		private String _Mobile;
		private String _Address;
		private String _DetailInfo;

		#endregion

		#region Public Properties
					public Int32 ClientLoginID
		{
			get
			{
				return _ClientLoginID;
			}
			set
			{
				_ClientLoginID = value;
			}
		}
		public String Username
		{
			get
			{
				return _Username;
			}
			set
			{
				_Username = value;
			}
		}
		public String Password
		{
			get
			{
				return _Password;
			}
			set
			{
				_Password = value;
			}
		}
		public String ClientName
		{
			get
			{
				return _ClientName;
			}
			set
			{
				_ClientName = value;
			}
		}
		public String Email
		{
			get
			{
				return _Email;
			}
			set
			{
				_Email = value;
			}
		}
		public String Phone
		{
			get
			{
				return _Phone;
			}
			set
			{
				_Phone = value;
			}
		}
		public String Mobile
		{
			get
			{
				return _Mobile;
			}
			set
			{
				_Mobile = value;
			}
		}
		public String Address
		{
			get
			{
				return _Address;
			}
			set
			{
				_Address = value;
			}
		}
		public String DetailInfo
		{
			get
			{
				return _DetailInfo;
			}
			set
			{
				_DetailInfo = value;
			}
		}

        #endregion

	}
}

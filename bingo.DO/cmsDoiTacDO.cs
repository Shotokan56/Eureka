/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Collections;

namespace Bingo.DO
{
   [Serializable ]
   public class cmsDoiTacDO
    {

        /// <summary>
        /// Summary description for cmsDoiTacDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string DOITACID_FIELD ="DoiTacID";
		public const string TENDOITAC_FIELD ="TenDoiTac";
		public const string DESCRIPTION_FIELD ="Description";
		public const string IMAGEURL_FIELD ="ImageURL";
		public const string SURL_FIELD ="sURL";

		#endregion
		
		#region Private Variables
					private Int32 _DoiTacID;
		private String _TenDoiTac;
		private String _Description;
		private String _ImageURL;
		private String _sURL;

		#endregion

		#region Public Properties
					public Int32 DoiTacID
		{
			get
			{
				return _DoiTacID;
			}
			set
			{
				_DoiTacID = value;
			}
		}
		public String TenDoiTac
		{
			get
			{
				return _TenDoiTac;
			}
			set
			{
				_TenDoiTac = value;
			}
		}
		public String Description
		{
			get
			{
				return _Description;
			}
			set
			{
				_Description = value;
			}
		}
		public String ImageURL
		{
			get
			{
				return _ImageURL;
			}
			set
			{
				_ImageURL = value;
			}
		}
		public String sURL
		{
			get
			{
				return _sURL;
			}
			set
			{
				_sURL = value;
			}
		}

        #endregion

	}
}

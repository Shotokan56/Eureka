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
   public class cmsCategoryDO
    {

        /// <summary>
        /// Summary description for cmsCategoryDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string CATEGORYID_FIELD ="CategoryID";
		public const string TITLE_FIELD ="Title";
		public const string ETITLE_FIELD ="eTitle";
		public const string DESCRIPTION_FIELD ="Description";
		public const string EDESCRIPTION_FIELD ="eDescription";
		public const string ORDERID_FIELD ="OrderID";
		public const string ISPUBLISH_FIELD ="IsPublish";
		public const string ISHOMPAGE_FIELD ="IsHompage";
		public const string USERCREATE_FIELD ="UserCreate";
		public const string CREATEDATE_FIELD ="CreateDate";
		public const string CATEGORYTYPEID_FIELD ="CategoryTypeID";
		public const string PARENTID_FIELD ="ParentID";
		public const string ISCONTENT_FIELD ="IsContent";
		public const string IMAGEURL_FIELD ="ImageURL";
		public const string DETAILCONTENT_FIELD ="DetailContent";
		public const string EDETAILCONTENT_FIELD ="eDetailContent";
		public const string MODULE_FIELD ="Module";
		public const string ISMENU_FIELD ="IsMenu";

		#endregion
		
		#region Private Variables
					private Int32 _CategoryID;
		private String _Title;
		private String _eTitle;
		private String _Description;
		private String _eDescription;
		private Int32 _OrderID;
		private Boolean _IsPublish;
		private Boolean _IsHompage;
		private Int32 _UserCreate;
		private DateTime _CreateDate;
		private Int32 _CategoryTypeID;
		private Int32 _ParentID;
		private Boolean _IsContent;
		private String _ImageURL;
		private String _DetailContent;
		private String _eDetailContent;
		private String _Module;
		private Boolean _IsMenu;

		#endregion

		#region Public Properties
					public Int32 CategoryID
		{
			get
			{
				return _CategoryID;
			}
			set
			{
				_CategoryID = value;
			}
		}
		public String Title
		{
			get
			{
				return _Title;
			}
			set
			{
				_Title = value;
			}
		}
		public String eTitle
		{
			get
			{
				return _eTitle;
			}
			set
			{
				_eTitle = value;
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
		public String eDescription
		{
			get
			{
				return _eDescription;
			}
			set
			{
				_eDescription = value;
			}
		}
		public Int32 OrderID
		{
			get
			{
				return _OrderID;
			}
			set
			{
				_OrderID = value;
			}
		}
		public Boolean IsPublish
		{
			get
			{
				return _IsPublish;
			}
			set
			{
				_IsPublish = value;
			}
		}
		public Boolean IsHompage
		{
			get
			{
				return _IsHompage;
			}
			set
			{
				_IsHompage = value;
			}
		}
		public Int32 UserCreate
		{
			get
			{
				return _UserCreate;
			}
			set
			{
				_UserCreate = value;
			}
		}
		public DateTime CreateDate
		{
			get
			{
				return _CreateDate;
			}
			set
			{
				_CreateDate = value;
			}
		}
		public Int32 CategoryTypeID
		{
			get
			{
				return _CategoryTypeID;
			}
			set
			{
				_CategoryTypeID = value;
			}
		}
		public Int32 ParentID
		{
			get
			{
				return _ParentID;
			}
			set
			{
				_ParentID = value;
			}
		}
		public Boolean IsContent
		{
			get
			{
				return _IsContent;
			}
			set
			{
				_IsContent = value;
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
		public String DetailContent
		{
			get
			{
				return _DetailContent;
			}
			set
			{
				_DetailContent = value;
			}
		}
		public String eDetailContent
		{
			get
			{
				return _eDetailContent;
			}
			set
			{
				_eDetailContent = value;
			}
		}
		public String Module
		{
			get
			{
				return _Module;
			}
			set
			{
				_Module = value;
			}
		}
		public Boolean IsMenu
		{
			get
			{
				return _IsMenu;
			}
			set
			{
				_IsMenu = value;
			}
		}

        #endregion

	}
}

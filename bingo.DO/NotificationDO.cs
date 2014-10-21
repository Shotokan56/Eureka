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
   public class NotificationDO
    {

        /// <summary>
        /// Summary description for NotificationDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string ARTICLEID_FIELD ="ArticleID";
		public const string TITLE_FIELD ="Title";
		public const string CATEGORYID_FIELD ="CategoryID";
		public const string ISPUBLISH_FIELD ="IsPublish";
		public const string ARTICLEDETAIL_FIELD ="ArticleDetail";

		#endregion
		
		#region Private Variables
					private Int32 _ArticleID;
		private String _Title;
		private Int32 _CategoryID;
		private Boolean _IsPublish;
		private String _ArticleDetail;

		#endregion

		#region Public Properties
					public Int32 ArticleID
		{
			get
			{
				return _ArticleID;
			}
			set
			{
				_ArticleID = value;
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
		public String ArticleDetail
		{
			get
			{
				return _ArticleDetail;
			}
			set
			{
				_ArticleDetail = value;
			}
		}

        #endregion

	}
}

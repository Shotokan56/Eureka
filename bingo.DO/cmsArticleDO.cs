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
   public class cmsArticleDO
    {

        /// <summary>
        /// Summary description for cmsArticleDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string ARTICLEID_FIELD ="ArticleID";
		public const string TITLE_FIELD ="Title";
		public const string ETITLE_FIELD ="eTitle";
		public const string CATEGORYID_FIELD ="CategoryID";
		public const string IMAGEURL_FIELD ="ImageUrl";
		public const string DESCRIPTION_FIELD ="Description";
		public const string EDESCRIPTION_FIELD ="eDescription";
		public const string ARTICLEDETAIL_FIELD ="ArticleDetail";
		public const string EARTICLEDETAIL_FIELD ="eArticleDetail";
		public const string TAGS_FIELD ="Tags";
		public const string ETAGS_FIELD ="eTags";
		public const string ISPUBLISH_FIELD ="IsPublish";
		public const string ORDERID_FIELD ="OrderID";
		public const string ISHOMPAGE_FIELD ="IsHompage";
		public const string USERCREATE_FIELD ="UserCreate";
		public const string CREATEDATE_FIELD ="CreateDate";
		public const string PARENTID_FIELD ="ParentID";

		#endregion
		
		#region Private Variables
					private Int32 _ArticleID;
		private String _Title;
		private String _eTitle;
		private Int32 _CategoryID;
		private String _ImageUrl;
		private String _Description;
		private String _eDescription;
		private String _ArticleDetail;
		private String _eArticleDetail;
		private String _Tags;
		private String _eTags;
		private Boolean _IsPublish;
		private Int32 _OrderID;
		private Boolean _IsHompage;
		private Int32 _UserCreate;
		private DateTime _CreateDate;
		private Int32 _ParentID;

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
		public String ImageUrl
		{
			get
			{
				return _ImageUrl;
			}
			set
			{
				_ImageUrl = value;
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
		public String eArticleDetail
		{
			get
			{
				return _eArticleDetail;
			}
			set
			{
				_eArticleDetail = value;
			}
		}
		public String Tags
		{
			get
			{
				return _Tags;
			}
			set
			{
				_Tags = value;
			}
		}
		public String eTags
		{
			get
			{
				return _eTags;
			}
			set
			{
				_eTags = value;
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

        #endregion

	}
}

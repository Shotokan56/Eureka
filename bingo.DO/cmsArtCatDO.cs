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
   public class cmsArtCatDO
    {

        /// <summary>
        /// Summary description for cmsArtCatDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string ARTICLEID_FIELD ="ArticleID";
		public const string CATEGORYID_FIELD ="CategoryID";

		#endregion
		
		#region Private Variables
					private Int32 _ArticleID;
		private Int32 _CategoryID;

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

        #endregion

	}
}

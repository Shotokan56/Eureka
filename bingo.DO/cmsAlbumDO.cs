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
   public class cmsAlbumDO
    {

        /// <summary>
        /// Summary description for cmsAlbumDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string ALBUMID_FIELD ="AlbumID";
		public const string SANPHAMID_FIELD ="SanPhamID";
		public const string TITLE_FIELD ="Title";
		public const string ETITLE_FIELD ="eTitle";
		public const string ORDERID_FIELD ="OrderID";
		public const string DESCRIPTION_FIELD ="Description";
		public const string EDESCRIPTION_FIELD ="eDescription";
		public const string CATEGORYID_FIELD ="CategoryID";
		public const string TYPE_FIELD ="Type";
		public const string COVERIMG_FIELD ="CoverImg";
		public const string LOAISP_FIELD ="LoaiSP";

		#endregion
		
		#region Private Variables
					private Int32 _AlbumID;
		private Int32 _SanPhamID;
		private String _Title;
		private String _eTitle;
		private Int32 _OrderID;
		private String _Description;
		private String _eDescription;
		private Int32 _CategoryID;
		private Boolean _Type;
		private String _CoverImg;
		private Int32 _LoaiSP;

		#endregion

		#region Public Properties
					public Int32 AlbumID
		{
			get
			{
				return _AlbumID;
			}
			set
			{
				_AlbumID = value;
			}
		}
		public Int32 SanPhamID
		{
			get
			{
				return _SanPhamID;
			}
			set
			{
				_SanPhamID = value;
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
		public Boolean Type
		{
			get
			{
				return _Type;
			}
			set
			{
				_Type = value;
			}
		}
		public String CoverImg
		{
			get
			{
				return _CoverImg;
			}
			set
			{
				_CoverImg = value;
			}
		}
		public Int32 LoaiSP
		{
			get
			{
				return _LoaiSP;
			}
			set
			{
				_LoaiSP = value;
			}
		}

        #endregion

	}
}

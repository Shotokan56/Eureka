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
   public class cmsImagesDO
    {

        /// <summary>
        /// Summary description for cmsImagesDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string IMAGEID_FIELD ="ImageID";
		public const string ALBUMID_FIELD ="AlbumID";
		public const string TITLE_FIELD ="Title";
		public const string ETITLE_FIELD ="eTitle";
		public const string DESCRIPTION_FIELD ="Description";
		public const string EDESCRIPTION_FIELD ="eDescription";
		public const string IMGFILE_FIELD ="ImgFile";
		public const string STYLEALBUM_FIELD ="StyleAlbum";
		public const string SANPHAMID_FIELD ="SanPhamID";

		#endregion
		
		#region Private Variables
					private Int32 _ImageID;
		private Int32 _AlbumID;
		private String _Title;
		private String _eTitle;
		private String _Description;
		private String _eDescription;
		private String _ImgFile;
		private Boolean _StyleAlbum;
		private Int64 _SanPhamID;

		#endregion

		#region Public Properties
					public Int32 ImageID
		{
			get
			{
				return _ImageID;
			}
			set
			{
				_ImageID = value;
			}
		}
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
		public String ImgFile
		{
			get
			{
				return _ImgFile;
			}
			set
			{
				_ImgFile = value;
			}
		}
		public Boolean StyleAlbum
		{
			get
			{
				return _StyleAlbum;
			}
			set
			{
				_StyleAlbum = value;
			}
		}
		public Int64 SanPhamID
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

        #endregion

	}
}

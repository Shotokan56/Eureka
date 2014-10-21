/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Data;
using System.Configuration;
using System.Collections;

using bingo.DAL;
using bingo.DO;
/// <summary>
/// Summary description for cmsImagesBL
/// </summary>
namespace bingo.BL 
{
    public class cmsImagesBL 
    {
    	#region Private Variables
		cmsImagesDAL objcmsImagesDAL;
		#endregion
		
        #region Public Constructors
        public cmsImagesBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objcmsImagesDAL=new cmsImagesDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(cmsImagesDO objcmsImagesDO)
        {
            return objcmsImagesDAL.Insert(objcmsImagesDO);
        }

        public int Update(cmsImagesDO objcmsImagesDO)
        {
             return objcmsImagesDAL.Update(objcmsImagesDO);

        }

        public int Delete(cmsImagesDO objcmsImagesDO)
        {
             return objcmsImagesDAL.Delete(objcmsImagesDO);

        }

         public int DeleteAll()
        {
             return objcmsImagesDAL.DeleteAll();
        }

        public cmsImagesDO Select(cmsImagesDO objcmsImagesDO)
        {
            return objcmsImagesDAL.Select(objcmsImagesDO);
        }

        public ArrayList SelectAll1( )
        {
         return objcmsImagesDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objcmsImagesDAL.SelectAll();
        }


     
#endregion          
    
    
        public DataTable SelectByAlbumID(int AlbumID)
        {
            return objcmsImagesDAL.SelectByAlbumID(AlbumID);
        }

        public DataTable SelectTop(int p)
        {
            return objcmsImagesDAL.SelectTop(p);
        }

        public DataTable SelectbyPage(int page, int pageSize, int albumid)
        {
            return objcmsImagesDAL.Selectbypage(page,pageSize,albumid);
        }

        public DataTable Selectvideo()
        {
            return objcmsImagesDAL.Selectvideo();
        }



        public DataTable Selectvideobypage(int page, int pagesize)
        {
            return objcmsImagesDAL.Selectvideobypage(page,pagesize);
        }
    }

}

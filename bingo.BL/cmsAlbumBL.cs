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
/// Summary description for cmsAlbumBL
/// </summary>
namespace bingo.BL 
{
    public class cmsAlbumBL 
    {
    	#region Private Variables
		cmsAlbumDAL objcmsAlbumDAL;
		#endregion
		
        #region Public Constructors
        public cmsAlbumBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objcmsAlbumDAL=new cmsAlbumDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(cmsAlbumDO objcmsAlbumDO)
        {
            return objcmsAlbumDAL.Insert(objcmsAlbumDO);
        }

        public int Update(cmsAlbumDO objcmsAlbumDO)
        {
             return objcmsAlbumDAL.Update(objcmsAlbumDO);

        }

        public int Delete(cmsAlbumDO objcmsAlbumDO)
        {
             return objcmsAlbumDAL.Delete(objcmsAlbumDO);

        }

         public int DeleteAll()
        {
             return objcmsAlbumDAL.DeleteAll();
        }

        public cmsAlbumDO Select(cmsAlbumDO objcmsAlbumDO)
        {
            return objcmsAlbumDAL.Select(objcmsAlbumDO);
        }

        public ArrayList SelectAll1( )
        {
         return objcmsAlbumDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objcmsAlbumDAL.SelectAll();
        }


     
#endregion          
    
    
        

    
    
        public DataTable SelectbyPage(int page, int pageSize)
        {
            return objcmsAlbumDAL.SelectByPage(page,pageSize);
        }
    }

}

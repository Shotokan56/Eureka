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
/// Summary description for cmsArtCatBL
/// </summary>
namespace bingo.BL 
{
    public class cmsArtCatBL 
    {
    	#region Private Variables
		cmsArtCatDAL objcmsArtCatDAL;
		#endregion
		
        #region Public Constructors
        public cmsArtCatBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objcmsArtCatDAL=new cmsArtCatDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(cmsArtCatDO objcmsArtCatDO)
        {
            return objcmsArtCatDAL.Insert(objcmsArtCatDO);
        }

        public int Update(cmsArtCatDO objcmsArtCatDO)
        {
             return objcmsArtCatDAL.Update(objcmsArtCatDO);

        }

        public int Delete(cmsArtCatDO objcmsArtCatDO)
        {
             return objcmsArtCatDAL.Delete(objcmsArtCatDO);

        }

         public int DeleteAll()
        {
             return objcmsArtCatDAL.DeleteAll();
        }

        public cmsArtCatDO Select(cmsArtCatDO objcmsArtCatDO)
        {
            return objcmsArtCatDAL.Select(objcmsArtCatDO);
        }

        public ArrayList SelectAll1( )
        {
         return objcmsArtCatDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objcmsArtCatDAL.SelectAll();
        }


     
#endregion          
    
    }

}

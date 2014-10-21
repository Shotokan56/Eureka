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
/// Summary description for SlideBL
/// </summary>
namespace bingo.BL 
{
    public class SlideBL 
    {
    	#region Private Variables
		SlideDAL objSlideDAL;
		#endregion
		
        #region Public Constructors
        public SlideBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objSlideDAL=new SlideDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(SlideDO objSlideDO)
        {
            return objSlideDAL.Insert(objSlideDO);
        }

        public int Update(SlideDO objSlideDO)
        {
             return objSlideDAL.Update(objSlideDO);

        }

        public int Delete(SlideDO objSlideDO)
        {
             return objSlideDAL.Delete(objSlideDO);

        }

         public int DeleteAll()
        {
             return objSlideDAL.DeleteAll();
        }

        public SlideDO Select(SlideDO objSlideDO)
        {
            return objSlideDAL.Select(objSlideDO);
        }

        public ArrayList SelectAll1( )
        {
         return objSlideDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objSlideDAL.SelectAll();
        }


     
#endregion          
    
    }

}

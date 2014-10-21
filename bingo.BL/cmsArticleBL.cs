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
/// Summary description for cmsArticleBL
/// </summary>
namespace bingo.BL 
{
    public class cmsArticleBL 
    {
    	#region Private Variables
		cmsArticleDAL objcmsArticleDAL;
		#endregion
		
        #region Public Constructors
        public cmsArticleBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objcmsArticleDAL=new cmsArticleDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(cmsArticleDO objcmsArticleDO)
        {
            return objcmsArticleDAL.Insert(objcmsArticleDO);
        }

        public int Update(cmsArticleDO objcmsArticleDO)
        {
             return objcmsArticleDAL.Update(objcmsArticleDO);

        }

        public int Delete(cmsArticleDO objcmsArticleDO)
        {
             return objcmsArticleDAL.Delete(objcmsArticleDO);

        }

         public int DeleteAll()
        {
             return objcmsArticleDAL.DeleteAll();
        }

        public cmsArticleDO Select(cmsArticleDO objcmsArticleDO)
        {
            return objcmsArticleDAL.Select(objcmsArticleDO);
        }

        public ArrayList SelectAll1( )
        {
         return objcmsArticleDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objcmsArticleDAL.SelectAll();
        }

        public DataTable SelectByCategoryID(int ID, int n)
        {
            return objcmsArticleDAL.SelectByCategoryID(ID, n);
        }

        public DataTable ArticleGetByPage(int CategoryID, int Page, int PageSize)
        {
            return objcmsArticleDAL.ArticleGetByPage(CategoryID, Page, PageSize);
        }

        public DataTable Selectbypk(int ArticleID)
        {
            return objcmsArticleDAL.GetbyPK(ArticleID);
        }
     
#endregion          
    
    
        public DataTable SelectArticleHome()
        {
            return objcmsArticleDAL.SelectHome();
        }

        public DataTable SelectMore(int p)
        {
            return objcmsArticleDAL.SelectMore(p);
        }



        public DataTable SelectNewClassTop(int p, int cate)
        {
            return objcmsArticleDAL.SelectNewClassTop(p, cate);
        }

        public DataTable SelectNoti(int p)
        {
            return objcmsArticleDAL.SelectNoti(p);
        }



        public DataTable GetTinTucbypage(int page, int pageSize)
        {
            return objcmsArticleDAL.GetTinTucbypage(page, pageSize);
        }

        public DataTable KhaiGiangGetByPage(int page, int pageSize)
        {
            return objcmsArticleDAL.KhaiGiangbypage(page, pageSize);
        }





        public object SelectTL(int lopid)
        {
            return objcmsArticleDAL.selecttl(lopid);
        }
    }

}

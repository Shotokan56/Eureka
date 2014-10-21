/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Data.SqlClient;
using bingo.DO;
/// <summary>
/// Summary description for cmsArticleDAL
/// </summary>
namespace bingo.DAL 
{
    
    public class cmsArticleDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public cmsArticleDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(cmsArticleDO objcmsArticleDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsArticle_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objcmsArticleDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@eTitle", SqlDbType.NVarChar);
Sqlparam.Value = objcmsArticleDO.eTitle;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CategoryID", SqlDbType.Int);
Sqlparam.Value = objcmsArticleDO.CategoryID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ImageUrl", SqlDbType.NVarChar);
Sqlparam.Value = objcmsArticleDO.ImageUrl;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objcmsArticleDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@eDescription", SqlDbType.NText);
Sqlparam.Value = objcmsArticleDO.eDescription;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ArticleDetail", SqlDbType.NText);
Sqlparam.Value = objcmsArticleDO.ArticleDetail;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@eArticleDetail", SqlDbType.NText);
Sqlparam.Value = objcmsArticleDO.eArticleDetail;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Tags", SqlDbType.NText);
Sqlparam.Value = objcmsArticleDO.Tags;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@eTags", SqlDbType.NText);
Sqlparam.Value = objcmsArticleDO.eTags;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IsPublish", SqlDbType.Bit);
Sqlparam.Value = objcmsArticleDO.IsPublish;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
Sqlparam.Value = objcmsArticleDO.OrderID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IsHompage", SqlDbType.Bit);
Sqlparam.Value = objcmsArticleDO.IsHompage;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@UserCreate", SqlDbType.Int);
Sqlparam.Value = objcmsArticleDO.UserCreate;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CreateDate", SqlDbType.DateTime);
Sqlparam.Value = objcmsArticleDO.CreateDate;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ParentID", SqlDbType.Int);
Sqlparam.Value = objcmsArticleDO.ParentID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(cmsArticleDO objcmsArticleDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsArticle_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ArticleID", SqlDbType.Int);
Sqlparam.Value = objcmsArticleDO.ArticleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objcmsArticleDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@eTitle", SqlDbType.NVarChar);
Sqlparam.Value = objcmsArticleDO.eTitle;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CategoryID", SqlDbType.Int);
Sqlparam.Value = objcmsArticleDO.CategoryID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ImageUrl", SqlDbType.NVarChar);
Sqlparam.Value = objcmsArticleDO.ImageUrl;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objcmsArticleDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@eDescription", SqlDbType.NText);
Sqlparam.Value = objcmsArticleDO.eDescription;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ArticleDetail", SqlDbType.NText);
Sqlparam.Value = objcmsArticleDO.ArticleDetail;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@eArticleDetail", SqlDbType.NText);
Sqlparam.Value = objcmsArticleDO.eArticleDetail;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Tags", SqlDbType.NText);
Sqlparam.Value = objcmsArticleDO.Tags;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@eTags", SqlDbType.NText);
Sqlparam.Value = objcmsArticleDO.eTags;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IsPublish", SqlDbType.Bit);
Sqlparam.Value = objcmsArticleDO.IsPublish;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
Sqlparam.Value = objcmsArticleDO.OrderID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IsHompage", SqlDbType.Bit);
Sqlparam.Value = objcmsArticleDO.IsHompage;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@UserCreate", SqlDbType.Int);
Sqlparam.Value = objcmsArticleDO.UserCreate;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CreateDate", SqlDbType.DateTime);
Sqlparam.Value = objcmsArticleDO.CreateDate;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ParentID", SqlDbType.Int);
Sqlparam.Value = objcmsArticleDO.ParentID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(cmsArticleDO objcmsArticleDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsArticle_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ArticleID", SqlDbType.Int);
Sqlparam.Value = objcmsArticleDO.ArticleID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsArticle_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public cmsArticleDO Select(cmsArticleDO objcmsArticleDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsArticle_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@ArticleID", SqlDbType.Int);
Sqlparam.Value = objcmsArticleDO.ArticleID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["ArticleID"]))
objcmsArticleDO.ArticleID=Convert.ToInt32(dr["ArticleID"]);
if(!Convert.IsDBNull(dr["Title"]))
objcmsArticleDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["eTitle"]))
objcmsArticleDO.eTitle=Convert.ToString(dr["eTitle"]);
if(!Convert.IsDBNull(dr["CategoryID"]))
objcmsArticleDO.CategoryID=Convert.ToInt32(dr["CategoryID"]);
if(!Convert.IsDBNull(dr["ImageUrl"]))
objcmsArticleDO.ImageUrl=Convert.ToString(dr["ImageUrl"]);
if(!Convert.IsDBNull(dr["Description"]))
objcmsArticleDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["eDescription"]))
objcmsArticleDO.eDescription=Convert.ToString(dr["eDescription"]);
if(!Convert.IsDBNull(dr["ArticleDetail"]))
objcmsArticleDO.ArticleDetail=Convert.ToString(dr["ArticleDetail"]);
if(!Convert.IsDBNull(dr["eArticleDetail"]))
objcmsArticleDO.eArticleDetail=Convert.ToString(dr["eArticleDetail"]);
if(!Convert.IsDBNull(dr["Tags"]))
objcmsArticleDO.Tags=Convert.ToString(dr["Tags"]);
if(!Convert.IsDBNull(dr["eTags"]))
objcmsArticleDO.eTags=Convert.ToString(dr["eTags"]);
if(!Convert.IsDBNull(dr["IsPublish"]))
objcmsArticleDO.IsPublish=Convert.ToBoolean(dr["IsPublish"]);
if(!Convert.IsDBNull(dr["OrderID"]))
objcmsArticleDO.OrderID=Convert.ToInt32(dr["OrderID"]);
if(!Convert.IsDBNull(dr["IsHompage"]))
objcmsArticleDO.IsHompage=Convert.ToBoolean(dr["IsHompage"]);
if(!Convert.IsDBNull(dr["UserCreate"]))
objcmsArticleDO.UserCreate=Convert.ToInt32(dr["UserCreate"]);
if(!Convert.IsDBNull(dr["CreateDate"]))
objcmsArticleDO.CreateDate=Convert.ToDateTime(dr["CreateDate"]);
if(!Convert.IsDBNull(dr["ParentID"]))
objcmsArticleDO.ParentID=Convert.ToInt32(dr["ParentID"]);

            }
             return objcmsArticleDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsArticle_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrcmsArticleDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
cmsArticleDO objcmsArticleDO= new cmsArticleDO();
if(!Convert.IsDBNull(dr["ArticleID"]))
objcmsArticleDO.ArticleID=Convert.ToInt32(dr["ArticleID"]);
if(!Convert.IsDBNull(dr["Title"]))
objcmsArticleDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["eTitle"]))
objcmsArticleDO.eTitle=Convert.ToString(dr["eTitle"]);
if(!Convert.IsDBNull(dr["CategoryID"]))
objcmsArticleDO.CategoryID=Convert.ToInt32(dr["CategoryID"]);
if(!Convert.IsDBNull(dr["ImageUrl"]))
objcmsArticleDO.ImageUrl=Convert.ToString(dr["ImageUrl"]);
if(!Convert.IsDBNull(dr["Description"]))
objcmsArticleDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["eDescription"]))
objcmsArticleDO.eDescription=Convert.ToString(dr["eDescription"]);
if(!Convert.IsDBNull(dr["ArticleDetail"]))
objcmsArticleDO.ArticleDetail=Convert.ToString(dr["ArticleDetail"]);
if(!Convert.IsDBNull(dr["eArticleDetail"]))
objcmsArticleDO.eArticleDetail=Convert.ToString(dr["eArticleDetail"]);
if(!Convert.IsDBNull(dr["Tags"]))
objcmsArticleDO.Tags=Convert.ToString(dr["Tags"]);
if(!Convert.IsDBNull(dr["eTags"]))
objcmsArticleDO.eTags=Convert.ToString(dr["eTags"]);
if(!Convert.IsDBNull(dr["IsPublish"]))
objcmsArticleDO.IsPublish=Convert.ToBoolean(dr["IsPublish"]);
if(!Convert.IsDBNull(dr["OrderID"]))
objcmsArticleDO.OrderID=Convert.ToInt32(dr["OrderID"]);
if(!Convert.IsDBNull(dr["IsHompage"]))
objcmsArticleDO.IsHompage=Convert.ToBoolean(dr["IsHompage"]);
if(!Convert.IsDBNull(dr["UserCreate"]))
objcmsArticleDO.UserCreate=Convert.ToInt32(dr["UserCreate"]);
if(!Convert.IsDBNull(dr["CreateDate"]))
objcmsArticleDO.CreateDate=Convert.ToDateTime(dr["CreateDate"]);
if(!Convert.IsDBNull(dr["ParentID"]))
objcmsArticleDO.ParentID=Convert.ToInt32(dr["ParentID"]);
arrcmsArticleDO.Add(objcmsArticleDO);
}
            }
               return arrcmsArticleDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsArticle_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public DataTable SelectByCategoryID(int ID, int n)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsArticle_GetByCategoryID";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@id", SqlDbType.Int);
            Sqlparam.Value = ID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@n", SqlDbType.Int);
            Sqlparam.Value = n;
            Sqlcomm.Parameters.Add(Sqlparam);


            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable ArticleGetByPage(int CategoryID, int Page, int PageSize)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsArticle_GetByPage";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@CategoryID", SqlDbType.Int);
            Sqlparam.Value = CategoryID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Page", SqlDbType.Int);
            Sqlparam.Value = Page;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@PageSize", SqlDbType.Int);
            Sqlparam.Value = PageSize;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable GetbyPK(int ArticleID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsArticle_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ArticleID", SqlDbType.Int);
            Sqlparam.Value = ArticleID;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectHome()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsArticle_SelectHome";
            

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectMore(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsArticle_GetMore";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@po", SqlDbType.Int);
            Sqlparam.Value = p;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }



        public DataTable SelectNewClassTop(int Top, int cate)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsArticle_GetTop";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@Top", SqlDbType.Int);
            Sqlparam.Value = Top;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@categoryID", SqlDbType.Int);
            Sqlparam.Value = cate;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectNoti(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsArticle_SelectNoti";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@p", SqlDbType.Int);
            Sqlparam.Value = p;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }


        public DataTable GetTinTucbypage(int page, int pagesize)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsArticle_GetTinTucbypage";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@page", SqlDbType.Int);
            Sqlparam.Value = page;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@pagesize", SqlDbType.Int);
            Sqlparam.Value = pagesize;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable KhaiGiangbypage(int page, int pageSize)
        {
           SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsArticle_GetKhaiGiangbypage";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@page", SqlDbType.Int);
            Sqlparam.Value = page;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@pagesize", SqlDbType.Int);
            Sqlparam.Value = pageSize;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }




        public object selecttl(int lopid)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsArticle_GetTaiLieubyLop";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@LopID", SqlDbType.Int);
            Sqlparam.Value = lopid;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }
    }

}

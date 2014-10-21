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
/// Summary description for cmsArtCatDAL
/// </summary>
namespace bingo.DAL 
{
    
    public class cmsArtCatDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public cmsArtCatDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(cmsArtCatDO objcmsArtCatDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsArtCat_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ArticleID", SqlDbType.Int);
Sqlparam.Value = objcmsArtCatDO.ArticleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CategoryID", SqlDbType.Int);
Sqlparam.Value = objcmsArtCatDO.CategoryID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(cmsArtCatDO objcmsArtCatDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsArtCat_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ArticleID", SqlDbType.Int);
Sqlparam.Value = objcmsArtCatDO.ArticleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CategoryID", SqlDbType.Int);
Sqlparam.Value = objcmsArtCatDO.CategoryID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(cmsArtCatDO objcmsArtCatDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsArtCat_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ArticleID", SqlDbType.Int);
Sqlparam.Value = objcmsArtCatDO.ArticleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CategoryID", SqlDbType.Int);
Sqlparam.Value = objcmsArtCatDO.CategoryID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsArtCat_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public cmsArtCatDO Select(cmsArtCatDO objcmsArtCatDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsArtCat_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@ArticleID", SqlDbType.Int);
Sqlparam.Value = objcmsArtCatDO.ArticleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CategoryID", SqlDbType.Int);
Sqlparam.Value = objcmsArtCatDO.CategoryID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["ArticleID"]))
objcmsArtCatDO.ArticleID=Convert.ToInt32(dr["ArticleID"]);
if(!Convert.IsDBNull(dr["CategoryID"]))
objcmsArtCatDO.CategoryID=Convert.ToInt32(dr["CategoryID"]);

            }
             return objcmsArtCatDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsArtCat_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrcmsArtCatDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
cmsArtCatDO objcmsArtCatDO= new cmsArtCatDO();
if(!Convert.IsDBNull(dr["ArticleID"]))
objcmsArtCatDO.ArticleID=Convert.ToInt32(dr["ArticleID"]);
if(!Convert.IsDBNull(dr["CategoryID"]))
objcmsArtCatDO.CategoryID=Convert.ToInt32(dr["CategoryID"]);
arrcmsArtCatDO.Add(objcmsArtCatDO);
}
            }
               return arrcmsArtCatDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsArtCat_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    }

}

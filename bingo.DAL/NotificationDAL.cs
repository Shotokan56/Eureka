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
/// Summary description for NotificationDAL
/// </summary>
namespace bingo.DAL 
{
    
    public class NotificationDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public NotificationDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(NotificationDO objNotificationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spNotification_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objNotificationDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CategoryID", SqlDbType.Int);
Sqlparam.Value = objNotificationDO.CategoryID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IsPublish", SqlDbType.Bit);
Sqlparam.Value = objNotificationDO.IsPublish;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ArticleDetail", SqlDbType.NText);
Sqlparam.Value = objNotificationDO.ArticleDetail;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(NotificationDO objNotificationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spNotification_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ArticleID", SqlDbType.Int);
Sqlparam.Value = objNotificationDO.ArticleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objNotificationDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CategoryID", SqlDbType.Int);
Sqlparam.Value = objNotificationDO.CategoryID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IsPublish", SqlDbType.Bit);
Sqlparam.Value = objNotificationDO.IsPublish;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ArticleDetail", SqlDbType.NText);
Sqlparam.Value = objNotificationDO.ArticleDetail;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(NotificationDO objNotificationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spNotification_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ArticleID", SqlDbType.Int);
Sqlparam.Value = objNotificationDO.ArticleID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spNotification_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public NotificationDO Select(NotificationDO objNotificationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spNotification_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@ArticleID", SqlDbType.Int);
Sqlparam.Value = objNotificationDO.ArticleID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["ArticleID"]))
objNotificationDO.ArticleID=Convert.ToInt32(dr["ArticleID"]);
if(!Convert.IsDBNull(dr["Title"]))
objNotificationDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["CategoryID"]))
objNotificationDO.CategoryID=Convert.ToInt32(dr["CategoryID"]);
if(!Convert.IsDBNull(dr["IsPublish"]))
objNotificationDO.IsPublish=Convert.ToBoolean(dr["IsPublish"]);
if(!Convert.IsDBNull(dr["ArticleDetail"]))
objNotificationDO.ArticleDetail=Convert.ToString(dr["ArticleDetail"]);

            }
             return objNotificationDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spNotification_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrNotificationDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
NotificationDO objNotificationDO= new NotificationDO();
if(!Convert.IsDBNull(dr["ArticleID"]))
objNotificationDO.ArticleID=Convert.ToInt32(dr["ArticleID"]);
if(!Convert.IsDBNull(dr["Title"]))
objNotificationDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["CategoryID"]))
objNotificationDO.CategoryID=Convert.ToInt32(dr["CategoryID"]);
if(!Convert.IsDBNull(dr["IsPublish"]))
objNotificationDO.IsPublish=Convert.ToBoolean(dr["IsPublish"]);
if(!Convert.IsDBNull(dr["ArticleDetail"]))
objNotificationDO.ArticleDetail=Convert.ToString(dr["ArticleDetail"]);
arrNotificationDO.Add(objNotificationDO);
}
            }
               return arrNotificationDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spNotification_GetAll";
            
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

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
/// Summary description for cmsImagesDAL
/// </summary>
namespace bingo.DAL 
{
    
    public class cmsImagesDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public cmsImagesDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(cmsImagesDO objcmsImagesDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsImages_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
Sqlparam.Value = objcmsImagesDO.AlbumID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objcmsImagesDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@eTitle", SqlDbType.NVarChar);
Sqlparam.Value = objcmsImagesDO.eTitle;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objcmsImagesDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@eDescription", SqlDbType.NText);
Sqlparam.Value = objcmsImagesDO.eDescription;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ImgFile", SqlDbType.NVarChar);
Sqlparam.Value = objcmsImagesDO.ImgFile;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@StyleAlbum", SqlDbType.Bit);
Sqlparam.Value = objcmsImagesDO.StyleAlbum;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@SanPhamID", SqlDbType.BigInt);
Sqlparam.Value = objcmsImagesDO.SanPhamID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(cmsImagesDO objcmsImagesDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsImages_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ImageID", SqlDbType.Int);
Sqlparam.Value = objcmsImagesDO.ImageID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
Sqlparam.Value = objcmsImagesDO.AlbumID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objcmsImagesDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@eTitle", SqlDbType.NVarChar);
Sqlparam.Value = objcmsImagesDO.eTitle;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objcmsImagesDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@eDescription", SqlDbType.NText);
Sqlparam.Value = objcmsImagesDO.eDescription;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ImgFile", SqlDbType.NVarChar);
Sqlparam.Value = objcmsImagesDO.ImgFile;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@StyleAlbum", SqlDbType.Bit);
Sqlparam.Value = objcmsImagesDO.StyleAlbum;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@SanPhamID", SqlDbType.BigInt);
Sqlparam.Value = objcmsImagesDO.SanPhamID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(cmsImagesDO objcmsImagesDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsImages_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ImageID", SqlDbType.Int);
Sqlparam.Value = objcmsImagesDO.ImageID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsImages_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public cmsImagesDO Select(cmsImagesDO objcmsImagesDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsImages_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@ImageID", SqlDbType.Int);
Sqlparam.Value = objcmsImagesDO.ImageID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["ImageID"]))
objcmsImagesDO.ImageID=Convert.ToInt32(dr["ImageID"]);
if(!Convert.IsDBNull(dr["AlbumID"]))
objcmsImagesDO.AlbumID=Convert.ToInt32(dr["AlbumID"]);
if(!Convert.IsDBNull(dr["Title"]))
objcmsImagesDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["eTitle"]))
objcmsImagesDO.eTitle=Convert.ToString(dr["eTitle"]);
if(!Convert.IsDBNull(dr["Description"]))
objcmsImagesDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["eDescription"]))
objcmsImagesDO.eDescription=Convert.ToString(dr["eDescription"]);
if(!Convert.IsDBNull(dr["ImgFile"]))
objcmsImagesDO.ImgFile=Convert.ToString(dr["ImgFile"]);
if(!Convert.IsDBNull(dr["StyleAlbum"]))
objcmsImagesDO.StyleAlbum=Convert.ToBoolean(dr["StyleAlbum"]);
if(!Convert.IsDBNull(dr["SanPhamID"]))
objcmsImagesDO.SanPhamID=Convert.ToInt64(dr["SanPhamID"]);

            }
             return objcmsImagesDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsImages_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrcmsImagesDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
cmsImagesDO objcmsImagesDO= new cmsImagesDO();
if(!Convert.IsDBNull(dr["ImageID"]))
objcmsImagesDO.ImageID=Convert.ToInt32(dr["ImageID"]);
if(!Convert.IsDBNull(dr["AlbumID"]))
objcmsImagesDO.AlbumID=Convert.ToInt32(dr["AlbumID"]);
if(!Convert.IsDBNull(dr["Title"]))
objcmsImagesDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["eTitle"]))
objcmsImagesDO.eTitle=Convert.ToString(dr["eTitle"]);
if(!Convert.IsDBNull(dr["Description"]))
objcmsImagesDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["eDescription"]))
objcmsImagesDO.eDescription=Convert.ToString(dr["eDescription"]);
if(!Convert.IsDBNull(dr["ImgFile"]))
objcmsImagesDO.ImgFile=Convert.ToString(dr["ImgFile"]);
if(!Convert.IsDBNull(dr["StyleAlbum"]))
objcmsImagesDO.StyleAlbum=Convert.ToBoolean(dr["StyleAlbum"]);
if(!Convert.IsDBNull(dr["SanPhamID"]))
objcmsImagesDO.SanPhamID=Convert.ToInt64(dr["SanPhamID"]);
arrcmsImagesDO.Add(objcmsImagesDO);
}
            }
               return arrcmsImagesDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spcmsImages_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public DataTable SelectByAlbumID(int AlbumID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsImages_getByAlbumID";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
            Sqlparam.Value = AlbumID;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectTop(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsImages_gettop";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Top", SqlDbType.Int);
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

        public DataTable Selectbypage(int page, int pageSize, int albumid)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsImages_getbypage";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@page", SqlDbType.Int);
            Sqlparam.Value = page;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@pageSize", SqlDbType.Int);
            Sqlparam.Value = pageSize;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@albumid", SqlDbType.Int);
            Sqlparam.Value = albumid;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable Selectvideo()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsImages_GetVideo";
           

          

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable Selectvideobypage(int page, int pagesize)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsImages_selectvideobypage";
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

       
    }

}

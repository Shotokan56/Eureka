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
/// Summary description for SlideDAL
/// </summary>
namespace bingo.DAL
{

    public class SlideDAL : BaseDAL
    {
        #region Private Variables

        #endregion

        #region Public Constructors
        public SlideDAL()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        #endregion



        #region Public Methods
        public int Insert(SlideDO objSlideDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spSlide_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
            Sqlparam.Value = objSlideDO.Title;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@eTitle", SqlDbType.NVarChar);
            Sqlparam.Value = objSlideDO.eTitle;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
            Sqlparam.Value = objSlideDO.Description;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@eDescription", SqlDbType.NText);
            Sqlparam.Value = objSlideDO.eDescription;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@SlideURL", SqlDbType.NVarChar);
            Sqlparam.Value = objSlideDO.SlideURL;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@CategoryID", SqlDbType.Int);
            Sqlparam.Value = objSlideDO.CategoryID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
            Sqlparam.Value = objSlideDO.OrderID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@SlideImg", SqlDbType.NVarChar);
            Sqlparam.Value = objSlideDO.SlideImg;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);


            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(SlideDO objSlideDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spSlide_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@SlideID", SqlDbType.Int);
            Sqlparam.Value = objSlideDO.SlideID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
            Sqlparam.Value = objSlideDO.Title;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@eTitle", SqlDbType.NVarChar);
            Sqlparam.Value = objSlideDO.eTitle;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
            Sqlparam.Value = objSlideDO.Description;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@eDescription", SqlDbType.NText);
            Sqlparam.Value = objSlideDO.eDescription;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@SlideURL", SqlDbType.NVarChar);
            Sqlparam.Value = objSlideDO.SlideURL;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@CategoryID", SqlDbType.Int);
            Sqlparam.Value = objSlideDO.CategoryID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
            Sqlparam.Value = objSlideDO.OrderID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@SlideImg", SqlDbType.NVarChar);
            Sqlparam.Value = objSlideDO.SlideImg;
            Sqlcomm.Parameters.Add(Sqlparam);



            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;


        }

        public int Delete(SlideDO objSlideDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spSlide_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@SlideID", SqlDbType.Int);
            Sqlparam.Value = objSlideDO.SlideID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public int DeleteAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spSlide_DeleteAll";

            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public SlideDO Select(SlideDO objSlideDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spSlide_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@SlideID", SqlDbType.Int);
            Sqlparam.Value = objSlideDO.SlideID;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["SlideID"]))
                    objSlideDO.SlideID = Convert.ToInt32(dr["SlideID"]);
                if (!Convert.IsDBNull(dr["Title"]))
                    objSlideDO.Title = Convert.ToString(dr["Title"]);
                if (!Convert.IsDBNull(dr["eTitle"]))
                    objSlideDO.eTitle = Convert.ToString(dr["eTitle"]);
                if (!Convert.IsDBNull(dr["Description"]))
                    objSlideDO.Description = Convert.ToString(dr["Description"]);
                if (!Convert.IsDBNull(dr["eDescription"]))
                    objSlideDO.eDescription = Convert.ToString(dr["eDescription"]);
                if (!Convert.IsDBNull(dr["SlideURL"]))
                    objSlideDO.SlideURL = Convert.ToString(dr["SlideURL"]);
                if (!Convert.IsDBNull(dr["CategoryID"]))
                    objSlideDO.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                if (!Convert.IsDBNull(dr["OrderID"]))
                    objSlideDO.OrderID = Convert.ToInt32(dr["OrderID"]);
                if (!Convert.IsDBNull(dr["SlideImg"]))
                    objSlideDO.SlideImg = Convert.ToString(dr["SlideImg"]);

            }
            return objSlideDO;
        }

        public ArrayList SelectAll1()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spSlide_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrSlideDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    SlideDO objSlideDO = new SlideDO();
                    if (!Convert.IsDBNull(dr["SlideID"]))
                        objSlideDO.SlideID = Convert.ToInt32(dr["SlideID"]);
                    if (!Convert.IsDBNull(dr["Title"]))
                        objSlideDO.Title = Convert.ToString(dr["Title"]);
                    if (!Convert.IsDBNull(dr["eTitle"]))
                        objSlideDO.eTitle = Convert.ToString(dr["eTitle"]);
                    if (!Convert.IsDBNull(dr["Description"]))
                        objSlideDO.Description = Convert.ToString(dr["Description"]);
                    if (!Convert.IsDBNull(dr["eDescription"]))
                        objSlideDO.eDescription = Convert.ToString(dr["eDescription"]);
                    if (!Convert.IsDBNull(dr["SlideURL"]))
                        objSlideDO.SlideURL = Convert.ToString(dr["SlideURL"]);
                    if (!Convert.IsDBNull(dr["CategoryID"]))
                        objSlideDO.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                    if (!Convert.IsDBNull(dr["OrderID"]))
                        objSlideDO.OrderID = Convert.ToInt32(dr["OrderID"]);
                    if (!Convert.IsDBNull(dr["SlideImg"]))
                        objSlideDO.SlideImg = Convert.ToString(dr["SlideImg"]);
                    arrSlideDO.Add(objSlideDO);
                }
            }
            return arrSlideDO;
        }

        public DataTable SelectAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spSlide_GetAll";

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

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
/// Summary description for NotificationBL
/// </summary>
namespace bingo.BL 
{
    public class NotificationBL 
    {
    	#region Private Variables
		NotificationDAL objNotificationDAL;
		#endregion
		
        #region Public Constructors
        public NotificationBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objNotificationDAL=new NotificationDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(NotificationDO objNotificationDO)
        {
            return objNotificationDAL.Insert(objNotificationDO);
        }

        public int Update(NotificationDO objNotificationDO)
        {
             return objNotificationDAL.Update(objNotificationDO);

        }

        public int Delete(NotificationDO objNotificationDO)
        {
             return objNotificationDAL.Delete(objNotificationDO);

        }

         public int DeleteAll()
        {
             return objNotificationDAL.DeleteAll();
        }

        public NotificationDO Select(NotificationDO objNotificationDO)
        {
            return objNotificationDAL.Select(objNotificationDO);
        }

        public ArrayList SelectAll1( )
        {
         return objNotificationDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objNotificationDAL.SelectAll();
        }


     
#endregion          
    
    }

}

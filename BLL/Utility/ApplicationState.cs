using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.DataAccess;
using System.Transactions;
using Common;

namespace BLL.Utility
{
    public class ApplicationState
    {
        #region Member
        
        #endregion

        #region Properties
        public static string CompanyId { get; set; }        
        public static string CompanyName { get; set; }
        public static string CompanyAddress {get; set;}
        public static string LocationId { get; set; }
        public static string LocationName { get; set; }
        public static string User { get; set; }
        public static string UserFullName { get; set; }
        public static string Department { get; set; }
        public static string Level { get; set; }
        public static string UserEntryExitID { get; set; }

        public static IDataAccess DAClient
        {
            get
            {
                return DataAccessFactory.DAClient;
            }
        }
        #endregion

        #region Method
        
        #endregion
    }
}

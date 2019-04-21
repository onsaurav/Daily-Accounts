using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.DataAccess;

namespace BLL.Utility
{
    public class DataAccessFactory
    {
        /// <summary>
        /// 
        /// </summary>
        [ThreadStatic]
        private static IDataAccess _IDataAccess = null;

        /// <summary>
        /// Gets or sets the DA client.
        /// </summary>
        /// <value>
        /// The DA client.
        /// </value>
        public static IDataAccess DAClient
        {
            get
            {
                if (_IDataAccess == null)
                    _IDataAccess = new DataAccess();
                return _IDataAccess;
            }
            set
            {
                _IDataAccess = value;
            }
        }
    }
}

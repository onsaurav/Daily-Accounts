using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.ServiceModel;

namespace DAL.DataAccess
{
    //[MAIN Data Access]
    public partial class DataAccess : IDataAccess
    {
        private ONSAccountsDataContext _dataContext;
        private ErrorHandler _ErrorHandler = new ErrorHandler();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAccess"/> class.
        /// </summary>
        public DataAccess()
        {
            if (_dataContext == null)
            {
                string connectionString = "Data Source=.;Initial Catalog=ONSAccounts;Integrated Security=True";
                _dataContext = new ONSAccountsDataContext(connectionString);
                _dataContext.Log = Console.Out;
            }
        }

        /// <summary>
        /// Closes the data context.
        /// </summary>
        private void CloseDataContext()
        {
            if (_dataContext != null)
                _dataContext.Dispose();
        }
    }
}

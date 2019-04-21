using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DAL.DataAccess;
using BLL.Utility;
using Common;
using System.Transactions;

namespace BLL.Setup
{
    public class Setup_Insert_BLL
    {
        CommonMethods _CommonMethods = new CommonMethods();

        /// <summary>
        /// Inserts the accounts.
        /// </summary>
        /// <param name="_Account">The _ account.</param>
        /// <returns></returns>
        public ONSResult InsertAccounts(Account _Account)
        {
            ONSResult _ONSResultSave = new ONSResult();
            try
            {
                using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required, DBHelper.TransactionOptions))
                {
                    _ONSResultSave = ApplicationState.DAClient.InsertAccount(_Account);
                    transaction.Complete();
                }                
            }
            catch (Exception ex)
            {
                ErrorHandler _ErrorHandler = new ErrorHandler();
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return _ONSResultSave;
        }

        /// <summary>
        /// Inserts the control accounts.
        /// </summary>
        /// <param name="_ControlAccount">The _ control account.</param>
        /// <returns></returns>
        public ONSResult InsertControlAccounts(ControlAccount _ControlAccount)
        {
            ONSResult _ONSResultSave = new ONSResult();
            try
            {
                using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required, DBHelper.TransactionOptions))
                {
                    _ControlAccount.ControlId = _CommonMethods.RandomString(3);
                    _ONSResultSave = ApplicationState.DAClient.InsertControlAccount(_ControlAccount);
                    transaction.Complete();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler _ErrorHandler = new ErrorHandler();
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return _ONSResultSave;
        }

        /// <summary>
        /// Inserts the group accounts.
        /// </summary>
        /// <param name="_GroupAccount">The _ group account.</param>
        /// <returns></returns>
        public ONSResult InsertGroupAccounts(GroupAccount _GroupAccount)
        {
            ONSResult _ONSResultSave = new ONSResult();
            try
            {
                using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required, DBHelper.TransactionOptions))
                {
                    _ONSResultSave = ApplicationState.DAClient.InsertGroupAccount(_GroupAccount);
                    transaction.Complete();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler _ErrorHandler = new ErrorHandler();
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return _ONSResultSave;
        }

        /// <summary>
        /// Inserts the ID number.
        /// </summary>
        /// <param name="_IDNumber">The _ ID number.</param>
        /// <returns></returns>
        public ONSResult InsertIDNumber(IDNumber _IDNumber)
        {
            ONSResult _ONSResultSave = new ONSResult();
            try
            {
                using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required, DBHelper.TransactionOptions))
                {
                    _ONSResultSave = ApplicationState.DAClient.InsertIDNumber(_IDNumber);
                    transaction.Complete();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler _ErrorHandler = new ErrorHandler();
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return _ONSResultSave;
        }

        /// <summary>
        /// Inserts the user entry exit.
        /// </summary>
        /// <param name="_UserEntryExit">The _ user entry exit.</param>
        /// <returns></returns>
        public ONSResult InsertUserEntryExit(UserEntryExit _UserEntryExit)
        {
            ONSResult _ONSResultSave = new ONSResult();
            try
            {
                using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required, DBHelper.TransactionOptions))
                {
                    _ONSResultSave = ApplicationState.DAClient.InsertUserEntryExit(_UserEntryExit);
                    transaction.Complete();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler _ErrorHandler = new ErrorHandler();
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return _ONSResultSave;
        }
    }
}

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
    public class Setup_Update_BLL
    {
        /// <summary>
        /// Updates the accounts.
        /// </summary>
        /// <param name="_Account">The _ account.</param>
        /// <returns></returns>
        public ONSResult UpdateAccounts(Account _Account)
        {
            ONSResult _ONSResultSave = new ONSResult();
            try
            {
                using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required, DBHelper.TransactionOptions))
                {
                    _ONSResultSave = ApplicationState.DAClient.UpdateAccount(_Account);
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
        /// Updates the control accounts.
        /// </summary>
        /// <param name="_ControlAccount">The _ control account.</param>
        /// <returns></returns>
        public ONSResult UpdateControlAccounts(ControlAccount _ControlAccount)
        {
            ONSResult _ONSResultSave = new ONSResult();
            try
            {
                using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required, DBHelper.TransactionOptions))
                {
                    _ONSResultSave = ApplicationState.DAClient.UpdateControlAccount(_ControlAccount);
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
        /// Updates the group accounts.
        /// </summary>
        /// <param name="_GroupAccount">The _ group account.</param>
        /// <returns></returns>
        public ONSResult UpdateGroupAccounts(GroupAccount _GroupAccount)
        {
            ONSResult _ONSResultSave = new ONSResult();
            try
            {
                using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required, DBHelper.TransactionOptions))
                {
                    _ONSResultSave = ApplicationState.DAClient.UpdateGroupAccount(_GroupAccount);
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
        /// Updates the ID number.
        /// </summary>
        /// <param name="_IDNumber">The _ ID number.</param>
        /// <returns></returns>
        public ONSResult UpdateIDNumber(IDNumber _IDNumber)
        {
            ONSResult _ONSResultSave = new ONSResult();
            try
            {
                using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required, DBHelper.TransactionOptions))
                {
                    _ONSResultSave = ApplicationState.DAClient.UpdateIDNumber(_IDNumber);
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
        /// Updates the user entry exit.
        /// </summary>
        /// <param name="_UserEntryExit">The _ user entry exit.</param>
        /// <returns></returns>
        public ONSResult UpdateUserEntryExit(UserEntryExit _UserEntryExit)
        {
            ONSResult _ONSResultSave = new ONSResult();
            try
            {
                using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required, DBHelper.TransactionOptions))
                {
                    _ONSResultSave = ApplicationState.DAClient.UpdateUserEntryExit(_UserEntryExit);
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

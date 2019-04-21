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
    public class Setup_Save_BLL
    {
        CommonMethods _CommonMethods = new CommonMethods();

        /// <summary>
        /// Saves the control accounts.
        /// </summary>
        /// <param name="_listControlAccount">The _list control account.</param>
        /// <returns></returns>
        public ONSResult SaveControlAccounts(List<ControlAccount> _listControlAccount)
        {
            ONSResult _ONSResultSave = new ONSResult();

            try
            {
                using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required, DBHelper.TransactionOptions))
                {
                    foreach (ControlAccount item in _listControlAccount)
                    {
                        if (String.IsNullOrEmpty(item.ControlId))
                        {
                            item.ControlId = _CommonMethods.RandomString(3);
                            _ONSResultSave = ApplicationState.DAClient.InsertControlAccount(item);
                        }
                        else
                        {
                            _ONSResultSave = ApplicationState.DAClient.UpdateControlAccount(item);
                        }
                    }

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
        /// Saves the ID number.
        /// </summary>
        /// <param name="_listIDNumber">The _list ID number.</param>
        /// <returns></returns>
        public ONSResult SaveIDNumber(List<IDNumber> _listIDNumber)
        {
            ONSResult _ONSResultSave = new ONSResult();

            try
            {
                using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required, DBHelper.TransactionOptions))
                {
                    foreach (IDNumber item in _listIDNumber)
                    {
                        if (item.SlNo == 0)
                        {
                            _ONSResultSave = ApplicationState.DAClient.InsertIDNumber(item);
                        }
                        else
                        {
                            _ONSResultSave = ApplicationState.DAClient.UpdateIDNumber(item);
                        }
                    }

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

        public ONSResult SaveUserEntryExit(List<UserEntryExit> _listUserEntryExit)
        {
            ONSResult _ONSResultSave = new ONSResult();

            try
            {
                using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required, DBHelper.TransactionOptions))
                {
                    foreach (UserEntryExit item in _listUserEntryExit)
                    {
                        if (item.UserEntryExitID == string.Empty)
                        {
                            _ONSResultSave = ApplicationState.DAClient.InsertUserEntryExit(item);
                        }
                        else
                        {
                            _ONSResultSave = ApplicationState.DAClient.UpdateUserEntryExit(item);
                        }
                    }

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

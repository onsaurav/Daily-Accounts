using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.ServiceModel;
using System.Configuration;
using System.Transactions;

namespace DAL.DataAccess
{
    //[INSERT]
    public partial class DataAccess
    {
        /// <summary>
        /// SQLs the bulk insert.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listT">The list T.</param>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public void SqlBulkInsert<T>(List<T> listT)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[Common.Constant.CONNECTIONSTRING].ConnectionString;
            using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required, DBHelper.TransactionOptions))
            {
                DBHelper.InsertWithSqlBulkCopy(connectionString, DBHelper.ConvertCollectionToDataTable<T>(listT, Common.Constant.DATA_ACCESS_NAMESPACE_STRING));
                transaction.Complete();
            }
        }

        /// <summary>
        /// Inserts the account.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ONSResult InsertAccount(Account parameter)
        {
            ONSResult _ONSResultInsert = new ONSResult();
            try
            {
                _dataContext.Accounts.InsertOnSubmit(parameter);
                _dataContext.SubmitChanges();

                _ONSResultInsert.ID = parameter.AccountsId;
                _ONSResultInsert.IsSuccess = true;
                _ONSResultInsert.Message ="Account inserted successfully.";
            }
            catch (Exception ex)
            {
                _ONSResultInsert.IsSuccess = false;
                _ONSResultInsert.Message = ex.Message;
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return _ONSResultInsert;
        }

        /// <summary>
        /// Inserts the control account.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ONSResult InsertControlAccount(ControlAccount parameter)
        {
            ONSResult _ONSResultInsert = new ONSResult();
            try
            {
                _dataContext.ControlAccounts.InsertOnSubmit(parameter);
                _dataContext.SubmitChanges();

                _ONSResultInsert.ID = parameter.ControlId;
                _ONSResultInsert.IsSuccess = true;
                _ONSResultInsert.Message = "Control Account inserted successfully.";
            }
            catch (Exception ex)
            {
                _ONSResultInsert.IsSuccess = false;
                _ONSResultInsert.Message = ex.Message;
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return _ONSResultInsert;
        }

        /// <summary>
        /// Inserts the group account.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ONSResult InsertGroupAccount(GroupAccount parameter)
        {
            ONSResult _ONSResultInsert = new ONSResult();
            try
            {
                _dataContext.GroupAccounts.InsertOnSubmit(parameter);
                _dataContext.SubmitChanges();

                _ONSResultInsert.ID = parameter.GroupId;
                _ONSResultInsert.IsSuccess = true;
                _ONSResultInsert.Message = "Group Account inserted successfully.";
            }
            catch (Exception ex)
            {
                _ONSResultInsert.IsSuccess = false;
                _ONSResultInsert.Message = ex.Message;
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return _ONSResultInsert;
        }

        /// <summary>
        /// Inserts the ID number.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ONSResult InsertIDNumber(IDNumber parameter)
        {
            ONSResult _ONSResultInsert = new ONSResult();
            try
            {
                _dataContext.IDNumbers.InsertOnSubmit(parameter);
                _dataContext.SubmitChanges();

                _ONSResultInsert.ID = parameter.SlNo.ToString();
                _ONSResultInsert.IsSuccess = true;
                _ONSResultInsert.Message = "IDNumber inserted successfully.";
            }
            catch (Exception ex)
            {
                _ONSResultInsert.IsSuccess = false;
                _ONSResultInsert.Message = ex.Message;
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return _ONSResultInsert;
        }


        /// <summary>
        /// Inserts the user entry exit.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ONSResult InsertUserEntryExit(UserEntryExit parameter)
        {
            ONSResult _ONSResultInsert = new ONSResult();
            try
            {
                _dataContext.UserEntryExits.InsertOnSubmit(parameter);
                _dataContext.SubmitChanges();

                _ONSResultInsert.ID = parameter.UserEntryExitID;
                _ONSResultInsert.IsSuccess = true;
                _ONSResultInsert.Message = "UserEntryExit inserted successfully.";
            }
            catch (Exception ex)
            {
                _ONSResultInsert.IsSuccess = false;
                _ONSResultInsert.Message = ex.Message;
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return _ONSResultInsert;
        }
    }
}

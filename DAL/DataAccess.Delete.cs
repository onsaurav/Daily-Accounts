using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.ServiceModel;

namespace DAL.DataAccess
{
    //[DELETE]
    public partial class DataAccess
    {
        /// <summary>
        /// Deletes the account.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ONSResult DeleteAccount(Account parameter)
        {
            ONSResult _ONSResultInsert = new ONSResult();
            try
            {
                List<Account> list = new List<Account>();
                var query = from a in _dataContext.Accounts
                            where a.AccountsId == parameter.AccountsId
                            select a;
                list = query.ToList<Account>();

                if (list.Count == 1)
                {
                    _dataContext.Accounts.DeleteOnSubmit(list[0]);
                    _dataContext.SubmitChanges();

                    _ONSResultInsert.IsSuccess = true;
                    _ONSResultInsert.Message = "Account deleted successfully.";
                }
                else
                {
                    _ONSResultInsert.IsSuccess = false;
                    _ONSResultInsert.Message = "Account not found with this id.";
                }
                
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

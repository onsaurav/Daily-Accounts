using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.ServiceModel;

namespace DAL.DataAccess
{
    //[UPDATE]
    public partial class DataAccess
    {
        /// <summary>
        /// Updates the account.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ONSResult UpdateAccount(Account parameter)
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
                    Account obj = list[0];
                    if (!String.IsNullOrEmpty(parameter.AccountsId))
                        obj.AccountsId = parameter.AccountsId;
                    if (!String.IsNullOrEmpty(parameter.GroupId))
                        obj.GroupId = parameter.GroupId;
                    if (!String.IsNullOrEmpty(parameter.ControlId))
                        obj.ControlId = parameter.ControlId;
                    if (!String.IsNullOrEmpty(parameter.SubsidiaryId))
                        obj.SubsidiaryId = parameter.SubsidiaryId;
                    if (!String.IsNullOrEmpty(parameter.Name))
                        obj.Name = parameter.Name;
                    if (parameter.OpeningDate.HasValue)
                        obj.OpeningDate = parameter.OpeningDate.Value;
                    if (parameter.OpeningBalance.HasValue)
                        obj.OpeningBalance = parameter.OpeningBalance.Value;
                    if (!String.IsNullOrEmpty(parameter.Type))
                        obj.Type = parameter.Type;
                    if (!String.IsNullOrEmpty(parameter.CompanyId))
                        obj.CompanyId = parameter.CompanyId;
                    if (parameter.DateOfEntry.HasValue)
                        obj.DateOfEntry = parameter.DateOfEntry.Value;
                    if (!String.IsNullOrEmpty(parameter.EntryBy))
                        obj.EntryBy = parameter.EntryBy;
                    _dataContext.SubmitChanges();
                }
                _ONSResultInsert.IsSuccess = true;
                _ONSResultInsert.Message = "Account updated successfully.";
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
        /// Updates the control account.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ONSResult UpdateControlAccount(ControlAccount parameter)
        {
            ONSResult _ONSResultInsert = new ONSResult();
            try
            {
                List<ControlAccount> list = new List<ControlAccount>();
                var query = from a in _dataContext.ControlAccounts
                            where a.ControlId == parameter.ControlId
                            select a;
                list = query.ToList<ControlAccount>();

                if (list.Count == 1)
                {
                    ControlAccount obj = list[0];
                    if (!String.IsNullOrEmpty(parameter.ControlId))
                        obj.ControlId = parameter.ControlId;
                    if (!String.IsNullOrEmpty(parameter.GroupId))
                        obj.GroupId = parameter.GroupId;
                    if (!String.IsNullOrEmpty(parameter.Name))
                        obj.Name = parameter.Name;                   
                    if (!String.IsNullOrEmpty(parameter.CompanyId))
                        obj.CompanyId = parameter.CompanyId;
                    if (parameter.DateOfEntry.HasValue)
                        obj.DateOfEntry = parameter.DateOfEntry.Value;
                    if (!String.IsNullOrEmpty(parameter.EntryBy))
                        obj.EntryBy = parameter.EntryBy;
                    if (!String.IsNullOrEmpty(parameter.Remarks))
                        obj.Remarks = parameter.Remarks;
                    _dataContext.SubmitChanges();
                }
                _ONSResultInsert.IsSuccess = true;
                _ONSResultInsert.Message = "Control Account updated successfully.";
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
        /// Updates the group account.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ONSResult UpdateGroupAccount(GroupAccount parameter)
        {
            ONSResult _ONSResultInsert = new ONSResult();
            try
            {
                List<GroupAccount> list = new List<GroupAccount>();
                var query = from a in _dataContext.GroupAccounts
                            where a.GroupId == parameter.GroupId
                            select a;
                list = query.ToList<GroupAccount>();

                if (list.Count == 1)
                {
                    GroupAccount obj = list[0];
                    if (!String.IsNullOrEmpty(parameter.GroupId))
                        obj.GroupId = parameter.GroupId;
                    if (!String.IsNullOrEmpty(parameter.Name))
                        obj.Name = parameter.Name;
                    if (!String.IsNullOrEmpty(parameter.BalanceType))
                        obj.BalanceType = parameter.BalanceType;
                    _dataContext.SubmitChanges();
                }
                _ONSResultInsert.IsSuccess = true;
                _ONSResultInsert.Message = "Group Account updated successfully.";
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
        /// Updates the ID number.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ONSResult UpdateIDNumber(IDNumber parameter)
        {
            ONSResult _ONSResultInsert = new ONSResult();
            try
            {
                List<IDNumber> list = new List<IDNumber>();
                var query = from a in _dataContext.IDNumbers
                            where a.SlNo == parameter.SlNo
                            select a;
                list = query.ToList<IDNumber>();

                if (list.Count == 1)
                {
                    IDNumber obj = list[0];
                    if (parameter.SlNo != 0)
                        obj.SlNo = parameter.SlNo;
                    if (!String.IsNullOrEmpty(parameter.IDNo))
                        obj.IDNo = parameter.IDNo;
                    if (!String.IsNullOrEmpty(parameter.IDTypeId))
                        obj.IDTypeId = parameter.IDTypeId;
                    if (!String.IsNullOrEmpty(parameter.CompanyId))
                        obj.CompanyId = parameter.CompanyId;
                    if (!String.IsNullOrEmpty(parameter.LocationId))
                        obj.LocationId = parameter.LocationId;
                    if (!String.IsNullOrEmpty(parameter.EntryBy))
                        obj.EntryBy = parameter.EntryBy;
                    if (parameter.DateOfEntry.HasValue)
                        obj.DateOfEntry = parameter.DateOfEntry.Value;
                    if (parameter.IDYear.HasValue)
                        obj.IDYear = parameter.IDYear.Value;
                    _dataContext.SubmitChanges();
                }
                _ONSResultInsert.IsSuccess = true;
                _ONSResultInsert.Message = "IDNumber updated successfully.";
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
        /// Updates the user entry exit.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ONSResult UpdateUserEntryExit(UserEntryExit parameter)
        {
            ONSResult _ONSResultInsert = new ONSResult();
            try
            {
                List<UserEntryExit> list = new List<UserEntryExit>();
                var query = from a in _dataContext.UserEntryExits
                            where a.UserEntryExitID == parameter.UserEntryExitID
                            select a;
                list = query.ToList<UserEntryExit>();

                if (list.Count == 1)
                {
                    UserEntryExit obj = list[0];
                    if (!String.IsNullOrEmpty(parameter.UserEntryExitID))
                        obj.UserEntryExitID = parameter.UserEntryExitID;
                    if (!String.IsNullOrEmpty(parameter.Name))
                        obj.Name = parameter.Name;
                    if (!String.IsNullOrEmpty(parameter.EntryTime))
                        obj.EntryTime = parameter.EntryTime;
                    if (!String.IsNullOrEmpty(parameter.ExitTime))
                        obj.ExitTime = parameter.ExitTime;
                    if (parameter.EntryDate.HasValue)
                        obj.EntryDate = parameter.EntryDate.Value;
                    if (parameter.ExitDate.HasValue)
                        obj.ExitDate = parameter.ExitDate.Value;
                    if (!String.IsNullOrEmpty(parameter.CompanyId))
                        obj.CompanyId = parameter.CompanyId;
                    if (!String.IsNullOrEmpty(parameter.LocationId))
                        obj.LocationId = parameter.LocationId;
                    _dataContext.SubmitChanges();
                }
                _ONSResultInsert.IsSuccess = true;
                _ONSResultInsert.Message = "IDNumber updated successfully.";
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Common;
using System.ServiceModel;

namespace DAL.DataAccess
{
    //[SELECT]
    public partial class DataAccess
    {
        /// <summary>
        /// Selects the account.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public List<Account> SelectAccount(Account parameter)
        {
            List<Account> list = new List<Account>();
            try
            {
                var query = from a in _dataContext.Accounts
                        .WhereIf(!String.IsNullOrEmpty(parameter.AccountsId), q => q.AccountsId == parameter.AccountsId)
                        .WhereIf(!String.IsNullOrEmpty(parameter.GroupId), q => q.GroupId == parameter.GroupId)
                        .WhereIf(!String.IsNullOrEmpty(parameter.ControlId), q => q.ControlId == parameter.ControlId)
                        .WhereIf(!String.IsNullOrEmpty(parameter.SubsidiaryId), q => q.SubsidiaryId == parameter.SubsidiaryId)
                        .WhereIf(!String.IsNullOrEmpty(parameter.Name), q => q.Name == parameter.Name)
                        .WhereIf(parameter.OpeningDate.HasValue, q => q.OpeningDate.Value.Date == parameter.OpeningDate.Value.Date)
                        .WhereIf(parameter.OpeningBalance.HasValue , q => q.OpeningBalance == parameter.OpeningBalance)
                        .WhereIf(!String.IsNullOrEmpty(parameter.Type), q => q.Type == parameter.Type)
                        .WhereIf(!String.IsNullOrEmpty(parameter.CompanyId), q => q.CompanyId == parameter.CompanyId)
                        .WhereIf(parameter.DateOfEntry.HasValue, q => q.DateOfEntry == parameter.DateOfEntry)
                        .WhereIf(!String.IsNullOrEmpty(parameter.EntryBy), q => q.EntryBy == parameter.EntryBy)
                            orderby a.Name ascending
                            select a;
                list = query.ToList<Account>();
            }
            catch (SqlException ex)
            {
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return list;
        }

        /// <summary>
        /// Selects the control account.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public List<ControlAccount> SelectControlAccount(ControlAccount parameter)
        {
            List<ControlAccount> list = new List<ControlAccount>();
            try
            {
                var query = from a in _dataContext.ControlAccounts
                        .WhereIf(!String.IsNullOrEmpty(parameter.ControlId), q => q.ControlId == parameter.ControlId)
                        .WhereIf(!String.IsNullOrEmpty(parameter.GroupId), q => q.GroupId == parameter.GroupId)
                        .WhereIf(!String.IsNullOrEmpty(parameter.Name), q => q.Name == parameter.Name)
                        .WhereIf(parameter.DateOfEntry.HasValue, q => q.DateOfEntry.Value.Date == parameter.DateOfEntry.Value.Date)
                        .WhereIf(!String.IsNullOrEmpty(parameter.EntryBy), q => q.EntryBy == parameter.EntryBy)
                        .WhereIf(!String.IsNullOrEmpty(parameter.CompanyId), q => q.CompanyId == parameter.CompanyId)
                        .WhereIf(!String.IsNullOrEmpty(parameter.Remarks), q => q.CompanyId == parameter.Remarks)
                            orderby a.Name ascending
                            select a;
                list = query.ToList<ControlAccount>();
            }
            catch (SqlException ex)
            {
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return list;
        }
        
        /// <summary>
        /// Selects the company.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public List<Company> SelectCompany(Company parameter)
        {
            List<Company> list = new List<Company>();
            try
            {
                var query = from a in _dataContext.Companies
                        .WhereIf(!String.IsNullOrEmpty(parameter.CompanyId), q => q.CompanyId == parameter.CompanyId)
                        .WhereIf(!String.IsNullOrEmpty(parameter.Name), q => q.Name == parameter.Name)
                        .WhereIf(!String.IsNullOrEmpty(parameter.Address), q => q.Address == parameter.Address)
                        .WhereIf(!String.IsNullOrEmpty(parameter.Phone), q => q.Phone == parameter.Phone)
                        .WhereIf(!String.IsNullOrEmpty(parameter.Fax), q => q.Fax == parameter.Fax)
                        .WhereIf(!String.IsNullOrEmpty(parameter.Email), q => q.Email == parameter.Email)
                        .WhereIf(!String.IsNullOrEmpty(parameter.URL), q => q.URL == parameter.URL)
                        .WhereIf(parameter.OpeningDate.HasValue, q => q.OpeningDate.Value.Date == parameter.OpeningDate.Value.Date)
                        .WhereIf(parameter.DateOfEntry.HasValue, q => q.DateOfEntry.Value.Date == parameter.DateOfEntry.Value.Date)
                        .WhereIf(!String.IsNullOrEmpty(parameter.EntryBy), q => q.EntryBy == parameter.EntryBy)
                            orderby a.Name ascending
                            select a;
                list = query.ToList<Company>();
            }
            catch (SqlException ex)
            {
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return list;
        }

        /// <summary>
        /// Selects the location.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public List<Location> SelectLocation(Location parameter)
        {
            List<Location> list = new List<Location>();
            try
            {
                var query = from a in _dataContext.Locations
                        .WhereIf(!String.IsNullOrEmpty(parameter.LocationId), q => q.LocationId == parameter.LocationId)
                        .WhereIf(!String.IsNullOrEmpty(parameter.Name), q => q.Name == parameter.Name)
                        .WhereIf(!String.IsNullOrEmpty(parameter.CompanyId), q => q.CompanyId == parameter.CompanyId)
                        .WhereIf(parameter.DateOfEntry.HasValue, q => q.DateOfEntry.Value.Date == parameter.DateOfEntry.Value.Date)
                        .WhereIf(!String.IsNullOrEmpty(parameter.EntryBy), q => q.EntryBy == parameter.EntryBy)
                            orderby a.Name ascending
                            select a;
                list = query.ToList<Location>();
            }
            catch (SqlException ex)
            {
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return list;
        }

        /// <summary>
        /// Selects the group account.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public List<GroupAccount> SelectGroupAccount(GroupAccount parameter)
        {
            List<GroupAccount> list = new List<GroupAccount>();
            try
            {
                var query = from a in _dataContext.GroupAccounts
                        .WhereIf(!String.IsNullOrEmpty(parameter.GroupId), q => q.GroupId == parameter.GroupId)
                        .WhereIf(!String.IsNullOrEmpty(parameter.Name), q => q.Name == parameter.Name)
                        .WhereIf(!String.IsNullOrEmpty(parameter.BalanceType), q => q.BalanceType == parameter.BalanceType)
                            orderby a.Name ascending
                            select a;
                list = query.ToList<GroupAccount>();
            }
            catch (SqlException ex)
            {
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return list;
        }

        /// <summary>
        /// Selects the group account.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public List<IDNumber> SelectIDNumber(IDNumber parameter)
        {
            List<IDNumber> list = new List<IDNumber>();
            try
            {
                var query = from a in _dataContext.IDNumbers
                        .WhereIf(parameter.SlNo !=0 , q => q.SlNo == parameter.SlNo)
                        .WhereIf(!String.IsNullOrEmpty(parameter.IDNo), q => q.IDNo == parameter.IDNo)
                        .WhereIf(!String.IsNullOrEmpty(parameter.IDTypeId), q => q.IDTypeId == parameter.IDTypeId)
                        .WhereIf(!String.IsNullOrEmpty(parameter.CompanyId), q => q.CompanyId == parameter.CompanyId)
                        .WhereIf(!String.IsNullOrEmpty(parameter.LocationId), q => q.LocationId == parameter.LocationId)
                        .WhereIf(!String.IsNullOrEmpty(parameter.EntryBy), q => q.EntryBy == parameter.EntryBy)
                        .WhereIf(parameter.DateOfEntry.HasValue, q => q.DateOfEntry == parameter.DateOfEntry.Value)
                        .WhereIf(parameter.IDYear.HasValue, q => q.IDYear == parameter.IDYear.Value)
                            orderby a.IDNo ascending
                            select a;
                list = query.ToList<IDNumber>();
            }
            catch (SqlException ex)
            {
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return list;
        }

        /// <summary>
        /// Selects the user.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public List<User> SelectUser(User parameter)
        {
            List<User> list = new List<User>();
            try
            {
                var query = from a in _dataContext.Users
                        .WhereIf(!String.IsNullOrEmpty(parameter.DepartmentId), q => q.DepartmentId == parameter.DepartmentId)
                        .WhereIf(!String.IsNullOrEmpty(parameter.LevelId), q => q.LevelId == parameter.LevelId)
                        .WhereIf(!String.IsNullOrEmpty(parameter.UserName), q => q.UserName == parameter.UserName)
                        .WhereIf(!String.IsNullOrEmpty(parameter.FullName), q => q.FullName == parameter.FullName)
                        .WhereIf(!String.IsNullOrEmpty(parameter.Password), q => q.Password == parameter.Password)
                        .WhereIf(parameter.Active.HasValue, q => q.Active == parameter.Active.Value)
                        .WhereIf(parameter.DateOfEntry.HasValue, q => q.DateOfEntry == parameter.DateOfEntry.Value)
                        .WhereIf(parameter.FirstLogIn.HasValue, q => q.FirstLogIn == parameter.FirstLogIn.Value)
                        .WhereIf(parameter.ActiveDays.HasValue, q => q.ActiveDays == parameter.ActiveDays.Value)
                        .WhereIf(parameter.LastActivated.HasValue, q => q.LastActivated == parameter.LastActivated.Value)
                        .WhereIf(!String.IsNullOrEmpty(parameter.CompanyId), q => q.CompanyId == parameter.CompanyId)
                        .WhereIf(!String.IsNullOrEmpty(parameter.EntryBy), q => q.EntryBy == parameter.EntryBy)
                            orderby a.UserName ascending
                            select a;
                list = query.ToList<User>();
            }
            catch (SqlException ex)
            {
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return list;
        }

        /// <summary>
        /// Selects the user login assign.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns></returns>
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public List<UserLoginAssign> SelectUserLoginAssign(UserLoginAssign parameter)
        {
            List<UserLoginAssign> list = new List<UserLoginAssign>();
            try
            {
                var query = from a in _dataContext.UserLoginAssigns                        
                        .WhereIf(!String.IsNullOrEmpty(parameter.UserName), q => q.UserName == parameter.UserName)
                        .WhereIf(!String.IsNullOrEmpty(parameter.CompanyId), q => q.CompanyId == parameter.CompanyId)
                        .WhereIf(!String.IsNullOrEmpty(parameter.LocationId), q => q.LocationId == parameter.LocationId)
                        .WhereIf(parameter.DateOfEntry.HasValue, q => q.DateOfEntry == parameter.DateOfEntry.Value)
                        .WhereIf(!String.IsNullOrEmpty(parameter.EntryBy), q => q.EntryBy == parameter.EntryBy)
                            orderby a.UserName ascending
                            select a;
                list = query.ToList<UserLoginAssign>();
            }
            catch (SqlException ex)
            {
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return list;
        }
    }
}

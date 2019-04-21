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
    public class Setup_Select_BLL
    {
        /// <summary>
        /// Selects the accounts.
        /// </summary>
        /// <param name="_Account">The _ account.</param>
        /// <returns></returns>
        public List<Account> SelectAccounts(Account _Account)
        {
            List<Account> listAccountSelect = new List<Account>();
            try
            {
                listAccountSelect =  ApplicationState.DAClient.SelectAccount(_Account);
            }
            catch (Exception ex)
            {
                ErrorHandler _ErrorHandler = new ErrorHandler();
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return listAccountSelect;
        }

        /// <summary>
        /// Selects the control accounts.
        /// </summary>
        /// <param name="_Company">The _ company.</param>
        /// <returns></returns>
        public List<Company> SelectCompany(Company _Company)
        {
            List<Company> listCompanySelect = new List<Company>();
            try
            {
                listCompanySelect = ApplicationState.DAClient.SelectCompany(_Company);
            }
            catch (Exception ex)
            {
                ErrorHandler _ErrorHandler = new ErrorHandler();
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return listCompanySelect;
        }

        /// <summary>
        /// Selects the control accounts.
        /// </summary>
        /// <param name="_ControlAccount">The _ control account.</param>
        /// <returns></returns>
        public List<ControlAccount> SelectControlAccounts(ControlAccount _ControlAccount)
        {
            List<ControlAccount> listControlAccountSelect = new List<ControlAccount>();
            try
            {
                listControlAccountSelect = ApplicationState.DAClient.SelectControlAccount(_ControlAccount);
            }
            catch (Exception ex)
            {
                ErrorHandler _ErrorHandler = new ErrorHandler();
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return listControlAccountSelect;
        }

        /// <summary>
        /// Selects the group accounts.
        /// </summary>
        /// <param name="_GroupAccount">The _ group account.</param>
        /// <returns></returns>
        public List<GroupAccount> SelectGroupAccounts(GroupAccount _GroupAccount)
        {
            List<GroupAccount> listGroupAccountSelect = new List<GroupAccount>();
            try
            {
                listGroupAccountSelect = ApplicationState.DAClient.SelectGroupAccount(_GroupAccount);
            }
            catch (Exception ex)
            {
                ErrorHandler _ErrorHandler = new ErrorHandler();
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return listGroupAccountSelect;
        }

        /// <summary>
        /// Selects the location.
        /// </summary>
        /// <param name="_Location">The _ location.</param>
        /// <returns></returns>
        public List<Location> SelectLocation(Location _Location)
        {
            List<Location> listLocationSelect = new List<Location>();
            try
            {
                listLocationSelect = ApplicationState.DAClient.SelectLocation(_Location);
            }
            catch (Exception ex)
            {
                ErrorHandler _ErrorHandler = new ErrorHandler();
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return listLocationSelect;
        }

        /// <summary>
        /// Selects the user.
        /// </summary>
        /// <param name="_User">The _ user.</param>
        /// <returns></returns>
        public List<User> SelectUser(User _User)
        {
            List<User> listUserSelect = new List<User>();
            try
            {
                listUserSelect = ApplicationState.DAClient.SelectUser(_User);
            }
            catch (Exception ex)
            {
                ErrorHandler _ErrorHandler = new ErrorHandler();
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return listUserSelect;
        }

        /// <summary>
        /// Selects the user login assign.
        /// </summary>
        /// <param name="_UserLoginAssign">The _ user login assign.</param>
        /// <returns></returns>
        public List<UserLoginAssign> SelectUserLoginAssign(UserLoginAssign _UserLoginAssign)
        {
            List<UserLoginAssign> listUserLoginAssignSelect = new List<UserLoginAssign>();
            try
            {
                listUserLoginAssignSelect = ApplicationState.DAClient.SelectUserLoginAssign(_UserLoginAssign);
            }
            catch (Exception ex)
            {
                ErrorHandler _ErrorHandler = new ErrorHandler();
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return listUserLoginAssignSelect;
        }
    }
}

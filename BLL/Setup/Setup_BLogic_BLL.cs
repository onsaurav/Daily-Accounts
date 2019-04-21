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
    public class Setup_BLogic_BLL
    {
        Setup_Save_BLL _Setup_Save_BLL = new Setup_Save_BLL();

        public ONSResult CheckUserForLogIn(User _User)
        {
            ONSResult _ONSResult = new ONSResult();
            try
            {
                List<User> _listUser = new List<User>();
                _listUser = ApplicationState.DAClient.SelectUser(_User);

                if (_listUser.Count > 0)
                {
                    if (!_listUser[0].FirstLogIn.HasValue && !_listUser[0].LastActivated.HasValue )
                    {
                        _ONSResult.Remarks = "CP";
                        _ONSResult.IsSuccess = false;
                        _ONSResult.Message = "Invalid first login information.";
                    }
                    else if (_listUser[0].FirstLogIn.Value == true)
                    {
                        _ONSResult.Remarks = "CP";
                        _ONSResult.IsSuccess = false;
                        _ONSResult.Message = "Please change your password for the first time log in.";
                    }
                    else 
                    {
                        DateTime LastActivated = _listUser[0].LastActivated.Value;
                        LastActivated = LastActivated.AddDays((_listUser[0].ActiveDays.HasValue ? _listUser[0].ActiveDays.Value : 0));

                        if (DateTime.Now.Date.Subtract(LastActivated).Days > 0)
                        {
                            _ONSResult.Remarks = "CP";
                            _ONSResult.IsSuccess = false;
                            _ONSResult.Message = "Please change your password, Because your activitation time allready over.";
                        }
                        else
                        {
                            List<UserLoginAssign> listUserLoginAssign = new List<UserLoginAssign>();
                            listUserLoginAssign = ApplicationState.DAClient.SelectUserLoginAssign
                                (new UserLoginAssign { UserName = _listUser[0].UserName, CompanyId = _listUser[0].CompanyId, LocationId = _listUser[0].LocationId });
                            if (listUserLoginAssign.Count > 0)
                            {
                                ApplicationState.User = _listUser[0].UserName;
                                ApplicationState.UserFullName = _listUser[0].FullName;
                                ApplicationState.Department = _listUser[0].UserDepartment.Name;
                                ApplicationState.Level = _listUser[0].UserLevel.Name;

                                List<Company> listCompany = ApplicationState.DAClient.SelectCompany(new Company { CompanyId = listUserLoginAssign[0].CompanyId });
                                if (listCompany.Count > 0)
                                {
                                    ApplicationState.CompanyId = listCompany[0].CompanyId;
                                    ApplicationState.CompanyName = listCompany[0].Name;
                                    ApplicationState.CompanyAddress = listCompany[0].Address;
                                }

                                List<Location> listLocation = ApplicationState.DAClient.SelectLocation(new Location { LocationId = listUserLoginAssign[0].LocationId });
                                if (listLocation.Count > 0)
                                {
                                    ApplicationState.LocationId = listLocation[0].LocationId;
                                    ApplicationState.LocationName = listLocation[0].Name;
                                }

                                //ApplicationState.UserEntryExitID = CommonMethods.GetID(Constant.IDType.UEE.ToString(), DateTime.Now.Year);

                                List<UserEntryExit> _listUserEntryExit = new List<UserEntryExit>();
                                _listUserEntryExit.Add(new UserEntryExit
                                {
                                    Name = _listUser[0].UserName,
                                    EntryTime = DateTime.Now.ToLongTimeString(),
                                    EntryDate = DateTime.Now.Date
                                });

                                ApplicationState.UserEntryExitID = _Setup_Save_BLL.SaveUserEntryExit(_listUserEntryExit).ID;

                                _ONSResult.IsSuccess = true;
                                _ONSResult.Message = "Welcome! You are successfully log in.";
                            }
                            else
                            {
                                _ONSResult.IsSuccess = false;
                                _ONSResult.Message = "This user is not assigned for this location.";
                            }
                        }
                    }
                }
                else
                {
                    _ONSResult.IsSuccess = false;
                    _ONSResult.Message = "No user found with this user name and password.";
                }
            }
            catch (Exception ex)
            {
                ErrorHandler _ErrorHandler = new ErrorHandler();
                _ErrorHandler.ONSERRORProcessing(ex);
            }
            return _ONSResult;
        }

      
    }
}

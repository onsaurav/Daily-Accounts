using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace DAL.DataAccess
{
    public interface IDataAccess
    {
        //SELECT
        List<Account> SelectAccount(Account parameter);
        List<Company> SelectCompany(Company parameter);
        List<ControlAccount> SelectControlAccount(ControlAccount parameter);
        List<GroupAccount> SelectGroupAccount(GroupAccount parameter);        
        List<IDNumber> SelectIDNumber(IDNumber parameter);
        List<Location> SelectLocation(Location parameter);
        List<User> SelectUser(User parameter);
        List<UserLoginAssign> SelectUserLoginAssign(UserLoginAssign parameter);
            

        //INSERT
        ONSResult InsertAccount(Account parameter);
        ONSResult InsertControlAccount(ControlAccount parameter);
        ONSResult InsertGroupAccount(GroupAccount parameter);
        ONSResult InsertIDNumber(IDNumber parameter);
        ONSResult InsertUserEntryExit(UserEntryExit parameter);


        //UPDATE
        ONSResult UpdateAccount(Account parameter);
        ONSResult UpdateControlAccount(ControlAccount parameter);
        ONSResult UpdateGroupAccount(GroupAccount parameter);
        ONSResult UpdateIDNumber(IDNumber parameter);
        ONSResult UpdateUserEntryExit(UserEntryExit parameter);


        //DELETE
        ONSResult DeleteAccount(Account parameter);

    }
}

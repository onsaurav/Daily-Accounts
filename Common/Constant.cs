using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace Common
{
    public class Constant
    {
        public enum TaskStatus { Approved = 1, Waiting, Completed };
        public enum IDType { ACC = 1, ACG, ACN, ATR, BGT, CMP, DLG, UEE};
        public enum ControlType { Button = 1, TextBox, ComboBox, Label, ListBox, GridView, ListView, TreeView};
        public readonly static string EVENT_LOG = "ONS";
        public readonly static string EVENT_SOURCE = "ONS_ACCOUNTS_ERROR";
        public const IsolationLevel TRANSACTION_ISOLATION_LEVEL = IsolationLevel.ReadCommitted;
        public static readonly string DATA_ACCESS_NAMESPACE_STRING = "Accounts.DAL.DataAccess.";
        public static readonly string CONNECTIONSTRING = "DAL.Properties.Settings.ONSAccountsConnectionString";
        
        public enum Mode
        {
            onsAdd,
            onsEdit,
            onsDelete,
            onsClear,
            onsClose,
            onsOK,
            onsCancel,
            onsYes,
            onsNo,
            onsLoad,
            onsSave,
            onsPrint,
            onsSearch
        }
        public enum DropDownName
        {
            Accounts,
            Group
        }
    }
}

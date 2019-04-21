using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Common
{
    public class ONSResult
    {
        #region Members
        private bool isSuccess;
        private string id;
        private string message;
        private static DataTable oDatatable;
        private DataSet oDataSet;
        private DateTime DateFrom;
        private DateTime DateTo;
        private List<string> ListValue = new List<string>();
        private string[] Myarr;
        private double _value;
        private decimal amount;
        private string remarks;
        #endregion
        #region Properties
        public bool IsSuccess
        {
            get { return isSuccess; }
            set { isSuccess = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
       
        public static DataTable DataTableContainer
        {
            get { return oDatatable; }
            set { oDatatable = value; }
        }
         
        public DataSet DataSetValue
        {
            get { return oDataSet; }
            set { oDataSet = value; }
        }
        
        public List<string> List_Value
        {
            get { return ListValue; }
            set { ListValue = value; }
        }

        public string[] My_arr
        {
            get { return Myarr; }
            set { Myarr = value; }
        }

        public DateTime Date_From
        {
            get { return DateFrom; }
            set { DateFrom = value; }
        }

        public DateTime Date_To
        {
            get { return DateTo; }
            set { DateTo = value; }
        }

        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }
        #endregion
    }
}

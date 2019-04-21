using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Transactions;
using DAL.DataAccess;
using Common;
using BLL.Setup;

namespace BLL.Utility
{
    public class CommonMethods
    {
        /// <summary>
        /// Gets the ID.
        /// </summary>
        /// <param name="iDTypeId">The i D type id.</param>
        /// <param name="prefix">The prefix.</param>
        /// <returns></returns>
        public static string GetID(string iDTypeId, int Year)
        {
            double ICount = 0;
            string ID = "";

            List<IDNumber> list = new List<IDNumber>();
            try
            {
                using (TransactionScope transaction = new TransactionScope
                      (TransactionScopeOption.Required, DBHelper.TransactionOptions))
                {
                    string prefix = iDTypeId;
                    prefix = prefix + "-" + ApplicationState.CompanyId + "-" + ApplicationState.LocationId + "-" + Year.ToString("0000") + "-";
                    ID = prefix;
                    list = ApplicationState.DAClient.SelectIDNumber(new IDNumber { IDTypeId = iDTypeId , CompanyId = ApplicationState.CompanyId, LocationId = ApplicationState.LocationId });
                    if (list[0].IDNo == null)
                    {
                        ICount = 1;
                        ID = ID + ICount.ToString();
                    }
                    else if (list[0].IDNo.Length <= prefix.Length)
                    {
                        ICount = 1;
                        ID = ID + ICount.ToString();
                    }
                    else
                    {
                        if (list[0].IDNo.Substring(0, prefix.Length) == prefix)
                        {
                            ICount = int.Parse(list[0].IDNo.Substring(prefix.Length, list[0].IDNo.Length - prefix.Length)) + 1;
                        }
                        else
                        {
                            ICount = 1;
                        }
                        ID = ID + ICount.ToString();
                    }

                    list[0].IDNo = ID;

                    if (list[0].SlNo == 0)
                    {
                        ApplicationState.DAClient.InsertIDNumber(list[0]);
                    }
                    else
                    {
                        ApplicationState.DAClient.UpdateIDNumber(list[0]);
                    }

                    transaction.Complete();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler _ErrorHandler = new ErrorHandler();
                _ErrorHandler.ONSERRORProcessing(ex);
            }

            return ID;
        }

        /// <summary>
        /// Randoms the string.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="lowerCase">if set to <c>true</c> [lower case].</param>
        /// <returns></returns>
        public string RandomString(int size, bool lowerCase = false )
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase) return builder.ToString().ToLower();
            return builder.ToString();
        }

        /// <summary>
        /// Encrips the password.
        /// </summary>
        /// <param name="strPassword">The STR password.</param>
        /// <returns></returns>
        public string EncripPassword(string strPassword)
        {
            int l;
            int pass1;
            int ctr = 1;
            string passnew = "";
            pass1 = int.Parse(strPassword.Length.ToString()) - 1;
            ctr = 0;
            do
            {
                char k = Convert.ToChar(strPassword.Substring(ctr, 1));
                l = Convert.ToInt16(k) + 17;
                passnew = passnew.ToString() + (char)l;
                ctr = ctr + 1;
            }
            while (ctr <= pass1);
            return passnew;
        }
    }
}

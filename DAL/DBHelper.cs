using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.ServiceModel;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;
using System.Transactions;

namespace DAL.DataAccess
{
    public class DBHelper
    {
        #region Member
        private static TransactionOptions _transactionOptions;
        #endregion

        #region Method
        /// <summary>
        /// Inserts the with SQL bulk copy.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="dataTable">The data table.</param>
        /// <param name="isKeepIdentity">if set to <c>true</c> [is keep identity].</param>
        public static void InsertWithSqlBulkCopy(string connectionString, DataTable dataTable, bool isKeepIdentity = true)
        { 
            SqlBulkCopy bulkCopy = null;
            if (isKeepIdentity)
                bulkCopy = new SqlBulkCopy(connectionString, SqlBulkCopyOptions.KeepIdentity);
            else
                bulkCopy = new SqlBulkCopy(connectionString);
            
            bulkCopy.DestinationTableName = "dbo." + dataTable.TableName;

            try
            {
                bulkCopy.WriteToServer(dataTable);
            }
            catch (Exception ex)
            {
                ErrorHandler _ErrorHandler = new ErrorHandler();
                _ErrorHandler.ONSERRORProcessing(ex);
            }
        }

        /// <summary>
        /// Toes the data set.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <returns></returns>
        public static DataSet ToDataSet<T>(IList<T> list)
        {
            Type elementType = typeof(T);
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            ds.Tables.Add(t);

            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;
                t.Columns.Add(propInfo.Name, ColType);
            }
            
            foreach (T item in list)
            {
                DataRow row = t.NewRow();
                foreach (var propInfo in elementType.GetProperties())
                {
                    row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                }
                t.Rows.Add(row);
            }
            return ds;
        }

        /// <summary>
        /// Converts the collection to data table.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <param name="namespaceString">The namespace string.</param>
        /// <returns></returns>
        public static DataTable ConvertCollectionToDataTable<T>(ICollection<T> list, string namespaceString)
        {
            DataTable table = new DataTable();
            Type listType = typeof(T);

            table.TableName = listType.ToString().Replace(namespaceString, String.Empty);
            if (table.TableName.Contains("DTO"))
            {
                table.TableName = "t" + table.TableName.Replace("DTO", String.Empty);
            }

            PropertyInfo property;
            PropertyInfo[] listTypeProperties = listType.GetProperties();            

            int columnCount = 0;
            int valuesCount = 0;
            
            for (int i = 0; i < listTypeProperties.Length; i++)
            {
                property = listTypeProperties[i];
                if (!property.PropertyType.FullName.Contains("EntitySet") && IsDBColumn(property))
                {                    
                    if ((property.PropertyType.IsGenericType) && (property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                    {
                        table.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType));
                    }                    
                    else
                    {
                        table.Columns.Add(property.Name, property.PropertyType);
                    }
                    columnCount++;
                }
            }
            
            if ((list != null) && (list.Count > 0))
            {
                DataRow tableRow;
                foreach (T listItem in list)
                {
                    tableRow = table.NewRow();
                    columnCount = 0;
                    valuesCount = 0;
                    for (int i = 0; i < listTypeProperties.Length; i++)
                    {
                        property = listTypeProperties[i];
                        if (!property.PropertyType.FullName.Contains("EntitySet") && IsDBColumn(property))
                        {                          
                            object propertyValue = property.GetValue(listItem, null);
                            if (propertyValue != null)
                            {
                                tableRow[property.Name] = propertyValue;
                                valuesCount++;
                            }
                            else
                            {
                                tableRow[property.Name] = DBNull.Value;
                            }
                            columnCount++;
                        }
                    }

                    table.Rows.Add(tableRow);
                }                
            }

            return table;
        }

        /// <summary>
        /// Determines whether [is DB column] [the specified member].
        /// </summary>
        /// <param name="member">The member.</param>
        /// <returns>
        ///   <c>true</c> if [is DB column] [the specified member]; otherwise, <c>false</c>.
        /// </returns>
        private static bool IsDBColumn(PropertyInfo member)
        {
            foreach (object attribute in member.GetCustomAttributes(true))
            {
                if (attribute is DataMemberAttribute)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether [is I entity] [the specified object type].
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        ///   <c>true</c> if [is I entity] [the specified object type]; otherwise, <c>false</c>.
        /// </returns>
        private static bool IsIEntity(Type objectType)
        {
            Type[] interfaces = objectType.GetInterfaces();
            bool isIEntity = false;

            if (interfaces != null && interfaces.Length > 0)
            {
                foreach (Type type in interfaces)
                {
                    if (type == typeof(INotifyPropertyChanging) || type == typeof(INotifyPropertyChanged))
                    {
                        isIEntity = true;
                        break;
                    }
                }
            }

            if (!isIEntity)
            {
                Type[] typeParam = objectType.GetGenericArguments();
                if (typeParam != null && typeParam.Length > 0)
                {
                    foreach (Type type in typeParam)
                    {
                        if (IsIEntity(type))
                        {
                            isIEntity = true;
                            break;
                        }
                    }
                }
            }
            return isIEntity;
        }

        /// <summary>
        /// Gets or sets the transaction options.
        /// </summary>
        /// <value>
        /// The transaction options.
        /// </value>
        public static TransactionOptions TransactionOptions
        {
            get
            {
                if (_transactionOptions == null || _transactionOptions.IsolationLevel != Common.Constant.TRANSACTION_ISOLATION_LEVEL)
                {
                    _transactionOptions = new TransactionOptions();
                    _transactionOptions.IsolationLevel = Common.Constant.TRANSACTION_ISOLATION_LEVEL;
                    _transactionOptions.Timeout = new TimeSpan(1, 0, 30);
                }
                return _transactionOptions;
            }
            set
            {
                _transactionOptions = value;
            }
        }
        #endregion
    }
}

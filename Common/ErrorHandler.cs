using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Diagnostics;

namespace Common
{
    public class ErrorHandler
    {
        /// <summary>
        /// ONSs the error record finalize.
        /// </summary>
        /// <param name="_ex">The _ex.</param>
        public void ONSErrorRecordFinalize(Exception _ex)
        {
            if (!EventLog.SourceExists(Constant.EVENT_SOURCE)) EventLog.CreateEventSource(Constant.EVENT_SOURCE, Constant.EVENT_LOG);
            EventLog.WriteEntry(Constant.EVENT_SOURCE,  _ex.ToString() , EventLogEntryType.Error);
        }

        /// <summary>
        /// ONSERRORs the processing.
        /// </summary>
        /// <param name="_ex">The _ex.</param>
        public void ONSERRORProcessing(Exception _ex)
        {
            ShowError _ShowError = new ShowError(_ex);
            _ShowError.ShowDialog();
        }
    }
}

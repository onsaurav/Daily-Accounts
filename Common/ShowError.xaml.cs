using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Common
{
    /// <summary>
    /// Interaction logic for ShowError.xaml
    /// </summary>
    public partial class ShowError : Window
    {
        Exception _ex;
        ErrorHandler _ErrorHandler = new ErrorHandler();

        public ShowError()
        {
            InitializeComponent();
        }

        public ShowError(Exception ex)
        {
            InitializeComponent();
            _ex = ex;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtMessage.Text = _ex.ToString();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {            
            _ErrorHandler.ONSErrorRecordFinalize(_ex);
            this.Close();
        }
    }
}

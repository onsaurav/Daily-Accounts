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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Common;
using Accounts.Setup;
using BLL.Utility;

namespace Accounts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainAccounts : Window
    {
        public MainAccounts()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ApplicationState.CompanyId = "ONS";

            //ucControlAccounts _ucControlAccounts = new ucControlAccounts();
            //ClearItemsFromContent();
            //LoadControl(_ucControlAccounts);
        }

        public void ClearItemsFromContent()
        {
            //for (int i = 0; i < this.stkMain.Children.Count; i++)
            //{
            //    this.stkMain.Children.Remove(this.stkMain.Children[i]);
            //}
        }

        public void LoadControl(object oBj)
        {
            ////ClearItemsFromContent();
            //this.stkMain.Children.Add((UIElement)oBj);
        }
    }
}

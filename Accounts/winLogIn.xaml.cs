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
using BLL.Setup;
using DAL;
using Common;

namespace Accounts
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        #region Member
        Setup_BLogic_BLL _Setup_BLogic_BLL = new Setup_BLogic_BLL();
        Setup_Select_BLL _Setup_Select_BLL = new Setup_Select_BLL();
        #endregion
        #region Method
        public LogIn()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this) && this.IsLoaded)
            {
                cboCompany.ItemsSource = _Setup_Select_BLL.SelectCompany(new Company());
                if (cboCompany.Items.Count > 0) 
                    cboCompany.SelectedIndex = 0;

                cboLocation.ItemsSource = _Setup_Select_BLL.SelectLocation(new Location());
                if (cboLocation.Items.Count > 0) 
                    cboLocation.SelectedIndex = 0;

                if (cboCompany.Items.Count > 0 && cboLocation.Items.Count > 0)
                    txtUserName.Focus();
            }
        }

        private void cboLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SendKeys(e);
            }
        }

        private void cboCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SendKeys(e);
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SendKeys(e);
            }
        }

        private void SendKeys(KeyEventArgs e)
        {
            e.Handled = true;
            KeyEventArgs eInsertBack = new KeyEventArgs(Keyboard.PrimaryDevice, Keyboard.PrimaryDevice.ActiveSource, 0, Key.Tab);
            eInsertBack.RoutedEvent = UIElement.KeyDownEvent;
            InputManager.Current.ProcessInput(eInsertBack);
        }

        private void SendKeysButton(Button ABC)
        {
            ABC.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SendKeysButton(btnLogIn);
            }
        }
        
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure, you want to close the application.", "Close", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    Application.Current.Shutdown();
            }
            catch (Exception ex)
            {
                ErrorHandler _ErrorHandler = new ErrorHandler();
                _ErrorHandler.ONSERRORProcessing(ex);
            }
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            User _User = new User();

            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Password;
            if (cboCompany.SelectedValue != null)
                _User.CompanyId = cboCompany.SelectedValue.ToString();
            if (cboLocation.SelectedValue != null)
                _User.LocationId = cboLocation.SelectedValue.ToString();

            if (!IsValidControlAccount(_User)) return;

            ONSResult _ONSResult = new ONSResult();
            _ONSResult = _Setup_BLogic_BLL.CheckUserForLogIn(_User);
            MessageBox.Show(_ONSResult.Message, "Save", MessageBoxButton.OK, MessageBoxImage.Warning);

            if (_ONSResult.IsSuccess == true)
            {
                MainAccounts _MainAccounts = new MainAccounts();
                _MainAccounts.Show();
                this.Close();
            }
        }

        private bool IsValidControlAccount(User item)
        {
            bool IsValid = true;

            if (String.IsNullOrEmpty(item.UserName))
            {
                MessageBox.Show("Invalid user name selected.", "Checking", MessageBoxButton.OK, MessageBoxImage.Warning);
                IsValid = false;
            }

            if (String.IsNullOrEmpty(item.Password))
            {
                MessageBox.Show("Invalid password selected.", "Checking", MessageBoxButton.OK, MessageBoxImage.Warning);
                IsValid = false;
            }

            if (String.IsNullOrEmpty(item.CompanyId))
            {
                MessageBox.Show("Invalid company selected.", "Checking", MessageBoxButton.OK, MessageBoxImage.Warning);
                IsValid = false;
            }

            if (String.IsNullOrEmpty(item.LocationId))
            {
                MessageBox.Show("Invalid location selected.", "Checking", MessageBoxButton.OK, MessageBoxImage.Warning);
                IsValid = false;
            }

            return IsValid;
        }
        #endregion
    }
}

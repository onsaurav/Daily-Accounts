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
using DAL;
using BLL.Setup;
using BLL.Utility;
using Common;

namespace Accounts.Setup
{
    /// <summary>
    /// Interaction logic for ucControlAccounts.xaml
    /// </summary>
    public partial class ucControlAccounts : UserControl
    {
        #region Member
        Setup_Save_BLL _Setup_Save_BLL = new Setup_Save_BLL();
        Setup_Select_BLL _Setup_Select_BLL = new Setup_Select_BLL();
        #endregion
        #region Method
        public ucControlAccounts()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this) && this.IsLoaded)
            {
                cboGroup.ItemsSource = _Setup_Select_BLL.SelectGroupAccounts(new GroupAccount());
                LoadControlAccount();
            }
        }

        private void LoadControlAccount()
        {
            dgControlAccount.ItemsSource = null;
            dgControlAccount.ItemsSource = _Setup_Select_BLL.SelectControlAccounts(new ControlAccount { CompanyId = ApplicationState.CompanyId });
        }

        private void SelectAll_Click(object sender, RoutedEventArgs e)
        {
            List<ControlAccount> _listControlAccount = new List<ControlAccount>();
            foreach (var item in dgControlAccount.Items)
            {
                ControlAccount _ControlAccount = item as ControlAccount;
                _ControlAccount.IsSelected = true;
                _listControlAccount.Add(_ControlAccount);
            }
            dgControlAccount.ItemsSource = null;
            dgControlAccount.ItemsSource = _listControlAccount;
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            List<ControlAccount> _listControlAccount = new List<ControlAccount>();
            foreach (var item in dgControlAccount.Items)
            {
                ControlAccount _ControlAccount = item as ControlAccount;
                _ControlAccount.IsSelected = false;
                _listControlAccount.Add(_ControlAccount);
            }
            dgControlAccount.ItemsSource = null;
            dgControlAccount.ItemsSource = _listControlAccount;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            List<ControlAccount> _listControlAccount = new List<ControlAccount>();
            foreach (var _item in dgControlAccount.Items)
            {
                ControlAccount item = _item as ControlAccount;
                if (item != null && item.IsSelected == true)
                {
                    if (!IsValidControlAccount(item)) return;

                    item.CompanyId = SharedState.CompanyId;
                    item.EntryBy = SharedState.UserId;
                    item.DateOfEntry = DateTime.Now.Date;

                    _listControlAccount.Add(item);
                }
            }

            if (_listControlAccount.Count > 0)
            {
                ONSResult _ONSResult = _Setup_Save_BLL.SaveControlAccounts(_listControlAccount);
                MessageBox.Show(_ONSResult.Message, "Save", MessageBoxButton.OK, MessageBoxImage.Warning);
                LoadControlAccount();
            }
        }

        private bool IsValidControlAccount(ControlAccount item)
        {
            bool IsValid = true;

            if (String.IsNullOrEmpty(item.Name))
            {
                MessageBox.Show("Invalid control account selected.", "Checking", MessageBoxButton.OK, MessageBoxImage.Warning);
                IsValid = false;
            }

            if (String.IsNullOrEmpty(item.GroupId))
            {
                MessageBox.Show("Invalid group account selected.", "Checking", MessageBoxButton.OK, MessageBoxImage.Warning);
                IsValid = false;
            }

            return IsValid;
        }
        #endregion
    }
}

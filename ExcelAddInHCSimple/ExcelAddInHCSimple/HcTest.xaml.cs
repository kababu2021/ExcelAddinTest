using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExcelAddInHCSimple.Annotations;
using HandyControl.Tools;

namespace ExcelAddInHCSimple
{
    /// <summary>
    /// Interaction logic for HcTest.xaml
    /// </summary>
    public partial class HcTest : Window
    {
        #region Private Fields
        private ObservableCollection<User> _usersList = new ObservableCollection<User>();
        #endregion

        #region Constructors
        public HcTest()
        {
            ConfigHelper.Instance.SetLang("en");

            InitializeComponent();

            LoadUsers();
            
            chkcbUsers.ItemsSource = UsersList;
            
            AddUser();
        }
        #endregion

        #region Public Methods
        public ObservableCollection<User> UsersList
        {
            get
            {
                return _usersList;
            }
        }
        public List<string> UsersNameList
        {
            get
            {
                return this._usersList.Select(x => x.Name).Distinct().ToList();
            }
        }
        #endregion

        #region Nested Classes 
        //public class User : INotifyPropertyChanged
        public class User
        {
            #region Private Fields
            private string _name;
            private int _id;
            #endregion

            #region Properties
            public string Name
            {
                get => _name;
                set => _name = value;
            }
            public int Id
            {
                get => _id;
                set => _id = value;
            }
            #endregion

            #region Constructors

            public User(string name, int id)
            {
                this.Name = name;
                this.Id = id;
            }
            #endregion

            //#region INotifyPropertyChanged
            //public event PropertyChangedEventHandler PropertyChanged;

            //[NotifyPropertyChangedInvocator]
            //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            //{
            //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //}
            //#endregion
        }
        #endregion

        #region Events
        private void cbUserSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Nothing here
        }
        #endregion

        #region Private Methods

        private void LoadUsers()
        {
            this._usersList.Clear();
            this._usersList.Add(new User("Bob", 1232));
            this._usersList.Add(new User("Adam", 1398));
            this._usersList.Add(new User("John", 1620));
            this._usersList.Add(new User("Lewis", 5692));
            this._usersList.Add(new User("Walter", 3478));
        }

        private void AddUser()
        {
            this._usersList.Add(new User("Doe", 3542));
        }
        #endregion
    }
}

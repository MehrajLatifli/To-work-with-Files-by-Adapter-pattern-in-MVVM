using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using To_work_with_Files_by_Adapter_pattern_in_MVVM.Command;
using To_work_with_Files_by_Adapter_pattern_in_MVVM.Models;
using To_work_with_Files_by_Adapter_pattern_in_MVVM.Models.Adapter;


namespace To_work_with_Files_by_Adapter_pattern_in_MVVM.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnpropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }




        public ObservableCollection<User> Users { get; set; }

        private User _user;

        public User User { get { return _user; } set { _user = value; OnpropertyChanged(); } }


        public RelayCommand SaveCommand { get; set; }
        public RelayCommand ViewCommand { get; set; }

        public MainWindow MainWindows { get; set; }



        public MainViewModel()
        {
            XML_File XML_File = new XML_File();
            JSON_File JSON_File = new JSON_File();
          

            if (XML_File.User_List == null)
            {
                XML_File.User_List = new ObservableCollection<User>();
            }

            if (JSON_File.User_List == null)
            {
                JSON_File.User_List = new ObservableCollection<User>();
            }

            




            User = new User
            {
                Name = "Name",
                Surname = "Surname",
                Email = "Email",
            };



            SaveCommand = new RelayCommand((e) =>
            {
                IAdapter adapter;


                if (MainWindows.XML_CheckBox.IsChecked == true)
                {
            


                    try
                    {
                  
                        if (XML_File.User_List == null)
                        {

                            XML_File.User_List.Add(new User()
                            {
                                Name = MainWindows.NameTBox.Text,
                                Surname = MainWindows.SurnameTBox.Text,
                                Email = MainWindows.EmailTBox.Text,


                            });
                            
                            XML_File.User_List.RemoveAt(0);

                            adapter = new XML_Adapter(XML_File);

                            Application_File application = new Application_File(adapter);

                            application.Start();
                        }

                        if (XML_File.User_List != null)
                        {
                            XML_File.User_List.Add(new User()
                            {
                                Name = MainWindows.NameTBox.Text,
                                Surname = MainWindows.SurnameTBox.Text,
                                Email = MainWindows.EmailTBox.Text,


                            });

                            adapter = new XML_Adapter(XML_File);

                            Application_File application = new Application_File(adapter);

                            application.Start();
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }
       
                }


                if (MainWindows.JSON_CheckBox.IsChecked == true)
                {



                    try
                    {

                        if (JSON_File.User_List == null)
                        {

                            JSON_File.User_List.Add(new User()
                            {
                                Name = MainWindows.NameTBox.Text,
                                Surname = MainWindows.SurnameTBox.Text,
                                Email = MainWindows.EmailTBox.Text,


                            });

                            JSON_File.User_List.RemoveAt(0);

                            adapter = new JSON_Adapter(JSON_File);

                            Application_File application = new Application_File(adapter);

                            application.Start();
                        }

                        if (JSON_File.User_List != null)
                        {
                            JSON_File.User_List.Add(new User()
                            {
                                Name = MainWindows.NameTBox.Text,
                                Surname = MainWindows.SurnameTBox.Text,
                                Email = MainWindows.EmailTBox.Text,


                            });

                            adapter = new JSON_Adapter(JSON_File);

                            Application_File application = new Application_File(adapter);

                            application.Start();
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }

                }

            });


            ViewCommand = new RelayCommand((e) =>
            {
                if (MainWindows.XML_CheckBox.IsChecked == true)
                {
                    Process.Start("notepad.exe", $@"../../../DataBase/AccountData/RegisterUser/UserList.xml");
                }

                if (MainWindows.JSON_CheckBox.IsChecked == true)
                {
                    Process.Start("notepad.exe", $@"../../../DataBase/AccountData/RegisterUser/UserList.json");
                }
            });

        }

    }
}

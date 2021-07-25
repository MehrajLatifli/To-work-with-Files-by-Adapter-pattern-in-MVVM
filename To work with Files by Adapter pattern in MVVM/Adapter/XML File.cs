﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using To_work_with_Files_by_Adapter_pattern_in_MVVM.ViewModels;

namespace To_work_with_Files_by_Adapter_pattern_in_MVVM.Models.Adapter
{
    class XML_File : INotifyPropertyChanged
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
    
        public ObservableCollection<User> _User_List { get; set; }
        public ObservableCollection<User> User_List { get { return _User_List; } set { _User_List = value; OnpropertyChanged(); } }


        private User _user;

        public User User { get { return _user; } set { _user = value; OnpropertyChanged(); } }


        public MainWindow MainWindows { get; set; }

        public MainViewModel MainViewModels { get; set; }

        public XML_File()
        {
      
        }



        public void XML_Serialize()
        {
            if (!Directory.Exists("../../DataBase/AccountData"))
            {
                Directory.CreateDirectory("../../../DataBase/AccountData");
            }
            if (!Directory.Exists("../../../DataBase/AccountData/RegisterUser"))
            {
                Directory.CreateDirectory("../../../DataBase/AccountData/RegisterUser");
            }


            if (File.Exists($@"../../../DataBase/AccountData/RegisterUser/UserList.xml"))
            {
                File.Delete($@"../../../DataBase/AccountData/RegisterUser/UserList.xml");

            }

            var xml = new XmlSerializer(typeof(ObservableCollection<User>));
            using (var fs = new FileStream($@"../../../DataBase/AccountData/RegisterUser/UserList.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, User_List);
            }
        }

        public void XML_Deserialize()
        {
            User User = null;

            var xml2 = new XmlSerializer(typeof(ObservableCollection<User>));

            using (var fs2 = new FileStream($@"../../../DataBase/AccountData/RegisterUser/UserList.xml", FileMode.OpenOrCreate))
            {
                User = xml2.Deserialize(fs2) as User;
            }
        }

    }
}

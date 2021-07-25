using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using To_work_with_Files_by_Adapter_pattern_in_MVVM.ViewModels;

namespace To_work_with_Files_by_Adapter_pattern_in_MVVM.Models.Adapter
{
    class JSON_File : INotifyPropertyChanged
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

        public JSON_File()
        {
           
        }



        public void JSON_Serialize()
        {
            if (!Directory.Exists("../../DataBase/AccountData"))
            {
                Directory.CreateDirectory("../../../DataBase/AccountData");
            }
            if (!Directory.Exists("../../../DataBase/AccountData/RegisterUser"))
            {
                Directory.CreateDirectory("../../../DataBase/AccountData/RegisterUser");
            }


            if (File.Exists($@"../../../DataBase/AccountData/RegisterUser/UserList.json"))
            {
                File.Delete($@"../../../DataBase/AccountData/RegisterUser/UserList.json");

            }


            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter($@"../../../DataBase/AccountData/RegisterUser/UserList.json", true))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, User_List);
                }
            }

        }

        public void JSON_Deserialize()
        {
            User[] users = null;
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader($@"../../../DataBase/AccountData/RegisterUser/UserList.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    users = serializer.Deserialize<User[]>(jr);
                }
          
            }
        }

    }
}

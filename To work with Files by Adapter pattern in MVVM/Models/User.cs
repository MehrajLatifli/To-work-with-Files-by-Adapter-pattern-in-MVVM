using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace To_work_with_Files_by_Adapter_pattern_in_MVVM.Models
{
    public class User : INotifyPropertyChanged
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

        public User()
        {
                
        }

        public User(string name, string surname, string email)
        {
            Name = name;
            Surname = surname;
            Email = email;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

 
        public override string ToString()
        {
            return $"{Name} {Surname} {Email}";
        }
    }
}

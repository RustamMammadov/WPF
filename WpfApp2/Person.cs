using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Person
    {
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public TimeOnly Time { get; set; }

        public List<Chat> ChatList { get; set; } = new List<Chat>();



    }
}

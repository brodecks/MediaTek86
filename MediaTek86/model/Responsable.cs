using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    public class Responsable
    {
        public Responsable(string login, string pwd) 
        {
            this.Login = login;
            this.Pwd = pwd;
        }
        public string Login { get;}
        public string Pwd { get;}
    }
}

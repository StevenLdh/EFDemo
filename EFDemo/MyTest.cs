using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    public class MyTest
    {
        private string Username { get; set; }
        private string Password { get; set; }

        Action<object> b = (target) => { Console.WriteLine(target.GetType()); };
        Action<UserInfo> d = b;
        d(new UserInfo());
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public string SayHello()
        {
            string a;
            a = string.Format("你好我是{0}，我今年{1}岁，我家住在{2}", this.Name, this.Age, this.Adress);
            return a;
        }
    }
}

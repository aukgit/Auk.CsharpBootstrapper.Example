using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auk.CsharpBootstrapper.Example.Model
{
    public class Person1
    {
        public string Firstname { get; set; } = "first name";

        public DateTime DOB { get; set; } = DateTime.Now;

    }

    public class Person2
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int DOB { get; set; }

    }
}

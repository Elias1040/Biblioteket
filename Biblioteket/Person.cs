using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Person
    {
        protected string _navn;
        protected string _email;
        public string Navn { get { return _navn; } }
        public string Email { get { return _email;} }
    }
}

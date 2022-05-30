using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Bog
    {
        string _titel, _forfatter, _isbn;
        DateTime _uddlaansdato;

        public string Titel { get { return _titel; } }
        public string Forfatter { get { return _forfatter; } }
        public string Isbn { get { return _isbn;} }
        public DateTime Udlaansdato { get { return _uddlaansdato; } }
        public Bog(string titel, string forfatter, string isbn)
        {
            _titel = titel;
            _forfatter = forfatter;
            _isbn = isbn;
            _uddlaansdato = DateTime.Now;
        }
    }
}

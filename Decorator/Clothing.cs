using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Clothing : Person
    {
        protected Person _compont;

        public void Decorate(Person compont)
        {
            _compont = compont;
        }

        public override void Show()
        {
            if (_compont != null)
            {
                _compont.Show();
            }
        }
    }
}

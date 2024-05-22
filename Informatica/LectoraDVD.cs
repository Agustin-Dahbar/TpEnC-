using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class LectoraDVD
    {
        private string marca;

        public Boolean capazGrabar()
        {
            if(this.marca == "Sony")
            {
                return true;
            }

            return false;
        }
    }
}

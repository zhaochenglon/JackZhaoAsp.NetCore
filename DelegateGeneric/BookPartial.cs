using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateGeneric
{

    public partial class Book
    {
        public string Report()
        {
            return $"ID={this.ID},Name={this.NAME},PRICE={this.PRICE}";
        }
    }
}

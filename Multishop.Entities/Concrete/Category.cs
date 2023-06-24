using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Multishop.Entities.Concrete
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string PhotoUrl { get; set; }
    }
}

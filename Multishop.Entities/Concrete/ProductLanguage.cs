using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multishop.Entities.Concrete
{
    public class ProductLanguage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LangCode { get; set; }
        public string Seourl { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

using Multishop.Core.DataAccess;
using Multishop.Core.DataAccess.EntityFramework;
using Multishop.DataAccess.Abstract;
using Multishop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multishop.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfRepostoryBase<Category,AppDbContext>, ICategoryDal
    {
        public void DeleteAll()
        {
            
        }
    }
}

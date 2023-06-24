using Multishop.Core.DataAccess.SqlLite;
using Multishop.DataAccess.Abstract;
using Multishop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multishop.DataAccess.Concrete.Sqlite
{
    public class SlCategoryDal : SLiteRepostroryBase<Category>, ICategoryDal
    {
        public void DeleteAll()
        {
            throw new NotImplementedException();
        }
    }
}

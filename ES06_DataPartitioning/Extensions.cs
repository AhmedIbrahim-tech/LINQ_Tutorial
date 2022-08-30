using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES06_DataPartitioning
{
    public static class Extensions  
    {
        public static IEnumerable<T> Paginate<T>(this IEnumerable<T> sourse , int page = 1, int size = 10)  where T : class
        {
            if (page <= 0)
                page = 1;

            if (size <= 0)
                size = 1;

            var Total = sourse.Count();

            var pages = Convert.ToInt32( Math.Ceiling( Convert.ToDecimal( Total / size)));
            // var pages = (int) Math.Ceiling((Decimal)Total / size);

            var Result = sourse.Skip((pages - 1) * size).Take(size).ToList();
            
            return Result;


        }
    }
}

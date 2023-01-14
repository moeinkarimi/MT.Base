using MT.Base.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Base
{
    public class PaginationModel
    {
        public int PageNo { get; set; } = 0;
        public int PageSize { get; set; } = 10;
        public OrderingEnum OrderBy { get; set; } = OrderingEnum.Asc;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataModel
{
    public class PagingInputModel
    {
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public string SearchKey { get; set; }
        public string OrderBy { get; set; }

        public void SetDefaultIfEmpty()
        {
            if (PageSize < 1)
            {
                PageSize = 20;
            }
            if (PageIndex < 1)
            {
                PageIndex = 1;
            }
        }
    }
}

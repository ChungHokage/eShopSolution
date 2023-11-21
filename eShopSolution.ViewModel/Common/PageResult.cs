using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.DTO
{
    public class PageResult<T>
    {
        public int TotalRecord {  get; set; }
        public List<T> Items { get; set; }
    }
}

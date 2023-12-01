using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModel.Common
{
    public class ModelRequest<T>
    {
        public string Message { get; set; }
        public T Data { get; set; }
    }
}